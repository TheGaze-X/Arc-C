using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004BA9 RID: 19369
	[Token(Token = "0x2004BA9")]
	public struct MailGainItemComparer : IComparer<UIItemViewModel>
	{
		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x0601D1FF RID: 119295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700448C")]
		private int[] dimensionX
		{
			[Token(Token = "0x601D1FF")]
			[Address(RVA = "0x16AAB90", Offset = "0x16A9790", VA = "0x1816AAB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x0601D200 RID: 119296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700448D")]
		private int[] dimensionY
		{
			[Token(Token = "0x601D200")]
			[Address(RVA = "0x16AABF0", Offset = "0x16A97F0", VA = "0x1816AABF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x000AA9A0 File Offset: 0x000A8BA0
		[Token(Token = "0x601D201")]
		[Address(RVA = "0x16AA870", Offset = "0x16A9470", VA = "0x1816AA870", Slot = "4")]
		public int Compare(UIItemViewModel x, UIItemViewModel y)
		{
			return 0;
		}

		// Token: 0x0601D202 RID: 119298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D202")]
		[Address(RVA = "0x16AAA70", Offset = "0x16A9670", VA = "0x1816AAA70")]
		private static void _CalcCompareDimension(UIItemViewModel itemModel, int[] dimensions)
		{
		}

		// Token: 0x04026381 RID: 156545
		[Token(Token = "0x4026381")]
		private const int COMPARE_DIMENSION = 4;

		// Token: 0x04026382 RID: 156546
		[Token(Token = "0x4026382")]
		[FieldOffset(Offset = "0x0")]
		private int[] m_dimensionX;

		// Token: 0x04026383 RID: 156547
		[Token(Token = "0x4026383")]
		[FieldOffset(Offset = "0x8")]
		private int[] m_dimensionY;
	}
}
