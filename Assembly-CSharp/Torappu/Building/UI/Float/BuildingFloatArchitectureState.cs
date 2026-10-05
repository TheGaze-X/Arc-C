using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DC7 RID: 7623
	[Token(Token = "0x2001DC7")]
	public class BuildingFloatArchitectureState : BuildingFloatState
	{
		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x0600BC04 RID: 48132 RVA: 0x000460E0 File Offset: 0x000442E0
		[Token(Token = "0x170016C2")]
		protected override FloatState state
		{
			[Token(Token = "0x600BC04")]
			[Address(RVA = "0x3386F10", Offset = "0x3385B10", VA = "0x183386F10", Slot = "4")]
			get
			{
				return FloatState.NONE;
			}
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC05")]
		[Address(RVA = "0x3383C30", Offset = "0x3382830", VA = "0x183383C30")]
		private UIRoomIconSpriteHub _GetIconSpriteHub()
		{
			return null;
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC06")]
		[Address(RVA = "0x3383090", Offset = "0x3381C90", VA = "0x183383090")]
		private void OnEnable()
		{
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC07")]
		[Address(RVA = "0x3383A10", Offset = "0x3382610", VA = "0x183383A10", Slot = "8")]
		protected override void OnStateUpdated(bool isActive)
		{
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC08")]
		[Address(RVA = "0x33838A0", Offset = "0x33824A0", VA = "0x1833838A0", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC09")]
		[Address(RVA = "0x3383120", Offset = "0x3381D20", VA = "0x183383120", Slot = "6")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC0A")]
		[Address(RVA = "0x33834B0", Offset = "0x33820B0", VA = "0x1833834B0", Slot = "7")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BC0B")]
		[Address(RVA = "0x3383B00", Offset = "0x3382700", VA = "0x183383B00")]
		private Func<bool> _ActionCallback(RoomSlotModel model, Func<RoomSlotModel, bool> action)
		{
			return null;
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x000460F8 File Offset: 0x000442F8
		[Token(Token = "0x600BC0C")]
		[Address(RVA = "0x33858E0", Offset = "0x33844E0", VA = "0x1833858E0")]
		private bool _RoomCleanConfirmed(RoomSlotModel model)
		{
			return default(bool);
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x00046110 File Offset: 0x00044310
		[Token(Token = "0x600BC0D")]
		[Address(RVA = "0x3385090", Offset = "0x3383C90", VA = "0x183385090")]
		private bool _RoomBuildConfirmed(RoomSlotModel model)
		{
			return default(bool);
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x00046128 File Offset: 0x00044328
		[Token(Token = "0x600BC0E")]
		[Address(RVA = "0x3385E20", Offset = "0x3384A20", VA = "0x183385E20")]
		private bool _RoomLevelupConfirmed(RoomSlotModel model)
		{
			return default(bool);
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x00046140 File Offset: 0x00044340
		[Token(Token = "0x600BC0F")]
		[Address(RVA = "0x3386560", Offset = "0x3385160", VA = "0x183386560")]
		private bool _RoomTeardownConfirmed(RoomSlotModel model)
		{
			return default(bool);
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC10")]
		[Address(RVA = "0x3384400", Offset = "0x3383000", VA = "0x183384400")]
		private void _OnRoomRequestClean(object arg)
		{
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC11")]
		[Address(RVA = "0x33840B0", Offset = "0x3382CB0", VA = "0x1833840B0")]
		private void _OnRoomRequestBuild(object arg)
		{
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC12")]
		[Address(RVA = "0x3384750", Offset = "0x3383350", VA = "0x183384750")]
		private void _OnRoomRequestLevelup(object arg)
		{
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC13")]
		[Address(RVA = "0x3384AA0", Offset = "0x33836A0", VA = "0x183384AA0")]
		private void _OnRoomRequestTeardown(object arg)
		{
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC14")]
		[Address(RVA = "0x3384DF0", Offset = "0x33839F0", VA = "0x183384DF0")]
		private void _OnRoomShowDetail(object arg)
		{
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC15")]
		[Address(RVA = "0x3383DC0", Offset = "0x33829C0", VA = "0x183383DC0")]
		private void _OnBuildChoiceSelected(object arg)
		{
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC16")]
		[Address(RVA = "0x3383EB0", Offset = "0x3382AB0", VA = "0x183383EB0")]
		private void _OnRoomBuildComplete(BuildingData.RoomType builtRoomType)
		{
		}

		// Token: 0x0600BC17 RID: 48151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC17")]
		[Address(RVA = "0x3386E90", Offset = "0x3385A90", VA = "0x183386E90")]
		public BuildingFloatArchitectureState()
		{
		}

		// Token: 0x0600BC19 RID: 48153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC19")]
		[Address(RVA = "0x3383AF0", Offset = "0x33826F0", VA = "0x183383AF0")]
		private void <>xLuaBaseProxy_OnStateUpdated(bool P0)
		{
		}

		// Token: 0x0600BC1A RID: 48154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1A")]
		[Address(RVA = "0x3383AE0", Offset = "0x33826E0", VA = "0x183383AE0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600BC1B RID: 48155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1B")]
		[Address(RVA = "0x3383AC0", Offset = "0x33826C0", VA = "0x183383AC0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600BC1C RID: 48156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC1C")]
		[Address(RVA = "0x3383AD0", Offset = "0x33826D0", VA = "0x183383AD0")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400BC02 RID: 48130
		[Token(Token = "0x400BC02")]
		private const string BUTTON_SWITCH_ON = "SWITCH_ON";

		// Token: 0x0400BC03 RID: 48131
		[Token(Token = "0x400BC03")]
		private const float BY_SIDE_NOTIFY_DELAY = 0.5f;

		// Token: 0x0400BC04 RID: 48132
		[Token(Token = "0x400BC04")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color BUTTON_GRAY;

		// Token: 0x0400BC05 RID: 48133
		[Token(Token = "0x400BC05")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_roomDetailPanel;

		// Token: 0x0400BC06 RID: 48134
		[Token(Token = "0x400BC06")]
		[FieldOffset(Offset = "0x48")]
		private BuildingFloatArchSwitchView m_switchView;

		// Token: 0x0400BC07 RID: 48135
		[Token(Token = "0x400BC07")]
		[FieldOffset(Offset = "0x50")]
		private RoomSlotModel.RoomPanelInfo m_currentRoomPanelInfo;

		// Token: 0x0400BC08 RID: 48136
		[Token(Token = "0x400BC08")]
		[FieldOffset(Offset = "0x58")]
		private bool m_levelupValid;

		// Token: 0x0400BC09 RID: 48137
		[Token(Token = "0x400BC09")]
		[FieldOffset(Offset = "0x60")]
		private UIRoomIconSpriteHub m_roomIconSpriteHub;

		// Token: 0x0400BC0A RID: 48138
		[Token(Token = "0x400BC0A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400BC0B RID: 48139
		[Token(Token = "0x400BC0B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetIconSpriteHub;

		// Token: 0x0400BC0C RID: 48140
		[Token(Token = "0x400BC0C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400BC0D RID: 48141
		[Token(Token = "0x400BC0D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateUpdated;

		// Token: 0x0400BC0E RID: 48142
		[Token(Token = "0x400BC0E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400BC0F RID: 48143
		[Token(Token = "0x400BC0F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400BC10 RID: 48144
		[Token(Token = "0x400BC10")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400BC11 RID: 48145
		[Token(Token = "0x400BC11")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ActionCallback;

		// Token: 0x0400BC12 RID: 48146
		[Token(Token = "0x400BC12")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RoomCleanConfirmed;

		// Token: 0x0400BC13 RID: 48147
		[Token(Token = "0x400BC13")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RoomBuildConfirmed;

		// Token: 0x0400BC14 RID: 48148
		[Token(Token = "0x400BC14")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RoomLevelupConfirmed;

		// Token: 0x0400BC15 RID: 48149
		[Token(Token = "0x400BC15")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RoomTeardownConfirmed;

		// Token: 0x0400BC16 RID: 48150
		[Token(Token = "0x400BC16")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnRoomRequestClean;

		// Token: 0x0400BC17 RID: 48151
		[Token(Token = "0x400BC17")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnRoomRequestBuild;

		// Token: 0x0400BC18 RID: 48152
		[Token(Token = "0x400BC18")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnRoomRequestLevelup;

		// Token: 0x0400BC19 RID: 48153
		[Token(Token = "0x400BC19")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnRoomRequestTeardown;

		// Token: 0x0400BC1A RID: 48154
		[Token(Token = "0x400BC1A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnRoomShowDetail;

		// Token: 0x0400BC1B RID: 48155
		[Token(Token = "0x400BC1B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnBuildChoiceSelected;

		// Token: 0x0400BC1C RID: 48156
		[Token(Token = "0x400BC1C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnRoomBuildComplete;

		// Token: 0x0400BC1D RID: 48157
		[Token(Token = "0x400BC1D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
