public class TelaWindows : TelaMensagem{
    public override IBotao CriarBotao(){
        return new BotaoWindows();
    }
    public override ICampoTxt CriarCampoTxt(){
        return new CampoTxtWindows();
    }
}