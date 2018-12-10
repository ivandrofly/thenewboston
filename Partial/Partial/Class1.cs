
namespace Partial
{
    partial class MyClass
    {
        public string HairColor = "Brown";
        public bool Glasses = false;

        // Note: you cannot have the access modifier in partial methods!
        partial void Message(string message)
        {
            // Note: we can access the variable declared in antoher class 
            System.Windows.Forms.MessageBox.Show("Name is: " + this.Name + "\nHair-Color: " + HairColor + "\nGlasses :" + Glasses.ToString() + "\nYour Message is: " + message);
        }

        public void ShowMessage(string message)
        {
            Message(message);
        }
    }
}


