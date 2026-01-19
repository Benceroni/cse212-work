using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: nothing in queue
    // Expected Result: error gets thrown
    // Defect(s) Found: Seems to be working...
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message));
        }

    }

    [TestMethod]
    // Scenario: four icecream flavors, each with a priority level.
    // Expected Result: [mintChip, cookiesCream, vanilla, chocolate];
    // Defect(s) Found: It doesn't iterate through all the items when comaring (i < list.count - 1) when it should be (i < list.count).
    //                  it also didn't remove the hightest priority item from the list when returning it. 
    public void TestPriorityQueue_2()
    {
        var vanilla = new Icecream("Vanilla", 2);
        var chocolate = new Icecream("Chocolate", 1);
        var mintChip = new Icecream("Mint Chip", 4);
        var cookiesCream = new Icecream("Cookies and Cream", 3);

        Icecream[] expectedResult = [mintChip, cookiesCream, vanilla, chocolate];

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue(cookiesCream.Flavor, cookiesCream.Priority);
        priorityQueue.Enqueue(mintChip.Flavor, mintChip.Priority);
        priorityQueue.Enqueue(chocolate.Flavor, chocolate.Priority);
        priorityQueue.Enqueue(vanilla.Flavor, vanilla.Priority);

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(i);
            var _result = priorityQueue.Dequeue();
            Console.WriteLine("result: "+ _result + " expected: " + expectedResult[i].Flavor);
            Assert.AreEqual(_result, expectedResult[i].Flavor);
        }


        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}