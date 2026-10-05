using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F32 RID: 28466
	[Token(Token = "0x2006F32")]
	public class ActMultiV3MatchState : State
	{
		// Token: 0x060286E7 RID: 165607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60286E7")]
		[Address(RVA = "0x23B99F0", Offset = "0x23B85F0", VA = "0x1823B99F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060286E8 RID: 165608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286E8")]
		[Address(RVA = "0x23B9A50", Offset = "0x23B8650", VA = "0x1823B9A50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060286E9 RID: 165609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286E9")]
		[Address(RVA = "0x23B9C50", Offset = "0x23B8850", VA = "0x1823B9C50")]
		private void _OpenMatchPage()
		{
		}

		// Token: 0x060286EA RID: 165610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286EA")]
		[Address(RVA = "0x23B9D50", Offset = "0x23B8950", VA = "0x1823B9D50")]
		public ActMultiV3MatchState()
		{
		}

		// Token: 0x060286EB RID: 165611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286EB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403982B RID: 235563
		[Token(Token = "0x403982B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _openMatchPageDelay;

		// Token: 0x0403982C RID: 235564
		[Token(Token = "0x403982C")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_delayTween;

		// Token: 0x0403982D RID: 235565
		[Token(Token = "0x403982D")]
		[FieldOffset(Offset = "0x60")]
		private string m_actId;

		// Token: 0x0403982E RID: 235566
		[Token(Token = "0x403982E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403982F RID: 235567
		[Token(Token = "0x403982F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039830 RID: 235568
		[Token(Token = "0x4039830")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OpenMatchPage;

		// Token: 0x04039831 RID: 235569
		[Token(Token = "0x4039831")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
