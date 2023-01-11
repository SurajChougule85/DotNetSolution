using CDAC1collection;
using CDACcollection;
using System.Collections.Generic;
using System; 

List<Employee> emp= new List<Employee>();
emp.Add(new Employee(101,"Sadanand",50000));
emp.Add(new Employee(109,"Sadashiv",60000));
emp.Add(new Employee(105,"Sagar",40000));
emp.Add(new Employee(107,"Sarala",40000));
emp.Add(new Employee(110,"Sukumar",40000));

Console.WriteLine("List of Employees before Sort");

foreach(Employee employee in emp){
    Console.WriteLine(employee.id+"___and___"+employee.name+"___and___"+employee.salary);

//using and creating a new Instance of EmpComparer....


}


EmpComparer ec=new EmpComparer();
emp.Sort(ec);
Console.WriteLine("List of Employees after Sort-------------------------------------");
foreach(Employee employee in emp ){
    Console.WriteLine(employee.id+"___and___"+employee.name+"___and___"+employee.salary);
}


    Player1 p1=new Player1("Rajat",3455,97,26);
    Player1 p2=new Player1("Rahul",11000,356,27);
    Player1 p3=new Player1("Rohit",9344,234,34);
    Player1 p4=new Player1("Rakesh",3678,156,31);

List<Player1> newplayer=new List<Player1>();
    newplayer.Add(p1);
    newplayer.Add(p2);
    newplayer.Add(p3);
    newplayer.Add(p4);

Console.WriteLine("before sorting");
    foreach(Player1 newP in newplayer){
         Console.WriteLine(newP.name+" "+newP.matches+" "+newP.run+" "+newP.age);
    }

        newplayer.Sort();

Console.WriteLine("after sorting");
    foreach(Player1 newP in newplayer){
         Console.WriteLine(newP.name+" "+newP.matches+" "+newP.run+" "+newP.age);
    }



