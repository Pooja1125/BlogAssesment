using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDAL;

namespace BlogBAL
{
    public static class TagManagerBAL
    {
        public static bool UntagPost(string tag, int postId)
        {
            return TagManagerDAL.UntagPost(tag, postId);
        }
        public static int PostIsExists(int postId)
        {
            return TagManagerDAL.PostIsExists(postId);
        }
    }
}
