using System;

namespace Ranking
{
    public class Ranking
    {
      public static String Rank(float score){
        if(score >=8.0f ){
          return "excellent";
        }
        else if(score >= 6.5f){
          return "good";
        }
        else if(score >= 5.0f){
          return "average";
        }
        else if(score >= 3.5f){
          return "poor";
        }
        return "bad";
      }
    }
}
