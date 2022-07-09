using System;
using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    public class Notice
    {
        [Key] public int NoticeNo { get; set; }

        [Required] public string NoticeTitle { get; set; }

        [Required] public string NoticeContents { get; set; }

        [Required] public DateTime NoticePostingDate { get; set; }
    }
}