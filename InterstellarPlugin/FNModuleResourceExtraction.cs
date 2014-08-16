extern alias ORSv1_1;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ORSv1_1::OpenResourceSystem;

namespace InterstellarPlugin
{
    [KSPModule("Resource Extractor")]
    class FNModuleResourceExtraction : ORSModuleResourceExtraction
    {
        public override void OnFixedUpdate()
        {
            base.OnFixedUpdate();
        }
    }
}
