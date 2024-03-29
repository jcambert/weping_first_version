﻿using AutoMapper;
using System.Security.Cryptography.X509Certificates;
using Volo.Abp.AutoMapper;
using WePing.Girpe.Clubs.Dto;
using WePing.Girpe.Clubs.Queries;
using WePing.Girpe.Domain;
using WePing.Girpe.Joueurs;
using WePing.Girpe.Joueurs.Dto;
using WePing.Girpe.Joueurs.Queries;
using WePing.Girpe.Joueurs.Queries.Impl;
using WePing.Girpe.Parties.Dto;
using WePing.SmartPing.Domain.Joueurs.Dto;
using SP_QUERY = WePing.SmartPing.Domain.Clubs.Queries;
namespace WePing.Girpe;

public class GirpeApplicationAutoMapperProfile : Profile
{
    public GirpeApplicationAutoMapperProfile()
    {

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Club, ClubDto>()
            .ForMember(x => x.LastModificationTime, opt => opt.Ignore())
            .ForMember(x => x.LastModifierId, opt => opt.Ignore())
            .ForMember(x => x.CreationTime, opt => opt.Ignore())
            .ForMember(x => x.CreatorId, opt => opt.Ignore())
            //.ForAllMembers(x=>x.Ignore())
            ;
        CreateMap<ClubDto, Club>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            //.ForMember(x => x.Joueurs, opt => opt.Ignore())
            //.ForAllMembers(x => x.Ignore())
            //.ForMember(x=>x.ConcurrencyStamp,opt=>opt.Ignore())
            // .ForMember(x => x.ExtraProperties, opt => opt.Ignore())
            ;

        CreateMap<SmartPing.Domain.Clubs.Dto.ClubDto, Club>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForMember(x => x.Identifiant, opt => opt.MapFrom(src => src.Id))
            .ForMember(x => x.NomSalle, opt => opt.Ignore())
            .ForMember(x => x.AdresseSalle1, opt => opt.Ignore())
            .ForMember(x => x.AdresseSalle2, opt => opt.Ignore())
            .ForMember(x => x.AdresseSalle3, opt => opt.Ignore())
            .ForMember(x => x.CodePostalSalle, opt => opt.Ignore())
            .ForMember(x => x.VilleSalle, opt => opt.Ignore())
            .ForMember(x => x.Web, opt => opt.Ignore())
            .ForMember(x => x.NomCorrespondant, opt => opt.Ignore())
            .ForMember(x => x.PrenomCorrespondant, opt => opt.Ignore())
            .ForMember(x => x.MailCorrespondant, opt => opt.Ignore())
            .ForMember(x => x.TelephoneCorrespondant, opt => opt.Ignore())
            .ForMember(x => x.Latitude, opt => opt.Ignore())
            .ForMember(x => x.Longitude, opt => opt.Ignore())
            //.ForMember(x => x.Joueurs, opt => opt.Ignore())
            //.IgnoreAuditedObjectProperties()
            ;

        CreateMap<SmartPing.Domain.ClubDetails.Dto.ClubDetailDto, Club>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            .ForMember(x => x.Numero, opt => opt.Ignore())
            .ForMember(x => x.Identifiant, opt => opt.Ignore())
            .ForMember(x => x.Nom, opt => opt.Ignore())
            .ForMember(x => x.Validation, opt => opt.Ignore())
            //.ForMember(x => x.Joueurs, opt => opt.Ignore())
            //.IgnoreAuditedObjectProperties()
            ;

        CreateMap<CreateUpdateClubDto, Club>()
            .ForMember(x => x.Id, opt => opt.Ignore())
            //.ForMember(x => x.Joueurs, opt => opt.Ignore())
            //.ForAllMembers(x=>x.Ignore())
            /*.IgnoreAuditedObjectProperties()*//*.IgnoreAllPropertiesWithAnInaccessibleSetter()*/;

        CreateMap<Joueur, JoueurDto>()
            //.ForMember(x => x.NumeroClub, opt => opt.MapFrom(x => x.Club.Numero ?? string.Empty))
            //.ForMember(x => x.NomClub, opt => opt.MapFrom(x => x.Club.Nom ?? string.Empty))
            //.Ignore(x=>x.NomClub)
            //.Ignore(x => x.NumeroClub)
            .Ignore(x=>x.PartiesSpid)
            ;

        CreateMap<JoueurDto, Joueur>()
            .Ignore(x=>x.ExtraProperties)
            .Ignore(x=>x.ConcurrencyStamp)
            .Ignore(x=>x.PartiesSpid)
            //.Ignore(x => x.Club)
            ;
        CreateMap<Joueur, GetClubQuery>()
            .ForMember(x => x.Numero, y => y.MapFrom(x => x.NumeroClub));

        CreateMap<JoueurClassementDto, Joueur>()
            .Ignore(x => x.Id)
            .Ignore(x => x.ClubId)
            .Ignore(x => x.LicenceId)
            .Ignore(x => x.Sexe)
            .Ignore(x => x.Type)
            .Ignore(x => x.CertificatMedical)
            .Ignore(x => x.DateDeValidationDuCertificatMedical)
            .Ignore(x => x.Echelon)
            .Ignore(x => x.Place)
            .Ignore(x => x.CategorieAge)
            .Ignore(x => x.PointClassement)
            .Ignore(x => x.PointsMensuel)
            .Ignore(x => x.AncienPointsMensuel)
            .Ignore(x => x.PointsInitials)
            .Ignore(x => x.Mutation)
            .Ignore(x => x.Nationnalite)
            .Ignore(x => x.Arbitre)
            .Ignore(x => x.JugeArbitre)
            .Ignore(x => x.Tech)
            .Ignore(x => x.ClassementGlobal)
            .Ignore(x => x.PointsMensuels)
            .Ignore(x => x.AncienClassementGlobal)
            .Ignore(x => x.AnciensPoints)
            .Ignore(x => x.Categorie)
            .Ignore(x => x.RangRegional)
            .Ignore(x => x.RangDepartmental)
            .Ignore(x => x.PointsOfficiels)
            .Ignore(x => x.PropositionClassement)
            .Ignore(x => x.PointsDebutSaison)
            .Ignore(x=>x.PartiesSpid)
            .Ignore(x => x.ExtraProperties)
            .Ignore(x => x.ConcurrencyStamp)
            .IgnoreAuditedObjectProperties()
            ;

        CreateMap<JoueurDetailSpidClaDto, Joueur>()
            .Ignore(x => x.Id)
            .Ignore(x => x.ClubId)
            .Ignore(x => x.Classement)
            .Ignore(x => x.ClassementGlobal)
            .Ignore(x => x.PointsMensuels)
            .Ignore(x => x.AncienClassementGlobal)
            .Ignore(x => x.AnciensPoints)
            .Ignore(x => x.Categorie)
            .Ignore(x => x.RangRegional)
            .Ignore(x => x.RangDepartmental)
            .Ignore(x => x.PointsOfficiels)
            .Ignore(x => x.PropositionClassement)
            .Ignore(x => x.PointsDebutSaison)
            .Ignore(x => x.PartiesSpid)
            .Ignore(x => x.ExtraProperties)
            .Ignore(x => x.ConcurrencyStamp)
            .IgnoreAuditedObjectProperties()
            ;
        CreateMap<JoueurDetailSpidDto, Joueur>()
            .Ignore(x => x.Id)
            .Ignore(x => x.ClubId)
            .Ignore(x => x.Classement)
            .Ignore(x => x.PointsMensuel)
            .Ignore(x => x.AncienPointsMensuel)
            .Ignore(x => x.PointsInitials)
            .Ignore(x => x.Mutation)
            .Ignore(x => x.Nationnalite)
            .Ignore(x => x.Arbitre)
            .Ignore(x => x.JugeArbitre)
            .Ignore(x => x.Tech)
            .Ignore(x => x.ClassementGlobal)
            .Ignore(x => x.PointsMensuels)
            .Ignore(x => x.AncienClassementGlobal)
            .Ignore(x => x.AnciensPoints)
            .Ignore(x => x.Categorie)
            .Ignore(x => x.RangRegional)
            .Ignore(x => x.RangDepartmental)
            .Ignore(x => x.PointsOfficiels)
            .Ignore(x => x.PropositionClassement)
            .Ignore(x => x.PointsDebutSaison)
            .Ignore(x => x.PartiesSpid)
            .Ignore(x => x.ExtraProperties)
            .Ignore(x => x.ConcurrencyStamp)
            .IgnoreAuditedObjectProperties()
            ;

        CreateMap<JoueurDetailClassementDto, Joueur>()
            .Ignore(x => x.ClubId)
            .Ignore(x => x.LicenceId)
            .Ignore(x => x.Sexe)
            .Ignore(x => x.Type)
            .Ignore(x => x.CertificatMedical)
            .Ignore(x => x.DateDeValidationDuCertificatMedical)
            .Ignore(x => x.Echelon)
            .Ignore(x => x.Place)
            .Ignore(x => x.CategorieAge)
            .Ignore(x => x.PointClassement)
            .Ignore(x => x.AncienPointsMensuel)
            .Ignore(x => x.PointsMensuel)
            .Ignore(x => x.PointsInitials)
            .Ignore(x => x.Mutation)
            .Ignore(x => x.Arbitre)
            .Ignore(x => x.JugeArbitre)
            .Ignore(x => x.Tech)
            .Ignore(x => x.Id)
            .Ignore(x => x.PartiesSpid)
            .Ignore(x => x.ExtraProperties)
            .Ignore(x => x.ConcurrencyStamp)
            .IgnoreAuditedObjectProperties()
            ;
        /*CreateMap<JoueurDetailSpidClaDto,JoueurDto>()
            .Only()
            .For(x => x.Licence, y => y.Licence)
            .For(x => x.Nom, y => y.Nom)
            .For(x => x.Prenom, y => y.Prenom)
            .For(x => x.NumeroClub, y => y.NumeroClub)
            .For(x => x.NomClub, y => y.NomClub)

            .For(x => x.Sexe, y => y.Sexe)
            .For(x => x.Type, y => y.Type)
            .For(x => x.CertificatMedical, y => y.CertificatMedical)
            .For(x => x.DateDeValidationDuCertificatMedical, y => y.DateDeValidationDuCertificatMedical)
            .For(x => x.Echelon, y => y.Echelon)
            .For(x => x.Place, y => y.Place)
            .For(x => x.CategorieAge, y => y.CategorieAge)
            .For(x => x.PointClassement, y => y.PointClassement)
            .For(x => x.AncienPointsMensuel, y => y.AncienPointsMensuel)
            .For(x => x.PointsMensuel, y => y.PointsMensuel)
            .For(x => x.PointsInitials, y => y.PointsInitials)
            .For(x => x.Mutation, y => y.Mutation)
            .For(x => x.Arbitre, y => y.Arbitre)
            .For(x => x.JugeArbitre, y => y.JugeArbitre)
            .For(x => x.Tech, y => y.Tech)
           // .For(x => x., y => y.)
           .EndOnlyFor();*/
        CreateMap<BrowseClubQuery, SP_QUERY.BrowseClubsQuery>();

       
        
        CreateMap<GetClubQuery, Club>()
            .Only()
            .For(x=>x.Numero,y=>y.Numero)
            .EndOnlyFor()
            ;
        CreateMap<GetJoueurQuery, Joueur>()
            .Only()
            .For(x=>x.Licence,y=>y.Licence)
            .EndOnlyFor()
            ;


        CreateMap<BrowseJoueurQuery, Joueur>()
            .Only()
            .For(x => x.ClubNumero, y => y.NumeroClub)
            .For(x=>x.ClubId, y => y.ClubId)
            .EndOnlyFor()
           
            ;

        CreateMap<UpdateClubForJoueurQuery, GetJoueurQuery>()
            .Ignore(x => x.ForceLoadClubIfNotSet)
            .Ignore(x=>x.DetailOptions)
            ;

        CreateMap<UpdateJoueurQuery, Joueur>()
            .Only()
            .For(x=>x.Licence,y=>y.Licence)
            .EndOnlyFor()
            ;

        /*CreateMap<JoueurPartiesSpidDto, PartieSpid>()
            .Ignore(x=>x.PointsAcquisPerdus)
            ;
        */

        //CreateMap< PartieSpid, JoueurPartiesSpidDto>();

        CreateMap<BrowseClubResponse, BrowseClubResponseDto>()
            .ForCtorParam("Clubs", opt => opt.MapFrom(x => x.Clubs));

        CreateMap<GetClubResponse, GetClubResponseDto>()
            .ForCtorParam("Club", opt => opt.MapFrom(x => x.Club));

        CreateMap<UpdateClubForJoueurResponse, UpdateClubForJoueurResponseDto>()
            .ForCtorParam("Club", opt => opt.MapFrom(x => x.Club))
            .ForCtorParam("Joueur", opt => opt.MapFrom(x => x.Joueur));

        CreateMap<GetJoueurResponse, GetJoueurResponseDto>()
            .ForCtorParam("Joueur", opt => opt.MapFrom(x => x.Joueur));

        CreateMap<BrowseJoueurResponse, BrowseJoueurResponseDto>()
            .ForCtorParam("Joueurs", opt => opt.MapFrom(x => x.Joueurs));
    }
}