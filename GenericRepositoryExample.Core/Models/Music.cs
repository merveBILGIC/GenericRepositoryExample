﻿namespace GenericRepositoryExample.Core.Models
{
    public class Music
    {
        public Music()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }

        public Artist Artist { get; set; }
    }
}
