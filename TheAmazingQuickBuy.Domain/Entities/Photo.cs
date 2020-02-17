using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace TheAmazingQuickBuy.Domain.Entities
{
    public class Photo : EntityBase
    {
        public string FileName { get; set; }

        [NotMapped]
        public virtual Stream BinaryContent { get; set; }
        public string ContentType { get; set; }
        public override void Validate()
        {
            if(BinaryContent == null)
            {
                AddMessage("A Foto não pode estar vazia !");
            }
        }
    }
}
