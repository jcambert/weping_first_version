﻿
using Mediator;
using System.Collections.Generic;
using System.Threading.Tasks;
using WePing.Girpe.Clubs;
using WePing.Girpe.Clubs.Dto;
using WePing.Girpe.Clubs.Queries;

namespace WePing.Girpe.Services;

public class ClubAppService :
        GirpeAppService,
        IClubAppService
{

    public ClubAppService(IMediator mediator) : base(mediator) { }

    /* public ClubAppService(IRepository<Club, Guid> repository,ISpidAppService spid) 
     {
         this.Repository=repository;
         this.Spid=spid;
     }



     public async Task<ClubDto> GetAsync(Guid id)
     {
         //Get the IQueryable<Club> from the repository
         var queryable = await Repository.GetQueryableAsync();


         //Prepare a query to join books and authors
         var query = from club in queryable select new { club};

         //Execute the query and get the book with author
         var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);


         if (queryResult == null)
         {
             throw new EntityNotFoundException(typeof(Club), id);
         }

         var clubDto = ObjectMapper.Map<Club, ClubDto>(queryResult.club);

         return clubDto;
     }*/
    /*

    public override async Task<PagedResultDto<ClubDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {

        //Get the IQueryable<Book> from the repository
        var queryable = await Repository.GetQueryableAsync();

        //Prepare a query to join books and authors
        var query = from club in queryable select new { club };

        //Paging
        query = query
            .OrderBy(NormalizeSorting(input.Sorting))
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount);

        //Execute the query and get a list
        var queryResult = await AsyncExecuter.ToListAsync(query);

        //Convert the query result to a list of ClubDto objects
        var clubDtos = queryResult.Select(x =>
        {
            var clubDto = ObjectMapper.Map<Club, ClubDto>(x.club);
           
            return clubDto;
        }).ToList();


        //Get the total count with another query
        var totalCount = await Repository.GetCountAsync();

        return new PagedResultDto<ClubDto>(
                totalCount,
                clubDtos
            );
    }

    private static string NormalizeSorting(string sorting) => string.Empty;*/

    /*
     public async Task<List<ClubDto>> GetAllAsync()=>
         ObjectMapper.Map<List<Club>, List<ClubDto>>(await Repository.GetListAsync());

     public async Task<ClubDto> GetByNumero(string numero)
     {
         Check.NotNullOrEmpty(numero, nameof(numero));

         //Get the IQueryable<Club> from the repository
         var queryable = await Repository.GetQueryableAsync();


         //Prepare a query to join books and authors
         var query = from club in queryable where club.Numero==numero select new { club };

         //Execute the query and get the book with author
         var queryResult = await AsyncExecuter.FirstOrDefaultAsync(query);

         ClubDto clubDto;
         if (queryResult == null)
         {
             clubDto = await GetClubFromSpid(numero);
             if(clubDto == null)
                 throw new EntityNotFoundException(typeof(Club), numero);
             clubDto = await GetClubDetailFromSpid(clubDto);

             var result=await Repository.InsertAsync(ObjectMapper.Map<ClubDto, Club>(clubDto));
             clubDto = ObjectMapper.Map<Club, ClubDto>(result);
         }
         else
             clubDto = ObjectMapper.Map<Club, ClubDto>(queryResult.club);

         return clubDto;
     }

     protected async  Task<ClubDto> GetClubFromSpid(string numero)
     {
         var query = LazyServiceProvider.LazyGetRequiredService<IGetClubQuery>();
         query.Numero= numero;
         var club= await Spid.GetClub(query);

         var clubDto = ObjectMapper.Map < SmartPing.Domain.Clubs.Dto.ClubDto, ClubDto>(club);
         return clubDto;
     }

     protected async Task<ClubDto> GetClubDetailFromSpid(ClubDto dto)
     {
         var query=LazyServiceProvider.LazyGetRequiredService<IGetClubDetailQuery >();
         query.Club=dto.Numero;
         var club=await Spid.GetClubDetail(query);

         var clubDto = ObjectMapper.Map<SmartPing.Domain.ClubDetails.Dto.ClubDetailDto, ClubDto>(club,dto);

         return clubDto;
     }
    */
    public async Task<ClubDto> GetAsync(IGetClubQuery query)
    => (await Mediator.Send(query)).Club;

    public Task<List<ClubDto>> GetAllAsync()
    {
        throw new System.NotImplementedException();
    }
}