using System;

namespace GarbageCollection.IDisposableDemo
{
    class FileResource : IDisposable
    {
        private bool isDisposed = false;

        public FileResource()
        {
            Console.WriteLine("File opened");
        }

        public void UseFile()
        {
            if (isDisposed)
                throw new ObjectDisposedException("FileResource");

            Console.WriteLine("Writing to file");
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                Console.WriteLine("File closed using Dispose()");
                isDisposed = true;
            }
        }
    }
}