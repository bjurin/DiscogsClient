using DiscogsClient.Data.Query;
using DiscogsClient.Data.Result;
using System.Threading;
using System.Threading.Tasks;

namespace DiscogsClient
{
    public interface IDiscogsCollectionClient// : IDiscogsReleaseRatingClient
    {
        Task<DiscogsCollectionFolders> GetCollectionFoldersAsync(string username,
            DiscogsPaginable paginable = null);

        Task<DiscogsCollectionFolders> GetCollectionFoldersAsync(string username,
         DiscogsPaginable paginable, CancellationToken token);

        Task<DiscogsFolderReleases> GetCollectionReleasesByFolderAsync(string username, int folderID, DiscogsPaginable paginable = null);

        Task<DiscogsFolderReleases> GetCollectionReleasesByFolderAsync(string username, int folderID, DiscogsPaginable paginable, CancellationToken token);
    }
}