using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001426 RID: 5158
	[Token(Token = "0x2001426")]
	public class MedalSetCustomDataRequest
	{
		// Token: 0x060076E7 RID: 30439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E7")]
		[Address(RVA = "0x241F0F0", Offset = "0x241DCF0", VA = "0x18241F0F0")]
		public MedalSetCustomDataRequest()
		{
		}

		// Token: 0x04007456 RID: 29782
		[Token(Token = "0x4007456")]
		[FieldOffset(Offset = "0x10")]
		public string index;

		// Token: 0x04007457 RID: 29783
		[Token(Token = "0x4007457")]
		[FieldOffset(Offset = "0x18")]
		public MedalSetCustomDataRequest.Data data;

		// Token: 0x02001427 RID: 5159
		[Token(Token = "0x2001427")]
		public class LayoutItem
		{
			// Token: 0x060076E8 RID: 30440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LayoutItem()
			{
			}

			// Token: 0x04007458 RID: 29784
			[Token(Token = "0x4007458")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04007459 RID: 29785
			[Token(Token = "0x4007459")]
			[FieldOffset(Offset = "0x18")]
			public int[] pos;
		}

		// Token: 0x02001428 RID: 5160
		[Token(Token = "0x2001428")]
		public class Data
		{
			// Token: 0x060076E9 RID: 30441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076E9")]
			[Address(RVA = "0x241E7E0", Offset = "0x241D3E0", VA = "0x18241E7E0")]
			public Data()
			{
			}

			// Token: 0x0400745A RID: 29786
			[Token(Token = "0x400745A")]
			[FieldOffset(Offset = "0x10")]
			public List<MedalSetCustomDataRequest.LayoutItem> layout;
		}
	}
}
