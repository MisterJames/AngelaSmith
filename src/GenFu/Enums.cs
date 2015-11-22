﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace GenFu
{

    public enum Properties
    {
        FirstNames,
        LastNames,
        Words,
        Titles,
        Domains,
        StreetNames,
        CityNames,
        CanadianProvinces,
        UsaStates,
        MusicArtists,
        MusicGenre,
        MusicAlbums,
        Ingredients,
        CompanyNames,
        Industries,
        Drugs,
        MedicalProcedures
    }

    [Flags]
    public enum DateRules
    {
        FutureDates = 0,
        Within1Year = 1,
        Within10Years = 2,
        Within25years = 4,
        Within50Years = 8,
        Within100Years = 16,
        PastDate = 32
    }
}
