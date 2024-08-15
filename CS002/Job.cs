namespace CS002;


class Job : MethodInterface{
        // attributes
        private int id;
        private string title;
        private string salary;

        // properties
        public string JobTitle {
            get {
                return title;
            }
            set {
                title = value;
            }
        }
        // contructor
        // public Job() {}
        public Job(int id, string title, string salary) {
            this.id = id;
            this.title = title;
            this.salary = salary;
        }
        // destructor
        ~Job() {
            System.Console.WriteLine("Destructor was called.");
        }
        // methods
        public override void show() {
            base.show();
            System.Console.WriteLine($"Job: [id => {id}, title => {title}, salary => {salary}]");
        }
        public override string ToString()
        {
            return $"Job: [id => {id}, title => {title}, salary => {salary}]";
        }
}