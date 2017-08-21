using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ProjectOxford.Vision.Contract;

namespace LiveCameraSample
{
    public class CelebritiesResult
    {
        public Celebrity[] Celebrities { get; set; }
    }

    public class Celebrity
    {
        public string Name { get; set; }
        public FaceRectangle FaceRectangle { get; set; }
        public float Confidence { get; set; }
    }
}
