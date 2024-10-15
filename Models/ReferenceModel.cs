using System.Collections.Generic;
using System;

namespace Models
{
    public class ReferenceModel
    {
        public bool isHumanoid { get; set; }
        public string planet { get; set; }
        public int? ageMin { get; set; }
        public int? ageMax { get; set; }
        public List<string> traits { get; set; }
    
    
        public static Dictionary<string, List<ReferenceModel>> GetAllSpecies()
        {
            return new Dictionary<string, List<ReferenceModel>>
            {
                { 
                    "Star Wars", new List<ReferenceModel>
                    {
                        new ReferenceModel
                        {
                            isHumanoid = false,
                            planet = "Kashyyyk",
                            ageMin = 0, 
                            ageMax = 400,
                            traits = new List<string> { "HAIRY", "TALL" }
                        },
                        new ReferenceModel
                        {
                            isHumanoid = false,
                            planet = "Endor",
                            ageMin = 0, 
                            ageMax = 60,
                            traits = new List<string> { "SHORT", "HAIRY" }
                        }
                    }
                },
                { 
                    "Marvel", new List<ReferenceModel>
                    {
                        new ReferenceModel
                        {
                            isHumanoid = true,
                            planet = "Asgard",
                            ageMin = 0, 
                            ageMax = 5000,
                            traits = new List<string> { "BLONDE", "TALL" }
                        },
                    }
                },
                { 
                    "Hitchhiker", new List<ReferenceModel>
                    {
                        new ReferenceModel
                        {
                            isHumanoid = true,
                            planet = "Betelgeuse",
                            ageMin = 0, 
                            ageMax = 100,
                            traits = new List<string> { "EXTRA_ARMS", "EXTRA_HEAD" }
                        },
                        new ReferenceModel
                        {
                            isHumanoid = false,
                            planet = "Vogsphere",
                            ageMin = 0, 
                            ageMax = 200,
                            traits = new List<string> { "GREEN", "BULKY" }
                        }
                    }
                },
                { 
                    "Lord of the rings", new List<ReferenceModel>
                    {
                        new ReferenceModel
                        {
                            isHumanoid = true,
                            planet = "Earth",
                            ageMin = null, 
                            ageMax = null,
                            traits = new List<string> { "BLONDE", "POINTY_EARS" }
                        },
                        new ReferenceModel
                        {
                            isHumanoid = true,
                            planet = "Earth",
                            ageMin = 0, 
                            ageMax = 200,
                            traits = new List<string> { "SHORT", "BULKY" }
                        }
                    }
                }

            };
        }
    }
}