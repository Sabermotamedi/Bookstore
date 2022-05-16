using Bookstore.API.Models;
using Bookstore.Client.Service;
using IdentityModel.Client;
using Microsoft.AspNetCore.Components;

namespace Bookstore.Client.Pages
{
    public partial class Bookstores
    {
		private List<BookModels> Books = new();
		[Inject] private HttpClient HttpClient { get; set; }
		[Inject] private IConfiguration Config { get; set; }
		[Inject] private ITokenService TokenService { get; set; }

		protected override async Task OnInitializedAsync()
		{
            var tokenResponse = await TokenService.GetToken("BookstoreAPI.read");
            HttpClient.SetBearerToken(tokenResponse.AccessToken);

            var result = await HttpClient.GetAsync(Config["apiUrl"] + "/api/v1/Book");

			if (result.IsSuccessStatusCode)
			{
				Books = await result.Content.ReadFromJsonAsync<List<BookModels>>();
			}
		}
	}
}
