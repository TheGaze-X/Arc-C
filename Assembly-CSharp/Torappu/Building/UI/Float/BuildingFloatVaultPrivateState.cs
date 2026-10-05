using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Building.DIY.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DEA RID: 7658
	[Token(Token = "0x2001DEA")]
	public class BuildingFloatVaultPrivateState : BuildingFloatVaultInfoState
	{
		// Token: 0x170016E0 RID: 5856
		// (get) Token: 0x0600BD18 RID: 48408 RVA: 0x000463C8 File Offset: 0x000445C8
		[Token(Token = "0x170016E0")]
		public bool DIYShopShown
		{
			[Token(Token = "0x600BD18")]
			[Address(RVA = "0x33AE300", Offset = "0x33ACF00", VA = "0x1833AE300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x0600BD19 RID: 48409 RVA: 0x000463E0 File Offset: 0x000445E0
		[Token(Token = "0x170016E1")]
		protected override FloatState state
		{
			[Token(Token = "0x600BD19")]
			[Address(RVA = "0x33AE3C0", Offset = "0x33ACFC0", VA = "0x1833AE3C0", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1A")]
		[Address(RVA = "0x33AD310", Offset = "0x33ABF10", VA = "0x1833AD310", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BD1B RID: 48411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1B")]
		[Address(RVA = "0x33ACFF0", Offset = "0x33ABBF0", VA = "0x1833ACFF0", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1C")]
		[Address(RVA = "0x33AD680", Offset = "0x33AC280", VA = "0x1833AD680", Slot = "16")]
		protected override void TriggerModeChange()
		{
		}

		// Token: 0x0600BD1D RID: 48413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1D")]
		[Address(RVA = "0x33AD230", Offset = "0x33ABE30", VA = "0x1833AD230", Slot = "7")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600BD1E RID: 48414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1E")]
		[Address(RVA = "0x33AD5B0", Offset = "0x33AC1B0", VA = "0x1833AD5B0", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD1F")]
		[Address(RVA = "0x33AD510", Offset = "0x33AC110", VA = "0x1833AD510", Slot = "9")]
		protected override void OnStateFocusUpdate()
		{
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD20")]
		[Address(RVA = "0x33ADD00", Offset = "0x33AC900", VA = "0x1833ADD00")]
		private void _UpdatePrivateRoomInfo()
		{
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD21")]
		[Address(RVA = "0x33ADB10", Offset = "0x33AC710", VA = "0x1833ADB10")]
		private void _UpdateFavorUpLevel(int comfort)
		{
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x000463F8 File Offset: 0x000445F8
		[Token(Token = "0x600BD22")]
		[Address(RVA = "0x33AD960", Offset = "0x33AC560", VA = "0x1833AD960")]
		private int _LoadComfortBySlot(RoomSlotModel slotModel)
		{
			return 0;
		}

		// Token: 0x0600BD23 RID: 48419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD23")]
		[Address(RVA = "0x33ACC90", Offset = "0x33AB890", VA = "0x1833ACC90")]
		public void EventOnDIYClick()
		{
		}

		// Token: 0x0600BD24 RID: 48420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD24")]
		[Address(RVA = "0x33ACDB0", Offset = "0x33AB9B0", VA = "0x1833ACDB0")]
		public void EventOnDIYShopClick()
		{
		}

		// Token: 0x0600BD25 RID: 48421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD25")]
		[Address(RVA = "0x33AE280", Offset = "0x33ACE80", VA = "0x1833AE280")]
		public BuildingFloatVaultPrivateState()
		{
		}

		// Token: 0x0600BD27 RID: 48423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD27")]
		[Address(RVA = "0x3389D30", Offset = "0x3388930", VA = "0x183389D30")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BD28 RID: 48424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD28")]
		[Address(RVA = "0x3389D20", Offset = "0x3388920", VA = "0x183389D20")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD29")]
		[Address(RVA = "0x33AB780", Offset = "0x33AA380", VA = "0x1833AB780")]
		private void <>xLuaBaseProxy_TriggerModeChange()
		{
		}

		// Token: 0x0600BD2A RID: 48426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2A")]
		[Address(RVA = "0x33AA0A0", Offset = "0x33A8CA0", VA = "0x1833AA0A0")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0600BD2B RID: 48427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2B")]
		[Address(RVA = "0x3387830", Offset = "0x3386430", VA = "0x183387830")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BD2C RID: 48428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2C")]
		[Address(RVA = "0x33A3160", Offset = "0x33A1D60", VA = "0x1833A3160")]
		private void <>xLuaBaseProxy_OnStateFocusUpdate()
		{
		}

		// Token: 0x0400BD48 RID: 48456
		[Token(Token = "0x400BD48")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Info bar")]
		private Text _comfortText;

		// Token: 0x0400BD49 RID: 48457
		[Token(Token = "0x400BD49")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Info bar")]
		private GameObject _panelNoCharTip;

		// Token: 0x0400BD4A RID: 48458
		[Token(Token = "0x400BD4A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Info bar")]
		private GameObject _panelFavor;

		// Token: 0x0400BD4B RID: 48459
		[Token(Token = "0x400BD4B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Info bar")]
		private Text _txtFavor;

		// Token: 0x0400BD4C RID: 48460
		[Token(Token = "0x400BD4C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Info bar")]
		private Image _imgFavorUpLevel;

		// Token: 0x0400BD4D RID: 48461
		[Token(Token = "0x400BD4D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Info bar")]
		private Sprite[] _favorUpLevelIcons;

		// Token: 0x0400BD4E RID: 48462
		[Token(Token = "0x400BD4E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Info bar")]
		private GameObject _panelRoomChar;

		// Token: 0x0400BD4F RID: 48463
		[Token(Token = "0x400BD4F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Info bar")]
		private Image _imgRoomChar;

		// Token: 0x0400BD50 RID: 48464
		[Token(Token = "0x400BD50")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Info bar")]
		private GameObject _panelCharRecall;

		// Token: 0x0400BD51 RID: 48465
		[Token(Token = "0x400BD51")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _shopPanelHolder;

		// Token: 0x0400BD52 RID: 48466
		[Token(Token = "0x400BD52")]
		[FieldOffset(Offset = "0xF0")]
		private DIYShopPanel m_diyShopPanel;

		// Token: 0x0400BD53 RID: 48467
		[Token(Token = "0x400BD53")]
		[FieldOffset(Offset = "0xF8")]
		private Coroutine m_interactFurniture;

		// Token: 0x0400BD54 RID: 48468
		[Token(Token = "0x400BD54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_DIYShopShown;

		// Token: 0x0400BD55 RID: 48469
		[Token(Token = "0x400BD55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BD56 RID: 48470
		[Token(Token = "0x400BD56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BD57 RID: 48471
		[Token(Token = "0x400BD57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BD58 RID: 48472
		[Token(Token = "0x400BD58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerModeChange;

		// Token: 0x0400BD59 RID: 48473
		[Token(Token = "0x400BD59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BD5A RID: 48474
		[Token(Token = "0x400BD5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BD5B RID: 48475
		[Token(Token = "0x400BD5B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStateFocusUpdate;

		// Token: 0x0400BD5C RID: 48476
		[Token(Token = "0x400BD5C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdatePrivateRoomInfo;

		// Token: 0x0400BD5D RID: 48477
		[Token(Token = "0x400BD5D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateFavorUpLevel;

		// Token: 0x0400BD5E RID: 48478
		[Token(Token = "0x400BD5E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadComfortBySlot;

		// Token: 0x0400BD5F RID: 48479
		[Token(Token = "0x400BD5F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnDIYClick;

		// Token: 0x0400BD60 RID: 48480
		[Token(Token = "0x400BD60")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnDIYShopClick;

		// Token: 0x0400BD61 RID: 48481
		[Token(Token = "0x400BD61")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
