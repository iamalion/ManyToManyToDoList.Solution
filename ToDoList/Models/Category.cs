
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
  public class Category
  {
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public List<Item> Items { get; set; }
  }
}