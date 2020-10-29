using FluentAssertions;
using MarkMe.API.Domain;
using MarkMe.IntegrationTests.Core;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace MarkMe.IntegrationTests
{
    public class TodoListControllerTests : IntegrationTest
    {
        [Fact]
        public async Task GetAll_WithoutAnyTodoLists_ReturnsEmptyResponse()
        {
            var response = await TestServer.GetAsync("api/todoList");

            response.StatusCode.Should().Be(HttpStatusCode.OK);
            (await response.Content.ReadFromJsonAsync<List<TodoList>>()).Should().BeEmpty();
        }

        [Fact]
        public async Task Create_ReturnsCreatedTodoList()
        {
            var todoList = new TodoList
            {
                Nome = "Yamete Kudasai"
            };

            var response = await TestServer.PostAsJsonAsync("api/todoList", todoList);
            var data = await response.Content.ReadFromJsonAsync<TodoList>();

            data.Nome.Should().Be(todoList.Nome);
        }

        //[Fact]
        //public async Task GetById_ReturnsOneTodoList()
        //{

        //}
    }
}
