using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue the highest priority
    // Expected Result: Highest priority item is returned first
    // Defect(s) Found: Original Dequeue logic ignored the last item in loop
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("Medium", 5);
        pq.Enqueue("High", 10);

        string result = pq.Dequeue();
        Assert.AreEqual("High", result); // Highest priority returned first
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same priority, should follow FIFO
    // Expected Result: Dequeue returns items in enqueue order for same priority
    // Defect(s) Found: Original code might not correctly handle same priority
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 3);
        pq.Enqueue("Second", 3);
        pq.Enqueue("Third", 3);

        string firstOut = pq.Dequeue();
        string secondOut = pq.Dequeue();
        string thirdOut = pq.Dequeue();

        Assert.AreEqual("First", firstOut);
        Assert.AreEqual("Second", secondOut);
        Assert.AreEqual("Third", thirdOut);
    }
}
