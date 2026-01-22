using System;
using System.Threading;

Pedido p1 = new Pedido(1, "Evelyn", 3);
Pedido p2 = new Pedido(2, "Juan", 5);
Pedido p3 = new Pedido(3, "Ciane", 2);

Thread t1 = new Thread(p1.Processar); 
Thread t2 = new Thread(p2.Processar);
Thread t3 = new Thread(p3.Processar);

t1.Start();
t2.Start();
t3.Start();

Console.WriteLine("Iniciou!");

