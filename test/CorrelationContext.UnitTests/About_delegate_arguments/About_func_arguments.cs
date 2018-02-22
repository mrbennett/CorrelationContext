using Xunit;

namespace CorrelationContext.UnitTests.About_delegate_arguments
{
    public class About_func_arguments
    {
        [Fact]
        public void it_can_run_a_func_with_one_arg()
        {
            var context = new CorrelationContext();

            var i = context.Run(x => x, 1);

            Assert.True(i == 1,
                $"Expected i to be 1 (the sum of args) but had <{i}>");
        }

        [Fact]
        public void it_can_run_a_func_with_two_args()
        {
            var context = new CorrelationContext();

            var i = context.Run((x, y) => x + y, 1, 1);

            Assert.True(i == 2,
                $"Expected i to be 2 (the sum of args) but had <{i}>");
        }

        [Fact]
        public void it_can_run_a_func_with_three_args()
        {
            var context = new CorrelationContext();

            var i = context.Run((x, y, z) => x + y + z, 1, 1 ,1);

            Assert.True(i == 3,
                $"Expected i to be 3 (the sum of args) but had <{i}>");
        }

        [Fact]
        public void it_can_run_a_func_with_four_args()
        {
            var context = new CorrelationContext();

            var i = context.Run((w, x, y, z) => w + x + y + z, 1, 1, 1, 1);

            Assert.True(i == 4,
                $"Expected i to be 1 (the sum of args) but had <{i}>");
        }

        [Fact]
        public void it_can_run_a_func_with_five_args()
        {
            var context = new CorrelationContext();

            var i = context.Run((v, w, x, y, z) => v + w + x + y + z, 1, 1, 1, 1, 1);

            Assert.True(i == 5,
                $"Expected i to be 1 (the sum of args) but had <{i}>");
        }
    }
}