using oop_session2.inheritance;
using Common;
namespace oop_session2
{
    internal class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public void fun1() { Console.WriteLine("Iam Employee"); }
        public virtual void fun2() { }
    }
    class FullTimeEmp : Employee
    {
        public double Salary { get; set; }
        public new void fun1() { Console.WriteLine("Iam a Full Time Employee"); }
        public override void fun2() { Console.WriteLine($"Salary: {Salary}"); }
    }
    class PartTimeEmp : Employee
    {
        public double Rate { get; set; }
        public int NumberOfHours { get; set; }
        public new void fun1() { Console.WriteLine("Iam a Part Time Employee"); }
        public override void fun2() { Console.WriteLine($"part salary: {Rate * NumberOfHours}"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class vs Struct
            /* Using struct or class when there are some related attributes that wanted to make [data type] from them. 
             class: 
                    --> reference type [reference in stack and obj in heap]
                    --> new in class means the 4 points [it creates the object]
                    --> any user defined constructor cancle the default one
                    --> includes the all 6 access modidfiers
                    --> support inheritance, ploymorphism, abstructing and encapsulation
                    --> dealing with class instance is slower than struct
                    --> lifetime of class object is longer than lifetime of struct object 
                    as the reference is deleted from stack but the object itself is kept in Heap until GC removes it.
                    --> class object can be mutable or immutable
                    --> use class in big projects as many instances can be created so we avoid stack overflow
                    --> use class when the data is complex and when we need all the oop features.
            struct:
                    --> value type [obj is in stack]
                    --> new in struct means constructor selection only
                    --> the default constructor is canceled via overriding it only.
                    --> includes 3 access modidfiers only [private, public, internal]
                    --> support encapsulation and overloading in ploymorphism [don't support inheritance].
                    --> dealing with struct instance is faster than class because of stack accessing
                    --> lifetime of struct object is shorter than the lifetime of class object 
                    as when the function that uses the struct object is termineted, the struct obj is deleted from stack. 
                    --> struct object is mutable only [can change its value]
                    --> use struct when the data is simple and when we don't need to use the other oop features like inheritance.
            */
            #endregion

            #region inheritance
            //DRY --> Don't Repaet Yourself
            //parent, base, super class
            //child, drived, sub class
            // a reference of any class can refer to object from this class or another object from any class
            // that inherites from that class --> [object o1 = new object()] [o1="hi"] [o1=5] [o1=true]

            /*Child c1 = new Child(1, 2, 3, 4);
            c1.fn2();
            c1.x = 5;
            c1.y = 10;
            c1.b = 20;
            // c1.a     --> Invalid: child doesn't inherite the [private] attributes
            c1.fn2();
            c1.fn1();   //override  */
            #endregion

            #region classes relationships
            /* 
                1. Generalization (Inheritance): [is a] relation
                2. Association: [has a] relation
                   relation between two separate classes which can be one-to-one, one-to-many or many-to-many.
                2.1 Aggregation: [has a] relation
                    unidirectional association. one-way relationship. weak association.
                    For example, a department can have students but vice versa is not possible.
                    both entries can survive individually which means ending one entity will not affect the other entity.
                2.2 Composition: [has a] relaiton
                    It is a restricted form of Aggregation in which two entities are highly dependent on each other.  
                    It represents part-of relationship. strong association. 
                    both entities are dependent on each other.
                    the composed object cannot exist without the other entity.
             */
            #endregion

            #region Polymorphism
            // Compile-time Polymorphism --> method overloading
            // Run-time Polymorphism --> method overriding
            #endregion

            #region overloading
            // Compile-time Polymorphism
            // more than function in the same scope [class - struct] has the same name with different signature.
            // functions are different in [count - type - order] parameters.
            /*sum(1, 2);
            sum(1.5, 2.4);
            sum(1, 2.7);
            sum(4.1, 2);
            sum(1, 2, 3);*/
            #endregion

            #region overriding [new - override]
            // overriding means Hidding
            // Run-time Polymorphism
            // more than function in different scope [class] has the same name and the same signature but with different body or behaviour.
            // apply it using keywords [new] or [override]  --> [new] is the defult
            // To apply override using override keyword --> method must be [virtual] and [NOT private]
            // [virtual]: make CLR calling the last overrided function in binding case.

            // the difference between new and override is when using [Binding]
            // Person obj = new Employee(); --> Person reference type
            //                              --> Employee object type
            // In this case obj see what all inside [Person] class and only the overrided function in
            // Employee class with keyword [override] only, if the overrided function using new keyword
            // the obj willn't see it and it will call the method in Person class.

            /*TypeB typeB = new TypeB(1,2);
            typeB.Fn1();
            typeB.Fn2();*/
            #endregion

            #region Binding [related to inheritance]
            // Binding --> reference from parent and object from child [related to inheritance]
            // Reference of any class can refer to object from this class or another object from class that inherites from that class.
            // Binding EX: object o1;  [o1="hi"] [o1=5] [o1=true]

            // 1. apply override using [new]:
            // [static] binding     [Early] binding     [compilaiton time]
            // [compiler] will call function based on the [reference type] not object type

            // 2. apply override using [override]:
            // method must be [Not private] and [virtual]
            // [dynamic] binding     [late] binding     [run time]
            // [CLR] will call function based on the [object type] not reference type

            // Person obj = new Employee(); --> Person reference type
            //                              --> Employee object type
            // In this case obj see what all inside [Person] class and only the overrided function in
            // Employee class with keyword [override] only, if the overrided function using new keyword
            // the obj willn't see it and it will call the method in Person class.

            /*TypeA obj = new TypeB(1,2);
            obj.A = 10;
            //obj.B;        Invalid --> obj see what inside TypeA class and B is not in TypeA class
            obj.Fn1();      // static binding based on reference type
            obj.Fn2();      //virtual: dynamic binding based on object type */
            #endregion

            #region Not Binding
            /*TypeA typeA;
            typeA = new TypeA(1);
            typeA = new TypeB(1, 2);    //Binding
            //TypeB obj = typeA;        //Invalid 
            TypeB obj = (TypeB) typeA;  //Explicit casting (un safe)
            obj.Fn1();
            obj.Fn2();
            
            //Person p = new Person();
            //Employee e = p;       //Invalid cast exception

            //Person p2 = new Employee();  // Binding
            //Employee e2 = (Employee) p2; // Invalid Explicit casting (un safe)*/
            #endregion

            #region Binding EX
            //DispalyEmp(new FullTimeEmp());
            //DispalyEmp(new PartTimeEmp());
            #endregion

            #region Binding EX2
            //TypeA typeA;

            /*typeA = new TypeA(1);
            typeA.fun1();
            typeA.fun2();*/

            /*typeA = new TypeE(1, 2, 3, 4, 5);
            typeA.fun1();   // static binding
            typeA.fun2();*/   // dynamic binding  --> call the last override

            /*typeA = new TypeD(1, 2, 3, 4);
            typeA.fun2();*/

            /*TypeD typeD = new TypeE(1,2,3,4,5);
            typeD.fun1();
            typeD.fun2();*/
            #endregion

            #region Access modifiers [protected, inernal protected, private protected]
            /*Common.TypeA obj = new Common.TypeA();
            obj.x = 0;          //[invalid as private]
            obj.y = 0;          //[invalid as private] 
            obj.z = 0;          //[invalid as internal]
            obj.m = 0;          //[invalid as private]*/

            /*Common.TypeB obj2 = new Common.TypeB();
            obj2.x = 0;        //[invalid as private]
            obj2.y = 0;        //[invalid as private]
            obj2.z = 0;        //[invalid as private]*/

            /*Test t = new Test();
            t.x = 0;            //[invalid as x is not inherited]
            t.y = 0;            //[invalid as private]
            t.z = 0;            //[invalid as private]*/

            /*
             1. protected private:
                classes inside project  --> inherit it as [private]
                classes outside project --> cann't inherit it

            1. protected:
                classes inside project  --> inherit it as [private]
                classes outside project --> inherit it as [private]

            1. protected internal:
                classes inside project  --> inherit it as [internal]
                classes outside project --> inherit it as [private]
            */
            #endregion
        }
        public static int sum(int x, int y) { return x + y; }
        public static double sum(double x, double y) { return x + y; }
        public static double sum(int x, double y) { return x + y; }
        public static double sum(double x, int y) { return x + y; }
        public static int sum(int x, int y, int z) { return x + y + z; }
        public static void DispalyEmp(Employee emp)
        {
            if (emp is not null)
            {
                emp.fun1();// static binding [compiler depends on reference type]
                emp.fun2();// dynamic binding [CLR depends on object type]
            }
        }
    }
}
