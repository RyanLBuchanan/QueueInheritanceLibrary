using LinkedListLibrary;

namespace QueueInheritanceLibrary
{
    public class QueueInheritance : List
    {
        // Pass the name "queue" to the list constructor
        public QueueInheritance() : base("queue") { }

        // Place datsValue at the end of queue by inserting 
        // at end of linked list
        public void Enqueue(object dataValue)
        {
            InsertAtBack(dataValue);
        }

        // Remove item from front of queue by removing
        // item at front of linked list
        public object Dequeue()
        {
            return RemoveFromFront();
        }
    }
}