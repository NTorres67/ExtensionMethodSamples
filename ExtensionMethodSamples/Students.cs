using Ardalis.GuardClauses;
using System.Collections.Generic;

namespace ExtensionMethodSamples.SourceData
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            // Guard Clause
            Guard.Against.NullOrWhiteSpace(firstName, nameof(firstName));
            Guard.Against.NullOrWhiteSpace(lastName, nameof(lastName));
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public List<CompletedCourse> CompletedCourses { get; } = new List<CompletedCourse>();

        public bool IsGoodStudent()
        {
            // Log("Calling IsGoodStudent");
            return (CompletedCourses.TrueForAll(c => c.GradesReceived.Passing()));
        }

        //public static void DoSomething()
        //{
        //    if(firstName)
        //}
    }
}