using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x0200287B RID: 10363
	[Token(Token = "0x200287B")]
	public interface IParam : IParamBindable
	{
		// Token: 0x040134A1 RID: 79009
		[Token(Token = "0x40134A1")]
		public const int PARAM_DEFAULT = -1;

		// Token: 0x040134A2 RID: 79010
		[Token(Token = "0x40134A2")]
		public const int PARAM_SOURCE_CONST = 0;

		// Token: 0x040134A3 RID: 79011
		[Token(Token = "0x40134A3")]
		public const int PARAM_SOURCE_GETTER = 1;

		// Token: 0x040134A4 RID: 79012
		[Token(Token = "0x40134A4")]
		public const int PARAM_SOURCE_TEMP = 100;
	}
}
