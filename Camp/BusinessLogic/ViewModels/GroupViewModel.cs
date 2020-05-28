using BusinessLogic.Enums;
using System.ComponentModel;

namespace BusinessLogic.ViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public int? CounsellorId { get; set; }

        [DisplayName("Название")]
        public string Name { get; set; }

        [DisplayName("Вожатый")]
        public string CounsellorName { get; set; }        

        [DisplayName("Профиль")]
        public Profile Profile { get; set; }

        [DisplayName("Количество детей")]
        public Profile ChildrenCount { get; set; }



    }
}
