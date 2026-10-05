using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ED4 RID: 20180
	[Token(Token = "0x2004ED4")]
	public class FifthAnnivExploreMapEntryState : PopupFadeState
	{
		// Token: 0x0601E1BB RID: 123323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E1BB")]
		[Address(RVA = "0x17CF080", Offset = "0x17CDC80", VA = "0x1817CF080", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E1BC RID: 123324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1BC")]
		[Address(RVA = "0x17CF0E0", Offset = "0x17CDCE0", VA = "0x1817CF0E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E1BD RID: 123325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E1BD")]
		[Address(RVA = "0x17CF1C0", Offset = "0x17CDDC0", VA = "0x1817CF1C0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601E1BE RID: 123326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1BE")]
		[Address(RVA = "0x17CF3A0", Offset = "0x17CDFA0", VA = "0x1817CF3A0")]
		private void _OnJumpFromGroupChooseState(IStateBean stateBean)
		{
		}

		// Token: 0x0601E1BF RID: 123327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1BF")]
		[Address(RVA = "0x17CF640", Offset = "0x17CE240", VA = "0x1817CF640")]
		public FifthAnnivExploreMapEntryState()
		{
		}

		// Token: 0x0601E1C2 RID: 123330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E1C2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E1C3 RID: 123331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E1C3")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04028105 RID: 164101
		[Token(Token = "0x4028105")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _mapEntryGo;

		// Token: 0x04028106 RID: 164102
		[Token(Token = "0x4028106")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x04028107 RID: 164103
		[Token(Token = "0x4028107")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animEntrySideBar;

		// Token: 0x04028108 RID: 164104
		[Token(Token = "0x4028108")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private FifthAnnivExploreMapEffect _animMapEffect;

		// Token: 0x04028109 RID: 164105
		[Token(Token = "0x4028109")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x0402810A RID: 164106
		[Token(Token = "0x402810A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402810B RID: 164107
		[Token(Token = "0x402810B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402810C RID: 164108
		[Token(Token = "0x402810C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0402810D RID: 164109
		[Token(Token = "0x402810D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpFromGroupChooseState;

		// Token: 0x0402810E RID: 164110
		[Token(Token = "0x402810E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
