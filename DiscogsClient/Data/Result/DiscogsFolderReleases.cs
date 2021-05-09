namespace DiscogsClient.Data.Result 
{
    public sealed class DiscogsFolderReleases : DiscogsPaginableResults<DiscogsFolderRelease> 
    {
        public DiscogsFolderRelease[] releases { get; set; }

        public override DiscogsFolderRelease[] GetResults() 
        {
            return releases;
        }
    }
}