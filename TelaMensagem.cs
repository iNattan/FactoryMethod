public abstract class TelaMensagem{
    public abstract IBotao CriarBotao();
    public abstract ICampoTxt CriarCampoTxt();

    public void Mostrar(){
        var botao = CriarBotao();
        var campoTxt = CriarCampoTxt();
        Console.WriteLine(botao.Mostrar());
        Console.WriteLine(campoTxt.Mostrar());
    }
}