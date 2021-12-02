using System.Collections.Generic;
using System.Linq;
using System;
using NUnit.Framework;
using _234Schedule_a_Brew.Models;
using Microsoft.EntityFrameworkCore;

namespace bitsTests
{
    [TestFixture]
    public class Tests
    {
        BitsContext dbContext;
        Batch b;
        Recipe r;
        Style s;

        [SetUp]
        public void Setup()
        {
            dbContext = new BitsContext();
        }

        [Test]
        public void GetBrewTest()
        {
            b = dbContext.Batches.Find(1);
            Assert.IsNotNull(b);
            Assert.AreEqual(100, b.Volume);
            Console.WriteLine(b);
        }

        [Test]
        public void AddBrewTest()
        {
            b = new Batch();
            DateTime dt = new DateTime();
            DateTime d = new DateTime(2021, 12, 2);
            b.BatchId = 1;
            b.Volume = 100;
            b.EquipmentId = 1;
            b.RecipeId = 1;
            b.ScheduledStartDate = dt;
            b.EstimatedFinishDate = d;
            b.Abv = 1.01;
            b.Ibu = 59;
            dbContext.Batches.Add(b);
            dbContext.SaveChanges();
            Assert.IsNotNull(dbContext.Batches.Find(1));
        }
    }
}