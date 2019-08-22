using System;

namespace DrawingBookServices
{
    public class DrawingBookServices
    {
        public int FindTurns(int page, int total){
            
        return Math.Min(page/2,(total-page)/(page/2));

        }
    }
}
