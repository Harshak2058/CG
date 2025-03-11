using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LatefeeREPractise
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
            string author ="Unknown Author";
            numPages=0;
            dueDate=DateTime.Now;
            returnedDate=DateTime.Now;
        }
        public Book(string title, string author, int numPages, DateTime dueDate,DateTime returnedDate)

        {
            this.title=title;
            this.author=author;
            this.numPages=numPages;
            this.dueDate= dueDate;
            this.returnedDate=returnedDate;
        }

        public double AveragePagesReadPerDay(int daysToRead)
        {
            double AveragePagesReadPerDayy= numPages/daysToRead;
            return AveragePagesReadPerDayy;

        }
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int NumberOfDaysLate= (returnedDate- dueDate).Days;
            double latefees= NumberOfDaysLate * dailyLateFeeRate;
            return latefees;
        }


    }
}