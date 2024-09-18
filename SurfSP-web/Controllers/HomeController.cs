using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SurfSP_web.Models;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SurfSP_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Praias()
        {
            List<Praias> listaDePraias = new List<Praias>
            {
                new Praias 
                {
                    idPraia = 1,
                    nomePraia = "Ubatuba",
                    descricaoPraia = "Um destino imperd�vel para surfistas de todos os n�veis � Praia Grande, em Ubatuba." +
                                    "� reconhecido por suas ondas consistentes e acess�veis. � uma excelente �rea para surfe," +
                                    "principalmente de setembro a fevereiro, quando as ondas s�o mais suaves e ideais para " +
                                    "iniciantes e intermedi�rios.  Al�m de ser um local popular para o surf, a Praia Grande tamb�m " +
                                    "� conhecida por sua atmosfera animada e paisagens de tirar o f�lego, o que a torna uma das praias " +
                                    "mais populares de Ubatuba. Ideal para exerc�cios como caminhadas e corridas na areia, � tamb�m um �timo " +
                                    "lugar para desfrutar e admirar o sol.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 2,
                    nomePraia = "Caraguatatuba",
                    descricaoPraia = "Conhecida por suas ondas longas e desafiadoras, a Praia de Massagua�u, em Caraguatatuba, �" +
                                    "um verdadeiro para�so para surfistas avan�ados e intermedi�rios. Para manobras radicais, �"+
                                    "ideal ter �guas agitadas e ondula��es consistentes, especialmente de junho a novembro. A"+
                                    "ampla praia garante espa�o suficiente para surfistas e banhistas, enquanto a infraestrutura"+
                                    "do entorno, que oferece restaurantes, bares e caf�s, oferece conforto e comodidade. Al�m disso,"+
                                    "Massagua�u encanta com suas belezas naturais, oferecendo vistas panor�micas do mar e das"+
                                    "montanhas, sendo o local ideal para caminhadas e relaxamento ap�s o surf.O f�cil acesso e a"+
                                    "proximidade facilitam a chegada.Prepare - se para uma deliciosa refei��o e aproveite as ondas"+
                                    "poderosas em um dos melhores spots do litoral norte de S�o Paulo!",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 3,
                    nomePraia = "Ihabela",
                    descricaoPraia = "Para surfistas em busca de ondas desafiadoras e um ambiente abrangente, a Praia do Bonete, em Ilhabela,"+
                                    "� uma op��o imperd�vel.Praia Bonete � reconhecida por suas ondas fortes e tubulares, sendo uma das"+
                                    "melhores praias para surfe na regi�o. Os meses de inverno e primavera, que v�o de junho a novembro, s�o"+
                                    "ideais para surfistas avan�ados e intermedi�rios.A comunidade cai�ara tradicional e uma natureza exuberante"+
                                    "circunda a Praia do Bonete, que � acess�vel por trilha ou barco.� uma experi�ncia �nica. Bonete adora a"+
                                    "beleza natural da regi�o, que inclui praias pr�ximas e pontos de interesse interessantes para explorar.Depois"+
                                    "de um dia intenso de surf, a tranquilidade e o isolamento da praia fazem dela o local ideal para descontrair e"+
                                    "reencontrar - se com a natureza."
                    ,
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 4,
                    nomePraia = "S�o Sebasti�o",
                    descricaoPraia = "Conhecida por suas ondas consistentes e desafiadoras, a Praia de Maresias, em S�o Sebasti�o, � um dos destinos"+
                                    "mais famosos para surfistas do Brasil.Os meses de outono e inverno, de mar�o a agosto, oferecem excelentes condi��es"+
                                    "para surfistas, principalmente avan�ados e intermedi�rios, pois as ondas s�o mais frequentes e as ondas alcan�am seu"+
                                    "melhor potencial. Maresias oferece uma vasta variedade de quiosques, bares, restaurantes e seguran�a, al�m de"+
                                    "uma infraestrutura completa que o torna um local confort�vel e conveniente para passar o dia.Possui um ambiente"+
                                    "natural de tirar o f�lego com vistas panor�micas do oceano e das montanhas circundantes.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 5,
                    nomePraia = "Bertioga",
                    descricaoPraia = "Para surfistas que procuram ondas consistentes e um ambiente tranquilo, a Praia de Guaratuba em Bertioga � um"+
                                    "destino ideal. Uma escolha popular para surfistas de todos os n�veis, Guaratuba � conhecida por suas ondas longas"+
                                    "e bem formadas. As ondas frequentes e fortes ocorrem durante os meses de inverno e primavera, junho a novembro, oferecendo"+
                                    "oportunidades ideais para praticar o surfe. A praia se destaca pelo ambiente natural bem preservado, extensos recifes e �guas"+
                                    "limpas, proporcionando muito espa�o para os surfistas. Prepare sua prancha de surf e venha explorar as ondas constantes e"+
                                    "o clima tranquilo da Praia de Guaratuba, um dos melhores spots de surf de Bertioga!"
                    ,
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 6,
                    nomePraia = "Guaruj�",
                    descricaoPraia =  "Um dos destinos mais conhecidos para surfistas na regi�o � a Praia de Pitangueiras, do Guaruj�, porque oferece"+
                                    "condi��es adequadas e um ambiente animado. Reconhecida por suas ondas constantes e variadas, Pitangueiras"+
                                    "oferece oportunidades tanto para surfistas iniciantes quanto experientes.As ondas provocadas pelas ondula��es"+
                                    "do sul durante os meses de outono e inverno, ao longo de mar�o a agosto, oferecem condi��es ideais para o surfe,"+
                                    "com ondas mais desafiadoras e tubulares. A proximidade com o centro do Guaruj� tamb�m facilita o acesso a servi�os"+
                                    "e comodidades adicionais.Al�m do surf, Pitangueiras � conhecida por seu ambiente animado e atividades de lazer"+
                                    "como passeios de barco, nata��o e caminhadas na praia." ,
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 7,
                    nomePraia = "Santos",
                    descricaoPraia = "Um dos principais pontos de surf da Baixada Santista � a Praia de Gonzaga, em Santos. � conhecido por suas ondas"+
                                    "consistentes e atmosfera urbana animada. Gonzaga oferece condi��es ideais para surfar ao longo do ano, com ondas"+
                                    "que oferecem oportunidades �timas para surfistas de todos os n�veis. Particularmente nos meses de janeiro a novembro,"+
                                    "que se chamam de primavera e inverno, as ondas t�m uma tend�ncia a ser mais intensas, sendo ideais para quem procura"+
                                    "desafios mais elevados. O cal�ad�o Gonzaga � ideal para corridas e caminhadas, possuindo vistas deslumbrantes do"+
                                    "oceano e um ambiente descontra�do para descomprimir sem rigor ap�s uma sess�o de surf.",

                imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 8,
                    nomePraia = "S�o Vicente",
                    descricaoPraia = "Surfistas buscando ondas consistentes e um ambiente acolhedor frequentam a Praia de Itarar�, em S�o Vicente."+
                                    "Itarar�, reconhecida por suas excelentes condi��es de surf ao longo do ano, fornece diversos picos.As ondula��es"+
                                    "do sul t�m swells que t�m excelentes oportunidades para surfar, com ondas mais desafiadoras e tubulares, durante"+
                                    "os meses de outono e inverno, de mar�o a agosto. A praia possui uma variedade de restaurantes, bares e op��es de"+
                                    "hospedagem pr�ximas, garantindo conforto e conviv�ncia aos visitantes por meio de uma infraestrutura completa.�"+
                                    "parte do surf, a Praia de Itarar� oferece diversas atividades e � um excelente local para desfrutar do sol e das"+
                                    "vistas panor�micas da ba�a de S�o Vicente al�m de ser um ponto de descanso.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 9,
                    nomePraia = "Praia Grande",
                    descricaoPraia = "Para os amantes do surf, a Praia do Canto do Forte � uma �tima op��o. Com uma extens�o de 1,5 km, essa praia possui"+
                                    "ondas m�dias que atraem surfistas ao longo do ano.Para recarregar as energias depois de uma sess�o de surfe, o"+
                                    "bairro do Canto do Forte tem op��es gastron�micas na Avenida Marechal Mallet.O inverno � o melhor per�odo para"+
                                    "visitar essa praia, pois o mar oferece condi��es ideais para a pr�tica do surfe e as ondas s�o mais consistentes."+
                                    "Aproveite a oportunidade para explorar a ilha arborizada, repleta de caranguejos e que confere um car�ter �nico �"+
                                    "regi�o.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 10,
                    nomePraia = "Mongagu�",
                    descricaoPraia = "Surfistas em busca de sossego e boas ondas podem encontrar ref�gio na Praia de Agenor de Campos, em Mongagu�."+
                                    "Uma das condi��es que atrai surfistas ao longo do ano � a praia.� particularmente popular durante os meses de"+
                                    "inverno e primavera, que acontecem de junho a novembro.Em compara��o com outras praias da regi�o mais frequentadas,"+
                                    "a atmosfera da Praia de Agenor de Campos � mais tranquila, proporcionando uma experi�ncia mais intimista e descansante."+
                                    "A �rea do recife � grande, oferecendo espa�o suficiente para os surfistas aproveitarem as ondas sem grandes grupos."+
                                    "Prepare sua prancha de surf e v� at� a Praia de Agenor de Campos, em Mongagu�, para um ref�gio tranquilo e ideal para"+
                                   " os amantes do surf!",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 11,
                    nomePraia = "Itanha�m",
                    descricaoPraia = "Situada no litoral sul de S�o Paulo, Itanha�m � um destino muito querido pelos surfistas por suas praias animadas"+
                                    "e condi��es ideais para a pr�tica do esporte.A Praia dos Sonhos � reconhecida como o ponto de surf mais aprimorado"+
                                    "da regi�o. Ao longo do ano, as ondula��es na Praia dos Sonhos s�o constantes, proporcionando uma experi�ncia"+
                                    "desafiadora e emocional para ambos os n�veis de habilidade.A paisagem deslumbrante da praia, combinada com fal�sias"+
                                    "e uma vista panor�mica do oceano, eleva a especialidade de cada sess�o de surf. Durante o ano, a Praia dos Sonhos"+
                                    "oferece boas condi��es para surfar, mas h� alguns per�odos especificamente espec�ficos. O in�cio da primavera, de"+
                                    "setembro a novembro, � a melhor �poca para encontrar ondas constantes e praias menos movimentadas.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 12,
                    nomePraia = "Peru�be",
                    descricaoPraia = "Situada no litoral sul de S�o Paulo, a deslumbrante Praia do Guara� atrai surfistas de todos os n�veis. Ela �"+
                                    "reconhecida como o ponto principal para surfistas, oferecendo ondas desafiadoras e uma beleza natural para tirar"+
                                    "o f�lego.� famosa por suas ondas fortes e constantes, sendo o destino ideal para surfistas que buscam vivencias"+
                                    "cativantes ao mar.Para iniciantes e surfistas conhecidos, as ondula��es na Praia do Guara� s�o constantes ao longo"+
                                    "do ano, proporcionando condi��es boas.A acolhedora comunidade de surfistas estabelece um ambiente de camaradagem e"+
                                    "troca de experi�ncias. � comum ver grupos de surfistas locais e turistas trocando dicas e hist�rias, agregando ainda"+
                                    "mais � experi�ncia do surfista na regi�o.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 13,
                    nomePraia = "Iguape",
                    descricaoPraia = "Os entusiastas do surf encontrar�o em Iguape, uma cidade historicamente significativa no litoral sul de S�o Paulo,"+
                                    "um destino inesperado. O melhor local para praticar esse esporte � a Praia da Jur�ia, pois proporciona uma"+
                                    "combina��o ideal de ondas emocionantes e um cen�rio natural deslumbrante. Todos os que se aventuram em suas �guas"+
                                    "t�m a op��o de uma experi�ncia diversificada e emocional devido �s variedades e for�a das ondas. Apesar de oferecer"+
                                    "boas condi��es para surfar ao longo do ano, a Praia da Jur�ia � particularmente favor�vel em alguns per�odos de surf."+
                                    "De setembro a novembro, a primavera � a perfei��o perfeita para encontrar ondas consistentes e uma praia menos"+
                                    "frequentada, possibilitando sess�es de surf mais eficientes.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 14,
                    nomePraia = "Ilha Comprida",
                    descricaoPraia = "Surfistas em busca de paisagens naturais deslumbrantes e ondas emocionantes t�m que chegar � Ilha Comprida,"+
                                    "uma ilha cativante do litoral sul de S�o Paulo. A Praia do Boqueir�o Sul � reconhecida como o melhor local para"+
                                    "praticar surf, possuindo ambiente tranquilo e condi��es ideais para surfistas de todos os n�veis.O outono, que"+
                                    "acontece de mar�o a junho, � uma excelente �poca, caracterizada por ondas bem formadas e condi��es clim�ticas"+
                                    "confort�veis.No ver�o, que tem tempo de dezembro a fevereiro, apesar do aumento no n�mero de visitantes, das"+
                                    "temperaturas extremas e das boas ondas, especialmente no in�cio da manh� e do final da tarde, garantem uma experi�ncia"+
                                    "espec�fica no surf.",
                    imgPraia = "~/Imagens/uba.png"
                },
                new Praias 
                {
                    idPraia = 15,
                    nomePraia = "Canan�ia",
                    descricaoPraia = "Nesta cidade hist�rica, Canan�ia, � um verdadeiro para�so para surfistas que buscam ondas de qualidade e um ambiente"+
                                    "natural preservado. � localizada no litoral sul de S�o Paulo. Particularmente, a Ilha do Cardoso se destaca como o"+
                                    "ponto ideal para praticar surferismo na �rea.Para os amantes do surf, a ilha proporciona uma experi�ncia �nica devido"+
                                    "�s suas praias intocadas e sua biodiversidade abundante.A Praia da Ilha do Cardoso � conhecida pelas suas ondas"+
                                    "consistentes e bem formadas, ideais tanto para surfistas novatos como experientes.Durante o ano, as ondula��es"+
                                    "ocorrem com frequ�ncia, garantindo boas condi��es para o surf em qualquer loca��o.Chegar � Praia da Ilha do Cardoso"+
                                    "� uma aventura por si s�. O acesso � feito por barco, saindo de Canan�ia, o que j� d� um toque especial para a viagem.",
                    imgPraia = "~/Imagens/uba.png"
                },


			};

            return View(listaDePraias);

        }
        [HttpPost]

        public IActionResult Ondas()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
