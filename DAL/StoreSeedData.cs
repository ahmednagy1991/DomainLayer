
using Service.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class StoreSeedData : DropCreateDatabaseIfModelChanges<StoreEntities>
    {
        protected override void Seed(StoreEntities context)
        {
            //GetCategories().ForEach(c => context.Categories.Add(c));
           

            context.Commit();
        }

        private static List<UserModel> GetCategories()
        {
            return new List<UserModel>
            {
                new UserModel {
                    Username="test1"
                },
                new UserModel {
                    Username = "test2"
                },
                new UserModel {
                    Username = "test3"
                }
            };
        }

       
    }
}
