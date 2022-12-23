﻿using WePing.Girpe.Joueurs.Dto;

namespace WePing.Girpe.Joueurs.Queries;

public interface IUpdateJoueurQuery:IGirpeQuery<UpdateJoueurResponse>
{
    string Licence { get; set; }
    Guid Id { get; set; }

    UpdateJoueurFromSpidOption DetailOptions { get; set; } 
}

public sealed record UpdateJoueurResponse(JoueurDto Joueur) : GirpeResponse;