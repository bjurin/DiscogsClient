namespace DiscogsClient.Data.Result 
{
    public class DiscogsFolderRelease : DiscogsEntity 
    {
        public int id { get; set; }     

        public int instance_id { get; set; }

        public DiscogsFolderReleaseBasicInformation basic_information { get; set; }     
    }
}
