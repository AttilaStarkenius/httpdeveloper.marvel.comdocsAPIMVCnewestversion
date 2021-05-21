using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marvel.Api.Filters;
using Marvel.Api.Results;
using RestSharp;

namespace httpdeveloper.marvel.comdocsAPIMVCnewestversion.Controllers
{
         public partial class MarvelRestClient
        {
            private const string CharactersUrlSegment = "/public/characters";
   
           public virtual CharacterResult FindCharacters(CharacterRequestFilter filter = default(CharacterRequestFilter))
         {
              var request = new RestRequest(CharactersUrlSegment, Method.GET);                
              
              // Parse filter
               //
               ParseCharacterFilter(request, filter);
   
               return Execute<CharacterResult>(request);
         }
    
            public virtual CharacterResult FindCharacter(string characterId)
            {
                // Build request url
                //
                string requestUrl =
                    string.Format("{0}/{1}", CharactersUrlSegment, characterId);
    
                var request = new RestRequest(requestUrl, Method.GET);            
   
               return Execute<CharacterResult>(request);
          }

           public virtual ComicResult FindCharacterComics(string characterId, ComicRequestFilter filter = default(ComicRequestFilter))
           {
                // Build request url
   60             //
   61             string requestUrl =
   62                 string.Format("{0}/{1}/comics", CharactersUrlSegment, characterId);
    63
   64             var request = new RestRequest(requestUrl, Method.GET);
    65
   66             // Parse filter
   67             //
   68             ParseComicFilter(request, filter);
    69
   70             return Execute<ComicResult>(request);
    71         }
72
   83         public virtual EventResult FindCharacterEvents(string characterId, EventRequestFilter filter = default(EventRequestFilter))
   84         {
    85             // Build request url
   86             //
   87             string requestUrl =
   88                 string.Format("{0}/{1}/events", CharactersUrlSegment, characterId);
    89
   90             var request = new RestRequest(requestUrl, Method.GET);
    91
   92             // Parse filter
   93             //
   94             ParseEventFilter(request, filter);
    95
   96             return Execute<EventResult>(request);
    97         }
98
  109         public virtual SeriesResult FindCharacterSeries(string characterId, SeriesRequestFilter filter = default(SeriesRequestFilter))
  110         {
    111             // Build request url
  112             //
  113             string requestUrl =
  114                 string.Format("{0}/{1}/series", CharactersUrlSegment, characterId);
    115
  116             var request = new RestRequest(requestUrl, Method.GET);
    117
  118             // Parse filter
  119             //
  120             ParseSeriesFilter(request, filter);
    121
  122             return Execute<SeriesResult>(request);
    123         }
124
  134         public virtual StoryResult FindCharacterStories(string characterId, StoryRequestFilter filter = default(StoryRequestFilter))
  135         {
    136             // Build request url
  137             //
  138             string requestUrl =
  139                 string.Format("{0}/{1}/stories", CharactersUrlSegment, characterId);
    140
               var request = new RestRequest(requestUrl, Method.GET);
    
              // Parse filter
              //
              ParseStoryFilter(request, filter);
                return Execute<StoryResult>(request);
             }
     }
   }


    }
}
