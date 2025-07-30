using Xunit;
using Microsoft.AspNetCore.Mvc;
using System;

public class HelloControllerTests
{
    [Fact]
    public void Get_ReturnsHello()
    {
        var controller = new HelloController();
        var result = controller.Get() as OkObjectResult;
        Assert.NotNull(result);
        Assert.Equal("Hello from CI/CD!", result.Value);
    }
}
