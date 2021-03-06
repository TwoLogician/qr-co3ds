﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace QrCo3ds.Models
{
    public class DlcRequest
    {
        public IFormFile CiaFile { get; set; }
        public string Json { get; set; }
    }

    public class GameRequest
    {
        public IFormFile BoxArtFile { get; set; }
        public IFormFile CiaFile { get; set; }
        public string Json { get; set; }
    }
}
