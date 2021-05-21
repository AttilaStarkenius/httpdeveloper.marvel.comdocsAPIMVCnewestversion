using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using httpdeveloper.marvel.comdocsAPIMVCnewestversion.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Marvel;
using Marvel.Api;
using Marvel.Api.Filters;
using Marvel.Api.Model.DomainObjects;
using Marvel.Api.Results;
using Marvel.Api.Model;
//using DocumentFormat.OpenXml.ExtendedProperties;
using RestSharp;
using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using httpdeveloper.marvel.comdocsAPIMVC.Models;
//using DocumentFormat.OpenXml.Wordprocessing;
using httpdeveloper.marvel.comdocsAPIMVCnewestversion.Controllers;
using Newtonsoft.Json.Linq;
using Marvel.Api.Filters;
using Marvel.Api.Results;
using RestSharp;

namespace httpdeveloper.marvel.comdocsAPIMVCnewestversion.Controllers
{
    public class HomeController : Controller
    {







        private const string StoriesUrlSegment = "/public/stories";


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /*public virtual RestResponse*/

        public async Task<IActionResult> GetFromExternal(string storyId = "1009351", CharacterRequestFilter filter = null)
        {

            HttpClient httpClient = new HttpClient();

            using (var response = await httpClient.GetAsync("https://localhost:5001/api/externalEndpoint"))
            {

                string httprequestUrl =
                    string.Format("{0}/{1}/characters", StoriesUrlSegment, storyId);

                //HttpRequest httpRequest = new HttpRequest(httprequestUrl, Method.GET);



                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, httprequestUrl);


                //request.RequestFormat = DataFormat.Json;

                HttpClient httpTheClient = new HttpClient/*("http://gateway.marvel.com/").BaseAddress*/();

                System.Uri uri = new System.Uri("http://gateway.marvel.com/");

                httpTheClient.BaseAddress = uri;

                StreamContent stream;

                //System.IO.Stream streamContent = "Hej";

                //stream = new StreamContent(/*streamContent*/);

                /*var content = await response.Content.CopyToAsync(stream,);*/ /*<IActionResult>*/
                /*ReadAsStringAsync<IActionResult>*/
                /*.ReadAsAsync<IActionResult>*/

                return Ok(/*content*/);


            }

            //restClient.Execute(request);

            //restClient.DefaultParameters







            //            httpClient.DefaultRequestHeaders
            //.Accept
            //.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

            //            request.AddHeader("Content-Type", "application/json;charset=UTF-8");

            //            if (!response.IsSuccessStatusCode)
            //                    return StatusCode((int)response.StatusCode);

            //                var responseContent = await response.Content.ReadAsStringAsync();
            //                var deserializedResponse = JsonConvert.DeserializeObject<List<string>>(responseContent);

            //                return Ok(deserializedResponse);
            //            }
            //        }

        }

        public async Task<ViewResult> /*RestResponse*//*RestRequest*//*CharacterResult*/ /*FindStoryCharacters(string storyId = "1009351", CharacterRequestFilter filter = null)*/FindStoryCharacters(string storyId = "1009351", CharacterRequestFilter filter = null)
        {
            // Build request url
            //
            string requestUrl =
                string.Format("{0}/{1}/characters", StoriesUrlSegment, storyId);

            RestRequest request = new RestRequest(requestUrl, Method.GET);

            request.RequestFormat = DataFormat.Json;

            // Parse filter
            //
            //ParseCharacterFilter(request, filter);

            RestClient restClient = new RestClient("http://gateway.marvel.com/");

            //HttpRequest httpRequest = new HttpRequest()

            // GET api/values/getFromExternal
            //[HttpGet, Route("getFromExternal")]
            ////public async Task<IActionResult> GetFromExternal()
            ////{
            ////    using (var response = await HttpClient.GetAsync("https://localhost:5001/api/externalEndpoint"))
            ////    {
            ////        if (!response.IsSuccessStatusCode)
            ////            return StatusCode((int)response.StatusCode);

            ////        var responseContent = await response.Content.ReadAsStringAsync();
            ////        var deserializedResponse = JsonConvert.DeserializeObject<List<string>>(responseContent);

            ////        return Ok(deserializedResponse);
            ////    }
            ////}

            // Build request url
            //
            string httprequestUrl =
                string.Format("{0}/{1}/characters", StoriesUrlSegment, storyId);

            //HttpRequest httpRequest = new HttpRequest(httprequestUrl, Method.GET);



            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, httprequestUrl);


