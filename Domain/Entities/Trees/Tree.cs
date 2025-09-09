using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Trees
{
    /// <summary>
    /// Tree entity
    /// </summary>
    public class Tree : BaseEntity
    {
        /// <summary>
        /// Tree name required field
        /// </summary>
        [Required]
        public required string Name { get; set; }

        /// <summary>
        /// Tree nodes collection
        /// </summary>
        public IList<TreeNode> Nodes { get; set; } = new List<TreeNode>();
    }
}