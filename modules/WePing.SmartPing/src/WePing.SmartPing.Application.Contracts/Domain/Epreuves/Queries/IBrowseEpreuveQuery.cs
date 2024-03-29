﻿using WePing.SmartPing.Domain.Epreuves.Domain;
using WePing.SmartPing.Spid;

namespace WePing.SmartPing.Domain.Epreuves.Queries;

public interface IBrowseEpreuveQuery : ISpidRequestQuery<BrowseEpreuveResponse>
{
    public string Organisme { get; set; }
    public string Type { get; set; }
}
public sealed record BrowseEpreuveResponse(List<Epreuve> Epreuves): Response;