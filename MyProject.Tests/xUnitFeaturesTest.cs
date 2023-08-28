namespace MyProject.Tests
{
    public class xUnitFeaturesTest
    {
        public class FactTest
        {
            [Fact]
            public void Should_be_equal()
            {
                var expectedValue = 2;
                var actualValue = 2;
                Assert.Equal(expectedValue, actualValue);
            }
        }

        public class AsyncFactTest
        {
            [Fact]
            public async Task Should_be_equal()
            {
                var expectedValue = 2;
                var actualValue = 2;
                await Task.Yield();
                Assert.Equal(expectedValue, actualValue);
            }
        }

        public class AssertionTest{
            [Fact]
            public void Exploring_xUnit_assertions()
            {
                object obj1 = new MyClass { Name = "Object 1" };
                object obj2 = new MyClass { Name = "Object 1" };
                object obj3 = obj1;
                object? obj4 = default(MyClass);

                Assert.Equal(expected: 2, actual: 2);
                Assert.NotEqual(expected: 2, actual: 1);

                Assert.Same(obj1, obj3);
                Assert.NotSame(obj1, obj4);
                Assert.Equal(obj1, obj2);

                Assert.Null(obj4);
                Assert.NotNull(obj3);

                var instanceOfMyClass = Assert.IsType<MyClass>(obj1);
                Assert.Equal(expected: "Object 1", actual: instanceOfMyClass.Name);

                var exception = Assert.Throws<SomeCustomException>(
                    testCode: () => OperationThatThrows("Toto")
                    );

                static void OperationThatThrows(string name)
                {
                    throw new SomeCustomException { Name = name };
                }
            }
        
        }

        private record class MyClass
        {
            public string? Name { get; set; }
        }

        private class SomeCustomException : Exception
        {
            public string? Name { get; set; }
        }
    }
}