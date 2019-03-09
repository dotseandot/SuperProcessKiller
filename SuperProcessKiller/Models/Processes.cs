namespace SuperProcessKiller
{
    class Processes
    {
        public string ProcessName { get; set; }
        public int ProcessTotal { get; set; }
        public long MemoryTotal { get; set; }

        public Processes()
        {
            MemoryTotal = 0;
        }
    }
}
