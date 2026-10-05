using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DE8 RID: 7656
	[Token(Token = "0x2001DE8")]
	public abstract class BuildingFloatVaultInfoState : BuildingFloatState
	{
		// Token: 0x0600BCEE RID: 48366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEE")]
		[Address(RVA = "0x33AB520", Offset = "0x33AA120", VA = "0x1833AB520", Slot = "14")]
		protected virtual void Start()
		{
		}

		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x0600BCEF RID: 48367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DC")]
		protected FloatRoomDetailViewProperty detailProperty
		{
			[Token(Token = "0x600BCEF")]
			[Address(RVA = "0x33ACB90", Offset = "0x33AB790", VA = "0x1833ACB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170016DD RID: 5853
		// (get) Token: 0x0600BCF0 RID: 48368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016DD")]
		protected FloatStationViewProperty stationProperty
		{
			[Token(Token = "0x600BCF0")]
			[Address(RVA = "0x33ACC10", Offset = "0x33AB810", VA = "0x1833ACC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF1")]
		[Address(RVA = "0x33AB890", Offset = "0x33AA490", VA = "0x1833AB890")]
		public void TryToggleStationSlide()
		{
		}

		// Token: 0x0600BCF2 RID: 48370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF2")]
		[Address(RVA = "0x33AB7F0", Offset = "0x33AA3F0", VA = "0x1833AB7F0")]
		public void TryToggleRoomInfoSlide()
		{
		}

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF3")]
		[Address(RVA = "0x33AA840", Offset = "0x33A9440", VA = "0x1833AA840")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF4")]
		[Address(RVA = "0x33AA6F0", Offset = "0x33A92F0", VA = "0x1833AA6F0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF5")]
		[Address(RVA = "0x33AAF90", Offset = "0x33A9B90", VA = "0x1833AAF90", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF6")]
		[Address(RVA = "0x33AAA30", Offset = "0x33A9630", VA = "0x1833AAA30", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF7")]
		[Address(RVA = "0x33AB250", Offset = "0x33A9E50", VA = "0x1833AB250", Slot = "13")]
		protected override void OnProcIn()
		{
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF8")]
		[Address(RVA = "0x33AABB0", Offset = "0x33A97B0", VA = "0x1833AABB0", Slot = "7")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCF9")]
		[Address(RVA = "0x33AA550", Offset = "0x33A9150", VA = "0x1833AA550", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFA")]
		[Address(RVA = "0x33AB2D0", Offset = "0x33A9ED0", VA = "0x1833AB2D0", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFB")]
		[Address(RVA = "0x33AAED0", Offset = "0x33A9AD0", VA = "0x1833AAED0", Slot = "10")]
		public override void OnHandleSignal(string signal)
		{
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFC")]
		[Address(RVA = "0x33AB1C0", Offset = "0x33A9DC0", VA = "0x1833AB1C0", Slot = "15")]
		protected virtual void OnPlayerDataChanged(object args)
		{
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFD")]
		[Address(RVA = "0x33AC1F0", Offset = "0x33AADF0", VA = "0x1833AC1F0")]
		private void _OnFloatViewRequestToClose()
		{
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFE")]
		[Address(RVA = "0x33AA370", Offset = "0x33A8F70", VA = "0x1833AA370")]
		public void EventOnRoomInfoClicked()
		{
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCFF")]
		[Address(RVA = "0x33AA460", Offset = "0x33A9060", VA = "0x1833AA460")]
		public void EventOnStationInfoClicked()
		{
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD00")]
		[Address(RVA = "0x33AA250", Offset = "0x33A8E50", VA = "0x1833AA250")]
		public void EventOnActiveFurniClick()
		{
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD01")]
		[Address(RVA = "0x33AC850", Offset = "0x33AB450", VA = "0x1833AC850")]
		private void _TrySwitchToMode(BuildingFloatSlideMode targetMode)
		{
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD02")]
		[Address(RVA = "0x33AB780", Offset = "0x33AA380", VA = "0x1833AB780", Slot = "16")]
		protected virtual void TriggerModeChange()
		{
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD03")]
		[Address(RVA = "0x33ABC50", Offset = "0x33AA850", VA = "0x1833ABC50")]
		private void _LoadData()
		{
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD04")]
		[Address(RVA = "0x33AC270", Offset = "0x33AAE70", VA = "0x1833AC270")]
		private void _TryEnableFurnOutlineBySubType(BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD05")]
		[Address(RVA = "0x33AC3E0", Offset = "0x33AAFE0", VA = "0x1833AC3E0")]
		private void _TryEnableFurnOutlineByTrackPoint()
		{
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BD06")]
		[Address(RVA = "0x33ABB60", Offset = "0x33AA760", VA = "0x1833ABB60")]
		private IEnumerator _DisableFurniOutline(VDIYRoom diyRoom, BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD07")]
		[Address(RVA = "0x33AC980", Offset = "0x33AB580", VA = "0x1833AC980")]
		protected BuildingFloatVaultInfoState()
		{
		}

		// Token: 0x0600BD0B RID: 48395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0B")]
		[Address(RVA = "0x33A2C40", Offset = "0x33A1840", VA = "0x1833A2C40")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0C")]
		[Address(RVA = "0x33A2B20", Offset = "0x33A1720", VA = "0x1833A2B20")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0D")]
		[Address(RVA = "0x33A2CA0", Offset = "0x33A18A0", VA = "0x1833A2CA0")]
		private void <>xLuaBaseProxy_OnProcIn()
		{
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0E")]
		[Address(RVA = "0x33A2B80", Offset = "0x33A1780", VA = "0x1833A2B80")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD0F")]
		[Address(RVA = "0x33A2AC0", Offset = "0x33A16C0", VA = "0x1833A2AC0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0600BD10 RID: 48400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD10")]
		[Address(RVA = "0x33A31C0", Offset = "0x33A1DC0", VA = "0x1833A31C0")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD11")]
		[Address(RVA = "0x33A2BE0", Offset = "0x33A17E0", VA = "0x1833A2BE0")]
		private void <>xLuaBaseProxy_OnHandleSignal(string P0)
		{
		}

		// Token: 0x0400BD1E RID: 48414
		[Token(Token = "0x400BD1E")]
		[FieldOffset(Offset = "0x0")]
		public static string CLOSE_STATION_PANEL;

		// Token: 0x0400BD1F RID: 48415
		[Token(Token = "0x400BD1F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PrefabInstHolder _panelRoomInfoHolder;

		// Token: 0x0400BD20 RID: 48416
		[Token(Token = "0x400BD20")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PrefabInstHolder _panelStationInfoHolder;

		// Token: 0x0400BD21 RID: 48417
		[Token(Token = "0x400BD21")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingFloatSlideModeToggle[] _slideModeToggles;

		// Token: 0x0400BD22 RID: 48418
		[Token(Token = "0x400BD22")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("This is nullable")]
		private BuildingUIRoomTitle _roomTitle;

		// Token: 0x0400BD23 RID: 48419
		[Token(Token = "0x400BD23")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRoomTypeColorMap _roomTypeColorMap;

		// Token: 0x0400BD24 RID: 48420
		[Token(Token = "0x400BD24")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _detailLevelEmptyColor;

		// Token: 0x0400BD25 RID: 48421
		[Token(Token = "0x400BD25")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingFloatFurniBtnView _furniBtnView;

		// Token: 0x0400BD26 RID: 48422
		[Token(Token = "0x400BD26")]
		[FieldOffset(Offset = "0x80")]
		private FloatRoomDetailViewProperty m_detailProperty;

		// Token: 0x0400BD27 RID: 48423
		[Token(Token = "0x400BD27")]
		[FieldOffset(Offset = "0x88")]
		private FloatStationViewProperty m_stationProperty;

		// Token: 0x0400BD28 RID: 48424
		[Token(Token = "0x400BD28")]
		[FieldOffset(Offset = "0x90")]
		private CommonBasicRoomViewProperty m_basicRoomProperty;

		// Token: 0x0400BD29 RID: 48425
		[Token(Token = "0x400BD29")]
		[FieldOffset(Offset = "0x98")]
		private BuildingFloatSlideModeProperty m_slideProperty;

		// Token: 0x0400BD2A RID: 48426
		[Token(Token = "0x400BD2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BD2B RID: 48427
		[Token(Token = "0x400BD2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_detailProperty;

		// Token: 0x0400BD2C RID: 48428
		[Token(Token = "0x400BD2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_stationProperty;

		// Token: 0x0400BD2D RID: 48429
		[Token(Token = "0x400BD2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryToggleStationSlide;

		// Token: 0x0400BD2E RID: 48430
		[Token(Token = "0x400BD2E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryToggleRoomInfoSlide;

		// Token: 0x0400BD2F RID: 48431
		[Token(Token = "0x400BD2F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BD30 RID: 48432
		[Token(Token = "0x400BD30")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400BD31 RID: 48433
		[Token(Token = "0x400BD31")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BD32 RID: 48434
		[Token(Token = "0x400BD32")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BD33 RID: 48435
		[Token(Token = "0x400BD33")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnProcIn;

		// Token: 0x0400BD34 RID: 48436
		[Token(Token = "0x400BD34")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BD35 RID: 48437
		[Token(Token = "0x400BD35")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400BD36 RID: 48438
		[Token(Token = "0x400BD36")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD37 RID: 48439
		[Token(Token = "0x400BD37")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnHandleSignal;

		// Token: 0x0400BD38 RID: 48440
		[Token(Token = "0x400BD38")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400BD39 RID: 48441
		[Token(Token = "0x400BD39")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnFloatViewRequestToClose;

		// Token: 0x0400BD3A RID: 48442
		[Token(Token = "0x400BD3A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnRoomInfoClicked;

		// Token: 0x0400BD3B RID: 48443
		[Token(Token = "0x400BD3B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnStationInfoClicked;

		// Token: 0x0400BD3C RID: 48444
		[Token(Token = "0x400BD3C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnActiveFurniClick;

		// Token: 0x0400BD3D RID: 48445
		[Token(Token = "0x400BD3D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TrySwitchToMode;

		// Token: 0x0400BD3E RID: 48446
		[Token(Token = "0x400BD3E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TriggerModeChange;

		// Token: 0x0400BD3F RID: 48447
		[Token(Token = "0x400BD3F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0400BD40 RID: 48448
		[Token(Token = "0x400BD40")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TryEnableFurnOutlineBySubType;

		// Token: 0x0400BD41 RID: 48449
		[Token(Token = "0x400BD41")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TryEnableFurnOutlineByTrackPoint;

		// Token: 0x0400BD42 RID: 48450
		[Token(Token = "0x400BD42")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__DisableFurniOutline;

		// Token: 0x0400BD43 RID: 48451
		[Token(Token = "0x400BD43")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
