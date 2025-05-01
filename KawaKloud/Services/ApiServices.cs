using System.Net.Http;
using System.Net.Http.Json;
using KawaKloud.Models;

namespace KawaKloud.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://api.myanimelist.net/v2") // Chosen Api for Anime databse
        };
    }
    //Popular Anime
    public async Task<List<AnimeItem>> GetPopularAnimeAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<AnimeItem>>("anime/popular") ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[API ERROR] Uh-Oh, Kloudia is having trouble. Please try again.: {ex.Message}");
                return new List<AnimeItem>();
            }
        }

    //Anime for Kids page
    public async Task<List<AnimeItem>> GetKidsAnimeAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<AnimeItem>>("anime/kids") ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[API ERROR] Uh-Oh, Kloudia is having trouble. Please try again.: {ex.Message}");
                return new List<AnimeItem>();
            }
        }
    //Newly Released
    public async Task<List<AnimeItem>> GetNewlyReleasedAnimeAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<AnimeItem>>("anime/new") ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[API ERROR] Uh-Oh, Kloudia is having trouble. Please try again.: {ex.Message}");
                return new List<AnimeItem>();
            }
        }
    // Favorites
    public async Task<List<AnimeItem>> GetFavoritesAsync()
        {
            try
            {
                // This could also hit a local database instead of API
                return await _httpClient.GetFromJsonAsync<List<AnimeItem>>("user/favorites") ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[API ERROR] Uh-Oh, Kloudia is having trouble. Please try again.: {ex.Message}");
                return new List<AnimeItem>();
            }
        }
    }
