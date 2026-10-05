using System;
using Il2CppDummyDll;
using Torappu.Battle.UI.HalfIdle;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200329D RID: 12957
	[Token(Token = "0x200329D")]
	public class HalfIdleUIDragAndPutDownTrapState : UIDragAndPutDownState
	{
		// Token: 0x170030B5 RID: 12469
		// (get) Token: 0x06014941 RID: 84289 RVA: 0x00087870 File Offset: 0x00085A70
		[Token(Token = "0x170030B5")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014941")]
			[Address(RVA = "0xCD24A0", Offset = "0xCD10A0", VA = "0x180CD24A0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x06014942 RID: 84290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030B6")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6014942")]
			[Address(RVA = "0xCD20F0", Offset = "0xCD0CF0", VA = "0x180CD20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06014943 RID: 84291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030B7")]
		private UICardList cardList
		{
			[Token(Token = "0x6014943")]
			[Address(RVA = "0xCD2070", Offset = "0xCD0C70", VA = "0x180CD2070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06014944 RID: 84292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030B8")]
		private Transform dragPlane
		{
			[Token(Token = "0x6014944")]
			[Address(RVA = "0xCD21F0", Offset = "0xCD0DF0", VA = "0x180CD21F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x06014945 RID: 84293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030B9")]
		protected override UIDirectionSelector directionSelector
		{
			[Token(Token = "0x6014945")]
			[Address(RVA = "0xCD2170", Offset = "0xCD0D70", VA = "0x180CD2170", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06014946 RID: 84294 RVA: 0x00087888 File Offset: 0x00085A88
		[Token(Token = "0x170030BA")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014946")]
			[Address(RVA = "0xCD22D0", Offset = "0xCD0ED0", VA = "0x180CD22D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06014947 RID: 84295 RVA: 0x000878A0 File Offset: 0x00085AA0
		[Token(Token = "0x170030BB")]
		public override bool enablePause
		{
			[Token(Token = "0x6014947")]
			[Address(RVA = "0xCD2270", Offset = "0xCD0E70", VA = "0x180CD2270", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170030BC RID: 12476
		// (get) Token: 0x06014948 RID: 84296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170030BC")]
		private HalfIdleUIPlugin uiPlugin
		{
			[Token(Token = "0x6014948")]
			[Address(RVA = "0xCD2330", Offset = "0xCD0F30", VA = "0x180CD2330")]
			get
			{
				return null;
			}
		}

		// Token: 0x06014949 RID: 84297 RVA: 0x000878B8 File Offset: 0x00085AB8
		[Token(Token = "0x6014949")]
		[Address(RVA = "0xCD1B90", Offset = "0xCD0790", VA = "0x180CD1B90", Slot = "30")]
		protected override bool NeedPutDownCamera()
		{
			return default(bool);
		}

		// Token: 0x0601494A RID: 84298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601494A")]
		[Address(RVA = "0xCD1F60", Offset = "0xCD0B60", VA = "0x180CD1F60", Slot = "31")]
		protected override void _UpdateBuildableHighlight()
		{
		}

		// Token: 0x0601494B RID: 84299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601494B")]
		[Address(RVA = "0xCD1B10", Offset = "0xCD0710", VA = "0x180CD1B10", Slot = "33")]
		protected override void DisableUiCardIsOn(int nextState)
		{
		}

		// Token: 0x0601494C RID: 84300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601494C")]
		[Address(RVA = "0xCD1C80", Offset = "0xCD0880", VA = "0x180CD1C80", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601494D RID: 84301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601494D")]
		[Address(RVA = "0xCD1DB0", Offset = "0xCD09B0", VA = "0x180CD1DB0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0601494E RID: 84302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601494E")]
		[Address(RVA = "0xCD2010", Offset = "0xCD0C10", VA = "0x180CD2010")]
		public HalfIdleUIDragAndPutDownTrapState()
		{
		}

		// Token: 0x0601494F RID: 84303 RVA: 0x000878D0 File Offset: 0x00085AD0
		[Token(Token = "0x601494F")]
		[Address(RVA = "0xCD1F50", Offset = "0xCD0B50", VA = "0x180CD1F50")]
		private UIStateEnum <>xLuaBaseProxy_get_uiState()
		{
			return UIStateEnum.DEFAULT;
		}

		// Token: 0x06014950 RID: 84304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014950")]
		[Address(RVA = "0xCD1F20", Offset = "0xCD0B20", VA = "0x180CD1F20")]
		private UIDirectionSelector <>xLuaBaseProxy_get_directionSelector()
		{
			return null;
		}

		// Token: 0x06014951 RID: 84305 RVA: 0x000878E8 File Offset: 0x00085AE8
		[Token(Token = "0x6014951")]
		[Address(RVA = "0xCD1F40", Offset = "0xCD0B40", VA = "0x180CD1F40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014952 RID: 84306 RVA: 0x00087900 File Offset: 0x00085B00
		[Token(Token = "0x6014952")]
		[Address(RVA = "0xCD1F30", Offset = "0xCD0B30", VA = "0x180CD1F30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014953 RID: 84307 RVA: 0x00087918 File Offset: 0x00085B18
		[Token(Token = "0x6014953")]
		[Address(RVA = "0xCD1EE0", Offset = "0xCD0AE0", VA = "0x180CD1EE0")]
		private bool <>xLuaBaseProxy_NeedPutDownCamera()
		{
			return default(bool);
		}

		// Token: 0x06014954 RID: 84308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014954")]
		[Address(RVA = "0xCD1F10", Offset = "0xCD0B10", VA = "0x180CD1F10")]
		private void <>xLuaBaseProxy__UpdateBuildableHighlight()
		{
		}

		// Token: 0x06014955 RID: 84309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014955")]
		[Address(RVA = "0xCD1ED0", Offset = "0xCD0AD0", VA = "0x180CD1ED0")]
		private void <>xLuaBaseProxy_DisableUiCardIsOn(int P0)
		{
		}

		// Token: 0x06014956 RID: 84310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014956")]
		[Address(RVA = "0xCD1EF0", Offset = "0xCD0AF0", VA = "0x180CD1EF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014957 RID: 84311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014957")]
		[Address(RVA = "0xCD1F00", Offset = "0xCD0B00", VA = "0x180CD1F00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0401858F RID: 99727
		[Token(Token = "0x401858F")]
		private const string TRAP_DRAG_STATE = "TRAP_GRAG_STATE";

		// Token: 0x04018590 RID: 99728
		[Token(Token = "0x4018590")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018591 RID: 99729
		[Token(Token = "0x4018591")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x04018592 RID: 99730
		[Token(Token = "0x4018592")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardList;

		// Token: 0x04018593 RID: 99731
		[Token(Token = "0x4018593")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_dragPlane;

		// Token: 0x04018594 RID: 99732
		[Token(Token = "0x4018594")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_directionSelector;

		// Token: 0x04018595 RID: 99733
		[Token(Token = "0x4018595")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018596 RID: 99734
		[Token(Token = "0x4018596")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018597 RID: 99735
		[Token(Token = "0x4018597")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_uiPlugin;

		// Token: 0x04018598 RID: 99736
		[Token(Token = "0x4018598")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NeedPutDownCamera;

		// Token: 0x04018599 RID: 99737
		[Token(Token = "0x4018599")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateBuildableHighlight;

		// Token: 0x0401859A RID: 99738
		[Token(Token = "0x401859A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DisableUiCardIsOn;

		// Token: 0x0401859B RID: 99739
		[Token(Token = "0x401859B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401859C RID: 99740
		[Token(Token = "0x401859C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401859D RID: 99741
		[Token(Token = "0x401859D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
