/// <summary>
/// This queue is circular.  When people are added via AddPerson, then they are added to the 
/// back of the queue (per FIFO rules).  When GetNextPerson is called, the next person
/// in the queue is saved to be returned and then they are placed back into the back of the queue.  
/// Each person stays in the queue and is given turns.  
/// If turns is 0 or less, the person has infinite turns and never leaves the queue.  
/// If turns is positive, they will be removed once they run out of turns.  
/// </summary>
public class TakingTurnsQueue
{
    private readonly PersonQueue _people = new();

    public int Length => _people.Length;

    /// <summary>
    /// Add new people to the queue with a name and number of turns
    /// </summary>
    public void AddPerson(string name, int turns)
    {
        var person = new Person(name, turns);
        _people.Enqueue(person);
    }

    /// <summary>
    /// Get the next person in the queue.  
    /// - If the person has infinite turns (0 or less), put them back unchanged.  
    /// - If the person has more than 1 turn left, reduce turns and put them back.  
    /// - If the person has exactly 1 turn, use it and then remove them.  
    /// Throws an exception if the queue is empty.  
    /// </summary>
    public Person GetNextPerson()
    {
        if (_people.IsEmpty())
        {
            throw new InvalidOperationException("No one in the queue.");
        }

        // Take the next person out of the queue
        Person person = _people.Dequeue();

        // Handle infinite turn case
        if (person.Turns <= 0)
        {
            _people.Enqueue(person); // stays forever
        }
        // Handle finite turns > 1
        else if (person.Turns > 1)
        {
            person.Turns -= 1;       // use one turn
            _people.Enqueue(person); // still has turns left
        }
        // If turns == 1, they are done → don’t re-add

        return person;
    }

    public override string ToString()
    {
        return _people.ToString();
    }
}
