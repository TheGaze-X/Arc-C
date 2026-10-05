using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DynTargetTween
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public class DynTargetTweener : IHotfixable
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EB")]
		public Tween activeTween
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x554F460", Offset = "0x554E060", VA = "0x18554F460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000EC")]
		public RefTuple targets
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x554F4C0", Offset = "0x554E0C0", VA = "0x18554F4C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x554F300", Offset = "0x554DF00", VA = "0x18554F300")]
		public void SetTargets(RefTuple targets)
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x554F380", Offset = "0x554DF80", VA = "0x18554F380")]
		public void SetTween(Tween tween)
		{
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x554F400", Offset = "0x554E000", VA = "0x18554F400")]
		public DynTargetTweener()
		{
		}

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x10")]
		private Tween m_activeTween;

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x18")]
		private RefTuple m_targets;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate215 __Hotfix0_get_activeTween;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate214 __Hotfix0_get_targets;

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate0 __Hotfix0_SetTargets;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate0 __Hotfix0_SetTween;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
