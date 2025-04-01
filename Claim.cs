using System;
public class Claim
{
// Define Properties
public int ClaimID { get; set;}
public string PatientName { get; set;}

public string PolicyNumber { get; set;}

public string Treatment { get; set;}

public double Cost { get; set;}

public string Status { get; set;}





//Constructor
public Claim(int id, string patientName, string policyNumber, string treatment, double cost )
{

ClaimID = id;
PatientName = patientName;
PolicyNumber = policyNumber;
Treatment = treatment;
Cost = cost;
Status = "Pending";

}

//DisplayClaim method
public void DisplayClaim(){
            Console.WriteLine("==================================");
            Console.WriteLine($"Claim ID      : {ClaimID}");
            Console.WriteLine($"Patient Name  : {PatientName}");
            Console.WriteLine($"Policy Number : {PolicyNumber}");
            Console.WriteLine($"Treatment     : {Treatment}");
            Console.WriteLine($"Cost          : ${Cost}");
            Console.WriteLine($"Status        : {Status}");
            Console.WriteLine("==================================");

}


}