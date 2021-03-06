﻿using System;
using System.Linq;
using Humanizer;
using Joyride.Extensions;
using Joyride.Interfaces;
using Joyride.Platforms;
using Joyride.Specflow.Support;
using Joyride.Support;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Joyride.Specflow.Steps
{
    [Binding]
    public class CollectionSteps : TechTalk.SpecFlow.Steps
    {
        #region Given/Whens

        [Given(@"I swipe (left|right|up|down) the ""(\d+)(?:(?:st|nd|rd|th)?)"" item in the ""([^""]*)"" collection")]
        [When(@"I swipe (left|right|up|down) the ""(\d+)(?:(?:st|nd|rd|th)?)"" item in the ""([^""]*)"" collection")]
        public void GivenISwipeTheItemInTheCollection(string direction, int ordinal, string collectionName)
        {
            var dir = (Direction) Enum.Parse(typeof (Direction), direction, true);
            Context.MobileApp.Do<Screen>(s => s.SwipeInCollection(collectionName, dir, ordinal));
        }
        
        [Given(@"I tap the ""(first|most recent|last)"" item in the ""([^""]*)"" collection")]
        [When(@"I tap the ""(first|most recent|last)"" item in the ""([^""]*)"" collection")]
        public void GivenITapTheItemInTheCollection(string ordinal, string collectionName)
        {
            switch (ordinal)
            {
                case "last":
                case "most recent":
                    Context.MobileApp.Do<Screen>(s => s.TapInCollection(collectionName, last: true));
                    break;

                case "first":
                    Context.MobileApp.Do<Screen>(s => s.TapInCollection(collectionName, 1));
                    break;
            }
        }

        [Given(@"I tap the ""(\d+)(?:(?:st|nd|rd|th)?)"" item in the ""([^""]*)"" collection")]
        [When(@"I tap the ""(\d+)(?:(?:st|nd|rd|th)?)"" item in the ""([^""]*)"" collection")]
        public void GivenITapTheItemByIndexInCollection(int ordinal, string collectionName)
        {
            if (ordinal < 1)
                throw new IndexOutOfRangeException("Expecting ordinal to be greater than 0. Received: " + ordinal);

            Context.MobileApp.Do<Screen>(s => s.TapInCollection(collectionName, ordinal));
            
        }

        [Given(@"I tap up to ""(\d+)"" (?:item|items) in the ""([^""]*)"" collection")]
        [When(@"I tap up to ""(\d+)"" (?:item|items) in the ""([^""]*)"" collection")]
        public void GivenITapUpToXItemsInTheCollection(int times, string collectionName)
        {
            if (times < 1)
                throw new IndexOutOfRangeException("Expecting max count to be greater than 1. Received: " + times);

            for (int i = 1; i <= times; i++)
            {
                //copy to local var due to access modifier warning
                int j = i;
                Context.MobileApp.Do<Screen>(s => s.TapInCollection(collectionName, j));
            }
        }

        [Given(@"I inspect the number of items in collection ""([^""]*)""")]
        [When(@"I inspect the number of items in collection ""([^""]*)""")]
        public void GivenIInspectNumberOfItemsInCollection(string collectionName)
        {
            var count = 0;
            Context.MobileApp.Do<Screen>(s => count = s.SizeOf(collectionName));
            var collectionKey = collectionName;
            Context.SetValue(collectionKey, count);
        }


        #endregion

        #region #Thens

        [Then(@"I (should|should not) see an item in collection ""([^""]*)"" with text (equals|starts with|containing|matching) (?:""(.*?)""|{(.*?)})")]
        public void ThenIShouldSeeItemInCollectionWithText(string shouldOrShouldNot, string collectionName, string compareType, string quotedText, string curlyText)
        {
            var text = (quotedText != String.Empty) ? quotedText : curlyText;
            var hasText = false;
            Context.MobileApp.Do<Screen>(s => hasText = s.HasTextInCollection(collectionName, text, compareType.ToCompareType()));

            if (shouldOrShouldNot == "should")
              Assert.IsTrue(hasText);
            else
              Assert.IsFalse(hasText);
        }

        [Then(@"I (should|should not) see ""(\d+)"" (?:item|items) in ""([^""]*)"" collection")]
        public void ThenIShouldSeeNumberOfItemsInCollection(string shouldOrShouldNot, int size, string collectionName)
        {
            var actualSize = 0;
            Context.MobileApp.Do<Screen>(s => actualSize = s.SizeOf(collectionName));

            if (shouldOrShouldNot == "should")
              Assert.That(actualSize == size, Is.True,
                 "Unexpected number of items in '" + collectionName + "' with  " + actualSize + ".  Expecting: " + size);
            else
                Assert.That(actualSize == size, Is.False,
                   "Unexpected number of items in '" + collectionName + "' with actual number of " + actualSize + " = " + size);
        }

        [Then(@"I should see the collection ""([^""]*)"" is (not empty|empty)")]
        public void ThenIShouldSeeEmptyCollection(string collectionName, string emptyOrNotEmpty)
        {
            var actualSize = 0;
            Context.MobileApp.Do<Screen>(s => actualSize = s.SizeOf(collectionName));

            if (emptyOrNotEmpty == "empty")
                Assert.That(actualSize == 0, Is.True,
                  "Unexpected number of items in '" + collectionName + "' with  " + actualSize + ".  Expecting: " + 0);
            else
                Assert.That(actualSize != 0, Is.True,
                  "Expecting number of items in '" + collectionName + "' to be not 0");
        }

        [Then(@"I should see the number of items in the collection ""([^""]*)"" to be (less than|greater than) ""(\d+)""")]
        public void ThenIShouldSeCollectionGreaterLessThan(string collectionName, string lessThanOrGreaterThan, int size)
        {
            var actualSize = 0;
            Context.MobileApp.Do<Screen>(s => actualSize = s.SizeOf(collectionName));

            if (lessThanOrGreaterThan == "less than")
                Assert.That(actualSize < size, Is.True,
                  "The number of items (" + actualSize + ") in '" + collectionName + "' is not less than " + size);
            else
                Assert.That(actualSize > size, Is.True,
                  "The number of items (" + actualSize + ") in '" + collectionName + "' is not greater than " + size);
        }

        [Then(@"I should see ""(\d+)"" (less|more) (?:item|items) in ""([^""]*)"" collection")]
        public void ThenIShouldSeeMoreLessItems(int difference, string lessOrMore, string collectionName)
        {
            var actualSize = 0;
            Context.MobileApp.Do<Screen>(s => actualSize = s.SizeOf(collectionName));

            var originalSize = (int) Context.GetValue(collectionName);
            int expectedSize;

            if (lessOrMore == "less")
                expectedSize = originalSize - difference;
            else
                expectedSize = originalSize + difference;

            Assert.IsTrue(expectedSize == actualSize,
                "Unexpected number of items in '" + collectionName + "' with  " + actualSize + ".  Expecting: " + expectedSize);
        }

        [Then(@"there (should|should not) exists ""([^""]*)"" within the collection ""([^""]*)""")]
        public void ThenIShouldSeeProperty(string shouldOrShouldNot, string property, string collectionName)
        {
            var hasProperty = false;
            var actualProperty = property.Dehumanize();
            Context.MobileApp.Do<IEntryEnumerable>(i =>
            {
                var entries = i.GetEntries(collectionName);
                foreach (var e in entries.Where(e => Util.HasMember(e, actualProperty)))
                {
                    object value = Util.GetDynamicMemberValue(e, actualProperty);
                    hasProperty = true;
                    break;
                }
            });
            if (shouldOrShouldNot == "should")
                Assert.IsTrue(hasProperty);
            else
                Assert.IsFalse(hasProperty);
        }

        [Then(@"I should see all the following properties within the collection ""([^""]*)""")]
        public void ThenIShouldSeeTheFollowingPropertiesWithinCollection(string collectionName, Table table)
        {
            var conditionsMeet = true;
            Context.MobileApp.Do<IEntryEnumerable>(i =>
            {                
                var conditions = table.CreateSet<PropertyCondition>();
                if (conditions == null)
                    throw new ArgumentException("Unable to retrieve entry property table.");

                var entries = i.GetEntries(collectionName);
                foreach (var e in entries)
                {
                    if (!conditionsMeet)
                        break;

                    foreach (var c in conditions)
                    {
                        var property = c.PropertyName.Dehumanize();
                        var foundProperty = Util.HasMember(e, property);
                        if (foundProperty)
                        {
                            object value = Util.GetDynamicMemberValue(e, property);
                            continue;
                        }

                        if (c.Mandatory)
                            conditionsMeet = false;
                    }
                }                
                Assert.IsTrue(conditionsMeet);
            });
        }

        [Then(@"I should see all the following properties within the collection ""([^""]*)"" meeting the conditions")]
        public void ThenIShouldSeeTheFollowingPropertiesInCollectionMeetingCondition(string collectionName, Table table)
        {
            var conditionsMeet = true;
            var errorMsg = "";
            Context.MobileApp.Do<IEntryEnumerable>(i =>
            {
                var conditions = table.CreateSet<PropertyCondition>();
                if (conditions == null)
                    throw new ArgumentException("Unable to retrieve entry property table.");

                var entries = i.GetEntries(collectionName);
                foreach (var e in entries)
                {
                    if (!conditionsMeet)
                        break;

                    foreach (var c in conditions)
                    {
                        var property = c.PropertyName.Dehumanize();
                        var foundProperty = Util.HasMember(e, property);

                        if (c.Mandatory && !foundProperty)
                        {
                            errorMsg = "Property (" + c.PropertyName + ") should mandatory but is not found.";
                            conditionsMeet = false;
                        }

                        if (foundProperty)
                        {
                            object value = Util.GetDynamicMemberValue(e, property);
                            if (string.IsNullOrEmpty(c.Condition))
                                continue;

                            if (!EntryEvaluator.MeetsCondition(c, e))
                            {
                                errorMsg = "Property failed to meet condition: " + c.PropertyName;
                                conditionsMeet = false;
                            }
                        }
                    }
                }
                Assert.IsTrue(conditionsMeet, errorMsg);
            });
        }

        #endregion

    }
}
