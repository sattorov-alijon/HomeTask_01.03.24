using Tasc1;



var teacher=new Teacher("");
System.Console.Write("Nomi 1 : ");
    teacher.Name=Console.ReadLine();

var student=new Student("");
System.Console.Write("Nomi 2 : ");
student.Name=Console.ReadLine();
var student1=new Student("");
System.Console.Write("Nomi 3 : ");
student1.Name=Console.ReadLine();
teacher.Explaing();
student.Study();
student1.Study();