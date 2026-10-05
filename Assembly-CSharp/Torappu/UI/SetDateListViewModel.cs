using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020039B9 RID: 14777
	[Token(Token = "0x20039B9")]
	public class SetDateListViewModel
	{
		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x06017596 RID: 95638 RVA: 0x000961C8 File Offset: 0x000943C8
		// (set) Token: 0x06017597 RID: 95639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170037EA")]
		public long dragContextID
		{
			[Token(Token = "0x6017596")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6017597")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x06017598 RID: 95640 RVA: 0x000961E0 File Offset: 0x000943E0
		[Token(Token = "0x170037EB")]
		public int pagerSelectedPage
		{
			[Token(Token = "0x6017598")]
			[Address(RVA = "0xFB6800", Offset = "0xFB5400", VA = "0x180FB6800")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x06017599 RID: 95641 RVA: 0x000961F8 File Offset: 0x000943F8
		[Token(Token = "0x170037EC")]
		public int currentDate
		{
			[Token(Token = "0x6017599")]
			[Address(RVA = "0xFB67C0", Offset = "0xFB53C0", VA = "0x180FB67C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601759A RID: 95642 RVA: 0x00096210 File Offset: 0x00094410
		[Token(Token = "0x601759A")]
		[Address(RVA = "0xFB66D0", Offset = "0xFB52D0", VA = "0x180FB66D0")]
		public int SwitchPagerIndex(int idx)
		{
			return 0;
		}

		// Token: 0x0601759B RID: 95643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601759B")]
		[Address(RVA = "0xFB6720", Offset = "0xFB5320", VA = "0x180FB6720")]
		public void UpdateSelection(int idx)
		{
		}

		// Token: 0x0601759C RID: 95644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601759C")]
		[Address(RVA = "0xFB6730", Offset = "0xFB5330", VA = "0x180FB6730")]
		public SetDateListViewModel()
		{
		}

		// Token: 0x0401C322 RID: 115490
		[Token(Token = "0x401C322")]
		[FieldOffset(Offset = "0x10")]
		public List<int> dates;

		// Token: 0x0401C323 RID: 115491
		[Token(Token = "0x401C323")]
		[FieldOffset(Offset = "0x18")]
		public int selectedDateIdx;
	}
}
