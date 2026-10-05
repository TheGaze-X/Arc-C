using System;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F1B RID: 24347
	[Token(Token = "0x2005F1B")]
	public struct UplevelAttribute
	{
		// Token: 0x06023457 RID: 144471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023457")]
		[Address(RVA = "0x1DD3090", Offset = "0x1DD1C90", VA = "0x181DD3090")]
		public void LoadData(PlayerCharacter playerChar, int targetLevel)
		{
		}

		// Token: 0x040309E2 RID: 199138
		[Token(Token = "0x40309E2")]
		[FieldOffset(Offset = "0x0")]
		public int maxHp;

		// Token: 0x040309E3 RID: 199139
		[Token(Token = "0x40309E3")]
		[FieldOffset(Offset = "0x4")]
		public int atk;

		// Token: 0x040309E4 RID: 199140
		[Token(Token = "0x40309E4")]
		[FieldOffset(Offset = "0x8")]
		public int def;

		// Token: 0x040309E5 RID: 199141
		[Token(Token = "0x40309E5")]
		[FieldOffset(Offset = "0xC")]
		public float res;
	}
}
