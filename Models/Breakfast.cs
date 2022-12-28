using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBreakfast.Models;

    public record Breakfast(
        string Name,
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTIme,
        Uri Image,
        List<string> Savory,
        List<string> Sweet);

