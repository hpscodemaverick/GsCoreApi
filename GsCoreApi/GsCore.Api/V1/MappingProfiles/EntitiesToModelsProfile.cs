﻿using AutoMapper;
using GsCore.Api.V1.Contracts.Requests;
using GsCore.Api.V1.Contracts.Requests.Patch;
using GsCore.Api.V1.Contracts.Requests.Post;
using GsCore.Api.V1.Contracts.Requests.Put;
using GsCore.Api.V1.Contracts.Responses;
using GsCore.Database.Entities;

namespace GsCore.Api.V1.MappingProfiles
{
    public class EntitiesToModelsProfile: Profile
    {
        public EntitiesToModelsProfile()
        {


            CreateMap<Genre, GenreGetResponse>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.GenreName));

            CreateMap<GenreGetResponse,Genre>()
                .ForMember(dest => dest.GenreName, source => source.MapFrom(src => src.Name));

            CreateMap<GenrePostRequest,Genre>()
                .ForMember(dest => dest.GenreName, source => source.MapFrom(src => src.Name));

            CreateMap<GenrePutRequest,Genre>()
                .ForMember(dest => dest.GenreName, source => source.MapFrom(src => src.Name));

            
            CreateMap<GenrePatchRequest, Genre>()
                .ForMember(dest => dest.GenreName, source => source.MapFrom(src => src.Name));
            CreateMap<Genre, GenrePatchRequest>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.GenreName));



            CreateMap<Artist, ArtistGetResponse>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.ArtistName))
                .ForMember(dest => dest.BasicInfo, source => source.MapFrom(src => src.ArtistBasicInfo));

            CreateMap<ArtistGetResponse, Artist>()
                .ForMember(dest => dest.ArtistName, source => source.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArtistBasicInfo, source => source.MapFrom(src => src.BasicInfo)); ;

            CreateMap<ArtistBasicInfo, ArtistBasicInfoGetResponse>();
            CreateMap<ArtistBasicInfoGetResponse,ArtistBasicInfo>();

            CreateMap<ArtistBasicInfo, ArtistBasicInfoCreateRequest>();
            CreateMap<ArtistBasicInfoCreateRequest,ArtistBasicInfo>();

            CreateMap<Artist, ArtistPostRequest>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.ArtistName))
                .ForMember(dest => dest.BasicInfo, source => source.MapFrom(src => src.ArtistBasicInfo));

            CreateMap<ArtistPostRequest,Artist>()
                .ForMember(dest => dest.ArtistName, source => source.MapFrom(src => src.Name))
                .ForMember(dest => dest.ArtistBasicInfo, source => source.MapFrom(src => src.BasicInfo));

            CreateMap<Album, AlbumGetResponse>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.AlbumName));

            CreateMap<AlbumGetResponse,Album>()
                .ForMember(dest => dest.AlbumName, source => source.MapFrom(src => src.Name));

            CreateMap<Album, AlbumCreateRequest>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.AlbumName));

            CreateMap<AlbumCreateRequest, Album>()
                .ForMember(dest => dest.AlbumName, source => source.MapFrom(src => src.Name));

            CreateMap<Track, TrackGetResponse>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.TrackName));

            CreateMap<TrackGetResponse,Track>()
                .ForMember(dest => dest.TrackName, source => source.MapFrom(src => src.Name));


            CreateMap<Track, TrackCreateRequest>()
                .ForMember(dest => dest.Name, source => source.MapFrom(src => src.TrackName));

            CreateMap<TrackCreateRequest,Track>()
                .ForMember(dest => dest.TrackName, source => source.MapFrom(src => src.Name));





        }

    }
}
