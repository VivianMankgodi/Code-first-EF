using DVT.SchoolLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVT.SchoolLibrary.Repositories
{//here we must inherite the Generic Repository and in this Learner Repo we can add more methods that are only used by Learner becuase we want to use Learner class inside the Repository<T> we replace it with Learner object
 public    class LearnerRepo: Repository<Learner>
    {

    }
}