            request.RequestFormat = DataFormat.Json;

            HttpClient httpClient = new HttpClient/*("http://gateway.marvel.com/").BaseAddress*/();

            System.Uri uri = new System.Uri("http://gateway.marvel.com/");

            httpClient.BaseAddress = uri;


            //restClient.Execute(request);

            //restClient.DefaultParameters

            httpClient.DefaultRequestHeaders
.Accept
.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

            request.AddHeader("Content-Type", "application/json;charset=UTF-8");



            RestResponse restResponse = (RestResponse)restClient.Execute(request);

            //[HttpPost]
            //[Route("AddorUpdatePersonalInfo")]
            //public async Task<HttpResponseMessage> AddorUpdatePersonalInfo(/*[FromBody] PersonalInfo personalinfo*/)
            //{
            //    try
            //    {
            //        var result = await this._Personalinforepository.AddorUpdatePersonalInfo(personalinfo);
            //        HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            //        return response;
            //    }
            //    catch (Exception ex)
            //    {
            //        throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
            //    }
            //}

            /*(await)*//*c */
            /*Microsoft.AspNetCore.Http.HttpResponse httpResponse*/ /*Task*/
            //Microsoft.AspNetCore.Http.HttpResponse httpResponse = await (Microsoft.AspNetCore.Http.HttpResponse)httpClient.GetAsync(httpClient.BaseAddress/*uri*//*httpRequestMessage.ToString()*//*httpRequest.ToString()*/);

            //response.Headers.Add("Content-Type", "application/json;charset=UTF-8");

            //    return await Task<HttpResponseMessage>.Factory.StartNew(() =>
            //{
            //   return Request.CreateResponse(HttpStatusCode.OK, data);
            //});creating

            //var data = 

            //async Task<Microsoft.AspNetCore.Http.HttpResponseMessage> Get()
            //{
            //    var data = await httpClient.GetAsync(httpClient.BaseAddress);
            //    return /*httpRequestMessage.Headers */httpResponse;/*(HttpStatusCode.OK, data);*/
            //}

            var content = "Content-Type";
            var response = new HttpResponseMessage
            {
                Content = new StringContent(content)
            };
            response.Content.Headers.Add(@"Content-Length", content.Length.ToString());

            //httpResponse.Headers.Add(  HttpHeader header = "Content-Type", Value = "application/json;charset=UTF-8" );

            //httpResponse.Headers.Add(Name = "Content-Type", Value = "application/json;charset=UTF-8");


            //ViewBag == httpResponse;


            //ViewBag.Message = httpResponse;

            return View(/*<Task>*//*httpResponse*/);

            //_ = response.Content;


