  Console.WriteLine ("Enter your number");
    string number = Console.ReadLine ();
        if (number.Length < 3){
      Console.WriteLine ("there is no third number");
    }
    else {
      Console.WriteLine (number[2]);
    }