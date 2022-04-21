using dolbolesya_LITO_course;

User Alex = new User();
Alex.id = 125125;
Alex.isAdmin = false;

Console.Write("enter name: ");
Alex.name = Console.ReadLine();

Console.Write($"enter {Alex.name} age: ");
Alex.age = uint.Parse(Console.ReadLine());

Console.Write($"enter {Alex.profession} profession: ");
Alex.profession = Console.ReadLine();

Alex.Me();