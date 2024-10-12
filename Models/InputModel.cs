using System.Collections.Generic;
using System;

namespace Models
{
    public class InputWord  // To avoid 'input' word
    {
        public List<InputModel> input { get; set; }
    }

    public class InputModel
    {
        public int id { get; set; }
        public bool? isHumanoid { get; set; }
        public string? planet { get; set; }
        public int? age { get; set; }
        public List<string>? traits { get; set; }
    }
}