using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Maths_Problems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
         *Find the volume of a rectangular solid when given the length,width and height. 
        */
        private void BtnVolumeOfRectangle_Click(object sender, EventArgs e)
        {
            float length;
            float width;
            float height; 

            length = float.Parse(Interaction.InputBox("Enter the Length.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            width  = float.Parse(Interaction.InputBox("Enter the Width.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            height = float.Parse(Interaction.InputBox("Enter the Height.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);


            float volume = length * width * height;

            MessageBox.Show("The volume is " + volume);
        }

        /*
         * A delicatessen sells cold cuts by the pound. Write a program which calculates the 
         * customer’s bill after accepting the pounds purchased and price per pound.
        */
        private void BtnPricePerPound_Click(object sender, EventArgs e)
        {
            float pounds;
            float price;

            pounds = float.Parse(Interaction.InputBox("Enter the amount of pounds.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            price = float.Parse(Interaction.InputBox("Enter the price per pound.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);

            float bill = pounds * price;

            MessageBox.Show("The total price per pound is " + Math.Round(bill, 2));
        }

        /*
         * Find the cost of broadloom given the length and width of a room in metres. The cost of
         * the broadloom is $12 per square metres.
        */
        private void BtnCarpetArea_Click(object sender, EventArgs e)
        {
            float length;
            float width;
            float pricePerMetre = 12f;

            length = float.Parse(Interaction.InputBox("Enter the length for the room.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            width = float.Parse(Interaction.InputBox("Enter the width for the room.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);

            pricePerMetre = length * width * pricePerMetre;

            MessageBox.Show("The cost of the carpet will be R" + pricePerMetre);
        }


        /*
         * Write a program to calculate the percentage markup for any store item, given the cost and
         * the selling price.
        */
        private void BtnMarkupCalculator_Click(object sender, EventArgs e)
        {
            float costOfItem;
            float sellingPriceOfItem;
            float markup;

            costOfItem = float.Parse(Interaction.InputBox("Enter the cost of the item.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            sellingPriceOfItem = float.Parse(Interaction.InputBox("Enter the selling price of the item.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);

            markup = ((sellingPriceOfItem - costOfItem) / costOfItem) * 100;

            MessageBox.Show("The markup of the item is " + markup + "%");
        }


        /*
         * Write a program which accepts a salespersons sales for one week and then determines 
         * commission. Commission is 14% of sales.
        */
        private void BtnCommisionCalculator_Click(object sender, EventArgs e)
        {
            float salesForTheWeek;
            float commission;

            salesForTheWeek = float.Parse(Interaction.InputBox("Enter the sales for the week.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);

            commission = salesForTheWeek * 0.14f;

            MessageBox.Show("The Commission is R" + Math.Round(commission, 2));
        }

        /*
         * Write a program which accepts an employees name, rate of pay and hours worked. The 
         * following values should then be calculated: Gross pay, Taxes (20% of gross pay), and netpay.
        */
        private void BtnEmployeeTaxCalculator_Click(object sender, EventArgs e)
        {
            string employeeName;
            float rateOfPay;
            float hoursWorked;
            float grossPay;
            float taxes;
            float netPay;

            employeeName = Interaction.InputBox("Enter Employee name.", "", "0");
            rateOfPay = float.Parse(Interaction.InputBox("Enter the pay rate for the employee.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            hoursWorked = float.Parse(Interaction.InputBox("Enter the amount of hours worked.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);

            grossPay = rateOfPay * hoursWorked;
            taxes = grossPay * 0.20f;
            netPay = grossPay - taxes;

            MessageBox.Show("The gross pay for " + employeeName + " is R" + grossPay + ".\n" +
                            "The taxes is R" + taxes + ".\n" + 
                            "The net pay is R" + Math.Round(netPay, 2) + ".");
        }


        /*
         * A vineyard measures the amount of wine in its storage tanks in gallons, but it must ship 
         * the wine in barrels. There are 159 litres in a barrel. Write a program that will accept an 
         * input, the number of gallons in the tank, and display using a MessageBox.Show() the 
         * number of barrels that can be shipped, and the number of gallons remaining after as many 
         * barrels as possible have been filled.
         */
        private void BtnWineCalculator_Click(object sender, EventArgs e)
        {
            float wineInLitres;
            float numberOfBarrels;
            float barrelCapacity = 159;
            float filledUpBarrel;
            float amountOfRemainingLitres;

            wineInLitres = float.Parse(Interaction.InputBox("Enter the amount of wine in litres.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);
            numberOfBarrels = float.Parse(Interaction.InputBox("Enter the amount of barrels.", "", "0"), CultureInfo.InvariantCulture.NumberFormat);

            filledUpBarrel = (wineInLitres / barrelCapacity) * numberOfBarrels;

            amountOfRemainingLitres = wineInLitres % filledUpBarrel;

            MessageBox.Show(wineInLitres + "ℓ of wine can fill " + numberOfBarrels + " barrel/s with " + Math.Round(amountOfRemainingLitres, 2) + "ℓ of wine remaining.");
        }
    }
}
