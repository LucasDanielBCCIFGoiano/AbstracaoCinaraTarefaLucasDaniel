using System;

namespace AbstracaoCinaraTarefaLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook sony = new Notebook("Sony Vaio");
            sony.Porta1 = new Iphone();
            var iphone = new Iphone();
            iphone.Plugar();
            sony.Porta2 = new Mouse();
            var mouse = new Mouse();
            mouse.Plugar();
            sony.Porta3 = new Teclado();
            var teclado = new Teclado();
            teclado.Plugar();
            Console.ReadLine();
        }
    }
}

