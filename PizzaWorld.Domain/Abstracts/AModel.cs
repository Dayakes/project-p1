namespace PizzaWorld.Domain.Abstracts
{
    public abstract class AModel
    {
        public long EntityId { get; set; }
        public AModel()
        {
            EntityId = System.DateTime.Now.Ticks;
        }
    }
}