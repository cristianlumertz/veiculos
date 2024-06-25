public class Moto : Veiculo
{
    public override void Acelerar()
    {
        velocidade = velocidade + 15;
        Console.WriteLine("Moto acelerando");
    }
    public override void Frear()
    {
        velocidade = velocidade - 10;
        Console.WriteLine("Moto freando");
    }
    public void ExibirVelocidade()
    {
        Console.WriteLine($"A velocidade do moto e: {velocidade}");
    }
}