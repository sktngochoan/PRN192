using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StudentManagement.Models
{
    public partial class student_managementContext : DbContext
    {
        public student_managementContext()
        {
        }

        public student_managementContext(DbContextOptions<student_managementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<GradeCategory> GradeCategories { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAttended> StudentAttendeds { get; set; }
        public virtual DbSet<StudentGrade> StudentGrades { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Week> Weeks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost; database=student_management;uid=sa;password=matma123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("class");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .HasColumnName("class_name");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__class__semester___398D8EEE");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grade");

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.GradeCategoryId).HasColumnName("grade_category_id");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(255)
                    .HasColumnName("grade_name");

                entity.HasOne(d => d.GradeCategory)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.GradeCategoryId)
                    .HasConstraintName("FK__grade__grade_cat__3A81B327");
            });

            modelBuilder.Entity<GradeCategory>(entity =>
            {
                entity.ToTable("grade_category");

                entity.Property(e => e.GradeCategoryId).HasColumnName("grade_category_id");

                entity.Property(e => e.GradeCategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("grade_category_name");
            });

            modelBuilder.Entity<Lecturer>(entity =>
            {
                entity.ToTable("lecturers");

                entity.Property(e => e.LecturerId).HasColumnName("lecturer_id");

                entity.Property(e => e.LecturerEmail)
                    .HasMaxLength(255)
                    .HasColumnName("lecturer_email");

                entity.Property(e => e.LecturerImg)
                    .HasMaxLength(255)
                    .HasColumnName("lecturer_img");

                entity.Property(e => e.LecturerName)
                    .HasMaxLength(255)
                    .HasColumnName("lecturer_name");

                entity.Property(e => e.LecturerPass)
                    .HasMaxLength(255)
                    .HasColumnName("lecturer_pass");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("room");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .HasColumnName("room_name");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("schedule");

                entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.Day)
                    .HasMaxLength(1)
                    .HasColumnName("day");

                entity.Property(e => e.LecturerId).HasColumnName("lecturer_id");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnType("date")
                    .HasColumnName("schedule_date");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.WeekId).HasColumnName("week_id");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__schedule__class___3B75D760");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.LecturerId)
                    .HasConstraintName("FK__schedule__lectur__3C69FB99");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK__schedule__room_i__3D5E1FD2");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK__schedule__slot_i__3E52440B");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__schedule__subjec__5AEE82B9");

                entity.HasOne(d => d.Week)
                    .WithMany(p => p.Schedules)
                    .HasForeignKey(d => d.WeekId)
                    .HasConstraintName("FK__schedule__week_i__73BA3083");
            });

            modelBuilder.Entity<Semester>(entity =>
            {
                entity.ToTable("semester");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(255)
                    .HasColumnName("semester_name");
            });

            modelBuilder.Entity<Slot>(entity =>
            {
                entity.ToTable("slot");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.SlotTime)
                    .HasMaxLength(50)
                    .HasColumnName("slot_time");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.StudentAddress)
                    .HasMaxLength(255)
                    .HasColumnName("student_address");

                entity.Property(e => e.StudentBofd)
                    .HasColumnType("date")
                    .HasColumnName("student_bofd");

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(50)
                    .HasColumnName("student_code");

                entity.Property(e => e.StudentEmail)
                    .HasMaxLength(255)
                    .HasColumnName("student_email");

                entity.Property(e => e.StudentGender).HasColumnName("student_gender");

                entity.Property(e => e.StudentImg)
                    .HasMaxLength(255)
                    .HasColumnName("student_img");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(255)
                    .HasColumnName("student_name");

                entity.Property(e => e.StudentPass)
                    .HasMaxLength(255)
                    .HasColumnName("student_pass");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__student__class_i__3F466844");
            });

            modelBuilder.Entity<StudentAttended>(entity =>
            {
                entity.ToTable("student_attended");

                entity.Property(e => e.StudentAttendedId).HasColumnName("student_attended_id");

                entity.Property(e => e.ScheduleId).HasColumnName("schedule_id");

                entity.Property(e => e.StudentAttendedDate)
                    .HasColumnType("date")
                    .HasColumnName("student_attended_date");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.StudentStatus).HasColumnName("student_status");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.StudentAttendeds)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK__student_a__sched__403A8C7D");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentAttendeds)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__student_a__stude__412EB0B6");
            });

            modelBuilder.Entity<StudentGrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student_grade");

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.StudentId).HasColumnName("student_id");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.HasOne(d => d.Grade)
                    .WithMany()
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK__student_g__grade__4222D4EF");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__student_g__stude__4316F928");

                entity.HasOne(d => d.Subject)
                    .WithMany()
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__student_g__subje__440B1D61");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("subject");

                entity.Property(e => e.SubjectId).HasColumnName("subject_id");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.LecturerId).HasColumnName("lecturer_id");

                entity.Property(e => e.SemesterId).HasColumnName("semester_id");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(255)
                    .HasColumnName("subject_code");

                entity.Property(e => e.SubjectName)
                    .HasMaxLength(255)
                    .HasColumnName("subject_name");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__subject__class_i__44FF419A");

                entity.HasOne(d => d.Lecturer)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.LecturerId)
                    .HasConstraintName("FK__subject__lecture__38996AB5");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK__subject__semeste__45F365D3");
            });

            modelBuilder.Entity<Week>(entity =>
            {
                entity.ToTable("week");

                entity.Property(e => e.WeekId).HasColumnName("week_id");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.WeekDate)
                    .HasMaxLength(255)
                    .HasColumnName("week_date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
