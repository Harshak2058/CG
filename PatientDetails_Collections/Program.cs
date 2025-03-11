using System;
using System.Collections.Generic;
namespace PatientDetails_Collections
{
    public class Program
    {
        Queue<Patient> PatientQueue= new Queue<Patient>();
        public static void Main(string[] args)
        {
            Patient p = new Patient();
            Console.WriteLine("Enter the reason");
            Console.WriteLine("1. Patient admission");
            Console.WriteLine("2. Display the first admitted patient details");
            Console.WriteLine("3. Remove the first admitted patient details");
            Console.WriteLine("4. Exit");
            
            string choice= Console.ReadLine();
            if(choice=="1") //1. Patient admission
            {
                Console.WriteLine("Enter the patient Id");
                int id= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the patient Name");
                string name= Console.ReadLine();
                Console.WriteLine("Enter the patient Address");
                string address= Console.ReadLine();
                p.AddPatientDetails(id,name,address);
                Console.WriteLine("Patient added successfully");
            }
            else if(choice =="2")//2. Display the first admitted patient details 
            {
                string strMess= p.GetPatientDetails();
                Console.WriteLine(strMess);
            }
            else if(choice =="3")//3. Remove the first admitted patient details
            {

            }
            else if(choice=="4")//4.Exit
            {
                Console.WriteLine("Thank you");
                break;
            }
        }
    }
}


/*
a system is needed to 
add new patient information 
upon admission and remove it upon discharge.
*/
