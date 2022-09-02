int respuesta;
Console.WriteLine("Ingrese su nombre");
			String nombre = Console.ReadLine();
Console.WriteLine("Especifique en numeros su salario");
			int salario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la medida de uno de los lados de un cuadrado");
			int medida = Convert.ToInt32(Console.ReadLine());
			int areac = Convert.ToInt32(medida*medida);
do {
				Console.WriteLine("Indique la opcion que desee consultar");
				Console.WriteLine("1: El area de un cuadrado");
				Console.WriteLine("2: saber si recibe auxilio de transporte");
				Console.WriteLine("3: Salir");
				 respuesta =Convert.ToInt32(Console.ReadLine());
				switch (respuesta) {
				case 1:
					Console.WriteLine(nombre+" el area del cuadrado es de "+areac);
					break;
				case 2:
					if (salario<2000000) {
						Console.WriteLine(nombre+" aplicas a auxilio de transporte");
					} else {
						Console.WriteLine(nombre+" no aplicas a auxilio de transporte");
					}
					break;
				case 3:
					Console.WriteLine(nombre+" gracias por usar el programa");
					break;
				default:
					Console.WriteLine(nombre+" no olvides marcar del 1 al 3");
                    break;
				}
				Console.ReadKey();
				Console.Clear();
			} while (respuesta!=3);          