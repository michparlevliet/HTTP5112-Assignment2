using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HTTP5112_Assignment2_MichelleParlevliet.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}