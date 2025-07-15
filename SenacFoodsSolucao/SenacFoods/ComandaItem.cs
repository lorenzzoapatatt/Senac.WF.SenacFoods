using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SenacFoods;
//Botar ponto e virgula no final deixa sem as chaves

public class ComandaItem
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CardapioItemId { get; set; }
    public int ComandaId { get; set; }

}
