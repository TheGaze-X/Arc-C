using System;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E4C RID: 20044
	[Token(Token = "0x2004E4C")]
	public class FireworkChangeAnimalRequest
	{
		// Token: 0x0601DECB RID: 122571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DECB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FireworkChangeAnimalRequest()
		{
		}

		// Token: 0x04027B86 RID: 162694
		[Token(Token = "0x4027B86")]
		[FieldOffset(Offset = "0x10")]
		public string animal;

		// Token: 0x04027B87 RID: 162695
		[Token(Token = "0x4027B87")]
		[FieldOffset(Offset = "0x18")]
		public string groupId;
	}
}
