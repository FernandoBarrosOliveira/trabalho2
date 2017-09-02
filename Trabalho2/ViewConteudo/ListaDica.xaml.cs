using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Trabalho2.Classes;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Trabalho2.ViewConteudo
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class ListaDica : Page
    {

        public static ListaDica PageListAnotacao;

        private ObservableCollection<Dica> listagemDica = new ObservableCollection<Dica>();
        ObservableCollection<Dica> ListagemDica { get { return this.listagemDica; } }
        

        public ListaDica()
        {
            PageListAnotacao = this;
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            criaLista();

        }

        private void criaLista()
        {
            listagemDica.Add(new Dica("1. SIGA O MAPA DE SALA", "Dependendo da série em que você estiver e até mesmo da quantidade de alunos na sala, os professores acham que a melhor maneira de controlar e favorecer o aprendizado de todos é por meio de um mapa que indica onde cada estudante deve se sentar. Se esse for o seu caso, siga o mapa. Os seus professores têm um motivo para querer você sentado em determinado lugar e não em outro."));
            listagemDica.Add(new Dica("2. MANTENHA UMA AGENDA", "Você pode se orgulhar da memória mais eficiente da sala, mas ainda assim não é um computador e pode deixar algo passar. Para evitar perder datas de provas ou prazos de entrega de trabalhos, mantenha uma agenda e anote nela todos os seus compromissos relacionados ao colégio."));
            listagemDica.Add(new Dica("3. TENHA FOCO", "Pode parecer óbvio pedir a um aluno que ele mantenha o foco, mas muitas vezes os estudantes simplesmente não sabem como fazer isso. Para evitar distrações, evite ficar olhando para a janela, para a porta ou mesmo para o que seus colegas estão fazendo. Concentre-se nas suas tarefas."));
            listagemDica.Add(new Dica("4. SEJA SÉRIO", "Leve os seus estudos a sério. Tenha em mente que você está na escola por um motivo e que esse motivo é aprender. Não invente mentiras para faltar ou mesmo para escapar das aulas, como se fingir de doente ou dizer ao professor que precisa urgentemente ir ao banheiro."));
            listagemDica.Add(new Dica("5. QUESTIONE", "Nunca vá para casa com uma dúvida. Se você não está entendendo algo relacionado à matéria, pergunte. Nunca considere uma dúvida como sem importância. Lembre-se de que por mais boba que uma pergunta pareça, ela pode ser a dúvida de outros colegas de sala."));
            listagemDica.Add(new Dica("6. SEJA RESPEITOSO", "Evite interromper os professores ou colegas e quando quiser fazer alguma pergunta ou observação, levante a mão antes de fazê-lo. É claro que você tem direito de se expressar em sala de aula, mas procure respeitar os outros estudantes, eles também têm esse direito."));
            listagemDica.Add(new Dica("7. SEJA CONSCIENTE", "A sala de aula não foi criada para que os estudantes vivam uma espécie de regime militar, no qual os alunos estão proibidos de conversar ou sequer olhar pro lado. No entanto, você também não deve aproveitar a liberdade que tem e passar a aula inteira rindo, conversando e se virando para trás ou para os lados. Isso atrapalha a concentração do seu professor e dos seus colegas."));
            listagemDica.Add(new Dica("8. COPIE A MATÉRIA", "Pode parecer a dica mais óbvia de todos os tempos, mas se o professor está escrevendo a matéria no quadro, provavelmente ela não está presente nos livros de referência que vocês utilizam em sala. Não perca tempo com as famosas perguntas do tipo “é para copiar?”. Pense que se não houvesse essa necessidade o seu professor não perderia tempo colocando essas informações no quadro."));
            listagemDica.Add(new Dica("9. PRESTE ATENÇÃO", "Outra dica aparentemente desnecessária, mas que é seguida por pouquíssimos alunos. A explicação do professor é o momento que você tem para compreender melhor os conceitos abordados no material de estudo e sanar as suas dúvidas. Portanto, essa não é a melhor hora para desenhar, rabiscar o caderno dos amigos ou mandar bilhetinhos."));
            listagemDica.Add(new Dica("10. NÃO COLE", "Embora aquele velho ditado assegure que “quem não cola não sai da escola”, procure fazer diferente. Colando você não absorve o conteúdo e ainda corre o risco de ser pego e se envolver em situações, no mínimo, complicadas."));
            listagemDica.Add(new Dica("11. NÃO DISCUTA", "Você pode ter a certeza absoluta de que o seu professor está enganado no que está afirmando, mas se você não tiver argumentos que provem isso, fique quieto. Se não tiver razão, então, faça uso do silêncio. Discutir com o professor nunca traz nada de positivo para você."));
            listagemDica.Add(new Dica("12. NÃO CONVERSE COM PESSOAS DE FORA DURANTE A AULA", "Ninguém disse que você precisa fazer amizade apenas com os colegas da sua sala, ou do seu ano. Você pode ter amigos em séries diferentes e os horários de vocês provavelmente não vão coincidir. Portanto, evite conversar com esses colegas durante o período de aulas, quando você os encontra no corredor, por exemplo."));
            listagemDica.Add(new Dica("13. FAÇA OS SEUS DEVERES", "Pode parecer chato e sem utilidade, mas os deveres de casa têm como objetivo fixar o conteúdo estudado durante a aula. Portanto, leve-os a sério. Fazer as suas tarefas de qualquer jeito não vai ajudar você a entender a matéria estudada e você pode sentir falta disso na hora da prova."));
            listagemDica.Add(new Dica("14. EVITE SAIR DURANTE A EXPLICAÇÃO", "A não ser que seja um caso muito urgente, como você estar passando mal, evite sair da sala durante as explicações do professor. Embora possa parecer muito entediante escutar o professor de história falar sobre as inquisições na Idade Média, esse tipo de conteúdo será cobrado de você depois, então é melhor que você não perca os detalhes sobre ele."));
            listagemDica.Add(new Dica("15. NÃO FAÇA BRINCADEIRAS COM O SEU PROFESSOR", "Alguns professores são muito divertidos e dão muita liberdade aos seus alunos, mas não se aproveite disso para atrapalhar a aula. Ficar se levantando o tempo todo para fazer brincadeiras ou mesmo indo até a lixeira sem necessidade são atitudes que podem deixar o seu professor irritado e acabar com a liberdade conquistada."));
            listagemDica.Add(new Dica(" 16. NÃO SEJA UM ALUNO APÁTICO", "Embora os professores não gostem daqueles alunos que conversam demais, atrapalham a aula e a concentração dos outros estudantes, eles também não esperam alunos silenciosos, que não se expressam e não participam da aula. Você pode conversar com os seus colegas, desde que seja sobre assuntos relacionados."));
            listagemDica.Add(new Dica("17. ESTUDE EM SALA", "Os exercícios pedidos pelos professores em sala de aula devem ser feitos lá. Não fique enrolando e esperando apenas pela correção, dedique-se, tente resolver os problemas propostos e conte com a ajuda do seu professor. Da mesma maneira, leve a sério a correção."));
            listagemDica.Add(new Dica("18. NÃO PERCA A MATÉRIA", "A frequência é importante para que você passe de ano, mas é claro que você precisará faltar em alguns dias. Quando isso acontecer, peça a algum colega de confiança que passe para você a matéria estudada naquele dia. Anote os deveres e copie a matéria, caso seja necessário."));
            listagemDica.Add(new Dica("19. SEJA RESPEITOSO", "Você pode detestar o professor de determinada matéria, mas precisa saber que ele é a figura de autoridade dentro da sala e, portanto, merece o seu respeito. Não grite ou fale palavrões em sala, isso transforma o ambiente de maneira negativa."));
            listagemDica.Add(new Dica("20. ESTUDE PARA AS PROVAS", "Você pode ser um excelente aluno, que realiza todas as tarefas e presta atenção em todas as explicações, mas se não estudar para as provas não terá como aplicar os seus conhecimentos. Dedique-se e crie planos de estudo que ajudem você a resumir a matéria necessária."));
        }

   
        private void ListViewAnotacao_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DicaPage), listagemDica[(sender as ListView).SelectedIndex]);
        }
    }

    
}
