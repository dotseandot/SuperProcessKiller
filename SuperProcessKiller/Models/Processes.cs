namespace SuperProcessKiller
{
    class ProcessDetail
    {
        public string ProcessName { get; set; }
        public int ProcessTotal { get; set; }
        public long MemoryTotal { get; set; }

        /// <summary>
        /// set the starting memory as 0 for each process
        /// </summary>
        public ProcessDetail()
        {
            MemoryTotal = 0;
        }
    }
}
