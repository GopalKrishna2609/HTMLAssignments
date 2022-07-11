using HTMLDay3AssignmentProject.Students;

namespace HTMLDay3AssignmentProject
{
    internal class LINQquery
    {
        List<Student> students = new List<Student>()
        {
            new Student() { ID = 101 , Name = "Rajesh" , Age = 20},
            new Student() { ID = 102 , Name = "Aditya" , Age = 14},
            new Student() { ID = 103 , Name = "Himanshu" , Age = 13},
            new Student() { ID = 104 , Name = "Janvi" , Age = 15},
            new Student() { ID = 105 , Name = "Riya" , Age = 17},
            new Student() { ID = 106 , Name = "Ishuta" , Age = 16},
            new Student() { ID = 107 , Name = "Harsh" , Age = 10},

        };
        public void Query()
        {
            var studentNames = students.Where(s => s.Age > 12 && s.Age < 20)
                              .Select(s => s);
            studentNames.ToList().ForEach(s => Console.WriteLine("Student ID = " + s.ID + " Student Name = " + s.Name +" Student Age = " + s.Age ));
        }
    }

}


