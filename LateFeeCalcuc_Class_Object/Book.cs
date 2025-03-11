using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LateFeeCalcuc_Class_Object
{
    public class Book
    {
        private string title{get;set;}
        private string author {get;set;}
        private int numPages {get;set;}
        private DateTime dueDate {get;set;}
        public DateTime returnedDate{get;set;}
        public Book()
        {
            title= "Unknown title";
            author="Unknown author";
            numPages=0;
            dueDate=DateTime.Now;
            returnedDate=DateTime.Now;
        }
        public Book(string title, string author,int numPages, DateTime dueDate,DateTime returnedDate)
        {
            this.title= title;
            this.author=author;
            this.numPages=numPages;
            this.dueDate=dueDate;
            this.returnedDate=returnedDate;
        }
        public double AveragePagesReadPerDay(int daysToRead)
        {
            if(daysToRead==0)
            return 0;
            double AveragePagesReadPerDayy= numPages/daysToRead;
            return AveragePagesReadPerDayy;
        }
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int numberDaysLate= (returnedDate-dueDate).Days;// .Days method I used here
            if(numberDaysLate<=0)
            return 0;
            double LateFee= numberDaysLate * dailyLateFeeRate;
            return LateFee;
        }

    }
}