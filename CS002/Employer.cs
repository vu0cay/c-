

using System.Reflection;

namespace CS002{
    class Employer : MethodInterface{
        // attributes
        private int id;
        private string name;
        private string mail;

        // properties
        public int EmployerID {
            get {
                return id;
            }
            set {
                id = value;
            }
        }
        // contructor
        // public Employer() {}
        public Employer(int id, string name, string mail) {
            this.id = id;
            this.name = name;
            this.mail = mail;
        }
        // destructor
        ~Employer() {
            System.Console.WriteLine("Destructor was called.");
        }
        // methods
        public static void testStatic() {
            System.Console.WriteLine("Static method");
        }
        public override void show() {
            System.Console.WriteLine($"Employer: [id => {id}, name => {name}, mail => {mail}]");
        }
        public override string ToString()
        {
            return $"Employer: [id => {id}, name => {name}, mail => {mail}]";
        }
    }
}