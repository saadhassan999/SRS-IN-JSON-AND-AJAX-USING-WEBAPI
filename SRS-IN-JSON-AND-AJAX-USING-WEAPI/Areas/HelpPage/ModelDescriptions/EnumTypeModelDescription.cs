using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SRS_IN_JSON_AND_AJAX_USING_WEAPI.Areas.HelpPage.ModelDescriptions
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