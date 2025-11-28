namespace SmartSaverFront.Models
{
    public record Tx(DateTime Date, string Type, string Description, decimal Amount);
    public record Goal(string Name, decimal Target, decimal Current);
}
