﻿using GenFu.ValueGenerators.Geospatial;
using GenFu.ValueGenerators.People;
using System;
using System.Text;

namespace GenFu
{
    public class StringFiller : PropertyFiller<string>
    {
        public StringFiller(): this(A.GenFuInstance) { }

        public StringFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "*" }, true)
        {
        }

        public override object GetValue(object instance)
        {
            return BaseValueGenerator.Word();
        }
    }
    public class ArticleTitleFiller : PropertyFiller<string>
    {
        public ArticleTitleFiller() : this(A.GenFuInstance) { }

        public ArticleTitleFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "title" })
        {
        }

        public override object GetValue(object instance)
        {
            return Names.Title();
        }
    }

    public class FirstNameFiller : PropertyFiller<string>
    {
        public FirstNameFiller() : this(A.GenFuInstance) { }

        public FirstNameFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "firstname", "fname", "first_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return Names.FirstName();
        }
    }

    public class PersonTitleFiller : PropertyFiller<string>
    {
        public PersonTitleFiller() : this(A.GenFuInstance) { }

        public PersonTitleFiller(GenFuInstance genFu)
            : base(genFu, new[] { "person", "employee", "user" }, new[] { "title" })
        {
        }

        public override object GetValue(object instance)
        {
            return Names.PersonTitle();
        }
    }

    public class LastNameFiller : PropertyFiller<string>
    {
        public LastNameFiller() : this(A.GenFuInstance) { }

        public LastNameFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "lastname", "lname", "last_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return Names.LastName();
        }
    }

    public class EmailFiller : PropertyFiller<string>
    {
        public EmailFiller() : this(A.GenFuInstance) { }

        public EmailFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "email", "emailaddress", "email_address" })
        {
        }

        public override object GetValue(object instance)
        {
            return ContactInformation.Email();
        }
    }

    public class TwitterFiller : PropertyFiller<string>
    {
        public TwitterFiller(): this(A.GenFuInstance) { }

        public TwitterFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "twitter", "twitterhandle", "twitter_handle", "twittername" })
        {
        }

        public override object GetValue(object instance)
        {
            return ContactInformation.Twitter();
        }
    }

    public class AddressFiller : PropertyFiller<string>
    {
        public AddressFiller() : this(A.GenFuInstance) { }

        public AddressFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "address", "address1", "address_1", "billingaddress", "billing_address" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.AddressLine();
        }
    }

    public class AddressLine2Filler : PropertyFiller<string>
    {
        public AddressLine2Filler() : this(A.GenFuInstance) { }

        public AddressLine2Filler(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "address2", "address_2" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.AddressLine2();
        }
    }

    public class CityFiller : PropertyFiller<string>
    {
        public CityFiller() : this(A.GenFuInstance) { }

        public CityFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "city", "cityname", "city_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.City();
        }
    }

    public class StateFiller : PropertyFiller<string>
    {
        public StateFiller(): this(A.GenFuInstance) { }

        public StateFiller(GenFuInstance genFu)
                : base(genFu, new[] { "object" }, new[] { "state", "statename", "state_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.UsaState();
        }
    }

    public class StateAbreviationFiller : PropertyFiller<string>
    {
        public StateAbreviationFiller() : this(A.GenFuInstance) { }

        public StateAbreviationFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "stateAbreviation" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.UsaStateAbreviation();
        }
    }


    public class ProvinceFiller : PropertyFiller<string>
    {
        public ProvinceFiller() : this(A.GenFuInstance) { }

        public ProvinceFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "province", "provincename", "province_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.CanadianProvince();
        }
    }

    public class ZipCodeFiller : PropertyFiller<string>
    {
        public ZipCodeFiller(): this(A.GenFuInstance) { }

        public ZipCodeFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "zip", "zipcode", "zip_code" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.ZipCode();
        }
    }

    public class PostalCodeFiller : PropertyFiller<string>
    {
        public PostalCodeFiller() : this(A.GenFuInstance) { }

        public PostalCodeFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "postalcode", "postal_code" })
        {
        }

        public override object GetValue(object instance)
        {
            return Address.PostalCode();
        }
    }

    public class PhoneNumberFiller : PropertyFiller<string>
    {
        public PhoneNumberFiller() : this(A.GenFuInstance) { }

        public PhoneNumberFiller(GenFuInstance genFu)
            : base(genFu, new[] { "object" }, new[] { "fax", "phone", "phonenumber", "phone_number", "homenumber", "worknumber" })
        {
        }

        public override object GetValue(object instance)
        {
            return ContactInformation.PhoneNumber();
        }
    }

    public class MusicAlbumTitleFiller : PropertyFiller<string>
    {
        public MusicAlbumTitleFiller() : this(A.GenFuInstance) { }

        public MusicAlbumTitleFiller(GenFuInstance genfu)
            : base(genfu, new[] { "album", "musicalbum", "music_album" }, new[] { "title", "albumname", "name" })
        {
        }

        public override object GetValue(object instance)
        {
            return ValueGenerators.Music.Album.Title();
        }
    }

    public class MusicArtistNameFiller : PropertyFiller<string>
    {
        public MusicArtistNameFiller() : this(A.GenFuInstance) { }

        public MusicArtistNameFiller(GenFuInstance genfu)
            : base(genfu, new[] { "artist" }, new[] { "name", "artistname", "artist_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return ValueGenerators.Music.Artist.Name();
        }
    }

    public class MusicGenreNameFiller : PropertyFiller<string>
    {
        public MusicGenreNameFiller() : this(A.GenFuInstance) { }

        public MusicGenreNameFiller(GenFuInstance genfu)
            : base(genfu, new[] { "genre", "musicgenre", "music_genre" }, new[] { "title", "name", "genre_title", "genre_name" })
        {
        }

        public override object GetValue(object instance)
        {
            return ValueGenerators.Music.Genre.Name();
        }
    }

    public class MusicGenreDescriptionFiller : PropertyFiller<string>
    {
        public MusicGenreDescriptionFiller() : this(A.GenFuInstance) { }

        public MusicGenreDescriptionFiller(GenFuInstance genFu)
            : base(genFu, new[] { "genre", "musicgenre", "music_genre" }, new[] { "description", "desc", "genre_description", "genre_desc" })
        {
        }

        public override object GetValue(object instance)
        {
            return ValueGenerators.Music.Genre.Description();
        }
    }

}
