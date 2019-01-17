using Microsoft.AspNetCore.Mvc;
using RestfulCoreAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tapioca.HATEOAS;

namespace RestfulCoreAPI.Hypermedia
{
    public class PersonEnricher : ObjectContentResponseEnricher<PersonViewModel>
    {
        protected override Task EnrichModel(PersonViewModel content, IUrlHelper urlHelper)
        {
            var path = "api/v1/people";
            var url = new { controller = path, id = content.Id };

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.GET,
                Href = urlHelper.Link("DefaultApi", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });

            content.Links.Add(new HyperMediaLink()
            {
                Action = HttpActionVerb.POST,
                Href = urlHelper.Link("DefaultApi", url),
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });

            // Não implementados para PersonController
            //content.Links.Add(new HyperMediaLink()
            //{
            //    Action = HttpActionVerb.PUT,
            //    Href = urlHelper.Link("DefaultApi", url),
            //    Rel = RelationType.self,
            //    Type = ResponseTypeFormat.DefaultPost
            //});

            //content.Links.Add(new HyperMediaLink()
            //{
            //    Action = HttpActionVerb.DELETE,
            //    Href = urlHelper.Link("DefaultApi", url),
            //    Rel = RelationType.self,
            //    Type = "int"
            //});

            return null;
        }
    }
}
