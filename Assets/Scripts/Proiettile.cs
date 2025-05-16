public abstract class Proiettile
{
    private float speed;

    public abstract void Lancia();

    public float GetSpeed() => speed;
    public void SetSpeed(float speed) => this.speed = speed;
  
}
