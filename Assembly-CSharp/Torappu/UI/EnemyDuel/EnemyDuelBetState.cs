using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FC9 RID: 20425
	[Token(Token = "0x2004FC9")]
	public class EnemyDuelBetState : EnemyDuelBattleState, IValueMsgReceiver
	{
		// Token: 0x0601E54A RID: 124234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E54A")]
		[Address(RVA = "0x17FAFA0", Offset = "0x17F9BA0", VA = "0x1817FAFA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E54B RID: 124235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E54B")]
		[Address(RVA = "0x17FA580", Offset = "0x17F9180", VA = "0x1817FA580", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E54C RID: 124236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E54C")]
		[Address(RVA = "0x17FAED0", Offset = "0x17F9AD0", VA = "0x1817FAED0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601E54D RID: 124237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E54D")]
		[Address(RVA = "0x17FA4C0", Offset = "0x17F90C0", VA = "0x1817FA4C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E54E RID: 124238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E54E")]
		[Address(RVA = "0x17FA9F0", Offset = "0x17F95F0", VA = "0x1817FA9F0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E54F RID: 124239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E54F")]
		[Address(RVA = "0x17FB680", Offset = "0x17FA280", VA = "0x1817FB680")]
		private void _OnStatusChanged(object arg)
		{
		}

		// Token: 0x0601E550 RID: 124240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E550")]
		[Address(RVA = "0x17FB1F0", Offset = "0x17F9DF0", VA = "0x1817FB1F0")]
		private void _OnBetBtnClicked(EnemyDuelBetSelectStatus selectStatus)
		{
		}

		// Token: 0x0601E551 RID: 124241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E551")]
		[Address(RVA = "0x17FB4F0", Offset = "0x17FA0F0", VA = "0x1817FB4F0")]
		private void _OnEnemyDetailBtnClicked()
		{
		}

		// Token: 0x0601E552 RID: 124242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E552")]
		[Address(RVA = "0x17FB5C0", Offset = "0x17FA1C0", VA = "0x1817FB5C0")]
		private void _OnHideDetailPnlClicked()
		{
		}

		// Token: 0x0601E553 RID: 124243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E553")]
		[Address(RVA = "0x17FB360", Offset = "0x17F9F60", VA = "0x1817FB360")]
		private void _OnDisableEmoticonClicked()
		{
		}

		// Token: 0x0601E554 RID: 124244 RVA: 0x000AE300 File Offset: 0x000AC500
		[Token(Token = "0x601E554")]
		[Address(RVA = "0x17FB130", Offset = "0x17F9D30", VA = "0x1817FB130")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601E555 RID: 124245 RVA: 0x000AE318 File Offset: 0x000AC518
		[Token(Token = "0x601E555")]
		[Address(RVA = "0x17FA520", Offset = "0x17F9120", VA = "0x1817FA520", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E556 RID: 124246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E556")]
		[Address(RVA = "0x17FB7A0", Offset = "0x17FA3A0", VA = "0x1817FB7A0")]
		public EnemyDuelBetState()
		{
		}

		// Token: 0x0601E557 RID: 124247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E557")]
		[Address(RVA = "0x17FAF90", Offset = "0x17F9B90", VA = "0x1817FAF90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E558 RID: 124248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E558")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0402885E RID: 165982
		[Token(Token = "0x402885E")]
		[NonSerialized]
		public const int MSG_ON_BET_BTN_CLICKED = 0;

		// Token: 0x0402885F RID: 165983
		[Token(Token = "0x402885F")]
		[NonSerialized]
		public const int MSG_ON_ENEMY_DETAIL_BTN_CLICKED = 1;

		// Token: 0x04028860 RID: 165984
		[Token(Token = "0x4028860")]
		[NonSerialized]
		public const int MSG_ON_HIDE_ENEMY_DETAIL_PNL = 2;

		// Token: 0x04028861 RID: 165985
		[Token(Token = "0x4028861")]
		[NonSerialized]
		public const int MSG_ON_DISABLE_EMOTICON_CLICKED = 3;

		// Token: 0x04028862 RID: 165986
		[Token(Token = "0x4028862")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelBetView _view;

		// Token: 0x04028863 RID: 165987
		[Token(Token = "0x4028863")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04028864 RID: 165988
		[Token(Token = "0x4028864")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelBetProperty m_property;

		// Token: 0x04028865 RID: 165989
		[Token(Token = "0x4028865")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04028866 RID: 165990
		[Token(Token = "0x4028866")]
		[FieldOffset(Offset = "0xA8")]
		private UIAnimationTween m_showTween;

		// Token: 0x04028867 RID: 165991
		[Token(Token = "0x4028867")]
		[FieldOffset(Offset = "0xB0")]
		private EnemyDuelBattleCoolDownController m_coolDownController;

		// Token: 0x04028868 RID: 165992
		[Token(Token = "0x4028868")]
		[FieldOffset(Offset = "0xB8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028869 RID: 165993
		[Token(Token = "0x4028869")]
		[FieldOffset(Offset = "0xC8")]
		private float m_minBetCd;

		// Token: 0x0402886A RID: 165994
		[Token(Token = "0x402886A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402886B RID: 165995
		[Token(Token = "0x402886B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402886C RID: 165996
		[Token(Token = "0x402886C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402886D RID: 165997
		[Token(Token = "0x402886D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402886E RID: 165998
		[Token(Token = "0x402886E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402886F RID: 165999
		[Token(Token = "0x402886F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStatusChanged;

		// Token: 0x04028870 RID: 166000
		[Token(Token = "0x4028870")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBetBtnClicked;

		// Token: 0x04028871 RID: 166001
		[Token(Token = "0x4028871")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnEnemyDetailBtnClicked;

		// Token: 0x04028872 RID: 166002
		[Token(Token = "0x4028872")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnHideDetailPnlClicked;

		// Token: 0x04028873 RID: 166003
		[Token(Token = "0x4028873")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnDisableEmoticonClicked;

		// Token: 0x04028874 RID: 166004
		[Token(Token = "0x4028874")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x04028875 RID: 166005
		[Token(Token = "0x4028875")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x04028876 RID: 166006
		[Token(Token = "0x4028876")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
