using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E1B RID: 3611
	[Token(Token = "0x2000E1B")]
	public class ActivityLoginData
	{
		// Token: 0x06006AEF RID: 27375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEF")]
		[Address(RVA = "0x1FFC770", Offset = "0x1FFB370", VA = "0x181FFC770")]
		public ActivityLoginData()
		{
		}

		// Token: 0x04004B39 RID: 19257
		[Token(Token = "0x4004B39")]
		[FieldOffset(Offset = "0x10")]
		public string description;

		// Token: 0x04004B3A RID: 19258
		[Token(Token = "0x4004B3A")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> itemList;

		// Token: 0x04004B3B RID: 19259
		[Token(Token = "0x4004B3B")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, long> apSupplyOutOfDateDict;
	}
}
