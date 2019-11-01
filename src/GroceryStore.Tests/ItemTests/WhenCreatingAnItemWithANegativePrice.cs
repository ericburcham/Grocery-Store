using System;

using FluentAssertions;

using NUnit.Framework;

namespace GroceryStore.Tests.ItemTests
{
    [TestFixture]
    public class WhenCreatingAnItemWithANegativePrice
    {
        private Action _action;

        private Item _item;

        [OneTimeSetUp]
        internal void OneTimeSetUp()
        {
            _action = () => _item = new Item("sku", "name", -1M);
        }

        [Test]
        public void AnArgumentExceptionShouldBeThrown()
        {
            const string parameterName = "price";

            _action.Should().Throw<ArgumentException>()
                .WithMessage($"An item cannot have a negative price.\r\nParameter name: {parameterName}")
                .And.ParamName.Should().Be(parameterName);

            _item.Should().BeNull();
        }
    }
}