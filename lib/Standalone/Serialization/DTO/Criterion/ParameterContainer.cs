﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbqf.Criterion;
using ProtoBuf;
using System.Xml.Serialization;

namespace Standalone.Serialization.DTO.Criterion
{
    [ProtoContract]
    public class ParameterContainer
    {
        /// <summary>
        /// Gets or sets the project path that produced this parameter.  
        /// TODO: change to better identification mechanism.
        /// </summary>
        [XmlElement]
        [ProtoMember(1)]
        public string ProjectFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating what search type was used
        /// to create this parameter (e.g. Preset, Standard, Advanced).
        /// </summary>
        [XmlAttribute("Type")]
        [ProtoMember(2)]
        public string SearchType { get; set; }

        /// <summary>
        /// Gets or sets the subject index to use for fetching output.
        /// </summary>
        [XmlAttribute("Subject")]
        [ProtoMember(3)]
        public int SubjectIndex { get; set; }

        /// <summary>
        /// Gets or sets the parameter to limit the result set.
        /// </summary>
        [XmlElement]
        [ProtoMember(4)]
        public ParameterDTO Parameter { get; set; }

        /// <summary>
        /// Gets or sets the list of fields to use for custom output.
        /// </summary>
        [XmlArray]
        [ProtoMember(5)]
        public List<FieldPathDTO> Outputs { get; set; }
    }
}
