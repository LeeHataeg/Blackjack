namespace BlackJeck_Test01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //템플릿 패스
            GameExplain();
            Console.Clear();
            CardPackage package = new CardPackage();



        }
        static void GameExplain()
        {
            Console.WriteLine("트럼프 카드를 뽑게 됩니다.");
            Console.WriteLine("각 카드의 숫자에 해당하는 만큼 스코어를 획득하시며,");
            Console.WriteLine("J, Q, K는 10점. A는 11점을 획득하게 됩니다.");
            Console.WriteLine("스코어가 21점을 넘겨버리면 패배하시며,");
            Console.WriteLine("21점에 보다 더 가까운 사람이 승리하게 됩니다.");
            Console.WriteLine();
            Console.WriteLine("사회자와 게임을 진행하게 되는데");
            Console.WriteLine("사회자의 스코어가 17점 미만이면 카드를 더 뽑게 됩니다.");
            Console.WriteLine("게임을 진행하시려면 아무키나 입력해 주십시오.");
            Console.ReadLine();
        }
    }
}