# passkit-csharp-grpc-sdk
Use the PassKit gRPC SDK to issue and manage Apple Wallet and Google Pay Passes from your C# applications.

For more information, please visit [the documentation](https://docs.passkit.io/).

## Table Of Contents
- [Requirements](#requirements)
- [Installation](#installation)
- [Getting Started](#getting-started)
- [PassKit Portal](#passkit-portal)
- [Known Issues & Unsupported Endpoints](#known-issues--unsupported-endpoints)
- [Getting Help](#getting-help)
- [Contributing](#contributing)
- [Author & License](#author--license)

## Supported Platforms
- .NET Core on Linux, Windows and Mac OS X.
- .NET Framework 4.5+ (Windows).
- Mono 4+ on Linux, Windows and Mac OS X.

## Requirements

When using gRPC C# under .NET Core you only need to [https://www.microsoft.com/net/core](install .NET Core).

In addition to that, you can also use gRPC C# with these runtimes / IDEs:

- Windows: .NET Framework 4.5+, Visual Studio 2013 or newer, Visual Studio Code.
- Linux: Mono 4+, Visual Studio Code.
- Mac OS X: Mono 4+, Visual Studio Code, Visual Studio for Mac.

Furthermore you will need:
1. A PassKit account; sign up for free at [https://app.passkit.com](https://app.passkit.com/signup).
2. Your [SDK API credentials](https://app.passkit.com/app/account/developer-tools) (Home >> Account >> Developer Tools >> Generate New SDK Credentials).

## Installation

### Manual Installation

Clone the repo, import the required SDK's from the `lib` folder and add the following related packages:

```
<PackageReference Include="Google.Protobuf" Version="3.12.3" />
<PackageReference Include="Google.Api.CommonProtos" version="2.1.0" />
<PackageReference Include="Grpc.Core" Version="2.29.0"/>
```

## Getting Started

Follow the [installation procedure](#installation--usage), and see general usage format & examples below.

### Authorization

Simply download your SDK credentials from [the PassKit Portal](https://app.passkit.com/app/account/developer-tools). You need the credentials when you setup the SSL connection to the server.

Your credentials consist of 3 files:
- `ca-chain`: our CA chain.
- `client-cert`: the certificate for your account.
- `client-key`: the key that belongs to your certificate.

Setting up the connection:

```
var caCert = File.ReadAllText(@“ca-chain.pem");
var clientCert = File.ReadAllText(@"client.pem");
var clientKey = File.ReadAllText(@“client-key.pem");

var ssl = new SslCredentials(caCert, new KeyCertificatePair(clientCert, clientKey));

// Channel that holds the connection to the gRPC server. 
// Channel can remain open and be reused, but should be shutdown cleanly on exit.
Channel channel = new Channel(“api.passkit.io”, 443, ssl);
```

### General Instructions

The general format of using the SDK in your code is shown below. Each API has its own client that you will need to initialise. Clients can re-use the connection channel.

General format:

```csharp
using System;
using System.IO;
using Grpc.Core;
using PKMembers;

namespace Demo
{
    class MemberDemo
    {
        public static void Main(string[] args)
        {

            // Create a client
            var caCert = File.ReadAllText(@"ca-chain.pem");
            var clientCert = File.ReadAllText(@"client.pem");
            var clientKey = File.ReadAllText(@"client-key.pem");
            var ssl = new SslCredentials(caCert, new KeyCertificatePair(clientCert, clientKey));

            Channel channel = new Channel("grpc.passkit.io", 443, ssl);
            var client = new Members.MembersClient(channel);

            // Create a member object
            var member = new Member {
                ProgramId = "2hWUtzcwx43Q3xaZjSzutq",
                TierId = "blue",
            };

            try {
                // Call the API
                var reply = client.enrolMember(member);
    
                // Process the response
                Console.WriteLine(reply);
            } catch (Exception e) {
                Console.WriteLine("{0} Exception caught.", e);
            }

            // Channel can remain open and be reused, but should be shutdown cleanly on exit
            channel.ShutdownAsync().Wait();
        }
    }
}
```

### Examples
The [examples](/examples) folder contains a sample Visual Studio project with working sample code for using the SDK. 

To successfully run the program:
- Place your certificates in the certs folder.
- Replace the following variables with your own:


## PassKit Portal
The [https://app.passkit.com](https://app.passkit.com) allows you to easily design loyalty cards, membership cards and coupons for both Apple Wallet and Google Pay. 

Additionally, the PassKit portal facilitates management, distribution and simple analysis of your Mobile Wallet projects.

Best Practices:
- Use the web portal for initial account and project setup.
- Then use the SDKs / APIs to issue, update and delete your individual passes.

## Known Issues & Unsupported Endpoints
The following methods are currently not implemented:
__Members__:
- Update Members by Segment: can be done by updating individual members and looping on client side
- Delete Members by Segment: can be done by deleting individual members and looping on client side
- Check In / Out Member

__Coupons__:
- GetAnalytics

## Getting Help
- [Official documentation](https://docs.passkit.io/protocols/member/)
- [support@passkit.com](mailto:support@passkit.com)
- [Online Chat Support](https://app.passkit.com/)

## Contributing
Send bug reports, feature requests and code contributions into this repository.

## Author & License
PassKit Inc.: [support@passkit.com](mailto:support@passkit.com)

Distributed under MIT License. Details available in [license file](LICENSE).