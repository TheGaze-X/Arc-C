using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200287C RID: 10364
	[Token(Token = "0x200287C")]
	public interface IParamOutput : IParamBindable
	{
		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x0601140C RID: 70668
		[Token(Token = "0x17002614")]
		bool toInternalPath { [Token(Token = "0x601140C")] get; }

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x0601140D RID: 70669
		[Token(Token = "0x17002615")]
		bool toTemp { [Token(Token = "0x601140D")] get; }

		// Token: 0x040134A5 RID: 79013
		[Token(Token = "0x40134A5")]
		public const int PARAM_TARGET_NONE = 0;

		// Token: 0x040134A6 RID: 79014
		[Token(Token = "0x40134A6")]
		public const int PARAM_TARGET_TEMP = 100;
	}
}
