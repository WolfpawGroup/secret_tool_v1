using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace secret_tool_v1
{
	class keygen
	{
		public int genkey(int k)
		{
			return new Random(k).Next(1, 100);
		}

		public int[] gen5(int lastk)
		{
			int[] ret = new int[5];
			int ii = lastk;

			for (int i = 0; i < 5; i++)
			{
				ret[i] = genkey(ii);
				ii += ret[i];
			}

			return ret;
		}
	}
}
