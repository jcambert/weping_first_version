﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using WePing.SmartPing.Domain.Joueurs.Queries;

namespace WePing.SmartPing.Spid.Domain.Joueurs.Queries;

[Dependency(ServiceLifetime.Transient), ExposeServices(typeof(IBrowseJoueurSpidQuery))]
public class BrowseJoueurSpidQuery : IBrowseJoueurSpidQuery
{
    public string Club { get;set; }
    public string Licence { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Valid { get; set; } = "0";
}
