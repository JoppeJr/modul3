using System;

namespace PrintPeople
{
    public class Persons
    {
        public  string Name { get; private set; }
        public  string Age { get; private set; }
        public  string Place { get; private set; }

        public Persons(string name, string age, string place)
        {
            Name = name;
            Age = age;
            Place = place;
        }
        public  void ShowPersonInfo()
        {
            var labelWidth = 8;
            ShowSeperators(8);
            ShowFieldNameAndValue("Navn", labelWidth, Name);
            ShowFieldNameAndValue("Age", labelWidth, Age);
            ShowFieldNameAndValue("Place", labelWidth, Place);
            ShowSeperators(labelWidth);
        }


        private  void ShowFieldNameAndValue(string lable, int labelWidth, string fieldValue)
        {
            labelWidth -= lable.Length;
            Console.WriteLine("  " + lable + ":" + " ".PadLeft(labelWidth, ' ') + fieldValue);
        }
        private  void ShowSeperators(int labelWidth)
        {
            labelWidth += 14;
            Console.WriteLine(string.Empty.PadLeft(labelWidth, '*'));
        }
    }
}