using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002100 RID: 8448
	[Token(Token = "0x2002100")]
	public class AlphaFadeInOutSpine : UnitAnimator.Behaviour
	{
		// Token: 0x0600CF14 RID: 53012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF14")]
		[Address(RVA = "0x3508C80", Offset = "0x3507880", VA = "0x183508C80", Slot = "4")]
		public override void Init(UnitAnimator unitAnimator)
		{
		}

		// Token: 0x0600CF15 RID: 53013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF15")]
		[Address(RVA = "0x3508FA0", Offset = "0x3507BA0", VA = "0x183508FA0", Slot = "5")]
		public override void OnFinish()
		{
		}

		// Token: 0x0600CF16 RID: 53014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF16")]
		[Address(RVA = "0x35093B0", Offset = "0x3507FB0", VA = "0x1835093B0")]
		public AlphaFadeInOutSpine()
		{
		}

		// Token: 0x0600CF19 RID: 53017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF19")]
		[Address(RVA = "0x3509390", Offset = "0x3507F90", VA = "0x183509390")]
		private void <>xLuaBaseProxy_Init(UnitAnimator P0)
		{
		}

		// Token: 0x0600CF1A RID: 53018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF1A")]
		[Address(RVA = "0x35093A0", Offset = "0x3507FA0", VA = "0x1835093A0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400DCDA RID: 56538
		[Token(Token = "0x400DCDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0400DCDB RID: 56539
		[Token(Token = "0x400DCDB")]
		[FieldOffset(Offset = "0x28")]
		private SpineAnimator m_animator;

		// Token: 0x0400DCDC RID: 56540
		[Token(Token = "0x400DCDC")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x0400DCDD RID: 56541
		[Token(Token = "0x400DCDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DCDE RID: 56542
		[Token(Token = "0x400DCDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400DCDF RID: 56543
		[Token(Token = "0x400DCDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
