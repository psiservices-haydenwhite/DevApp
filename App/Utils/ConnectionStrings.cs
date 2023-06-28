namespace Insight.Database
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class DatabaseServiceAttribute : Attribute
    {
        public string ConnectionStringName { get; }

        public DatabaseServiceAttribute(string connectionStringName)
        {
            ConnectionStringName = connectionStringName;
        }
    }
}