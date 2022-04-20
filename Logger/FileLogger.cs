using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace lab_3.Logger
{
    public class FileLogger : WriterLogger
    {

        private bool disposed;
        protected FileStream stream;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this.disposed = true;
            }
        }

        public override void Dispose()
        {
            this.Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public FileLogger(string path)
        {

            stream = new FileStream(path, FileMode.Append);
            writer = new StreamWriter(stream);

        }

        ~FileLogger()
        {

        }

    }
}
