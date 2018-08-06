using System;
using System.Collections.Generic;
using System.Linq;

namespace Report.Fields
{
    public class FieldDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string SqlTableName { get; set; }
        public string SqlFieldName { get; set; }
        public bool IsOnDisplay { get; set; }

        public string Description { get; set; }
        public int FieldType { get; set; }
        public int PrimitiveType { get; set; }
        public int DataModelType { get; set; }
        public int ExtractionType { get; set; }

        public int DerivationFormulaType { get; set; }
        public string DerivedInputItems { get; set; }
        public string LinkedInput { get; set; }
        public string FieldOptions { get; set; }

        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

    public class FieldListDTO
    {
        public List<FieldDTO> Items { get; set; } = new List<FieldDTO>();
        public int Count { get => this.Items.Count; private set => value = Items?.Count() ?? 0; }
    }

    public class FieldInfoDTO
    {
        public string Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string SqlTableName { get; set; }
        public bool IsOnDisplay { get; set; }

        public int FieldType { get; set; }
        public string FieldTypeString { get; set; }

        public int DataModelType { get; set; }
        public string DataModelTypeString { get; set; }

        public int PrimitiveType { get; set; }
        public string PrimitiveTypeString { get; set; }
    }

    public class FieldInfoListDTO
    {
        public List<FieldInfoDTO> Items { get; set; } = new List<FieldInfoDTO>();
        public int Count { get => this.Items.Count; private set => value = Items?.Count() ?? 0; }
    }

    public class FieldPermissionsDTO
    {
        public bool IsIneHR { get; set; }
        public bool IsIneLink { get; set; }
        public bool IsInPayroll { get; set; }
    }

    public class FieldPermissionsListDTO
    {
        public List<FieldPermissionsDTO> Items { get; set; } = new List<FieldPermissionsDTO>();
        public int Count { get => this.Items.Count; private set => value = Items?.Count() ?? 0; }
    }
}
