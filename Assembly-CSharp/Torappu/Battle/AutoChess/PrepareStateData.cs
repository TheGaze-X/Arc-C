using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200271D RID: 10013
	[Token(Token = "0x200271D")]
	public class PrepareStateData
	{
		// Token: 0x06010477 RID: 66679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010477")]
		[Address(RVA = "0x80A670", Offset = "0x809270", VA = "0x18080A670")]
		public PrepareStateData()
		{
		}

		// Token: 0x0401231C RID: 74524
		[Token(Token = "0x401231C")]
		[FieldOffset(Offset = "0x10")]
		public ShopData shopData;

		// Token: 0x0401231D RID: 74525
		[Token(Token = "0x401231D")]
		[FieldOffset(Offset = "0x18")]
		public SelfChooseStateData selfChoose;
	}
}
