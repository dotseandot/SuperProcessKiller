namespace SuperProcessKiller
{
    class Config
    {
       public string SortColumn { get; set; }
       public string SortOrder { get; set; }

        public Config()
        {
            SortColumn = "MemoryTotal";
            SortOrder = "desc";
        }
    }
}