            /*return*/ /*Execute*//*<CharacterResult>*//*(*//*(RestRequest)*//*Task*//*)*/
            ;
        }

   //     public CharacterResult FindCharacter(/*string characterId*/)
   //36         {
   //37             // Build request url
   //38             //
   //39             string requestUrl =
   //40                 string.Format("{0}/{1}", CharactersUrlSegment, "30");
   //41 
   //42             var request = new RestRequest(requestUrl, Method.GET);            
   //43 
   //44             return /*Execute<CharacterResult>(request)*/;
   //45         }

    public IActionResult Index(/*byte[] byteBuffer*//*RestResponse restResponse*//*RestRequest request*//*NameViewModel postdata*/)
        {

            const string apiKey = "1f8c669bfb6d6b86aa65400c8f3ad03d";
            const string privateKey = "b7e37b0815b570c2f84f0267060b0637698ed06a";

            var client = new MarvelRestClient(apiKey, privateKey);
            //List<ResultViewModel> results = null;
            List<CharactersInResultViewModel> results = null;
            List<CharactersInResultViewModel> resultsCharactersInAStory = null;





            var characterRequestTest = new CharacterResult();


            //FindCharacter(")


            ///*ComicResult*/ /*Marvel.Api.MarvelRestClient.*/FindCharacterComics("30"/*,ComicRequestFilter  filter = default(ComicRequestFilter)*/);
//)









            //NameViewModel postdata = "hulk";

            //if (postdata.Type.ToLower() == "character")
            //{
            var filter = new CharacterRequestFilter { NameStartsWith = "hulk" };
            filter.OrderBy(OrderResult.NameAscending);
            //filter.Limit = 40;
            filter.Limit = 1;



            /////*var*/ CharacterResult response = (client.FindCharacters(filter))/*.AsAByteString()*/;



            //JToken token = filter;
            //var jTokenAsString = token.AsString();

            //docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method

            /// <summary>
            /// Gets string value from JToken
            /// </summary>
            /// <param name="token"></param>
            /// <returns></returns>
            /// 
            /*public */
            //            static string /*MiscExtensions.*/(this JToken token)
            //            {
            //                return token.Type == JTokenType.String ? token.Value<string>() : token.ToString();
            //            }

            //            /// <summary>
            //            /// Gets string value from JToken
            //            /// </summary>
            //            /// <param name="token"></param>
            //            /// <returns></returns>
            //            /*public */static string AsString(this JToken token, CultureInfo culture)
            //            {
            //                var value = token as JValue;
            //                if (value != null)
            //                {
            //                    return (string)value.Value.ChangeType(typeof(string), culture);
            //                }

            //                return token.Type == JTokenType.String ? token.Value<string>() : token.ToString();
            //            }

            //            /// <summary>
            //            /// Converts a byte array to a string, using its byte order mark to convert it to the right encoding.
            //            /// http://www.shrinkrays.net/code-snippets/csharp/an-extension-method-for-converting-a-byte-array-to-a-string.aspx
            //            /// </summary>
            //            /// <param name="buffer">An array of bytes to convert</param>
            //            /// <returns>The byte as a string.</returns>
            //            /*public */static string AsString(this byte[] buffer)
            //            {
            //                if (buffer == null) return "";

            //                // Ansi as default
            //                Encoding encoding = Encoding.UTF8;

            //#if FRAMEWORK
            //			return encoding.GetString(buffer);
            //#else
            //                if (buffer == null || buffer.Length == 0)
            //                    return "";

            //                /*
            //                    EF BB BF		UTF-8 
            //                    FF FE UTF-16	little endian 
            //                    FE FF UTF-16	big endian 
            //                    FF FE 00 00		UTF-32, little endian 
            //                    00 00 FE FF		UTF-32, big-endian 
            //                    */

            //                if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
            //                {
            //                    encoding = Encoding.UTF8;
            //                }
            //                else if (buffer[0] == 0xfe && buffer[1] == 0xff)
            //                {
            //                    encoding = Encoding.Unicode;
            //                }
            //                else if (buffer[0] == 0xfe && buffer[1] == 0xff)
            //                {
            //                    encoding = Encoding.BigEndianUnicode; // utf-16be
            //                }

            //                using (MemoryStream stream = new MemoryStream())
            //                {
            //                    stream.Write(buffer, 0, buffer.Length);
            //                    stream.Seek(0, SeekOrigin.Begin);
            //                    using (StreamReader reader = new StreamReader(stream, encoding))
            //                    {
            //                        return reader.ReadToEnd();
            //                    }
            //                }
            //#endif
            //            }





            var buffer = new byte[] { };

            //buffer = (client.FindCharacters(filter));

                    //var response = (client.FindCharacters(filter))/*.AsString(buffer)*/;
            /*.ToString()*//*)*//*;.Data*/

            //response.ToString();,

            //response.ToString();

            //response.AsAByteString(/*buffer*//*buffer*/);

            //var token = client.FindCharacters(filter);
            //token.ToString();
            


            //var jTokenAsString = token.AsString();                                               

            //if (response.Code == "200")
            //{
            //results =
            //response.Data.Results.Select(res =>
            //    new CharactersInResultViewModel { Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
            ////}

            return View(/*response*/);
        }

        //results =
        //    response.Data.Results.Select(res =>
            //new CharactersInResultViewModel { StoryID = /*res.Stories.Items.Equals(*//*"1009351"/*).ToString()*//*,StoryID = res.Stories. *//*Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();*/



            //            else
            //            {

            //                    if (response.Code == "200")
            //            {
            //            results =
            //            response.Data.Results.Select(res =>
            //                new CharactersInResultViewModel { Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL
            //    }).ToList();
            //}


            //results =
            //            response.Data.Results.Select(res =>
            //                new CharactersInResultViewModel { StoryID = /*res.Stories.Items.Equals(*/"1009351"/*).ToString()*/,/**StoryID = res.Stories. */Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();


            List < ResultViewModel > realresults = new List<ResultViewModel>();

            //ResultViewModel realresults; 


            /*realresults = response.ToList<ResultViewModel>();*/            //response.Data.Results.Select(res =>
            //    new ResultViewModel { Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();

            //realresults.FirstOrDefault();

            //return View(response); 

            //else
            //{

            //if (response.Code == "200")
            //{
            //results =
            //response.Data.Results.Select(res =>
            //    new ResultViewModel { Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
            //    }


            //results =
            //response.Data.Results.Select(res =>
            //    new CharactersInResultViewModel { StoryID = /*res.Stories.Items.Equals(*/"1009351"/*).ToString()*/,/**StoryID = res.Stories. */Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();


            //}
            //else
            //{

            //FindStoryCharacters();

            //ViewBag.Message = (List<CharactersInResultViewModel>)request;

            /*ViewBag.Message =*/ /*(List<CharactersInResultViewModel>)*//*request;*/

            /* ViewBag.Message =*/ /*(List<CharactersInResultViewModel>)*//*restResponse;*/


            //ViewBag.Message = results;





            //var comicFilter = new ComicRequestFilter { TitleStartsWith = "hulk" };
            //comicFilter.OrderBy(OrderResult.NameAscending);
            //comicFilter.Limit = 40;
            ////comicFilter.Limit = 1;

            //var comicFilterresponse = client.FindComics(comicFilter);

            ////if (response.Code == "200")
            ////{
            //results =
            //response.Data.Results.Select(res =>
            //    new CharactersInResultViewModel { /*Characters = Marvel.Api.Model.DomainObjects.Story.*/ Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
            ////}
            //var firstResultDescription = results.FirstOrDefault();

            //var characterList = 

            //var characterList = firstResultDescription.Description.

            //var Filter = new StoryRequestFilter { };
            //Filter.OrderBy(OrderResult.NameAscending);
            //Filter.Limit = 40;
            ////filter.Limit = 1;

            //StoryResult storyFilterresponse = client.FindStory("1009351");  /*client.FindStoryCharacters("1009351");*/

            //resultsCharactersInAStory =
            //storyFilterresponse.Data.Results.Select(res =>
            //    new CharactersInResultViewModel { /*Characters = res.Stories., */Id = res.Id, Description = res.Description/*, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL */}).ToList();
            ////    }



            //storyFilterresponse.Data.Results.

            //resultsCharactersInAStory =
            //storyFilterresponse.Data.Results.Select(res =>
            //    new CharactersInResultViewModel { /*Characters = res.Stories., */Id = res.Id, Description = res.Description/*, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL */}).ToList();
            ////    }

            //if (response.Code == "200")
            //{
            //results =
            //response.Data.Results.Select(res =>
            //    new ResultViewModel { Id = res.Id, Description = res.Description, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
            ////    }
            ////}

            List<CharactersInResultViewModel> charactersResults = null;

            //charactersResults = response.ToList();
            //response.Data.Results.Select(res =>
            //    new CharactersInResultViewModel { Name = res.Name }).ToList();
            //    }
            //}

            //var storyFilterresponseCharacterList = charactersResults;

            //var baseAddress = new Uri("http://importmarvel.com/");

            //using (var httpClient = new HttpClient
            //{
            //    BaseAddress = baseAddress
            //})
            //{

            //    using (var allCharactersInAStory = /*await */httpClient.GetAsync("api/characters"))
            //    {

            //        string allCharactersInAStoryData = allCharactersInAStory.Result.ToString();

            //        ViewBag.Message = allCharactersInAStoryData;

            //        return View(allCharactersInAStoryData);

            //    }

                //ViewBag.Message = allCharactersInAStoryData;

                //ViewBag.Message = realresults;

                //return View(allCharactersInAStoryData);

                //return View(realresults); 





                //ViewBag.Message = results;


                //return View(results); 



                //ViewBag.Message = resultsCharactersInAStory;


                //return View(resultsCharactersInAStory);






                //return View(storyFilterresponse);


                //ViewBag.Message = storyFilterresponseCharacterList;

                //return Json(storyFilterresponseCharacterList);

                //return View("Index", restResponse);

                //return View(storyFilterresponseCharacterList);

                //return Json(results);
















                //[HttpPost]
                //[HttpGet]
