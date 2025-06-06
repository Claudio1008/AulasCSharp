using ConsoleAppPOO.Model;
using ConsoleAppPOO.Controller;

/*Produto produto = new Produto();
List<Produto> listaProduto = new List<Produto>();

produto.Id = 1;
produto.Descricao = "Bola";

//apresentar apenas 1 produto
//produto.Apresentar(produto);

listaProduto.Add(produto);

produto = new Produto();
produto.Id = 2;
produto.Descricao = "Chuteira";

listaProduto.Add(produto);

//Construtor com parametros
Produto produto2 = new Produto( 3, "Luva");

listaProduto.Add(produto2);

produto.ApresentarLista(listaProduto);
*/

BolaController controller = new BolaController();
List<Bola> lista = new List<Bola>();

Bola bola = new Bola(1, "Topper", 150m);
lista = controller.Adicionar(bola);

bola = new Bola(2, "adidas", 300m);
lista = controller.Adicionar(bola);

bola = new Bola(3, "nike", 250m);
lista = controller.Adicionar(bola);

controller.Listar(lista);