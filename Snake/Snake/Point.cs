﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point //класс содержащий подпрограммы для вывода и взаимодействия с точками
	{
		public int x; //положение точки х
		public int y; //положение точки у
		public char sym; //вид символа


		public Point(int x, int y, char sym) //конструктор заимствующий значения 
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p) 
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)
		{
			if(direction == Direction.RIGHT)
			{
				x = x + offset;
			}
			else if(direction == Direction.LEFT)
			{
				x = x - offset;
			}
			else if(direction == Direction.UP)
			{
				y = y - offset;
			}
			else if(direction == Direction.DOWN)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
			Console.SetCursorPosition( x, y );
			Console.Write( sym );			
		}

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
