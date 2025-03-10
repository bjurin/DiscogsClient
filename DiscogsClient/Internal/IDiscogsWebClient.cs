﻿using RestSharp;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DiscogsClient.Internal
{
    internal interface IDiscogsWebClient
    {
        IRestRequest GetSearchRequest();

        IRestRequest GetReleaseRequest(int relaseId);

        IRestRequest GetMasterRequest(int masterId);

        IRestRequest GetMasterReleaseVersionRequest(int masterId);

        IRestRequest GetArtistRequest(int artistId);

        IRestRequest GetLabelRequest(int artistId);

        IRestRequest GetArtistReleaseVersionRequest(int artistId);

        IRestRequest GetAllLabelReleasesRequest(int labelId);

        IRestRequest GetGetUserReleaseRatingRequest(string userName, int releaseId);

        IRestRequest GetPutUserReleaseRatingRequest(string username, int releaseId);

        IRestRequest GetDeleteUserReleaseRatingRequest(string userName, int releaseId);

        IRestRequest GetCommunityReleaseRatingRequest(int releaseId);

        IRestRequest GetUserIdentityRequest();

        IRestRequest GetCollectionFoldersRequest(string userName);

        IRestRequest GetCollectionReleasesByFolderRequest(string userName, int folderID);

        IRestRequest GetCollectionNotesByFolderAndReleaseRequest(string userName, int folderID, int releaseID, int instanceID);

        Task<T> Execute<T>(IRestRequest request, CancellationToken cancellationToken);

        Task<HttpStatusCode> Execute(IRestRequest request, CancellationToken cancellationToken);

        Task Download(string url, Stream copyStream, CancellationToken cancellationToken, int timeOut=15000);

        Task<string> SaveFile(string url, string path, string fileName, CancellationToken cancellationToken, int timeOut = 15000);
    }
}