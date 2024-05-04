using Review_Website.Models;

namespace Review_Website.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                //var context = applicationBuilder.ApplicationServices.GetService<AppDbContext>();

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
                context.Database.EnsureCreated();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Michael Mann",
                            Bio = "As a director, screenwriter, and producer, four-time Academy Award nominee " +
                            "Michael Mann has established himself as one of the most innovative and influential " +
                            "filmmakers in American cinema",
                            ProfilePictureURL = "https://t2.gstatic.com/licensed-image?q=tbn:ANd9GcScuE1yyCtUbg4vxCGymjNXQXSmQ0UiNrnHne7b2eJ0dqIIZSwfa7PCtJUWS6LsMKKR"
                        },
                        new Producer()
                        {
                            FullName = "James Cameron",
                            Bio = "James Francis Cameron was born on August 16, 1954 in Kapuskasing, Ontario, Canada. " +
                            "He moved to the United States in 1971.",
                            ProfilePictureURL = "https://static.wikia.nocookie.net/disney/images/8/83/James_Cameron.jpg/revision/latest?cb=20180816154130"
                        },
                        new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "One of the most influential personalities in the history of cinema, " +
                            "Steven Spielberg is Hollywood's best known director and one of the wealthiest filmmakers " +
                            "in the world.",
                            ProfilePictureURL = "https://m.media-amazon.com/images/M/MV5BMTY1NjAzNzE1MV5BMl5BanBnXkFtZTYwNTk0ODc0._V1_.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Title = "Avatar: The Way of Water",
                            Description = "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora. " +
                            "Once a familiar threat returns to finish what was previously started, " +
                            "Jake must work with Neytiri and the army of the Na'vi race to protect their home.",
                            ReleaseDate = new DateTime(2022, 12, 15),
                            Genre = Genre.Action,
                            ProducerId = 2
                        },
                        new Movie()
                        {
                            Title = "Schindler's List",
                            Description = "In German-occupied Poland during World War II, " +
                            "industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing " +
                            "their persecution by the Nazis.",
                            ReleaseDate = new DateTime(1993, 11, 30),
                            Genre = Genre.Drama,
                            ProducerId = 3
                        },
                        new Movie()
                        {
                            Title = "The Insider",
                            Description = "A research chemist comes under personal and professional attack when he decides to appear in a " +
                            "60 Minutes exposé on Big Tobacco.",
                            ReleaseDate = new DateTime(1999, 11, 05),
                            Genre = Genre.Drama,
                            ProducerId = 1
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Sigourney Weaver",
                            Bio = "Born and educated in New York City, " +
                            "Weaver graduated from Stanford University and went on to receive a master's degree from the Yale School of Drama. " +
                            "Her first professional job was in Sir John Gielgud's production of The Constant Wife working with Ingrid Bergman.",
                            ProfilePictureURL = "https://resize-elle.ladmedia.fr/rcrop/638,,forcex/img/var/plain_site/storage/images/beaute/maquillage/maquillage-de-stars/people-elles-vieillissent-avec-grace/sigourney-weaver/23617214-1-fre-FR/Sigourney-Weaver.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Christopher Plummer",
                            Bio = "Christopher Plummer was born Arthur Christopher Orme Plummer on December 13, 1929 in Toronto, Ontario. ",
                            ProfilePictureURL = "https://cdn.britannica.com/05/197405-004-DD61C480/Christopher-Plummer-2012.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            MovieId = 3,
                            ActorId = 2
                        },
                        new Actor_Movie()
                        {
                            MovieId = 1,
                            ActorId = 1
                        }
                    });
                    context.SaveChanges();
                }
                //if (!context.Reviews.Any())
                //{
                //    context.Reviews.AddRange(new List<Review>()
                //    {
                //        new Review()
                //        {
                //            MovieId = 1,
                //            Text = "Ну крутяк вообще"
                //        }
                //    });
                //}

            }
        }

    }
}
