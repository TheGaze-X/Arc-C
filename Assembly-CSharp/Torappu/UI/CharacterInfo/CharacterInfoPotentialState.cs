using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005ED6 RID: 24278
	[Token(Token = "0x2005ED6")]
	public class CharacterInfoPotentialState : State
	{
		// Token: 0x060232AE RID: 144046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232AE")]
		[Address(RVA = "0x1DAD550", Offset = "0x1DAC150", VA = "0x181DAD550", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060232AF RID: 144047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232AF")]
		[Address(RVA = "0x1DAE0E0", Offset = "0x1DACCE0", VA = "0x181DAE0E0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060232B0 RID: 144048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B0")]
		[Address(RVA = "0x1DAD620", Offset = "0x1DAC220", VA = "0x181DAD620", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060232B1 RID: 144049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B1")]
		[Address(RVA = "0x1DADD10", Offset = "0x1DAC910", VA = "0x181DADD10", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060232B2 RID: 144050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B2")]
		[Address(RVA = "0x1DAE7E0", Offset = "0x1DAD3E0", VA = "0x181DAE7E0")]
		private void _OnJumpToPotentialFullState(IStateBean stateBean)
		{
		}

		// Token: 0x060232B3 RID: 144051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B3")]
		[Address(RVA = "0x1DAD5B0", Offset = "0x1DAC1B0", VA = "0x181DAD5B0")]
		public void OnCancelClick()
		{
		}

		// Token: 0x060232B4 RID: 144052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B4")]
		[Address(RVA = "0x1DAD870", Offset = "0x1DAC470", VA = "0x181DAD870")]
		public void OnItemClick(string itemId)
		{
		}

		// Token: 0x060232B5 RID: 144053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B5")]
		[Address(RVA = "0x1DADE40", Offset = "0x1DACA40", VA = "0x181DADE40")]
		public void OnVoucherClick(string itemId)
		{
		}

		// Token: 0x060232B6 RID: 144054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B6")]
		[Address(RVA = "0x1DAE900", Offset = "0x1DAD500", VA = "0x181DAE900")]
		private void _RefreshDataAfterLvlUp()
		{
		}

		// Token: 0x060232B7 RID: 144055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B7")]
		[Address(RVA = "0x1DAEAB0", Offset = "0x1DAD6B0", VA = "0x181DAEAB0")]
		private void _ShowPotentialNotify(bool isSuc)
		{
		}

		// Token: 0x060232B8 RID: 144056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B8")]
		[Address(RVA = "0x1DAE380", Offset = "0x1DACF80", VA = "0x181DAE380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060232B9 RID: 144057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232B9")]
		[Address(RVA = "0x1DAE6B0", Offset = "0x1DAD2B0", VA = "0x181DAE6B0")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x060232BA RID: 144058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232BA")]
		[Address(RVA = "0x1DAE450", Offset = "0x1DAD050", VA = "0x181DAE450")]
		private void _ItemRequest(string itemId)
		{
		}

		// Token: 0x060232BB RID: 144059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232BB")]
		[Address(RVA = "0x1DAEB80", Offset = "0x1DAD780", VA = "0x181DAEB80")]
		public CharacterInfoPotentialState()
		{
		}

		// Token: 0x060232BF RID: 144063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60232BF")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060232C0 RID: 144064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232C0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060232C1 RID: 144065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60232C1")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04030777 RID: 198519
		[Token(Token = "0x4030777")]
		private const string ANIM_ENTER = "potential_page_enter";

		// Token: 0x04030778 RID: 198520
		[Token(Token = "0x4030778")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterInfoPotentialView _view;

		// Token: 0x04030779 RID: 198521
		[Token(Token = "0x4030779")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterInfoPotentialNotifyView _potentialNotifyPrefab;

		// Token: 0x0403077A RID: 198522
		[Token(Token = "0x403077A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403077B RID: 198523
		[Token(Token = "0x403077B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403077C RID: 198524
		[Token(Token = "0x403077C")]
		[FieldOffset(Offset = "0x70")]
		private CharacterInfoPotentialStateBean m_stateBean;

		// Token: 0x0403077D RID: 198525
		[Token(Token = "0x403077D")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403077E RID: 198526
		[Token(Token = "0x403077E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403077F RID: 198527
		[Token(Token = "0x403077F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04030780 RID: 198528
		[Token(Token = "0x4030780")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030781 RID: 198529
		[Token(Token = "0x4030781")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04030782 RID: 198530
		[Token(Token = "0x4030782")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToPotentialFullState;

		// Token: 0x04030783 RID: 198531
		[Token(Token = "0x4030783")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x04030784 RID: 198532
		[Token(Token = "0x4030784")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04030785 RID: 198533
		[Token(Token = "0x4030785")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnVoucherClick;

		// Token: 0x04030786 RID: 198534
		[Token(Token = "0x4030786")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshDataAfterLvlUp;

		// Token: 0x04030787 RID: 198535
		[Token(Token = "0x4030787")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowPotentialNotify;

		// Token: 0x04030788 RID: 198536
		[Token(Token = "0x4030788")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030789 RID: 198537
		[Token(Token = "0x4030789")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0403078A RID: 198538
		[Token(Token = "0x403078A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ItemRequest;

		// Token: 0x0403078B RID: 198539
		[Token(Token = "0x403078B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
