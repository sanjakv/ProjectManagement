using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.DataAccessLayer.Entities
{
    public class ProjectEmployee
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;
        public bool IsProjectManager { get; set; } // Является ли сотрудник руководителем проекта
    }
}
