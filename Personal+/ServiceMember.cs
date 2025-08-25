using System;
using System.ComponentModel.DataAnnotations;

namespace Personal_
{
    /// <summary>
    /// Represents a basic record about a service member. This model mirrors
    /// the columns displayed on the KTVP form and can be extended with
    /// additional fields as needed.
    /// </summary>
    public class ServiceMember
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Position held by the service member.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Military rank.
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// Last name (Прізвище).
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// First name (Ім'я).
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Middle name (По батькові).
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Type of movement (тип руху).
        /// </summary>
        public string MovementType { get; set; }
    }
}
