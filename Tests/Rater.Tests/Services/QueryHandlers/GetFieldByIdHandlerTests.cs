using Moq;
using NUnit.Framework;
using Rater.Core.Contracts.Queries;
using Rater.Core.ReadModelData.Repositories;
using Rater.Services.QueryHandler;
using System;

namespace Rater.Tests
{
    [TestFixture]
    public class GetFieldByIdHandlerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetFieldByIdHandlerShallGetFieldFromRepository()
        {
            //Setup
            var fieldReadRepository = new Mock<IFieldReadRepository>();
            GetFieldByIdHandler handler = new GetFieldByIdHandler(fieldReadRepository.Object);

            //Action
            handler.Handle(new GetFieldById(It.IsAny<Guid>(), It.IsAny<Guid>()));

            //Assertions
            fieldReadRepository.Verify(f => f.GetFieldById(It.IsAny<Guid>()), Times.Once);
        }
    }
}