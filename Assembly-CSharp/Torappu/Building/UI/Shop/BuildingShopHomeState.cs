using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CF2 RID: 7410
	[Token(Token = "0x2001CF2")]
	public class BuildingShopHomeState : State, ITimeWatcher
	{
		// Token: 0x0600B717 RID: 46871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B717")]
		[Address(RVA = "0x3341F70", Offset = "0x3340B70", VA = "0x183341F70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x00045198 File Offset: 0x00043398
		[Token(Token = "0x600B718")]
		[Address(RVA = "0x3342E50", Offset = "0x3341A50", VA = "0x183342E50", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B719")]
		[Address(RVA = "0x33425D0", Offset = "0x33411D0", VA = "0x1833425D0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B71A")]
		[Address(RVA = "0x3342730", Offset = "0x3341330", VA = "0x183342730", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B71B")]
		[Address(RVA = "0x3341FD0", Offset = "0x3340BD0", VA = "0x183341FD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B71C RID: 46876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B71C")]
		[Address(RVA = "0x3341ED0", Offset = "0x3340AD0", VA = "0x183341ED0")]
		public void EventOnHarestClick()
		{
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B71D")]
		[Address(RVA = "0x3343250", Offset = "0x3341E50", VA = "0x183343250")]
		private void _OnJumpToFormulaState(SFormulaStateBean formulaBean)
		{
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B71E")]
		[Address(RVA = "0x3343060", Offset = "0x3341C60", VA = "0x183343060")]
		private void _OnJumpBackFromFormulaState(SFormulaStateBean formulaBean)
		{
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B71F")]
		[Address(RVA = "0x3343700", Offset = "0x3342300", VA = "0x183343700")]
		private void _OnStockEditConfirmed(SStockViewModel stockModel)
		{
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B720")]
		[Address(RVA = "0x3343660", Offset = "0x3342260", VA = "0x183343660")]
		private void _OnStockEditCancelled(SStockViewModel stockModel)
		{
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B721")]
		[Address(RVA = "0x3343500", Offset = "0x3342100", VA = "0x183343500")]
		private void _OnStockCountEdited(SStockViewModel stockModel, int delta)
		{
		}

		// Token: 0x0600B722 RID: 46882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B722")]
		[Address(RVA = "0x33439F0", Offset = "0x33425F0", VA = "0x1833439F0")]
		private void _OnStockFormulaClicked(SStockViewModel stockModel)
		{
		}

		// Token: 0x0600B723 RID: 46883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B723")]
		[Address(RVA = "0x3343460", Offset = "0x3342060", VA = "0x183343460")]
		private void _OnStockCharClicked(SStockViewModel stockModel)
		{
		}

		// Token: 0x0600B724 RID: 46884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B724")]
		[Address(RVA = "0x33433D0", Offset = "0x3341FD0", VA = "0x1833433D0")]
		private void _OnRoomSelected(string slotId)
		{
		}

		// Token: 0x0600B725 RID: 46885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B725")]
		[Address(RVA = "0x3342D30", Offset = "0x3341930", VA = "0x183342D30", Slot = "23")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x0600B726 RID: 46886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B726")]
		[Address(RVA = "0x3343360", Offset = "0x3341F60", VA = "0x183343360")]
		private void _OnPlayerDataChanged()
		{
		}

		// Token: 0x0600B727 RID: 46887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B727")]
		[Address(RVA = "0x3342F90", Offset = "0x3341B90", VA = "0x183342F90")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0600B728 RID: 46888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B728")]
		[Address(RVA = "0x3343AA0", Offset = "0x33426A0", VA = "0x183343AA0")]
		private void _SendConfirmFormulaChangeService(SStockViewModel stockModel)
		{
		}

		// Token: 0x0600B729 RID: 46889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B729")]
		[Address(RVA = "0x3343F30", Offset = "0x3342B30", VA = "0x183343F30")]
		private void _SettleSale()
		{
		}

		// Token: 0x0600B72A RID: 46890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B72A")]
		[Address(RVA = "0x3344130", Offset = "0x3342D30", VA = "0x183344130")]
		private void _TryRequestSettleEffect()
		{
		}

		// Token: 0x0600B72B RID: 46891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B72B")]
		[Address(RVA = "0x3342EC0", Offset = "0x3341AC0", VA = "0x183342EC0")]
		private void _ClearResEffects()
		{
		}

		// Token: 0x0600B72C RID: 46892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B72C")]
		[Address(RVA = "0x3344490", Offset = "0x3343090", VA = "0x183344490")]
		public BuildingShopHomeState()
		{
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x000451B0 File Offset: 0x000433B0
		[Token(Token = "0x600B731")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B732")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B733")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B734")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400B4E8 RID: 46312
		[Token(Token = "0x400B4E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0400B4E9 RID: 46313
		[Token(Token = "0x400B4E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingShopTabGroup _tabGroup;

		// Token: 0x0400B4EA RID: 46314
		[Token(Token = "0x400B4EA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PrefabInstHolder[] _stockHolders;

		// Token: 0x0400B4EB RID: 46315
		[Token(Token = "0x400B4EB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuildingShopOutputSlot _outputSlot;

		// Token: 0x0400B4EC RID: 46316
		[Token(Token = "0x400B4EC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BuildingShopRoomTitle _roomTitle;

		// Token: 0x0400B4ED RID: 46317
		[Token(Token = "0x400B4ED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _settleAnchor;

		// Token: 0x0400B4EE RID: 46318
		[Token(Token = "0x400B4EE")]
		[FieldOffset(Offset = "0x80")]
		private SHomeStateBean m_stateBean;

		// Token: 0x0400B4EF RID: 46319
		[Token(Token = "0x400B4EF")]
		[FieldOffset(Offset = "0x88")]
		private SStockViewModel m_clickedStockCache;

		// Token: 0x0400B4F0 RID: 46320
		[Token(Token = "0x400B4F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B4F1 RID: 46321
		[Token(Token = "0x400B4F1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0400B4F2 RID: 46322
		[Token(Token = "0x400B4F2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0400B4F3 RID: 46323
		[Token(Token = "0x400B4F3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0400B4F4 RID: 46324
		[Token(Token = "0x400B4F4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B4F5 RID: 46325
		[Token(Token = "0x400B4F5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnHarestClick;

		// Token: 0x0400B4F6 RID: 46326
		[Token(Token = "0x400B4F6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToFormulaState;

		// Token: 0x0400B4F7 RID: 46327
		[Token(Token = "0x400B4F7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpBackFromFormulaState;

		// Token: 0x0400B4F8 RID: 46328
		[Token(Token = "0x400B4F8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnStockEditConfirmed;

		// Token: 0x0400B4F9 RID: 46329
		[Token(Token = "0x400B4F9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnStockEditCancelled;

		// Token: 0x0400B4FA RID: 46330
		[Token(Token = "0x400B4FA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnStockCountEdited;

		// Token: 0x0400B4FB RID: 46331
		[Token(Token = "0x400B4FB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnStockFormulaClicked;

		// Token: 0x0400B4FC RID: 46332
		[Token(Token = "0x400B4FC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnStockCharClicked;

		// Token: 0x0400B4FD RID: 46333
		[Token(Token = "0x400B4FD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnRoomSelected;

		// Token: 0x0400B4FE RID: 46334
		[Token(Token = "0x400B4FE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0400B4FF RID: 46335
		[Token(Token = "0x400B4FF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400B500 RID: 46336
		[Token(Token = "0x400B500")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0400B501 RID: 46337
		[Token(Token = "0x400B501")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SendConfirmFormulaChangeService;

		// Token: 0x0400B502 RID: 46338
		[Token(Token = "0x400B502")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SettleSale;

		// Token: 0x0400B503 RID: 46339
		[Token(Token = "0x400B503")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryRequestSettleEffect;

		// Token: 0x0400B504 RID: 46340
		[Token(Token = "0x400B504")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ClearResEffects;

		// Token: 0x0400B505 RID: 46341
		[Token(Token = "0x400B505")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
