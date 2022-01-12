using System;
using Xunit;
using TodoApi.Models;


namespace TodoApi.Tests;

public class TodoApiTest
{
    [Fact]
    public void Test1()
    {
        var a = "hi";
        Assert.Equal(a, "hi");
    }

    [Fact]
    public void TestPostgreSqlUniqueClassOk()
    {
        var options = this.CreatePostgreSqlUniqueClassOptions<TodoContext>();
        using var context = new TodoContext(options);
    
    }

    [Fact]
    public void TestEnsureDeletedEnsureCreatedOk()
    {
        var options = this.CreatePostgreSqlUniqueClassOptions<TodoContext>();
        using var context = new TodoContext(options);
    
        context.Database.EnsureCreated();
        context.Database.EnsureCreated();
    }

    [Fact]
    public void TestEnsureCleanOk()
    {
        var options = this.CreatePostgreSqlUniqueClassOptions<TodoContext>();
        using var context = new TodoContext(options);
    
        context.Database.EnsureClean(); 
    }
}