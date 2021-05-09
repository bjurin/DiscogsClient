namespace DiscogsClient.Data.Result 
{
    public class DiscogsFolderReleaseBasicInformation : DiscogsEntity 
    {
        public string title { get; set; }    
      
        public DiscogsFolderReleaseBasicInformationArtist[] artists { get; set; }    
    }
}
