using OlaMundo.Service;

namespace OlaMundoTeste;

public class OlaMundoTest
{
    private OlaMundoMenssagem _mensagem;

    public OlaMundoTest()
    {
        _mensagem = new OlaMundoMenssagem();
    }
    
    [Fact]
    public void DeveExibirOlaMundo()
    {
        //Arrange
        string resposta;
        //Act
        resposta = _mensagem.ExibirMensagem();
        //Assert
        Assert.Equal("Olá, Mundo!", resposta);
    }
}