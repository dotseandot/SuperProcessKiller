namespace SuperProcessKiller
{
    class Config
    {
       public string SortColumn { get; set; }
       public string SortOrder { get; set; }

        /// <summary>
        /// Set the default sorting method for the process list
        /// </summary>
        public Config()
        {
            SortColumn = "MemoryTotal";
            SortOrder = "desc";
        }
    }
}
