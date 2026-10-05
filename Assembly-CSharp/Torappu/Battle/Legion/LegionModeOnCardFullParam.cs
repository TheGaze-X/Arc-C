using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A29 RID: 10793
	[Token(Token = "0x2002A29")]
	public struct LegionModeOnCardFullParam
	{
		// Token: 0x040142E8 RID: 82664
		[Token(Token = "0x40142E8")]
		[FieldOffset(Offset = "0x0")]
		public bool needPlayEffect;

		// Token: 0x040142E9 RID: 82665
		[Token(Token = "0x40142E9")]
		[FieldOffset(Offset = "0x8")]
		public Action callback;
	}
}
