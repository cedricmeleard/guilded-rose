using Xunit;
using System.Collections.Generic;
using GildedRose;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        IList<Item> items = new List<Item> { new() { Name = "foo", SellIn = 0, Quality = 0 } };
        GildedRose.GildedRose app = new(items);
        app.UpdateQuality();
        Assert.Equal("fixme", items[0].Name);
    }
}