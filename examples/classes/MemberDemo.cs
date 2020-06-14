using Grpc.Core;
using PKIo;
using PKMembers;
using System;

namespace examples{
    public class MembersDemo {
        Members.MembersClient client;

        // progamId is the program to enrol the member into.
        string programId = "69IxFnVAR5cOVgE9SC5l6P";
        // tierId is the tier to enrol the member into.
        string tierId = "bronze";

        public MembersDemo(Channel channel) {
            // init client
            client = new Members.MembersClient(channel);
        }

        public void RunSamples() {       
            try {
                // enrol new member
                string memberId = this.EnrolMember();
                Console.WriteLine("Created member: https://pub1.pskt.io/{0}", memberId);

                // update the member
                this.UpdateMember(memberId);
                Console.WriteLine("Updated member");

                // delete the member
                this.DeleteMember(memberId);
                Console.WriteLine("Deleted member");
            } catch (Exception e) {
                // in case of exceptions, log to console
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        
        // EnrolMember enrols a member and returns the unique Member ID, which can be used to form the unique pass URL.
        private string EnrolMember() {
            Member member = new Member {
                ProgramId =  this.programId,
                TierId = this.tierId,
                Person = new Person {
                    DisplayName = "Test Person",
                    EmailAddress = "test@gmail.com"
                }
            };

            var response = client.enrolMember(member);
            return response.Id_;
        }

        // UpdateMember updates the member with {memberId}.
        private void UpdateMember(string memberId) {
            Member member = new Member {
                Id = memberId,
                ProgramId =  this.programId,
                TierId = this.tierId,
                Person = new Person {
                    DisplayName = "Test Person",
                    EmailAddress = "test@gmail.com"
                }
            };

            client.updateMember(member);
        }

        // DeleteMember deletes the member with {memberId}.
        // DeleteMember allows us to set the final member values before the member is deleted and the pass updated & invalidated with the final values.
        private void DeleteMember(string memberId) {
            Member member = new Member {
                Id = memberId,
            };

            client.deleteMember(member);
        }
    }
}