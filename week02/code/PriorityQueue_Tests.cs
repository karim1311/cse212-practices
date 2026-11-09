using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {


        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("bob", 2);
        priorityQueue.Enqueue("tim", 5);
        priorityQueue.Enqueue("sue", 3);
        priorityQueue.Enqueue("george", 2);

        string[] expectedResult = ["tim", "sue", "bob", "george"];        

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
        }
        
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
       var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue()
        );

        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    // Add more test cases as needed below.
}