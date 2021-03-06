﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace QrCo3ds.Models
{
    public class GameInfo : AbstractBase
    {
        public string BoxArtLocalPath { get; set; } = string.Empty;
        public string CiaLocalPath { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public string GameplayUrl { get; set; } = string.Empty;
        public bool IsLegit { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumberOfPlayers { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public DateTime ReleaseDate { get; set; }
        public string TagName { get; set; } = string.Empty;

        public List<CategoryInfo> Categories { get; set; } = new List<CategoryInfo>();
        public List<DlcInfo> Dlcs { get; set; } = new List<DlcInfo>();
        public List<ScreenshotInfo> Screenshots { get; set; } = new List<ScreenshotInfo>();

        [NotMapped]
        public string BoxArtUrl => $"./games/{Id}/boxArtFile?{Guid.NewGuid().ToString("N")}";
        [NotMapped]
        public string CiaUrl => $"./games/{Id}/ciaFile?{Guid.NewGuid().ToString("N")}";
    }
}
