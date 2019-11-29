using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PlaylistAPI.Models.DataManager
{
    public class DBSeeder
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {

            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<PlaylistContext>();

                using (context)
                {
                    context.Database.Migrate();

                    if (!context.Playlists.Any())
                    {
                        var playlists = new List<Playlist>()
                        {
                            new Playlist(){
                                Artist = "Portugal The Man",
                                Song = "Feel It Still"
                            }
                        };


                        context.Playlists.AddRange(playlists);
                        context.SaveChanges();
                    }
                }
            }

        }
    }
}
