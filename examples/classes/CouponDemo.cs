using Grpc.Core;
using Google.Protobuf.WellKnownTypes;
using PKIo;
using PKSingleUseCoupons;
using System;

namespace examples{
    public class CouponsDemo {
        SingleUseCoupons.SingleUseCouponsClient client;

        // campaignId is the campaign to create the coupon for.
        string campaignId = "myCampaignId";
        // offerId is the offer to create the coupon for.
        string offerId = "myOfferId";

        public CouponsDemo(Channel channel) {
            // init client
            client = new SingleUseCoupons.SingleUseCouponsClient(channel);
        }

        public void RunSamples() {       
            try {
                // create new coupon
                string couponId = this.CreateCoupon();
                Console.WriteLine("Created coupon: https://pub1.pskt.io/{0}", couponId);

                // update the coupon
                this.UpdateCoupon(couponId);
                Console.WriteLine("Updated coupon");

                // redeem the coupon
                this.RedeemCoupon(couponId);
                Console.WriteLine("Redeemed coupon");

                // delete the coupon
                this.DeleteCoupon(couponId);
                Console.WriteLine("Deleted coupon");
            } catch (Exception e) {
                // in case of exceptions, log to console
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        
        // CreateCoupon creates a new unique coupon and returns the unique Coupon ID, which can be used to form the unique pass URL.
        private string CreateCoupon() {
            Coupon coupon = new Coupon {
                CampaignId =  this.campaignId,
                OfferId = this.offerId,
                Sku = "AB10",
                ExpiryDate = Timestamp.FromDateTime(DateTime.UtcNow.AddDays(30)),
                Person = new Person {
                    DisplayName = "Test Person",
                    EmailAddress = "test@gmail.com"
                }
            };

            var response = client.createCoupon(coupon);
            return response.Id_;
        }

        // UpdateCoupon updates the coupon with {couponId}.
        private void UpdateCoupon(string couponId) {
            Coupon coupon = new Coupon {
                Id = couponId,
                ExpiryDate = Timestamp.FromDateTime(DateTime.UtcNow.AddDays(60))
            };

            client.updateCoupon(coupon);
        }

        // RedeemCoupon redeems the coupon with {couponId}.
        private void RedeemCoupon(string couponId) {
            Coupon coupon = new Coupon {
                Id = couponId
            };

            client.redeemCoupon(coupon);
        }

        // DeleteCoupon deletes the coupon with {couponId}.
        // DeleteCoupon allows us to set the final coupon values before the coupon is voided and the pass updated & invalidated with the final values.
        private void DeleteCoupon(string couponId) {
            Coupon coupon = new Coupon {
                Id = couponId
            };

            client.voidCoupon(coupon);
        }
    }
}