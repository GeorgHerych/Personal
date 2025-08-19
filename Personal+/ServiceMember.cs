using System;
using System.ComponentModel.DataAnnotations;

namespace Personal_
{
    /// <summary>
    /// Represents a basic record about a service member. This is a minimal
    /// model used for demonstrating how data could be stored.
    /// It can be extended with additional fields as needed.
    /// </summary>
    public class ServiceMember
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Military rank.
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// Full name (ПІБ).
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Type of movement (тип руху).
        /// </summary>
        public string MovementType { get; set; }
    }
}
