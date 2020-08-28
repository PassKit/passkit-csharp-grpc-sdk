using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using PKIo;
using PKFlights;
using PKFlights.CabinCodes;
using System;

namespace examples{
    public class FlightsDemo {
        Flights.FlightsClient client;

        public FlightsDemo(Channel channel) {
            // init client
            client = new Flights.FlightsClient(channel);
        }

        public void RunSamples() {       
            try {
                // create new boarding pass
                string boardingPassId = this.CreateBoardingPass();
                Console.WriteLine("Created boarding pass: https://pub1.pskt.io/{0}", boardingPassId);

                // update boarding pass
               
            } catch (Exception e) {
                // in case of exceptions, log to console
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        
        // CreateBoardingPass creates a new boarding pass and returns the Boarding Pass ID, which can be used to form the unique pass URL.
        private string CreateBoardingPass() {
            BoardingPassRecord boardingPass = new BoardingPassRecord {
                OperatingCarrierPNR = "PK8F8R7",
                TicketNumber = "0411234567890",
                TicketLeg = 1,
                BoardingPoint = "HKG",
                DeplaningPoint = "LHR",
                CarrierCode = "PK",
                FlightNumber = "1234",
                DepartureDate = new Date {
                    Year = 2020,
                    Month = 6,
                    Day = 22,
                }, 
                Passenger = new Passenger {
                    PassengerDetails = new Person {
                        Forename = "Test",
                        Surname = "Person",
                        Gender = Gender.Male,
                    },
                    IdentityDetails = new IdentityDetails {
                        IdentityDocument = IdentityDocument.Passport,
                        IssuingCountry = "GB",
                        Nationality = "British National",
                        DocumentNumber = "5432800398",
                        DateOfBirth = new Date {
                            Year = 1985,
                            Month = 8,
                            Day = 1,
                        },
                        Gender = Gender.Male,
                        IssuedDate  = new Date {
                            Year = 2013,
                            Month = 4,
                            Day = 12,
                        },
                        ExpiryDate  = new Date {
                            Year = 2023,
                            Month = 4,
                            Day = 12,
                        }
                    }
                },
                Class = "Starter",
                CompartmentCode = CompartmentCode.Y,
                SeatNumber = "32A",
                SequenceNumber = 28,
                FreeBaggageAllowance = "0K",
                CarryOnAllowance = "7K",
                PassengerStatus = PassengerStatus.IssuedNotCheckedIn,
            };

            var response = client.createBoardingPass(boardingPass);
            return response.BoardingPasses[0].Id;
        }

        // updateBoardingPass updates the boarding pass with {boardingPassId}.
        private void updateBoardingPass(string boardingPassId) {
            BoardingPassRecord boardingPass = new BoardingPassRecord {
                Id = boardingPassId,
                PassengerStatus = PassengerStatus.IssuedCheckedIn,
                SeatNumber = "34B",
            };
            client.updateBoardingPass(boardingPass);
        }

        // deleteBoardingPass deletes the boarding pass with {boardingPassId}.
        private void deleteBoardingPass(string boardingPassId) {
            BoardingPassRecordRequest boardingPassRequest = new BoardingPassRecordRequest {
                PassId = new Id {
                    Id_ = boardingPassId
                }
            };
            client.deleteBoardingPass(boardingPassRequest);
        }
    }
}