﻿using RayPI.Entity;
using RayPI.IRepository;


namespace RayPI.SqlSugarRepository.Repository
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(MySqlSugarClient sugarClient) : base(sugarClient)
        {

        }
    }
}
