
using System;
using System.IO;
using Grpc.Core;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup the channel
            var caCert = File.ReadAllText(@"certs/ca-chain.pem");
            var clientCert = File.ReadAllText(@"certs/certificate.pem");
            var clientKey = File.ReadAllText(@"certs/key.pem");
            var ssl = new SslCredentials(caCert, new KeyCertificatePair(clientCert, clientKey));
            Channel channel = new Channel("grpc.pub1.passkit.io", 443, ssl);

            // run member sample code
            MembersDemo md = new MembersDemo(channel);
            md.RunSamples();

            // run coupon sample code
            CouponsDemo cd = new CouponsDemo(channel);
            cd.RunSamples();

            // run flights sample code
            FlightsDemo fd = new FlightsDemo(channel);
            fd.RunSamples();

            channel.ShutdownAsync().Wait();
        }
    }
}
