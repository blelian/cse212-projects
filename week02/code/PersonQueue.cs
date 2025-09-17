/// <summary>
/// A basic implementation of a Queue.  
/// I updated it so that Enqueue adds to the *end* of the list,  
/// since a queue should be FIFO (first in, first out).  
/// Before, it was inserting at index 0 which reversed the order.  
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _queue = new();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the back of the queue (FIFO).
    /// </summary>
    public void Enqueue(Person person)
    {
        _queue.Add(person); // add at end
    }

    /// <summary>
    /// Remove and return the person at the front of the queue.
    /// </summary>
    public Person Dequeue()
    {
        var person = _queue[0];   // front of the queue
        _queue.RemoveAt(0);
        return person;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}
