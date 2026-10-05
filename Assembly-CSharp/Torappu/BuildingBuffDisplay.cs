using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x2000A4F")]
	public class BuildingBuffDisplay
	{
		// Token: 0x0600670E RID: 26382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600670E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingBuffDisplay()
		{
		}

		// Token: 0x04003849 RID: 14409
		[Token(Token = "0x4003849")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("base")]
		public int baseBuff;

		// Token: 0x0400384A RID: 14410
		[Token(Token = "0x400384A")]
		[FieldOffset(Offset = "0x14")]
		public int buff;
	}
}
