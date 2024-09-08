using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace carserver.models
{
    public class PaimentDetails
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "float")]
        public float Base_price { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Type { get; set;} = "";
        [Column(TypeName = "float")]
        public float Base_Coast { get; set;} 
        [Column(TypeName = "float")]
        public float Special_Coast  { get; set;} 
        [Column(TypeName = "float")]
        public float Association_Cost { get; set;} 
        [Column(TypeName = "float")]
        public float Fixed_cost  { get; set;}
        [Column(TypeName = "float")]
        public float Custom_cost { get; set; }
        [Column(TypeName = "float")]
        public float Total_price  { get; set;} 
        [Column(TypeName = "nvarchar(100)")]
        public string Buy_date   { get; set;} = "";

    }
}
