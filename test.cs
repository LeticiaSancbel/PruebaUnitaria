using Xunit;
using System;
using System. Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class test
{
    [Fact]
    public void Test()
    {   
    Assert.Equal(4,Program.Add(2,2));
    }
}
