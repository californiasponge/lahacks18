﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewMe.Models.Requests
{
    public class QuestionsUpdateRequest : QuestionRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
