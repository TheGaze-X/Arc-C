using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Stencil
{
	// Token: 0x02005A4B RID: 23115
	[Token(Token = "0x2005A4B")]
	public struct UIStencilMaterialWrapper
	{
		// Token: 0x06021A5C RID: 137820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A5C")]
		[Address(RVA = "0x1C2EEC0", Offset = "0x1C2DAC0", VA = "0x181C2EEC0")]
		public void SetWrapper(int operation, int compareFunction, int colorMask, int readChannel, int writeChannel, bool useAlphaClip, bool isExclusive)
		{
		}

		// Token: 0x06021A5D RID: 137821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A5D")]
		[Address(RVA = "0x1C2EE60", Offset = "0x1C2DA60", VA = "0x181C2EE60")]
		public void Dispose()
		{
		}

		// Token: 0x17004EFD RID: 20221
		// (get) Token: 0x06021A5E RID: 137822 RVA: 0x000BB008 File Offset: 0x000B9208
		[Token(Token = "0x17004EFD")]
		public bool isEMPTY
		{
			[Token(Token = "0x6021A5E")]
			[Address(RVA = "0x1C2F0F0", Offset = "0x1C2DCF0", VA = "0x181C2F0F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0402E033 RID: 188467
		[Token(Token = "0x402E033")]
		[FieldOffset(Offset = "0x0")]
		public IMatChecker checker;

		// Token: 0x0402E034 RID: 188468
		[Token(Token = "0x402E034")]
		[FieldOffset(Offset = "0x8")]
		public Material material;

		// Token: 0x0402E035 RID: 188469
		[Token(Token = "0x402E035")]
		[FieldOffset(Offset = "0x10")]
		private bool m_matExclusive;

		// Token: 0x0402E036 RID: 188470
		[Token(Token = "0x402E036")]
		[FieldOffset(Offset = "0x14")]
		private int m_cachedOp;

		// Token: 0x0402E037 RID: 188471
		[Token(Token = "0x402E037")]
		[FieldOffset(Offset = "0x18")]
		private int m_cachedFunc;

		// Token: 0x0402E038 RID: 188472
		[Token(Token = "0x402E038")]
		[FieldOffset(Offset = "0x1C")]
		private int m_cachedColorMask;

		// Token: 0x0402E039 RID: 188473
		[Token(Token = "0x402E039")]
		[FieldOffset(Offset = "0x20")]
		private int m_cachedReadChannel;

		// Token: 0x0402E03A RID: 188474
		[Token(Token = "0x402E03A")]
		[FieldOffset(Offset = "0x24")]
		private int m_cachedWriteChannel;

		// Token: 0x0402E03B RID: 188475
		[Token(Token = "0x402E03B")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedMask;

		// Token: 0x0402E03C RID: 188476
		[Token(Token = "0x402E03C")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_cachedUseAlphaClip;
	}
}
