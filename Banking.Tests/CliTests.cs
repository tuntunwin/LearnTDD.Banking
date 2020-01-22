using System;
using Xunit;
using Moq;
using Banking.Cli;
using Banking.Models;

namespace Banking.Tests
{
    public class CliTests{
        [Fact]
        public void Create_Account_Test(){
            var consoleMock = new Mock<IShell>();
            consoleMock.SetupSequence(c => c.ReadLine())
                .Returns("1111")
                .Returns("2000");
            var repoMock = new Mock<IRepository>();
            var accId = 0;
            decimal balance = 0;
            repoMock.Setup(r => r.Save(It.IsAny<Account>()))
            .Callback<Account>(a => (accId, balance) = (a.AccountId, a.Balance));
            var createAccView = new CreateAccountView("fool", consoleMock.Object, repoMock.Object);
            createAccView.Show();
            Assert.Equal(1111, accId);
            Assert.Equal(2000, balance);
        }
    }
    
}