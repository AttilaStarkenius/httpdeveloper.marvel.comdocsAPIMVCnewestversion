using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marvel.Api.Filters;
using Marvel.Api.Results;
using RestSharp;
using Marvel.Api;
using RestSharp;
using httpdeveloper.marvel.comdocsAPIMVCnewestversion.Controllers;

namespace httpdeveloper.marvel.comdocsAPIMVCnewestversion.Controllers
{
         public partial class MarvelRestClient
        {

        //http://marvel.mrroa.com/static/docs/class_marvel_1_1_api_1_1_marvel_rest_client.html#a1c5135d0affb1412e719386cd590be55
        //    http://marvel.mrroa.com/static/docs/_characters_8cs_source.html#l00035

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
                //
                string requestUrl =
                    string.Format("{0}/{1}/comics", CharactersUrlSegment, characterId);
   
               var request = new RestRequest(requestUrl, Method.GET);
    
                // Parse filter
                //
                ParseComicFilter(request, filter);
    
               return Execute<ComicResult>(request);
             }

            public virtual EventResult FindCharacterEvents(string characterId, EventRequestFilter filter = default(EventRequestFilter))
            {
                // Build request url
              //
              string requestUrl =
                    string.Format("{0}/{1}/events", CharactersUrlSegment, characterId);
    
                var request = new RestRequest(requestUrl, Method.GET);
    
                // Parse filter
               //
               ParseEventFilter(request, filter);
    
               return Execute<EventResult>(request);
             }

           public virtual SeriesResult FindCharacterSeries(string characterId, SeriesRequestFilter filter = default(SeriesRequestFilter))
          {
                 // Build request url
               //
               string requestUrl =
                  string.Format("{0}/{1}/series", CharactersUrlSegment, characterId);
    
               var request = new RestRequest(requestUrl, Method.GET);
    
               // Parse filter
               //
               ParseSeriesFilter(request, filter);
    
              return Execute<SeriesResult>(request);
             }

           public virtual StoryResult FindCharacterStories(string characterId, StoryRequestFilter filter = default(StoryRequestFilter))
           {
                 // Build request url
               //
               string requestUrl =
                   string.Format("{0}/{1}/stories", CharactersUrlSegment, characterId);
    
               var request = new RestRequest(requestUrl, Method.GET);
    
              // Parse filter
              //
              ParseStoryFilter(request, filter);
                return Execute<StoryResult>(request);
             }
     }
   }



