﻿using WePing.Girpe.Joueurs.Dto;

namespace WePing.Girpe.Joueurs.Queries;

public interface IGetJoueurQuery : IGirpeQuery<GetJoueurResponse>
{
    string Licence { get; set; }

    bool RetrieveClub { get; set; }
}

public sealed record GetJoueurResponse(JoueurDto Joueur): GirpeResponse;
