using FluentValidator;
using FluentValidator.Validation;

namespace Loca.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome não pode conter menos de 3 caracteres")
                .HasMaxLen(FirstName, 30, "Name.FirstName", "Nome não pode conter mais de 30 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome não pode conter menos de 3 caracteres")
                .HasMaxLen(LastName, 40, "Name.LasName", "Sobrenome não pode conter mais de 40 caracteres")
            );
        }
    }
}
