namespace Report.Fields.Ref
{
    public class FieldPermissions
    {
        public static FieldPermissionsDTO MapToDTO(FieldPermissions domain)
        {
            return new FieldPermissionsDTO();
        }

        public static FieldPermissions MapFromDTO(FieldPermissionsDTO dto)
        {
            return new FieldPermissions();
        }
    }
}
