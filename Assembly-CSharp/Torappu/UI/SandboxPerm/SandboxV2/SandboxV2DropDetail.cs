using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042B0 RID: 17072
	[Token(Token = "0x20042B0")]
	public struct SandboxV2DropDetail
	{
		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0601A46D RID: 107629 RVA: 0x000A0AA0 File Offset: 0x0009ECA0
		[Token(Token = "0x17003E58")]
		public bool isEmpty
		{
			[Token(Token = "0x601A46D")]
			[Address(RVA = "0x1329570", Offset = "0x1328170", VA = "0x181329570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0601A46E RID: 107630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E59")]
		public UIItemViewModel itemViewModel
		{
			[Token(Token = "0x601A46E")]
			[Address(RVA = "0x1329580", Offset = "0x1328180", VA = "0x181329580")]
			get
			{
				return null;
			}
		}

		// Token: 0x040214BC RID: 136380
		[Token(Token = "0x40214BC")]
		[FieldOffset(Offset = "0x0")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x040214BD RID: 136381
		[Token(Token = "0x40214BD")]
		[FieldOffset(Offset = "0x8")]
		public string itemId;

		// Token: 0x040214BE RID: 136382
		[Token(Token = "0x40214BE")]
		[FieldOffset(Offset = "0x10")]
		public int maxCount;

		// Token: 0x040214BF RID: 136383
		[Token(Token = "0x40214BF")]
		[FieldOffset(Offset = "0x14")]
		public int currentCount;

		// Token: 0x040214C0 RID: 136384
		[Token(Token = "0x40214C0")]
		[FieldOffset(Offset = "0x18")]
		public bool showCountFlag;
	}
}