//                 IActionResult Index(/*NameViewModel postdata*/)
//                {

//                    const string apiKey = "1f8c669bfb6d6b86aa65400c8f3ad03d";
//                    const string privateKey = "b7e37b0815b570c2f84f0267060b0637698ed06a";

//                    const string characterName = "hulk";

//                    var client = new MarvelRestClient(apiKey, privateKey);
//                    List<ResultViewModel> results = null;

//                    //if (postdata.Type.ToLower() == "character")
//                    //{
//                    var filter = new StoryRequestFilter { /*Characters.Equals == The Hulk*//*NameStartsWith = postdata.Name*/ };
//                    filter.OrderBy(OrderResult.NameAscending);
//                    filter.Comics.Contains("hulk");
//                    /*filter.Comics.Where*/
//                    /*(*//*res.*//*filter.Comics.IndexOf((char)30));*/
////filter.Series.
////filter.Limit.Value { hulkValue};
//                        /*StoryResult*/ var response = client.FindStories/*Characters*/(filter);

//                        //var response = client.FindStories(filter);

//                        if (response.Code == "200")
//                        {
//                            results =
//                            response.Data.Results./*Where(results.*//*Where(response.Data.Results.).*/Select(res =>
//                                            //new ResultViewModel { Id = 30/*res.Id*/, Description = res.Description,  Name = "The second volume containing the Hulk\u0027s early adventures with appearances by the Sub-Mariner, the Mandarin, Ka-Zar and Nick Fury" /*res.Title*/, Url = "http://gateway.marvel.com/v1/public/stories/30" /*res.ResourceURI*/ })./*Where(response.Data.Results.Id*//*.Where(res.Id == 30)*//*.*/ToList()/*.Where(Id == 30)*//*.FirstOrDefault*//*(*//*t => t.Type == "detail").URL }).ToList(*//*)*/;
//                                            new ResultViewModel { Id = 30, Description = res.Description, Name = res.Title, Url = "http://gateway.marvel.com/v1/public/stories/30/" })./*Where(response.Data.Results.Id*//*.Where(res.Id == 30)*//*.*/ToList()/*.Where(Id == 30)*//*.FirstOrDefault*//*(*//*t => t.Type == "detail").URL }).ToList(*//*)*/;

