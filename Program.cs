using System;

namespace DentalInsuranceClaimManager
{
    class Program
    {
        static void Main()
        {
            ClaimManager claimManager = new ClaimManager();
            bool running = true;

            while (running){

                Console.WriteLine("\n====== Dental Insurance Claim Manager =====");
                Console.WriteLine("1. Add a New Claim");
                Console.WriteLine("2. View All Claims");
                Console.WriteLine("3. Update Claim Status");
                Console.WriteLine("4. Search Claim");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                    claimManager.AddClaim();
                    break;

                    case "2":
                    claimManager.ViewClaims();
                    break;

                    case "3": //update claim status
                    claimManager.UpdateClaimStatus();

                    
                    
                    break;
                    case "4":
                    claimManager.SearchClaim();
                    
                    
                    break;
                    case "5":
                    Console.WriteLine("Exiting...");
                    running = false;
                    break;

                    default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;




                }
                





            }
        

        }
    }
}