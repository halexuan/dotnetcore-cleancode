namespace CleanCode.Functions.DontUseSingletonPattern.Model
{
    internal class DBConnection
    {
        private bool options;

        public DBConnection(bool options)
        {
            this.options = options;
        }
    }
}