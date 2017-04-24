using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_18
{
    class Car
    {
        #region Variables
        private string make;
        private string model;
        private int year;
        private decimal price;
        #endregion

        #region Properties
        public string Make
        {
            get
            {
                return make;
            }

            set
            {
                make = value;
            }

        }

        public string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        #endregion

        #region Constructors
        public Car(string MakeInput, string ModelInput, int YearInput, decimal PriceInput)
        {
            make = MakeInput;
            model = ModelInput;
            year = YearInput;
            price = PriceInput;
        }

        public Car()
        {
            make = "Ford";
            model = "Mustang";
            year = 1970;
            price = 25000.00m;
        }
        #endregion
    }
}
