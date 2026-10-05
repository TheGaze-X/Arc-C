using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F40 RID: 16192
	[Token(Token = "0x2003F40")]
	public class SiracusaOperaFrameViewModel
	{
		// Token: 0x06019253 RID: 102995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019253")]
		[Address(RVA = "0x11DC0B0", Offset = "0x11DACB0", VA = "0x1811DC0B0")]
		public SiracusaOperaFrameViewModel()
		{
		}

		// Token: 0x0401F26B RID: 127595
		[Token(Token = "0x401F26B")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0401F26C RID: 127596
		[Token(Token = "0x401F26C")]
		[FieldOffset(Offset = "0x18")]
		public string operaId;

		// Token: 0x0401F26D RID: 127597
		[Token(Token = "0x401F26D")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x0401F26E RID: 127598
		[Token(Token = "0x401F26E")]
		[FieldOffset(Offset = "0x28")]
		public string subTitle;

		// Token: 0x0401F26F RID: 127599
		[Token(Token = "0x401F26F")]
		[FieldOffset(Offset = "0x30")]
		public string score;

		// Token: 0x0401F270 RID: 127600
		[Token(Token = "0x401F270")]
		[FieldOffset(Offset = "0x38")]
		public PlayerSiracusaMap.OperaState operaState;

		// Token: 0x0401F271 RID: 127601
		[Token(Token = "0x401F271")]
		[FieldOffset(Offset = "0x3C")]
		public int currentSlotIndex;

		// Token: 0x0401F272 RID: 127602
		[Token(Token = "0x401F272")]
		[FieldOffset(Offset = "0x40")]
		public int targetSlotIndex;

		// Token: 0x0401F273 RID: 127603
		[Token(Token = "0x401F273")]
		[FieldOffset(Offset = "0x44")]
		public int maxSlotIndex;

		// Token: 0x0401F274 RID: 127604
		[Token(Token = "0x401F274")]
		[FieldOffset(Offset = "0x48")]
		public List<SiracusaOperaFrameViewModel.HeadIcon> headIconList;

		// Token: 0x02003F41 RID: 16193
		[Token(Token = "0x2003F41")]
		public class HeadIcon
		{
			// Token: 0x06019254 RID: 102996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019254")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HeadIcon()
			{
			}

			// Token: 0x0401F275 RID: 127605
			[Token(Token = "0x401F275")]
			[FieldOffset(Offset = "0x10")]
			public string headIconId;
		}
	}
}
