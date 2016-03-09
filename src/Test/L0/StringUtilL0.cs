using Microsoft.VisualStudio.Services.Agent.Util;
using System;
using System.Diagnostics;
using Xunit;

namespace Microsoft.VisualStudio.Services.Agent.Tests
{            
    public class StringUtilL0
    {
        [Fact]
        [Trait("Level", "L0")]
        [Trait("Category", "Common")]
        public void FormatMessage()
        {
            using (TestHostContext hc = new TestHostContext(nameof(StringUtilL0)))
            {
                TraceSource trace = hc.GetTrace();

                String message = StringUtil.Format("Test {0}", "Test");
                trace.Info(message);

                Assert.Equal("Test Test", message); 
            }
        }
        
        [Fact]
        [Trait("Level", "L0")]
        [Trait("Category", "Common")]
        public void FormatMessageWithNoArgs()
        {
            using (TestHostContext hc = new TestHostContext(nameof(StringUtilL0)))
            {
                TraceSource trace = hc.GetTrace();

                String message = StringUtil.Format("Test {0}");
                trace.Info(message);

                Assert.Equal("Test {0}", message); 
            }
        }
    }
}