using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        const string RootGroup = "<Root>";
        const string Photo = RootGroup + "/" + "<Photo->";
        const string FirstNameAndLastName = Photo + "/" + "<FirstAndLastName>";
        const string TabbedGroup = FirstNameAndLastName + "/" + "{Tabs}";
        const string ContactGroup = TabbedGroup + "/" + "Contact";
        const string BDateAndGender = ContactGroup + "/" + "<BDateAndGender->";
        const string HomeAddressAndPhone = ContactGroup + "/" + "<HomeAddressAndPhone->";
        const string EmailAndSkype = ContactGroup + "/" + "<EmailAndSkype->";
        


        public User() { }
        [Display(Name = "Họ và tên", GroupName = FirstNameAndLastName, Order = 2)]
        public string Name { get; set; }
        [Display(Name = "Giới tính", GroupName = BDateAndGender)]
        public string Sex { get; set; }
        [Display(Name = "Ngày sinh", GroupName = BDateAndGender, Order = 3)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Số CMND", GroupName = BDateAndGender, Order = 4)]
        public string MId { get; set; }
        [Display(Name = "E-Mail", GroupName = EmailAndSkype, Order = 5)]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại", GroupName = HomeAddressAndPhone)]
        public string PhoneNum { get; set; }
        [Display(AutoGenerateField = false)]
        public int IDFunc { get; set; }
        [Display(Name = "Chức vụ")]
        public string Funtion { get; set; }
        [Display(Name = "Tên tài khoản")]
        public string Username { get; set; }
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }
        [Key, Display(AutoGenerateField = false)]
        public int ID { get; set; }

    }
}
