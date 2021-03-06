﻿using System.Threading;
using Xunit;

namespace CorrelationContext.UnitTests.About_result_annotation
{
    public class About_extra_information
    {
        [Fact]
        public void a_functions_result_can_be_annotated_with_timing()
        {
            var context = new CorrelationContext();

            var annotatedResult = 
                context.Run(x => { Thread.Sleep(1000); return x; }, "whereyouat");
            
            Assert.InRange(annotatedResult.TimeElapsed, 800, 1200);
        }

        [Fact]
        public void an_action_can_be_annotated_with_timing()
        {
            var context = new CorrelationContext();

            var annotatedResult =
                context.Run(x => Thread.Sleep(1000), "whereyouat");

            Assert.InRange(annotatedResult.TimeElapsed, 800, 1200);
        }
    }
}