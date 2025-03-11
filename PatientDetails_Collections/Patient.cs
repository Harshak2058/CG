using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetails_Collections
{
    public class Patient
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Address{get;set;}

        public Queue<Patient>AddPatientDetails(int id,string name, string address)
        {
            Patient newP= new Patient
            {Id=id, Name=name, Address= address};
            AddPatientDetails.Enqueue(newP);
            foreach(var item in newP)
            {
                Console.WriteLine(item);
            }
            


        }
        public string GetPatientDetails()
        {

              return ;
        }   
        public Queue<Patient>RemovePatientDetails()
        {

           q.Dequeue
        } 
    }
}