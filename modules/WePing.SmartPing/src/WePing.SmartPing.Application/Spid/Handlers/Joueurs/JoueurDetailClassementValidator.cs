﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;
using WePing.SmartPing.Domain.Joueurs.Queries;
using WePing.SmartPing.Spid.Domain.Joueurs.Queries;

namespace WePing.SmartPing.Spid.Handlers.Joueurs;

[Dependency(ServiceLifetime.Transient), ExposeServices(typeof(IPipelineBehavior<GetJoueurDetailClassementQuery, GetJoueurDetailClassementResponse>))]
public class JoueurDetailClassementValidator : IPipelineBehavior<GetJoueurDetailClassementQuery, GetJoueurDetailClassementResponse>
{
    public JoueurDetailClassementValidator()
    {
    }

    public Task<GetJoueurDetailClassementResponse> Handle(GetJoueurDetailClassementQuery request, RequestHandlerDelegate<GetJoueurDetailClassementResponse> next, CancellationToken cancellationToken)
    {
        if (request == null || string.IsNullOrEmpty(request.Licence) )
            throw new ArgumentException("You must specify Licence");
        return next();
        //return next(request, cancellationToken);
        //throw new NotImplementedException();
    }
}
