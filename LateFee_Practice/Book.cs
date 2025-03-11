using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LateFee_Practice
{
    public class Book
    {
        private string title{get;set;}
        private string author{get;set;}
        private int numPages{get;set;}
        private DateTime dueDate{get;set;}
        private DateTime returnedDate{get;set;}
        
        public Book()
        {
            title="Unknown title";
            author= "Unknown Author";
            numPages=0;
            dueDate=DateTime.Now;
            returnedDate= DateTime.Now;
        }
        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title=title;
            this.author= author;
            this.numPages=numPages;
            this.dueDate=dueDate;
            this.returnedDate= returnedDate;
        }
        public double AveragePagesReadPerDay(int daysToRead)
        {
            if(daysToRead==0)
            return 0;
            double Average= numPages/daysToRead;
            return Average;

        }
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            if(dailyLateFeeRate<=0)
            return 0;
            int NumberOfDaysLate = (returnedDate-dueDate).Days;
            double LateFee = NumberOfDaysLate * dailyLateFeeRate;
            return LateFee;

        }


    }
}