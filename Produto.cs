    public class Produto {
        private String nome;
        private decimal preco;
        private  String descricao;
        private String categoria;
        //construção classe Produto
        public Produto(string nome, decimal preco, string descricao, string categoria) {
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
            this.categoria = categoria;
        } 
         //Propriedades da classe Produto que permite acesso controlado a um campo privado
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public decimal Preco {
            get { return preco; }
            set { preco = value; }
        }
        public string Descricao {
            get { return descricao; }
            set { descricao = value; }
        }
        public string Categoria {
            get { return categoria; }
            set { categoria = value; }
        }
    } 
    public class ConsoleGame : Produto {
        private int capacidadeArmazenamento;

        //Construtor da classe consolegame
        public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadeArmazenamento) : base(nome, preco, descricao, categoria) {
            CapacidadeArmazenamento = capacidadeArmazenamento;
        }

        //Propriedades da classe ConsoleGame que permite acesso controlado a um campo privado
        public int CapacidadeArmazenamento{
            get { return capacidadeArmazenamento; }
            set { capacidadeArmazenamento = value; }
        }
    }
    public class Jogo : Produto {
        private string genero;

        //Construtor da classe jogo
        public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria) {
            Genero = genero;
        }

        //Propriedades da classe Jogo que permite acesso controlado a um campo privado
        public string Genero{
            get { return genero; }
            set { genero = value; }
        }
    }
    public class Acessorio : Produto {
        private string tipo;

        //Construtor da classe acessorio
        public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria) {
            Tipo = tipo;
        }

        //Propriedades da classe Acessorio que permite acesso controlado a um campo privado
        public string Tipo{
            get { return tipo; }
            set { tipo = value; }
        }
    } 
    public class Colecionavel : Produto {
        private bool edicaoLimitada;

        //Construtor da classe colecionavel
        public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada) : base(nome, preco, descricao, categoria) {
            EdicaoLimitada = edicaoLimitada;
        }

        //Propriedades da classe Colecionavel que permite acesso controlado a um campo privado
        public string EdicaoLimitada{
            get { return edicaoLimitada; }
            set { edicaoLimitada = value; }
        }
    } 
    public class Program {
        public static void main (String[] args) {
            Produto produto;
            produto = new ConsoleGame("PlayStation 5", 5.900, "Console de Vídeo Game PlayStation 5 Slim com 1 Tera de armazenamento", "Console", 1024000);

            Jogo jogo = new Jogo("Marvel's Spider-Man 2 PREMIUM", 299.9, "Jogo completo Marvel's Spider-Man 2 para PS5®.", "Jogo PS5", "Ação e Aventura");

            Acessorio acessorio = new Acessorio("Headset Gaming HyperX Cloud Alpha", 479.9, "Headset gamer compatível com console Xbox, PS5 e PC, design nas cores Preto e Vermelho, com fio e estrutura de alumínio", "Headset Gamer", "Periférico");

            Colecionavel colecionavel = new Colecionavel("Malenia Elden Ring 24CM - Action Figure", 549.9, "Action figure de 24CM da personagem Malenia do Jogo Elden Ring, feita de PVC, vem dentro de uma caixa personalizada do Jogo", "Action Figure", true);
        }    
    } 