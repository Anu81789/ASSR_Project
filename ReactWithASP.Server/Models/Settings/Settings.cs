﻿using System.ComponentModel.DataAnnotations;


    //public class SocialMediaAccountSettings
    //{
    //    public int Id { get; set; }
    //    public string SocialMediaId { get; set; }

    //    [StringLength(5, ErrorMessage = "The time limit must be at most 5 characters long.")]
    //    public string TimeLimit { get; set; }

    //    public DateTime CreatedOn { get; set; }

    //    public bool IsImageAllow { get; set; }
    //    public bool IsVedioAllow { get; set; }
    //    public bool IsTextAllow { get; set; }

    //    [StringLength(300, ErrorMessage = "The text size must be at most 300 characters long.")]
    //    public string Text { get; set; } 
    //    public IFormFile? Image { get; set; }
    //    public IFormFile? Video { get; set; }
    //}

    public class SocialMediaAccountSettings

        // Properties for storing file paths
        public string ImagePath { get; set; }

        // Properties for uploading files (excluded from database mapping)
        [NotMapped]

        // Properties for uploading files
        public IFormFile Image { get; set; }