using FluentAssertions;
using LoR.Client.Internal;
using Refit;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LoR.Client.Tests
{
    public class InternalClientIntegrationTests
    {
        private readonly IRuneterraInternalClient _client;

        public InternalClientIntegrationTests()
        {
            _client = RestService.For<IRuneterraInternalClient>("http://localhost:21337");
        }

        [Fact]
        [Trait("Category", "Integration")]
        public Task GetActiveDeckAsyncReturns200Ok() => ValidateRequest(() => _client.GetActiveDeckAsync());

        [Fact]
        [Trait("Category", "Integration")]
        public Task GetCardPositionsAsyncReturns200Ok() => ValidateRequest(() => _client.GetCardPositionsAsync());

        [Fact]
        [Trait("Category", "Integration")]
        public Task GetExpeditionsStateAsyncReturns200Ok() => ValidateRequest(() => _client.GetExpeditionsStateAsync());

        [Fact]
        [Trait("Category", "Integration")]
        public Task GetLastGameResultAsyncReturns200Ok() => ValidateRequest(() => _client.GetLastGameResultAsync());

        private Task ValidateRequest(Func<Task> request) => request.Should().NotThrowAsync("because it is a valid request");
    }
}
