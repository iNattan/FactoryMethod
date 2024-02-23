public class TelaWeb : TelaMensagem{
    public override IBotao CriarBotao(){
        return new BotaoWeb();
    }

    public override ICampoTxt CriarCampoTxt(){
        return new CampoTxtWeb();
    }
}