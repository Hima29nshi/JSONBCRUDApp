using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JSONBCRUDApp.Models
{
    public class DataModel
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="jsonb")]
        public Sample? Data { get; set; }  
    }

    public class Sample
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
