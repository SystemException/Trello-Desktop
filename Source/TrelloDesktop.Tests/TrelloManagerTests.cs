using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrelloDesktop.Library;
using FluentAssertions;

namespace TrelloDesktop.Tests
{
    [TestClass]
    public class TrelloManagerTests
    {
        // Yellow
        [TestMethod]
        public void GetBoards_BoardCount()
        {
            // Arrange
            TrelloManager trelloManager = TrelloManager.Instance;

            // Act
            List<String> boardList = trelloManager.GetAllBoards();

            // Assert
            boardList.Should().HaveCount(2);
        }

        // Yellow
        [TestMethod]
        public void FormatUrl_FormatMemberUrl()
        {
            // Arrange
            TrelloManager trelloManager = TrelloManager.Instance;


            // Act
            string url = trelloManager.FormatUrl(
                "https://api.trello.com/1/members/me/?key=8171b4a95a9615a64ad5fa779539f015&token={0}");

            // Assert
            url.Should().BeEquivalentTo("https://api.trello.com/1/members/me/?key=8171b4a95a9615a64ad5fa779539f015&token=428c8b5253c738979224f25fefc743104a1821bc54fbb09c27d4a87b025d9f7f");
        }

        // Yellow
        [TestMethod]
        public void GetMemberData_MemberData()
        {
            // Arrange
            TrelloManager trelloManager = TrelloManager.Instance;

            // Act
            TrelloUserData trelloUserData = trelloManager.GetUserData();

            // Assert
            trelloUserData.Id.Should().BeEquivalentTo("5ab4d2453d7186128c43b7ea");
        }
    }
}
