using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace timw255.Sitefinity.SuperForms
{
    [DataContract]
    internal class CriteriaItem
    {
        [DataMember(Name = "field")]
        public string Field { get; set; }

        [DataMember(Name = "fieldName", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public string Condition { get; set; }

        [DataMember(Name = "option", EmitDefaultValue = false)]
        public string Option { get; set; }
    }
}