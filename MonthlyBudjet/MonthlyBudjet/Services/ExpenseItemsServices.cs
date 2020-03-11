using MonthlyBudjet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MonthlyBudjet.Services
{
    public class ExpenseItemsServices
    {
        private static ObservableCollection<ExpenseItem> _expenses;

        public ExpenseItemsServices()
        {
            if(_expenses == null)
            {
                _expenses = new ObservableCollection<ExpenseItem>();
            }
        }

        public ObservableCollection<ExpenseItem> GetExpenseItems()
        {
            //var expenses = new ObservableCollection<ExpenseItem>() {

            //    new ExpenseItem (){
            //        Amout = 100,
            //        DateTimeStamp = DateTime.Now,
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "First Item",
            //        IconImageResourceId = "shopping.jpg"
            //    },
            //    new ExpenseItem (){
            //        Amout = 80,
            //        DateTimeStamp = DateTime.Now,
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "Seond Item",
            //        IconImageResourceId = "fitness.jpg"
            //    },
            //    new ExpenseItem (){
            //        Amout = 120,
            //        DateTimeStamp = DateTime.Now,
            //        Id = Guid.NewGuid().ToString(),
            //        Name = "Third Item",
            //        IconImageResourceId = "shopping.jpg"
            //    }
            //};

            return _expenses;
        }

        public void AddExpenseItem(ExpenseItem item)
        {
            _expenses.Add(item);
        }
    }
}