using System.ComponentModel.DataAnnotations;

namespace AmibDatePickerBlazorComponent;

public class InputPersianDateViewModel
{
    [Required] public string? Name { set; get; } = default!;

    [Required] public DateTime? BirthDayGregorian { set; get; } = DateTime.Now.AddYears(-40);

    public DateTime? LoginAt { set; get; } = DateTime.Now.AddMinutes(-2);

    [Required] public DateTimeOffset? LogoutAt { set; get; }

    public DateTimeOffset? RegisterAt { set; get; } = DateTimeOffset.Now.AddMinutes(-10);
}