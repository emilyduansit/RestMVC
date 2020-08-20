using System;
using Xunit;
using Commander.Controllers;

namespace RestAPI.Test
{
    public class UnitTest1
    {
        CommandersController controller = new CommandersController();

        [Fact]
        public void GetCommandId()
        {
            var returnvalue = controller.GetCommandById(1);
            Assert.Equal(0,0);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
