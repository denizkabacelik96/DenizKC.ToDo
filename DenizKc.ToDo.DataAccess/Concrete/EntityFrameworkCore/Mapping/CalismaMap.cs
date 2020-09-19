﻿using DenizKC.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DenizKc.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CalismaMap : IEntityTypeConfiguration<Calisma>
    {
        public void Configure(EntityTypeBuilder<Calisma> builder)
        {
            builder.HasKey(I=>I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Ad).HasMaxLength(200);
            builder.Property(I => I.Aciklama).HasColumnType("ntext");
        }
    }
}
