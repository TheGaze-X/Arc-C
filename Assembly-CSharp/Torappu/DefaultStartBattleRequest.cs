using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x20008B7")]
	public class DefaultStartBattleRequest : CommonStartBattleRequest
	{
		// Token: 0x06006565 RID: 25957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006565")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DefaultStartBattleRequest()
		{
		}

		// Token: 0x0400329B RID: 12955
		[Token(Token = "0x400329B")]
		[FieldOffset(Offset = "0x40")]
		public bool isRetro;

		// Token: 0x0400329C RID: 12956
		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0x44")]
		public int pry;

		// Token: 0x0400329D RID: 12957
		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x48")]
		public DefaultStartBattleRequest.BattleType battleType;

		// Token: 0x0400329E RID: 12958
		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x50")]
		public CommonStartBattleRequest.MultipleBattleModel multiple;

		// Token: 0x0400329F RID: 12959
		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x58")]
		public StartBattleExtraData extra;

		// Token: 0x020008B8 RID: 2232
		[Token(Token = "0x20008B8")]
		public enum BattleType
		{
			// Token: 0x040032A1 RID: 12961
			[Token(Token = "0x40032A1")]
			Common,
			// Token: 0x040032A2 RID: 12962
			[Token(Token = "0x40032A2")]
			Continuous,
			// Token: 0x040032A3 RID: 12963
			[Token(Token = "0x40032A3")]
			MULTIPLE
		}
	}
}
