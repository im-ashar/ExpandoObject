dynamic obj = new System.Dynamic.ExpandoObject();
obj.Name = "ABC";
obj.Age = 19;
if (ExpandoObjectHelper.HasProperty(obj, "Name"))
{
    Console.WriteLine(obj.Name);
}
else
{
    Console.WriteLine("Not Found");
}


public static class ExpandoObjectHelper
{
    public static bool HasProperty(ExpandoObject? expandoObject, string? propertyName)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
        {
            return false;
        }
        if (expandoObject is not IDictionary<string, object> convertedObject)
        {
            return false;
        }
        return convertedObject.ContainsKey(propertyName);
    }
}
