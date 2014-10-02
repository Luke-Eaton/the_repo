using System;

namespace my_first_repo
{
	public class player
	{
		int x, y;
		int hp;
		
		
		public player ()
		{
			x = 0;
			y = 0;
			hp = 100;
		}
		
		public player(int x, int y, int hp)
		{
			this.x = x;
			this.y = y;
			this.hp = hp;
		}
		
		public player(int x, int y)
		{
			this.x = x;
			this.y = y;
			hp = 100;
		}
		
		public void setHp(int hp)
		{
			this.hp = hp;
		}
		
		public int getHp()
		{
			return hp;
		}
		
		public void setPos(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		
		public int getX()
		{
			return x;
		}
		
		public int getY()
		{
			return y;
		}
	}
}

