using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogBAL;

namespace BlogAssignment.Controllers
{
    public class TagManagerController : ApiController
    {
        [HttpGet]
        public IHttpActionResult UntagPost(string tag, int postId)
        {
            if (string.IsNullOrEmpty(tag))
            {
                throw new System.ArgumentNullException("Tag is empty");
            }
            if (postId == 0)
            {
                throw new System.ArgumentNullException("PostId is invalid");
            }
            else
            {
                int existTagId = TagManagerBAL.PostIsExists(postId);

                if (existTagId > 0)
                {
                    return Ok(TagManagerBAL.UntagPost(tag, postId));
                }
                else
                {
                    throw new System.ArgumentNullException("PostId is not exists");
                }
            }
            
        }
    }
}
