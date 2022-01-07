
class Solution {
    public int reverse(int x) {
        int sign=1;
        int rev=0;
        int num=x;
        
        
        if(x<0)
        {
            x=x*-1;
            sign=-1;
        }
        while(x>0)
        {
            int pop=x%10;
            if (rev > Integer.MAX_VALUE/10 || (rev == Integer.MAX_VALUE / 10 && pop > 7)) return 0;
            if (rev < Integer.MIN_VALUE/10 || (rev == Integer.MIN_VALUE / 10 && pop < -8)) return 0;
            rev=rev*10+pop;
            x=x/10;
            
            
        }
       
        return rev*sign;
        
        
        
    }
}
