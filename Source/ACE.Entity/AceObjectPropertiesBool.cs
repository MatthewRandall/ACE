﻿using System;
using ACE.Common;
using MySql.Data.MySqlClient;
namespace ACE.Entity
{
    [DbTable("ace_object_properties_bool")]
    public class AceObjectPropertiesBool : BaseAceProperty, ICloneable
    {
        private bool? _value = false;
        
        [DbField("boolPropertyId", (int)MySqlDbType.UInt16, IsCriteria = true, Update = false)]
        public uint PropertyId { get; set; }

        [DbField("propertyIndex", (int)MySqlDbType.Byte, IsCriteria = true, Update = false)]
        public byte Index { get; set; } = 0;

        [DbField("propertyValue", (int)MySqlDbType.Bit)]

        public bool? PropertyValue
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                IsDirty = true;
            }
        }
        
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
