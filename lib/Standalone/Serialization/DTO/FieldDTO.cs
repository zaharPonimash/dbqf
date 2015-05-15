﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using dbqf.Configuration;
using Standalone.Serialization.DTO.Display;

namespace Standalone.Serialization.DTO
{
    [ProtoContract]
    public class FieldDTO
    {
        #region IField

        //ISubject Parent - can be set by assembler

        [XmlAttribute("Source")]
        [ProtoMember(1)]
        public string SourceName { get; set; }

        [XmlElement("Type")]
        [ProtoMember(2)]
        public string DataTypeFullName { get; set; }

        [ProtoMember(3)]
        public string DisplayName { get; set; }

        [ProtoMember(4)]
        public string DisplayFormat { get; set; }

        [ProtoMember(5)]
        public FieldListDTO List { get; set; }

        #endregion

        #region IRelationField

        [System.ComponentModel.DefaultValue(-1)]
        [ProtoMember(6)]
        public int RelatedSubjectIndex { get; set; }

        [XmlElement("OutputType")]
        [ProtoMember(7)]
        public string OutputDataTypeFullName { get; set; }

        [XmlElement("OutputSource")]
        [ProtoMember(8)]
        public string OutputSourceName { get; set; }

        #endregion

        #region Standalone Properties

        [ProtoMember(9)]
        public List<ParserDTO> Parsers { get; set; }

        #endregion

        public FieldDTO()
        {
            RelatedSubjectIndex = -1;
            Parsers = new List<ParserDTO>();
        }
    }
}