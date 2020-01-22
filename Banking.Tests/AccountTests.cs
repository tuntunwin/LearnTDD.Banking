using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Banking.Models;
using Xunit;
using Moq;

namespace Banking.Tests
{
    // class EmailServiceMock : IEmailService
    // {
    //     public bool SendToIsCalled;
    //     public bool SendTo(string toAddr, string subject, string message)
    //     {
    //         SendToIsCalled = true;
    //         return true;
    //     }
    // }
    public class AccountTests
    {
        // [Fact]
        // public void Balance_Is_Updated_And_Email_Is_Send_When_Deposite_Is_Made()
        // {
        //     //Arrange
        //     //var emailServiceMock =  new EmailServiceMock();
        //     var emailServiceMock = new Mock<IEmailService>();
        //     //emailServiceMock.Setup(e => 
        //     //e.SendTo(It.IsAny<String>(), It.IsAny<String>(), It.IsAny<string>())).Throws(new Exception());
        //     var account = new Account(111, 0);
        //     //Act
        //     //Assert.ThrowsAny<Exception>(()=> account.Deposite(1000));
        //     //Assert
        //     account.Deposite(1000);
        //     Assert.Equal(1000, account.Balance);
        //     emailServiceMock.Verify(e => e.SendTo(It.IsAny<String>(), It.IsAny<String>(), It.IsRegex("1000")));
        //     //Assert.True(emailServiceMock.SendToIsCalled);
            
        // }

        //  [Fact]
        // public void Exceptin_Must_Be_Throw_When_Deposite_Is_Made_And_Email_Service_Fails()
        // {
        //     //Arrange
        //     //var emailServiceMock =  new EmailServiceMock();
        //     var emailServiceMock = new Mock<IEmailService>();
        //     emailServiceMock.Setup(e => 
        //     e.SendTo(It.IsAny<String>(), It.IsAny<String>(), It.IsAny<string>())).Throws(new Exception());
        //     var account = new Account(111, 0);
        //     //Act
        //     Assert.ThrowsAny<Exception>(()=> account.Deposite(10000));
        //     //Assert
        //     // account.Deposite(1000);
        //     // Assert.Equal(1000, account.Balance);
        //     // emailServiceMock.Verify(e => e.SendTo(It.IsAny<String>(), It.IsAny<String>(), It.IsRegex("1000")));
        //     //Assert.True(emailServiceMock.SendToIsCalled);
            
        // }

        [Fact]
        public void Deposite_Should_Update_Correct_Balance_Amount_When_Deposite_Is_Made()
        {
            var account = new Account(111);
            account.Deposite(1000);
            Assert.Equal(1000, account.Balance);
            
        }

           [Fact]
        public void Withdraw_Should_Update_Correct_Balance()
        {
            var account = new Account(1111, 2000);
            account.Withdraw(1000);
            Assert.Equal(1000, account.Balance);
            
        }

        [Fact]
        public void Withdraw_Throws_Exception_When_Balance_Is_Not_Enought()
        {
            var account = new Account(1111, 500);
            Assert.ThrowsAny<NotEnoughtBalanceExeption>(()=>account.Withdraw(1000));
            // try{
            //     account.Withdraw(1000);
            // }catch(NotEnoughtBalanceExeption ex){
            //     //ex.CurrentBalance >
            // }
           
            
        }

        // [Fact]
        // public void Should_Update_Correct_Balance_Amount_When_Deposite_Is_Made()
        // {
        //     var account = new Account(111);
        //     account.Deposite(1000);
        //     Assert.Equal(1000, account.Balance);
            
        // }

        // [Theory]
        // [InlineData(0, 1000)]
        // [InlineData(1, 1001)]
        // [InlineData(3000, 4000)]
        // [InlineData(int.MaxValue - 1000, int.MaxValue)]
        // public void Balance_Is_Updated_Correctly_When_Deposite_Is_Made(int depositeAmt, int expertedAmount)
        // {
        //     var account = new Account(1000);
        //     account.Deposite(depositeAmt);
        //     Assert.Equal(expertedAmount, account.Balance);
            
        // }
        // public static IEnumerable<object[]> Deposites => new List<object[]>{new object[]{1000},new object[]{2000},new object[]{3000}};
        // [Theory]
        // [MemberData(nameof(Deposites))]
        // public void Balance_Is_Updated_Correctly_When_Deposite_Is_Made2(int value)
        // {
        //     var account = new Account(111);
        //     account.Deposite(value);
        //     Assert.Equal(value, account.Balance);
            
        // }

        //  [Fact]
        // public void Given_Balance_Is_Zero_When_Deposite_Is_Made_Then_Balance_Must_Be_The_Same_As_Deposite_Amount()
        // {
        //     var account = new Account(111);
        //     account.Deposite(1000);
        //     Assert.Equal(1000, account.Balance);
            
        // }
    }
}
