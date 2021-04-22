using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity<T> : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public BaseEntity()
        {
            CreateDate = DateTime.Now;
        }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {

    }
}
