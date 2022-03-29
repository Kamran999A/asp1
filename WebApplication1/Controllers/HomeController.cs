using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Cola",
                    ImagePath="../images/cola.png"
                },

                 new Drink
                {
                    Id=2,
                    Name="Fanta",
                    ImagePath="../images/fanta.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Sprite",
                    ImagePath="../images/sprite.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Red Bull",
                    ImagePath="../images/redbull.png"
                },
                   new Drink
                {
                    Id=5,
                    Name="Savalan )))",
                    ImagePath="../images/savalanim.png"
                }

            };
            List<HotMeal> hotMeals = new List<HotMeal>
            {
               new HotMeal
                {
                    Id=1,
                    Name="Dovga",
                    ImagePath="../images/dovga.jpg"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Gobelek supu",
                    ImagePath="../images/gobelek.jpg"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Merci supu",
                    ImagePath="../images/merci.jpg"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Toyuq Supu",
                    ImagePath="../images/toyuq.png"
                },
                new HotMeal
                {
                    Id=5,
                    Name="Yayla Supu",
                    ImagePath="../images/yayla.jpg"
                }

            };
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Shaurma",
                    ImagePath="../images/shaurma.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="Lahmacun",
                    ImagePath="../images/lahmacun.jpg"
                },
                new FastFood
                {
                    Id=3,
                    Name="Pide",
                    ImagePath="../images/pide.jpg"
                },
                new FastFood
                {
                    Id=4,
                    Name="Yunan Pizza",
                    ImagePath="../images/yunanpizza.jpg"
                },
                new FastFood
                {
                    Id=5,
                    Name="Dil Salati",
                    ImagePath="../images/dilsalati.jpg"
                }
            };
            var model = new MenuListViewModel
            {
                Drinks=drinks,
                HotMeals=hotMeals,
                FastFoods=fastFoods      
            };
            return View(model);
        }
        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink
                {
                    Id=1,
                    Name="Cola",
                    ImagePath="../images/cola.png"
                },

                 new Drink
                {
                    Id=2,
                    Name="Fanta",
                    ImagePath="../images/fanta.png"
                },

                  new Drink
                {
                    Id=3,
                    Name="Sprite",
                    ImagePath="../images/sprite.png"
                },
                   new Drink
                {
                    Id=4,
                    Name="Red Bull",
                    ImagePath="../images/redbull.png"
                },
                   new Drink
                {
                    Id=5,
                    Name="Savalan )))",
                    ImagePath="../images/savalanim.png"
                }

            };

            return View(drinks);
        }
        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>
            {
                new HotMeal
                {
                    Id=1,
                    Name="Dovga",
                    ImagePath="../images/dovga.jpg"
                },
                  new HotMeal
                {
                    Id=2,
                    Name="Gobelek supu",
                    ImagePath="../images/gobelek.jpg"
                },
                    new HotMeal
                {
                    Id=3,
                    Name="Merci supu",
                    ImagePath="../images/merci.jpg"
                },
                      new HotMeal
                {
                    Id=4,
                    Name="Toyuq Supu",
                    ImagePath="../images/toyuq.png"
                },
                new HotMeal
                {
                    Id=5,
                    Name="Yayla Supu",
                    ImagePath="../images/yayla.jpg"
                }

            };
            return View(hotMeals);
        }
        public IActionResult FastFood()
        {
            List<FastFood> fastFoods = new List<FastFood>
            {
                new FastFood
                {
                    Id=1,
                    Name="Shaurma",
                    ImagePath="../images/shaurma.jpg"
                },
                new FastFood
                {
                    Id=2,
                    Name="Lahmacun",
                    ImagePath="../images/lahmacun.jpg"
                },
                new FastFood
                {
                    Id=3,
                    Name="Pide",
                    ImagePath="../images/pide.jpg"
                },
                new FastFood
                {
                    Id=4,
                    Name="Yunan Pizza",
                    ImagePath="../images/yunanpizza.jpg"
                },
                new FastFood
                {
                    Id=5,
                    Name="Dil Salati",
                    ImagePath="../images/dilsalati.jpg"
                }
            };
            return View(fastFoods);

        }
    }
}
