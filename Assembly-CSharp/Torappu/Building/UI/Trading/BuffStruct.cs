using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C48 RID: 7240
	[Token(Token = "0x2001C48")]
	public struct BuffStruct
	{
		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x0600B43E RID: 46142 RVA: 0x000445C8 File Offset: 0x000427C8
		[Token(Token = "0x170015A4")]
		public float manpowerCostBase
		{
			[Token(Token = "0x600B43E")]
			[Address(RVA = "0x32EC6C0", Offset = "0x32EB2C0", VA = "0x1832EC6C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x0600B43F RID: 46143 RVA: 0x000445E0 File Offset: 0x000427E0
		[Token(Token = "0x170015A5")]
		public float manpowerCostBuffBase
		{
			[Token(Token = "0x600B43F")]
			[Address(RVA = "0x32EC6D0", Offset = "0x32EB2D0", VA = "0x1832EC6D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x000445F8 File Offset: 0x000427F8
		[Token(Token = "0x170015A6")]
		public float manpowerCostBuffSpec
		{
			[Token(Token = "0x600B440")]
			[Address(RVA = "0x32EC6F0", Offset = "0x32EB2F0", VA = "0x1832EC6F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x0600B441 RID: 46145 RVA: 0x00044610 File Offset: 0x00042810
		[Token(Token = "0x170015A7")]
		public float orderSpeedBuffBase
		{
			[Token(Token = "0x600B441")]
			[Address(RVA = "0x32EC710", Offset = "0x32EB310", VA = "0x1832EC710")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x0600B442 RID: 46146 RVA: 0x00044628 File Offset: 0x00042828
		[Token(Token = "0x170015A8")]
		public float orderSpeedBuffSpec
		{
			[Token(Token = "0x600B442")]
			[Address(RVA = "0xA27A30", Offset = "0xA26630", VA = "0x180A27A30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B443")]
		[Address(RVA = "0x32EC5D0", Offset = "0x32EB1D0", VA = "0x1832EC5D0")]
		public BuffStruct(TRoomViewModel viewModel)
		{
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x00044640 File Offset: 0x00042840
		[Token(Token = "0x600B444")]
		[Address(RVA = "0x32EC440", Offset = "0x32EB040", VA = "0x1832EC440")]
		private static int _SaveFloat(float val)
		{
			return 0;
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x00044658 File Offset: 0x00042858
		[Token(Token = "0x600B445")]
		[Address(RVA = "0x32EC430", Offset = "0x32EB030", VA = "0x1832EC430")]
		private static float _LoadFloat(int val)
		{
			return 0f;
		}

		// Token: 0x0400AFD8 RID: 45016
		[Token(Token = "0x400AFD8")]
		[FieldOffset(Offset = "0x0")]
		private int m_manpowerCostBase;

		// Token: 0x0400AFD9 RID: 45017
		[Token(Token = "0x400AFD9")]
		[FieldOffset(Offset = "0x4")]
		private int m_manpowerCostBuffBase;

		// Token: 0x0400AFDA RID: 45018
		[Token(Token = "0x400AFDA")]
		[FieldOffset(Offset = "0x8")]
		private int m_manpowerCostBuffSpec;

		// Token: 0x0400AFDB RID: 45019
		[Token(Token = "0x400AFDB")]
		[FieldOffset(Offset = "0xC")]
		private int m_orderSpeedBuffBase;

		// Token: 0x0400AFDC RID: 45020
		[Token(Token = "0x400AFDC")]
		[FieldOffset(Offset = "0x10")]
		private int m_orderSpeedBuffSpec;
	}
}
