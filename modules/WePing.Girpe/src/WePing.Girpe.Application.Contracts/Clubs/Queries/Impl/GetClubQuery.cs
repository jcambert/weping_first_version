﻿using System;

namespace WePing.Girpe.Clubs.Queries;


public class GetClubQuery : IGetClubQuery
{
    public string Numero { get; set; }
    public Guid Id { get; set; }
}
