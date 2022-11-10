
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var arr = new int[3];

        try
        {
        
        /*for (var index = 0; index< 10; index++)
        {
            //System.IndexOutOfRangeException
            Console.WriteLine(arr[index]);
        }*/

            Cadastar("");

        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("não encontrei o índice na lista");
        }
        catch (MinhaException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("Exceção customizada");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("ops, algo deu errado!");
        }
        finally
        {
            Console.WriteLine("chegou ao fim!");
        }




        ///////////////////////////////////
        /*var arr = new int[4];
        var arrb = new int [4];

        arrb[0] = arr[0];

        arr[0] = 23;
        Console.WriteLine(arrb[0]);*/

        /*var meuArray = new int[5]{1,2,3,4,5};

        foreach (var item in meuArray)
        {
           Console.WriteLine(item); 
        }*/

        /*for(var index = 0; index < meuArray.Length; index++)
        {
        Console.WriteLine(meuArray[index]);
        }*/


    }

    private static void Cadastar (string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException : Exception
    {
        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set; }
    }

}