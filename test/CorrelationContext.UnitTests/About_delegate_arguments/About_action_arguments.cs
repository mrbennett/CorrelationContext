using Xunit;

namespace CorrelationContext.UnitTests.About_delegate_arguments
{
    public class About_action_arguments
    {
        [Fact]
        public void it_can_run_an_action_with_one_arg()
        {
            var context = new CorrelationContext();
            var i = 0;

            context.Run(x => i += x, 1);

            Assert.True(i == 1,
                $"Expected x to have the value 2 (because it was updated) but was <{i}>");
        }

        [Fact]
        public void it_can_run_an_action_with_two_args()
        {
            var context = new CorrelationContext();
            var i = 0;

            context.Run((x, y) => i += x + y, 1, 1);

            Assert.True(i == 2,
                $"Expected x to have the value 3 (because it was updated) but was <{i}>");
        }
        [Fact]

        public void it_can_run_an_action_with_three_args()
        {
            var context = new CorrelationContext();
            var i = 0;

            context.Run((x, y, z) => i += x + y + z, 1, 1, 1);

            Assert.True(i == 3,
                $"Expected x to have the value 2 (because it was updated) but was <{i}>");
        }

        [Fact]
        public void it_can_run_an_action_with_four_args()
        {
            var context = new CorrelationContext();
            var i = 0;

            context.Run((w, x, y, z) => i += w + x + y + z, 1, 1 ,1 ,1);

            Assert.True(i == 4,
                $"Expected x to have the value 4 (because it was updated) but was <{i}>");
        }

        [Fact]
        public void it_can_run_an_action_with_five_args()
        {
            var context = new CorrelationContext();
            var i = 0;

            context.Run((v, w, x, y ,z) => i += v + w + x + y + z, 1, 1, 1, 1, 1);

            Assert.True(i == 5,
                $"Expected x to have the value 5 (because it was updated) but was <{i}>");
        }
    }
}
