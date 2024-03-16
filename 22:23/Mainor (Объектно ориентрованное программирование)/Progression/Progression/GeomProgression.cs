using System;
namespace Progression
{
	class GeomProgression : Progression
	{
		long zn;

		public GeomProgression() : base()
		{
			zn = 2;
			this.first = zn;
		}

		public GeomProgression(long zn) : base()
		{
			this.zn = 2;
            this.first = zn;
        }

		protected override long NextValue()
		{
			try
			{
				cur = checked(cur * zn);
			}
			catch(StackOverflowException exc)
			{
				Console.WriteLine(exc.Message);
			}
		}
    }
}

