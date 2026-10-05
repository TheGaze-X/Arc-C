using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x02007903 RID: 30979
	[Token(Token = "0x2007903")]
	public class GameCityShowInfoState : UIStateNode
	{
		// Token: 0x170065CA RID: 26058
		// (get) Token: 0x0602B730 RID: 177968 RVA: 0x000DBFD8 File Offset: 0x000DA1D8
		[Token(Token = "0x170065CA")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x602B730")]
			[Address(RVA = "0x275C700", Offset = "0x275B300", VA = "0x18275C700", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x0602B731 RID: 177969 RVA: 0x000DBFF0 File Offset: 0x000DA1F0
		[Token(Token = "0x170065CB")]
		public override bool enablePause
		{
			[Token(Token = "0x602B731")]
			[Address(RVA = "0x275C580", Offset = "0x275B180", VA = "0x18275C580", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x0602B732 RID: 177970 RVA: 0x000DC008 File Offset: 0x000DA208
		[Token(Token = "0x170065CC")]
		public override bool enableShowRange
		{
			[Token(Token = "0x602B732")]
			[Address(RVA = "0x275C640", Offset = "0x275B240", VA = "0x18275C640", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065CD RID: 26061
		// (get) Token: 0x0602B733 RID: 177971 RVA: 0x000DC020 File Offset: 0x000DA220
		[Token(Token = "0x170065CD")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x602B733")]
			[Address(RVA = "0x275C6A0", Offset = "0x275B2A0", VA = "0x18275C6A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x0602B734 RID: 177972 RVA: 0x000DC038 File Offset: 0x000DA238
		[Token(Token = "0x170065CE")]
		public override bool enablePerspectiveCanvas
		{
			[Token(Token = "0x602B734")]
			[Address(RVA = "0x275C5E0", Offset = "0x275B1E0", VA = "0x18275C5E0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602B735 RID: 177973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B735")]
		[Address(RVA = "0x275C010", Offset = "0x275AC10", VA = "0x18275C010", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0602B736 RID: 177974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B736")]
		[Address(RVA = "0x275C410", Offset = "0x275B010", VA = "0x18275C410", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0602B737 RID: 177975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B737")]
		[Address(RVA = "0x275C4C0", Offset = "0x275B0C0", VA = "0x18275C4C0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0602B738 RID: 177976 RVA: 0x000DC050 File Offset: 0x000DA250
		[Token(Token = "0x602B738")]
		[Address(RVA = "0x275BFA0", Offset = "0x275ABA0", VA = "0x18275BFA0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x0602B739 RID: 177977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B739")]
		[Address(RVA = "0x275C520", Offset = "0x275B120", VA = "0x18275C520")]
		public GameCityShowInfoState()
		{
		}

		// Token: 0x0602B73A RID: 177978 RVA: 0x000DC068 File Offset: 0x000DA268
		[Token(Token = "0x602B73A")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x0602B73B RID: 177979 RVA: 0x000DC080 File Offset: 0x000DA280
		[Token(Token = "0x602B73B")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x0602B73C RID: 177980 RVA: 0x000DC098 File Offset: 0x000DA298
		[Token(Token = "0x602B73C")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x0602B73D RID: 177981 RVA: 0x000DC0B0 File Offset: 0x000DA2B0
		[Token(Token = "0x602B73D")]
		[Address(RVA = "0x962380", Offset = "0x960F80", VA = "0x180962380")]
		private bool <>xLuaBaseProxy_get_enablePerspectiveCanvas()
		{
			return default(bool);
		}

		// Token: 0x0602B73E RID: 177982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B73E")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0602B73F RID: 177983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B73F")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x0602B740 RID: 177984 RVA: 0x000DC0C8 File Offset: 0x000DA2C8
		[Token(Token = "0x602B740")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0403ED46 RID: 257350
		[Token(Token = "0x403ED46")]
		private const string SHOW_INFO_ANIMATION = "act1arcade_gamestart_in";

		// Token: 0x0403ED47 RID: 257351
		[Token(Token = "0x403ED47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameCityInfoShowPanel _perform;

		// Token: 0x0403ED48 RID: 257352
		[Token(Token = "0x403ED48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x0403ED49 RID: 257353
		[Token(Token = "0x403ED49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0403ED4A RID: 257354
		[Token(Token = "0x403ED4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x0403ED4B RID: 257355
		[Token(Token = "0x403ED4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x0403ED4C RID: 257356
		[Token(Token = "0x403ED4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_enablePerspectiveCanvas;

		// Token: 0x0403ED4D RID: 257357
		[Token(Token = "0x403ED4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403ED4E RID: 257358
		[Token(Token = "0x403ED4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403ED4F RID: 257359
		[Token(Token = "0x403ED4F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0403ED50 RID: 257360
		[Token(Token = "0x403ED50")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x0403ED51 RID: 257361
		[Token(Token = "0x403ED51")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
