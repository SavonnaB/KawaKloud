namespace KawaKloud;

private async void OnPopularAnimeClicked(object sender, EventArgs e)
{
    await Shell.Current.GoToAsync(nameof(PopularAnimePage));
}

private async void OnKidsAnimeClicked(object sender, EventArgs e)
{
    await Shell.Current.GoToAsync(nameof(AnimeForKidsPage));
}

private async void OnNewlyReleasedClicked(object sender, EventArgs e)
{
    await Shell.Current.GoToAsync(nameof(NewlyReleasedPage));
}


