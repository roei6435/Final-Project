using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    internal class ReviewsList
    {
        private List<Reviews> listR;

        public ReviewsList(List<Reviews> listR)
        {
            this.listR = listR;
        }

        public Reviews findPersonById(string reviewId)
        {
            foreach (Reviews r in listR)
            {
                if (r.IdReviews == reviewId)
                    return r;
            }
            return null;
        }
    }
}