//                            results =
//                                    response.Data.Results.Select(res =>
//                                        new ResultViewModel { Id = res.Id, Description = res.Description, Name = res.Title, Url = res.ResourceURI.FirstOrDefault().ToString() }).ToList();




//                        }/*.*/

//            //results.Where()

//            //else
//                        {
//                            var comicFilter = new ComicRequestFilter { /*TitleStartsWith =*/ /*postdata.Name*/ };
//                        comicFilter.OrderBy(OrderResult.NameAscending);
//                        comicFilter.Limit = 40;

//                            var comicResponse = client.FindComics(comicFilter);

//                            if (comicResponse.Code == "200")
//                            {
//                                results =
//                                comicResponse.Data.Results.Select(res =>
//                                    new ResultViewModel { Id = res.Id, Name = res.Title, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
//                            }
//                        }
//                        //return Json(results/*.ToList()*/);
//                        return View(results);
//                        //}

//                        //return View();




//                        //[HttpPost]
//                        //public JsonResult SomeActionMethod(NameViewModel postdata)
//                        //{
//                        //    const string apiKey = "1f8c669bfb6d6b86aa65400c8f3ad03d";
//                        //    const string privateKey = "b7e37b0815b570c2f84f0267060b0637698ed06a";


//                        //    var client = new MarvelRestClient(apiKey, privateKey);
//                        //    List<ResultViewModel> results = null;

//                        //    if (postdata.Type.ToLower() == "character")
//                        //    {
//                        //        var filter = new CharacterRequestFilter { NameStartsWith = postdata.Name };
//                        //        filter.OrderBy(OrderResult.NameAscending);
//                        //        filter.Limit = 40;

//                        //        var response = client.FindCharacters(filter);

//                        //        if (response.Code == "200")
//                        //        {
//                        //            results =
//                        //            response.Data.Results.Select(res =>
//                        //                new ResultViewModel { Id = res.Id, Name = res.Name, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
//                        //        }
//                        //    }
//                        //    else
//                        //    {
//                        //        var filter = new ComicRequestFilter { TitleStartsWith = postdata.Name };
//                        //        filter.OrderBy(OrderResult.NameAscending);
//                        //        filter.Limit = 40;

//                        //        var response = client.FindComics(filter);

//                        //        if (response.Code == "200")
//                        //        {
//                        //            results =
//                        //            response.Data.Results.Select(res =>
//                        //                new ResultViewModel { Id = res.Id, Name = res.Title, Url = res.Urls.FirstOrDefault(t => t.Type == "detail").URL }).ToList();
//                        //        }
//                        //    }
//                        //    return Json(results);
//                        //return View();
//                    }
                }
            }

            //public IActionResult Privacy()
            //{
            //    return View();
            //}

////        }
////    }
////}

//    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//    public IActionResult Error()
//    {
//        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//    }
//}
        


