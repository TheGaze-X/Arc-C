using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C75 RID: 7285
	[Token(Token = "0x2001C75")]
	public class BuildingStationSelectConfirmHomeState : PopupFloatState, IHotfixable
	{
		// Token: 0x0600B4FB RID: 46331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4FB")]
		[Address(RVA = "0x32F22F0", Offset = "0x32F0EF0", VA = "0x1832F22F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4FC")]
		[Address(RVA = "0x32F2490", Offset = "0x32F1090", VA = "0x1832F2490", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x00044BB0 File Offset: 0x00042DB0
		[Token(Token = "0x600B4FD")]
		[Address(RVA = "0x32F2980", Offset = "0x32F1580", VA = "0x1832F2980", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4FE")]
		[Address(RVA = "0x32F2780", Offset = "0x32F1380", VA = "0x1832F2780", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4FF")]
		[Address(RVA = "0x32F2580", Offset = "0x32F1180", VA = "0x1832F2580", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B500")]
		[Address(RVA = "0x32F31D0", Offset = "0x32F1DD0", VA = "0x1832F31D0")]
		private void _OnJumpFromAssistReportState(CharSelectStateBean stateBean)
		{
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B501")]
		[Address(RVA = "0x32F2AA0", Offset = "0x32F16A0", VA = "0x1832F2AA0")]
		private List<int> _GenTrainingInstIds(List<int> selectedInstIds)
		{
			return null;
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B502")]
		[Address(RVA = "0x32F3050", Offset = "0x32F1C50", VA = "0x1832F3050")]
		private void _InitRoomList()
		{
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B503")]
		[Address(RVA = "0x32F2C40", Offset = "0x32F1840", VA = "0x1832F2C40")]
		private List<BuildingCharModel> _GenerateBuildingCharList(List<int> instIds)
		{
			return null;
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B504")]
		[Address(RVA = "0x32F2350", Offset = "0x32F0F50", VA = "0x1832F2350")]
		public void OnBackButtonPressed()
		{
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B505")]
		[Address(RVA = "0x32F23F0", Offset = "0x32F0FF0", VA = "0x1832F23F0")]
		public void OnConfirmButtonPressed()
		{
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B506")]
		[Address(RVA = "0x32F29F0", Offset = "0x32F15F0", VA = "0x1832F29F0")]
		private IEnumerator _ConfirmWhenTransFinish()
		{
			return null;
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B507")]
		[Address(RVA = "0x32F3680", Offset = "0x32F2280", VA = "0x1832F3680")]
		public BuildingStationSelectConfirmHomeState()
		{
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B509")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x00044BC8 File Offset: 0x00042DC8
		[Token(Token = "0x600B50A")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B50B")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B50C")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400B0FA RID: 45306
		[Token(Token = "0x400B0FA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _roomListContent;

		// Token: 0x0400B0FB RID: 45307
		[Token(Token = "0x400B0FB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingStationSelectConfirmRoomListItemView _roomListPrefab;

		// Token: 0x0400B0FC RID: 45308
		[Token(Token = "0x400B0FC")]
		[FieldOffset(Offset = "0x80")]
		private StationSelectConfirmStateBean m_stateBean;

		// Token: 0x0400B0FD RID: 45309
		[Token(Token = "0x400B0FD")]
		[FieldOffset(Offset = "0x88")]
		private StationConfirmModel m_cachedModel;

		// Token: 0x0400B0FE RID: 45310
		[Token(Token = "0x400B0FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B0FF RID: 45311
		[Token(Token = "0x400B0FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B100 RID: 45312
		[Token(Token = "0x400B100")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0400B101 RID: 45313
		[Token(Token = "0x400B101")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0400B102 RID: 45314
		[Token(Token = "0x400B102")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400B103 RID: 45315
		[Token(Token = "0x400B103")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpFromAssistReportState;

		// Token: 0x0400B104 RID: 45316
		[Token(Token = "0x400B104")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenTrainingInstIds;

		// Token: 0x0400B105 RID: 45317
		[Token(Token = "0x400B105")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitRoomList;

		// Token: 0x0400B106 RID: 45318
		[Token(Token = "0x400B106")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateBuildingCharList;

		// Token: 0x0400B107 RID: 45319
		[Token(Token = "0x400B107")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBackButtonPressed;

		// Token: 0x0400B108 RID: 45320
		[Token(Token = "0x400B108")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnConfirmButtonPressed;

		// Token: 0x0400B109 RID: 45321
		[Token(Token = "0x400B109")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ConfirmWhenTransFinish;

		// Token: 0x0400B10A RID: 45322
		[Token(Token = "0x400B10A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
