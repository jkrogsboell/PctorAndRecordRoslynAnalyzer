// ReSharper disable UnusedType.Global
// ReSharper disable UnusedMember.Global

using System;

namespace PrimaryCtorAndRecordTypes.Sample;

// If you don't see warnings, build the Analyzers Project.

public class Examples
{
    public class MyCompanyClass(int test) // Try to apply quick fix using the IDE.
    {
        public void test1()
        {
            Console.WriteLine(test);
        } 
    }

    public void ToStars()
    {
        var spaceship = new Spaceship(90);
        spaceship.SetSpeed(300000000); // Invalid value, it should be highlighted.
        spaceship.SetSpeed(42);
    }
}