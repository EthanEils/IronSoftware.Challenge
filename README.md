# Why I structure the solution this way:
I have structure the solution such that the source code is separated from the tests. This is a common pattern in the development space and allows for better organization of the codebase.

The source code is in the `src` directory and the tests are in the `tests` directory.

# How I went about solving the problem:
The first challenge that I though about was how to split the input into the respective number gruops that would be returned. Since I knew that a space would represent a pause, I decided that I could iterate over the text and group the numbers so long as they match each other.

This gave me a collection of number groups that I could: loop over, translate to their respective characters, append them to a string that would be returned as the result.

I know that there might be a more elegate way to translate the numbers to their respective characters, but given the context of the keyboard having a set layout, I knew that the number of combinations were limited, hence the use of a switch statement.

The special characters required specific behaviors, but for the delete key, I ended up using a feature of C# that allows me to grab all characters exept the last one as a way of handling the delete key. The space was easy enough to handle as well since I could append a space to the result string.

# Test framework used:
I opted to use xUnit as the test framework for the project as it is a popular test framework in the .NET ecosystem and is well supported.

## How to run the tests:
To run the tests, you can use the command `dotnet test` when in the root directory of the project.

Currently, one test is consistently failing due to what I believe to be a mistake in the examples provided in the prompt. I have left the test in the collection of tests to show that the accurate output is being returned. I have validated the output by hand and it is correct.





Thank you so much for your time and consideration. I look forward to hearing from you soon.
