

using System.Net;
using CS002;


/* Test out parameter
void Cal(double salary, out double result) {
    result = salary * (1 + 0.2);
}
double res;
double sal = 10000000;

Cal(sal, out res);

System.Console.WriteLine(res);
*/


/* Test ref parameter
void Cal(ref double salary) {
    System.Console.WriteLine(salary);
    salary = salary * (1 + 0.2);
}
double sal = 10000000;

Cal(ref sal);
System.Console.WriteLine(sal);
*/

/* Test static method
CS002.Employer.testStatic();
*/

/* Test Emplyer and Job Object
Employer microsoft = new Employer(2203594,"Microsoft","mic@gmail.com");

// test setter
// microsoft.EmployerName = "Apple";

// test getter
// System.Console.WriteLine(microsoft.EmployerName);

// test method
microsoft.show();

// test override toString()
// System.Console.WriteLine(microsoft);

Job programmer = new Job(112233, "Programmer", "50,000,000 VND");

programmer.show();
*/

/* Test Array

foreach(var employer in employers ) {
    employer.show();
}

Job[] jobs = new Job[] {
    new Job(1,"Programmer","50,000,000 VND"),
    new Job(2,"Developer","100,000,000 VND"),
    new Job(3,"Designer","125,000,000 VND")
};

foreach(var job in jobs ) {
    System.Console.WriteLine(job);
}
*/

/* Test List and Sort List method
List<Employer> employers = new List<Employer> {
    new Employer(2,"Microsoft","mic@gmail.com"),
    new Employer(1,"Samsung","samsung@gmail.com"),
    new Employer(3,"Apple","apple@gmail.com")
};

employers.Sort( (a, b) => {
    return Convert.ToInt32(a.EmployerID > b.EmployerID);
});

foreach(var employer in employers ) {
    employer.show();
}
*/

Dictionary<int, Employer> dictionEmp = new Dictionary<int, Employer>{
    {1, new Employer(2,"Microsoft","mic@gmail.com")},
    {2, new Employer(1,"Samsung","samsung@gmail.com")},
    {3, new Employer(3,"Apple","apple@gmail.com")}
};

System.Console.WriteLine(dictionEmp.Keys);

foreach(var item in dictionEmp) {
    System.Console.WriteLine(item.Key);
    System.Console.WriteLine(item.Value);
    
}