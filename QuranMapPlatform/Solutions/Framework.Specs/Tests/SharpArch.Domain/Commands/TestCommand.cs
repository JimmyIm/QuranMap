namespace Tests.SharpArch.Domain.Commands
{
    using global::Framework.Core.Domain.Commands;

    public class TestCommand : CommandBase
    {
        public string Data { get; set; }
    }
}