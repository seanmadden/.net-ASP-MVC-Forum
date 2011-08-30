using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Forum.Models
{
    public class BoardInitializer : DropCreateDatabaseIfModelChanges<ForumDB>
    {

    }
}