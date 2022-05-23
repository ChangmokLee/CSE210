/* Higher or lower? [h/l]
 * Your score is: 
 * total score */

public class Player{
    int scores = 300;


    public Player()
    { }


    public void Firstcard()
    {
        Random f_card = new Random();
        int firstcard = f_card.Next(1,13);

    }
    public void Secondcard()
    {
        Random s_card = new Random();
        int secondcard = s_card.Next(1,13);
    }



    public void Guesshilo(){
        Console.Write("Higher or lower [h/l] ");
        string hilo = Console.ReadLine();
        ///total score만들어야하는데 스코어 반복을 어떻게 해야하나
        
        do
        {
            if (hilo == "h")
            {
                Firstcard() < Secondcard();
            }
            else if (hilo == "l")
            {
                firstcard > secondcard;
            }
            elsea
            {
                Console.WriteLine("Invalid input \n");

            }
        }
        while (hilo != "h" || hilo != "l");
       
    } 

    public void get_high()
    {
        if (Firstcard < Secondcard)
        {
            scores += 100;
        }
        else if (firstcard > secondcard)
        {
            scores -= 75;
        }
        else
        {
            scores += 0;
        }
    }

    public void get_low()
    {
        if (firstcard > secondcard)
        {
            scores += 100;
        }
        else if (firstcard < secondcard)
        {
            scores -= 75;
        }
        else
        {
            scores += 0;
        }
            
    }
    
    public void do_outputs()
    {
        Console.WriteLine($"Your score is: {totalscores}");

    }



    
}    

