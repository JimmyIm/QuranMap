namespace Tests.SharpArch.Domain.Commands
{
    using System.ComponentModel.DataAnnotations;

    using global::Framework.Core.Domain.Commands;

    public class ValidCommand : CommandBase
    {
        public ValidCommand()
        {
            Valid = true;
        }

        [Required]
        public bool? Valid { get; set; }
    }
}