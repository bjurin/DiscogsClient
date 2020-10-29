namespace DiscogsClient.Data.Result
{
    public sealed class DiscogsCollectionFolders : DiscogsPaginableResults<DiscogsCollectionFolder>
    {
        public DiscogsCollectionFolder[] folders { get; set; }

        public override DiscogsCollectionFolder[] GetResults()
        {
            return folders;
        }
    }
}