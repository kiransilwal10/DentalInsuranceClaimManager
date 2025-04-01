using System;
using System.Collections.Generic;

public class ClaimManager{

//Declare all the dynamic array
private List<Claim> claims = new List<Claim>();


private int nextClaimId = 1;

//all your methods
public void AddClaim(){
    Console.WriteLine("Enter the Patient Name: ");
    string patientName = Console.ReadLine();

    Console.WriteLine("Enter policy Number: ");
    string policyNumber = Console.ReadLine();

    Console.WriteLine("Enter treatment type: ");
    string treatment = Console.ReadLine();

    Console.WriteLine("Enter the cost of treatment: ");
    double cost = Convert.ToDouble(Console.ReadLine());

    Claim newClaim = new Claim(nextClaimId, patientName, policyNumber, treatment, cost);

    claims.Add(newClaim); //this stores in the list
    nextClaimId++;

    Console.WriteLine("Claim added successfully!");
}

public void ViewClaims(){

    if (claims.Count == 0){
        Console.WriteLine("No claims found.");
        return;
    }
    Console.WriteLine("\n Displaying all cLaims: \n");

    foreach( Claim claim in claims){
        claim.DisplayClaim();

    }


}
public void UpdateClaimStatus(){
    //ask for claim id- convert input to an integer
    Console.WriteLine("Enter the Claim ID to update: ");

    string input = Console.ReadLine();

    if (!int.TryParse(input, out int idToUpdate))
    {
        Console.WriteLine("Invalid claim ID. Please enter a number.");
        return;

    }
    //search for the claim by ID in the list
    Claim claimToUpdate= null; 
    foreach (var claim in claims)
    {
        if (claim.ClaimID == idToUpdate)
        {
            claimToUpdate = claim;
            break;
        }
    }
    //if no claim found is with that particular ID

    if (claimToUpdate == null)
    {
        Console.WriteLine("Claim not found.");
        return;

    }

    //show current status and ask for a new one
    Console.WriteLine($"Current Status: {claimToUpdate.Status}");
    Console.WriteLine("Enter new status (Approved/Denied): ");

    string newStatus = Console.ReadLine().Trim().ToLower();

    if (newStatus == "approved" || newStatus == "denied"){
        claimToUpdate.Status = char.ToUpper(newStatus[0]) + newStatus.Substring(1);
        Console.WriteLine("Status Updated Successfully!");


    }
    else{
        Console.WriteLine("Invalid status entered. Status not changed.");

    }




    


    



}
public void SearchClaim(){
    Console.WriteLine("Enter the patient name: ");
    string nameInput = Console.ReadLine();

    Console.WriteLine("Enter the policy number:  ");
    string policyInput = Console.ReadLine();

    bool found = false;

    foreach (var claim in claims){
        if (claim.PatientName == nameInput || claim.PolicyNumber == policyInput)
        {
            claim.DisplayClaim();
            found = true;
        }
    }

    if (!found){
        Console.WriteLine("No matching found.");
    }
}

}