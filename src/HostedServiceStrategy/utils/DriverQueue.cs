using System;
using System.Collections.Generic;
using HostedServiceStrategy.Strategies;

namespace HostedServiceStrategy.Utils
{
    public class DriverQueue
    {
        private static Queue<Type> _queue = new Queue<Type>();

        static DriverQueue()
        {
            _queue.Enqueue(typeof(NotificationA));
            _queue.Enqueue(typeof(NotificationC));
            _queue.Enqueue(typeof(NotificationB));
            _queue.Enqueue(typeof(NotificationC));
            _queue.Enqueue(typeof(NotificationA));
            _queue.Enqueue(typeof(NotificationC));
            _queue.Enqueue(typeof(NotificationA));
            _queue.Enqueue(typeof(NotificationC));
            _queue.Enqueue(typeof(NotificationD));
            _queue.Enqueue(typeof(NotificationB));
            _queue.Enqueue(typeof(NotificationA));
            _queue.Enqueue(typeof(NotificationD));
        }

        public static Type TryDequeue()
        {
            Type type;
            if (_queue.TryDequeue(out type) == false)
            {
                throw new InvalidOperationException();
            }
            return type;
        }
    }
}
