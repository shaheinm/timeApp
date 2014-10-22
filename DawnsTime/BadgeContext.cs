using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace DawnsTime
{
    [PetaPoco.TableName("IeTime")]
    [PetaPoco.PrimaryKey("Id")]
    public partial class Time
    {
        [PetaPoco.Column("Id")]
        public Int64 Id { get; set; }
        [PetaPoco.Column("Name")]
        public String Name { get; set; }
        [PetaPoco.Column("Date")]
        public String Date { get; set; }
        [PetaPoco.Column("Project")]
        public String Project { get; set; }
        [PetaPoco.Column("Hours")]
        public Int32 Hours { get; set; }
        [PetaPoco.Column("Description")]
        public String Description { get; set; }
    }

    public class BadgeContext
    {
        internal IList<Time> Get(int top, int from, string filter)
        {
            // TODO: acknowledge parameter values.
            String sql = "select * from IeTime order by Id";
            return BadgeContext.GetDatabase().Query<Time>(sql).ToList();
        }

        public Time GetById(int id)
        {
            String sql = "select * from IeTime where Id =" + id.ToString();
            return BadgeContext.GetDatabase().FirstOrDefault<Time>(sql);
        }

        public void Add(Time badge)
        {
            BadgeContext.GetDatabase().Insert(badge);
        }

        internal void update(Time badge)
        {
            BadgeContext.GetDatabase().Update(badge);
        }
        internal void delete(Time badge)
        {
            BadgeContext.GetDatabase().Delete(badge);
        }

        private static PetaPoco.Database GetDatabase()
        {
            String conStr = @"data source=SMOUSSAVI;database=time;Trusted_Connection=yes;";
            PetaPoco.Database db = new PetaPoco.Database(conStr, "System.Data.SqlClient");
            return db;
        }
    }
}