

//Select Query Syntax
// bitta element

using LINQLesson;

//List<int> basicPropQuery = (from emp in Employee.GetEmployees() 
//                            select emp.Id)
//                            .ToList();

// Method Syntax

//IEnumerable<int> basicPropMethod = Employee.GetEmployees()
//.Select(emp => emp.Id).ToList();

//foreach (var item in basicPropQuery)
//{
//    Console.WriteLine(item);
//}


Queries.Run();