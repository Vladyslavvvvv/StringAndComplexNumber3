using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringAndComplexNumber3
{
    // Custom interface inheriting from the base class
    public interface IString
    {
        byte Length();
        void Clear();
    }

    // IComparable and IClonable interfaces are implemented in the base class tring
    // Class representing the main form
    public partial class Form1 : Form
    {
        private ComplexCollection<string> collection;
        public Form1()
        {
            InitializeComponent();
            collection = new ComplexCollection<string>();
        }

        // Method to check the validity of a complex number input
        private bool IsValidComplexNumber(string input)
        {
            // Divide the line by the "+" sign
            string[] parts = input.Split('+');

            // If after splitting, the string consists of two parts
            if (parts.Length == 2)
            {
                // Checking the first part for numbers
                if (parts[0].Any(char.IsDigit))
                {
                    // Checking the second part for numbers and the "i" symbol at the end
                    if (parts[1].TrimEnd().Any(char.IsDigit) && parts[1].TrimEnd().EndsWith("i"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Event handler for the button click
        private void buttonStart_Click(object sender, EventArgs e)
        {
            string firstInput = textBoxFirst.Text;
            string secondInput = textBoxSecond.Text;

            // Checking the correctness of entering the first number
            if (!IsValidComplexNumber(firstInput))
            {
                MessageBox.Show("Incorrect input format for first number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checking the correctness of entering the second number
            if (!IsValidComplexNumber(secondInput))
            {
                MessageBox.Show("Incorrect input format for second number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create complex numbers based on the entered lines
            ComplexNumber firstComplex = new ComplexNumber(firstInput);
            ComplexNumber secondComplex = new ComplexNumber(secondInput);

            // Check for equality
            bool isEqual = firstComplex.Equals(secondComplex);
            labelEquals.Text = "Equals? " + isEqual.ToString();

            // Adding numbers
            ComplexNumber sum = firstComplex.Add(secondComplex);
            labelAddition.Text = "Addition: " + sum.ToString();

            // Multiplication of numbers
            ComplexNumber product = firstComplex.Multiply(secondComplex);
            labelMultiplication.Text = "Multiplication: " + product.ToString();

            // Creating an array of objects
            ComplexNumber[] numbers = new ComplexNumber[4];

            // Filling the first half of the array
            numbers[0] = firstComplex;
            numbers[1] = secondComplex;

            // Filling the second half of the array with clones of the first half
            for (int i = 2; i < 4; i++)
            {
                numbers[i] = (ComplexNumber)numbers[i - 2].Clone();
            }

            try
            {
                // Sorting the array
                Array.Sort(numbers);

                // Displaying the sorted array using MessageBox
                string sortedNumbers = "Sorted Complex Numbers:\n";
                foreach (ComplexNumber num in numbers)
                {
                    sortedNumbers += num.ToString() + "\n";
                }
                MessageBox.Show(sortedNumbers, "Sorted Complex Numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            // Get the text from textBoxAdd
            string newItem = textBoxAdd.Text;

            // Check whether the value is entered
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                // Check whether the entered value is a correct complex number
                if (!IsValidComplexNumber(newItem))
                {
                    // Display a message about an incorrect value in labelAdded
                    labelAdded.Text = "An incorrect complex number was entered!";
                    return;
                }

                // Add a new item to the collection
                collection.Add(newItem);

                // Update listBoxElements to display the new element
                listBoxElements.Items.Add(newItem);

                // Display a message about the successful addition
                labelAdded.Text = "Added a new item: " + newItem;

                // Clear the textBoxAdd text field to enter the next element
                textBoxAdd.Clear();
            }
            else
            {
                // Inform the user about invalid input
                MessageBox.Show("Enter a value to add to the collection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check whether an element is selected in listBoxElements
            if (listBoxElements.SelectedIndex != -1)
            {
                // Get the selected element
                string selectedValue = listBoxElements.SelectedItem.ToString();

                // Get the index (ordinal position) of the selected item
                int selectedIndex = listBoxElements.SelectedIndex;

                // Display information about the selected element and its ordinal position in labelDisplayInfo
                labelDIsplayInfo.Text = "Item at position " + (selectedIndex + 1) + ": " + selectedValue;
            }
        }
    }

    // Base class
    public abstract class tring : IComparable, ICloneable, IString
    {
        protected string value;
        protected byte length;

        public tring()
        {
            value = "";
            length = 0;
        }

        public tring(string str)
        {
            value = str;
            length = (byte)str.Length;
        }

        public tring(char ch)
        {
            value = ch.ToString();
            length = 1;
        }

        // Method to return the length of the string
        public byte Length()
        {
            return length;
        }

        // Abstract method to clear the string
        public abstract void Clear();

        // Method to compare objects
        public int CompareTo(object obj)
        {
            tring other = obj as tring;
            if (other == null)
            {
                MessageBox.Show("Object is not a tring");
            }
            return this.length.CompareTo(other.length);
        }

        // Method to clone an object
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        // Method to return the string representation of the object
        public override string ToString()
        {
            return value;
        }
    }

    // Class representing a complex number, inheriting from tring and implementing IComparable and ICloneable
    public class ComplexNumber : tring, IComparable, ICloneable
    {
        public ComplexNumber() : base()
        {
        }

        public ComplexNumber(string str) : base(str)
        {
        }

        // Method to clear the complex number
        public override void Clear()
        {
            value = "";
            length = 0;
        }

        // Method to check if two complex numbers are equal
        public bool Equals(ComplexNumber other)
        {
            return this.value.Equals(other.value);
        }

        // Method to add two complex numbers
        public ComplexNumber Add(ComplexNumber other)
        {
            double realPart1 = ExtractRealPart(this.value);
            double imagPart1 = ExtractImaginaryPart(this.value);
            double realPart2 = ExtractRealPart(other.value);
            double imagPart2 = ExtractImaginaryPart(other.value);

            double resultReal = realPart1 + realPart2;
            double resultImag = imagPart1 + imagPart2;

            return new ComplexNumber(resultReal.ToString() + "+" + resultImag.ToString() + "i");
        }

        // Method to multiply two complex numbers
        public ComplexNumber Multiply(ComplexNumber other)
        {
            double realPart1 = ExtractRealPart(this.value);
            double imagPart1 = ExtractImaginaryPart(this.value);
            double realPart2 = ExtractRealPart(other.value);
            double imagPart2 = ExtractImaginaryPart(other.value);

            double resultReal = (realPart1 * realPart2) - (imagPart1 * imagPart2);
            double resultImag = (realPart1 * imagPart2) + (imagPart1 * realPart2);

            return new ComplexNumber(resultReal.ToString() + "+" + resultImag.ToString() + "i");
        }

        // Method to extract the real part of a complex number
        private double ExtractRealPart(string complexNumber)
        {
            string[] parts = complexNumber.Split('+');
            return double.Parse(parts[0]);
        }

        // Method to extract the imaginary part of a complex number
        private double ExtractImaginaryPart(string complexNumber)
        {
            string[] parts = complexNumber.Split('+');
            string imagPart = parts[1].Substring(0, parts[1].Length - 1);
            return double.Parse(imagPart);
        }

        // Method to return the string representation of the object
        public override string ToString()
        {
            return value;
        }

        // Method to compare objects
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            ComplexNumber other = obj as ComplexNumber;
            if (other != null)
            {
                // Comparing complex numbers based on their values
                double thisRealPart = ExtractRealPart(this.value);
                double thisImagPart = ExtractImaginaryPart(this.value);
                double otherRealPart = ExtractRealPart(other.value);
                double otherImagPart = ExtractImaginaryPart(other.value);

                // Comparing real parts first
                int realComparison = thisRealPart.CompareTo(otherRealPart);
                if (realComparison != 0)
                    return realComparison;

                // If real parts are equal, comparing imaginary parts
                return thisImagPart.CompareTo(otherImagPart);
            }
            else
            {
                MessageBox.Show("Object is not a ComplexNumber");
                // If the type is not ComplexNumber, we cannot determine the sorting order,
                // so it's better to throw an exception rather than just displaying a message
                throw new ArgumentException("Object is not a ComplexNumber");
            }
        }

        // Method to clone an object
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class ComplexCollection<T> : IEnumerable<T>
    {
        private Stack<T> items;

        // Initializes a new instance of the ComplexCollection class.
        public ComplexCollection()
        {
            items = new Stack<T>();
        }

        // Adds an item to the collection.
        public void Add(T item)
        {
            items.Push(item);
        }

        // Returns an enumerator that iterates through the collection.
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        // Returns an enumerator that iterates through the collection.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Displays information about a specific item in the collection.
        public void DisplayItemInfo(T item)
        {
            MessageBox.Show(item.ToString(), "Item Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class ComplexCollection1
    {
        private Stack items;

        // Initializes a new instance of the ComplexCollection1 class.
        public ComplexCollection1()
        {
            items = new Stack();
        }

        // Adds an item to the collection.
        public void Add(object item)
        {
            items.Push(item);
        }

        // Returns an enumerable object that iterates through the collection.
        public IEnumerable<object> GetItems()
        {
            foreach (object item in items)
            {
                yield return item;
            }
        }

        // Displays information about a specific item in the collection.
        public void DisplayItemInfo(object item)
        {
            MessageBox.Show(item.ToString(), "Item Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}