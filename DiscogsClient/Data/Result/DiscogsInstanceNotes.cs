namespace DiscogsClient.Data.Result
{
    public sealed class DiscogsInstanceNotes: DiscogsPaginableResults<DiscogsInstanceNote>
    {
        public DiscogsInstanceNote[] notes { get; set; }

        public override DiscogsInstanceNote[] GetResults()
        {
            return notes;
        }
    }
}