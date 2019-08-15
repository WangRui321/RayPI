﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RayPI.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RayPI.EntityFrameworkRepository.DbMapping
{
    public class StudentConfig : EntityBaseTypeConfig<StudentEntity>
    {
        public override void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            //表名
            builder.ToTable("Student");

            //字段
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();

            //基础字段
            base.Configure(builder);
        }
    }
}