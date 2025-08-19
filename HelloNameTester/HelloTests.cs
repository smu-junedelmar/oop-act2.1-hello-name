using System;
using System.IO;
using Xunit;

namespace Activity2_1.Tests
{
    public class HelloTests
    {
        [Theory]
        [InlineData("Juswa")]
        [InlineData("Maria")]
        [InlineData("Alex")]
        public void PrintsGreetingForAnyName(string name)
        {
            // Redirect Console input
            using var input = new StringReader(name);
            Console.SetIn(input);

            // Redirect Console output
            using var output = new StringWriter();
            Console.SetOut(output);

            // Run the student's program
            Program.Main();

            // Capture and check the output
            var printed = output.ToString().Trim();
            Assert.Equal($"Hello, {name}!", printed);
        }
    }
}
