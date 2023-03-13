namespace DACN_CarCare.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Book")]
    public partial class Book
    {
        private static string a;

        public int id { get; set; }

        public int? maxe { get; set; }

        
        [StringLength(100, ErrorMessage = "Ký tự tối đa là 100")]
        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        public string tenKH { get; set; }

        [StringLength(11,ErrorMessage = "Ký tự tối đa là 11")]
        
        public string sdt { get; set; }

        [StringLength(50)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]

        public string email { get; set; }

        public string ghichu { get; set; }

        public DateTime? ngay { get; set; }

        public virtual Loai Loai { get; set; }
        internal static List<Book> GetAll1()
        {
            Booking context = new Booking();

            return context.Books.ToList();
        }
        public void Insert()
        {
            Booking context = new Booking();
            try
            {
                context.Books.Add(this);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal static Book FindBookById(int id)
        {
            Booking context = new Booking();
            return context.Books.FirstOrDefault(p => p.id == id);
        }


        public void Update()
        {
            Booking context = new Booking();
            try
            {
                Book find = context.Books.FirstOrDefault(p => p.id == id);
                if (find != null)
                {
                    find.tenKH = this.tenKH;
                    find.sdt = this.sdt;
                    find.email = this.email;
                    find.ghichu = this.ghichu;
                    find.ngay = this.ngay;
                    find.maxe = this.maxe;
                    //c2
                    context.SaveChanges();

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static void Removee(int id)
        {
            Booking context = new Booking();
            try
            {
                Book find = context.Books.FirstOrDefault(p => p.id == id);
                if (find != null)
                {
                    context.Books.Remove(find);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal static object GetAll2(string a)
        {
            Booking ct = new Booking();
            return ct.Books.Where(p => p.email == a).ToList();
        }

        
    }
}
