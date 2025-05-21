namespace ProductManagementAPI.Models;

public class Category
{
    public int Id { get; set; }

    // null atanamaz uyarısı alıyorsan aşağıdaki gibi Required ekle
    public required string Name { get; set; }
}
