using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020007BF RID: 1983
	[Token(Token = "0x20007BF")]
	public class ChangeStarMarkCharRequest
	{
		// Token: 0x06006440 RID: 25664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006440")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeStarMarkCharRequest()
		{
		}

		// Token: 0x040030D3 RID: 12499
		[Token(Token = "0x40030D3")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "set")]
		public ListDict<string, int> chrIdDict;
	}
}
