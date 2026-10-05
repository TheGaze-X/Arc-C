using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200008F RID: 143
	[Token(Token = "0x200008F")]
	public class TickYieldInstruction
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000038")]
		public Component host
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002F54 File Offset: 0x00001154
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000039")]
		public TickYieldInstruction.Options options
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			[CompilerGenerated]
			get
			{
				return default(TickYieldInstruction.Options);
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x54F2960", Offset = "0x54F1560", VA = "0x1854F2960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x54F2900", Offset = "0x54F1500", VA = "0x1854F2900")]
		public TickYieldInstruction(Component host, TickYieldInstruction.Options options)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void TimeManagerOnly_SetTickFunc(TickFunction tickFunction)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x54F2830", Offset = "0x54F1430", VA = "0x1854F2830")]
		public void TimeManagerOnly_OnTick(float timeDelta)
		{
		}

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x10")]
		private TickFunction m_tickFunc;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x18")]
		private bool m_keepWaiting;

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		public struct Options
		{
			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x0")]
			public bool ignoreHost;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x4")]
			public TickGroupType tickGroup;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x8")]
			public Func<float, bool> yieldFunc;
		}
	}
}
