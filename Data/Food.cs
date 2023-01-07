namespace VisualStudioCode.Data;

public class Food
{
  public int Id { get; set; }

  public string Name { get; set; }

  public string Description { get; set; }

  public decimal Price { get; set; }

}

public class FoodService
{
  public Task<Food[]> GetFoodAsync()
  {
    var listOfFood = new Food[10];
    for (int i = 0; i < 10; i++)
    {
      listOfFood[i] = new Food();
      listOfFood[i].Name = "TestFood " + i;
      listOfFood[i].Price = i + 10;
    }

    return Task.FromResult(listOfFood);
  }
}