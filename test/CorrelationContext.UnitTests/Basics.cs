using Xunit;

namespace CorrelationContext.UnitTests
{
    public class Basics
    {
        [Fact]
        public void you_can_create_a_correlation_context()
        {
            var context = new CorrelationContext();

            Assert.NotNull(context);
        }

        [Fact]
        public void you_can_run_an_action_that_returns_nothing_with_it()
        {
            var context = new CorrelationContext();
            var x = 1;

            context.Run(() => x += 1);

            Assert.True(x == 2,
                $"Expected x to have the value 2 (because it was updated) but was <{x}>");
        }

        [Fact]
        public void you_can_run_a_func_which_returns_something_with_it()
        {
            var context = new CorrelationContext();

            var result = context.Run(() => 1);

            Assert.True(result == 1,
                $"Expected result to have the value 1 (because it was returned) but was <{result}>");
        }
    }
}
