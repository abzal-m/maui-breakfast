using CommunityToolkit.Mvvm.ComponentModel;
using MauiBreakfast.Models;

namespace MauiBreakfast.ViewModels;

public partial class MyBreakfastsViewModel : ObservableObject
{
    [ObservableProperty]
    List<Breakfast> breakfasts;

    public MyBreakfastsViewModel()
    {
        LoadBreakfasts();
    }

    private void LoadBreakfasts()
    {
        Breakfasts = new()
            {
                new Breakfast(
                    Name: "Vegan Sunshine",
                    Description: "Vegan everything! Join us for a  healthy breakfast full of vegan dishes and Cookies",
                    StartDateTime: DateTime.UtcNow.AddDays(1),
                    EndDateTIme: DateTime.UtcNow.AddDays(1).AddHours(2),
                    Image: new Uri("https://images.unsplash.com/photo-1525351484163-7529414344d8"),
                    Savory: new List<string>{ "Oatmeal", "Avacado Toast", "Omlet", "Salad" },
                    Sweet: new List<string>{"Salad"}),
                new Breakfast(
                    Name: "Breakfast @ Mery",
                    Description: "Hi, I`m Mery and I`ll be yours chef on Sunday",
                    StartDateTime: DateTime.UtcNow,
                    EndDateTIme: DateTime.UtcNow.AddHours(2),
                    Image: new Uri("https://images.unsplash.com/photo-1484723091739-30a097e8f929"),
                    Savory: new List<string>{ "Oatmeal", "Avacado Toast", "Omlet", "Salad" },
                    Sweet: new List<string>{"Salad"})
            };
    }
}

