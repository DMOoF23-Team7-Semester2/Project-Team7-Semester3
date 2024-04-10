using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rally.Application.Dto.Base;

namespace Rally.Application.Dto.EquipmentBase
{
    public class EquipmentBaseDto : BaseDto
    {
        public byte[] Image { get; set; } = new byte[0];

        public EquipmentBaseDto(byte[] image)
        {
            Image = image;
        }
    }
}