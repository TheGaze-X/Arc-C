using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003824 RID: 14372
	[Token(Token = "0x2003824")]
	public class ReentrantFloatOpt : IHotfixable
	{
		// Token: 0x06016C95 RID: 93333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016C95")]
		[Address(RVA = "0xF3B050", Offset = "0xF39C50", VA = "0x180F3B050")]
		private ReentrantFloatOpt(ReentrantFloatOpt.Builder builder)
		{
		}

		// Token: 0x06016C96 RID: 93334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C96")]
		[Address(RVA = "0xF3AE90", Offset = "0xF39A90", VA = "0x180F3AE90")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06016C97 RID: 93335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C97")]
		[Address(RVA = "0xF3ADE0", Offset = "0xF399E0", VA = "0x180F3ADE0")]
		public IEnumerator HideCoroutine()
		{
			return null;
		}

		// Token: 0x06016C98 RID: 93336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016C98")]
		[Address(RVA = "0xF3AFA0", Offset = "0xF39BA0", VA = "0x180F3AFA0")]
		private IEnumerator _WaitForEffectsFinish()
		{
			return null;
		}

		// Token: 0x06016C99 RID: 93337 RVA: 0x00092F10 File Offset: 0x00091110
		[Token(Token = "0x6016C99")]
		[Address(RVA = "0xF3AF40", Offset = "0xF39B40", VA = "0x180F3AF40")]
		private bool _CheckIfEffectStable()
		{
			return default(bool);
		}

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x06016C9A RID: 93338 RVA: 0x00092F28 File Offset: 0x00091128
		[Token(Token = "0x1700367A")]
		public bool isShown
		{
			[Token(Token = "0x6016C9A")]
			[Address(RVA = "0xF3B0F0", Offset = "0xF39CF0", VA = "0x180F3B0F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0401B7BC RID: 112572
		[Token(Token = "0x401B7BC")]
		[FieldOffset(Offset = "0x10")]
		private ReentrantFloatOpt.Builder m_builder;

		// Token: 0x0401B7BD RID: 112573
		[Token(Token = "0x401B7BD")]
		[FieldOffset(Offset = "0x30")]
		private int m_showCnt;

		// Token: 0x0401B7BE RID: 112574
		[Token(Token = "0x401B7BE")]
		[FieldOffset(Offset = "0x34")]
		private int m_effectCnt;

		// Token: 0x0401B7BF RID: 112575
		[Token(Token = "0x401B7BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B7C0 RID: 112576
		[Token(Token = "0x401B7C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401B7C1 RID: 112577
		[Token(Token = "0x401B7C1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401B7C2 RID: 112578
		[Token(Token = "0x401B7C2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__WaitForEffectsFinish;

		// Token: 0x0401B7C3 RID: 112579
		[Token(Token = "0x401B7C3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfEffectStable;

		// Token: 0x0401B7C4 RID: 112580
		[Token(Token = "0x401B7C4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isShown;

		// Token: 0x02003825 RID: 14373
		[Token(Token = "0x2003825")]
		public struct Builder
		{
			// Token: 0x06016C9B RID: 93339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016C9B")]
			[Address(RVA = "0xF398F0", Offset = "0xF384F0", VA = "0x180F398F0")]
			public ReentrantFloatOpt Build()
			{
				return null;
			}

			// Token: 0x0401B7C5 RID: 112581
			[Token(Token = "0x401B7C5")]
			[FieldOffset(Offset = "0x0")]
			public Func<IEnumerator> showEffect;

			// Token: 0x0401B7C6 RID: 112582
			[Token(Token = "0x401B7C6")]
			[FieldOffset(Offset = "0x8")]
			public Func<IEnumerator> hideEffect;

			// Token: 0x0401B7C7 RID: 112583
			[Token(Token = "0x401B7C7")]
			[FieldOffset(Offset = "0x10")]
			public Action beforeShowEffect;

			// Token: 0x0401B7C8 RID: 112584
			[Token(Token = "0x401B7C8")]
			[FieldOffset(Offset = "0x18")]
			public Action afterHideEffect;
		}
	}
}
