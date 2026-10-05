using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200331E RID: 13086
	[Token(Token = "0x200331E")]
	public class UIBattleStartState : UIStateNode
	{
		// Token: 0x17003144 RID: 12612
		// (get) Token: 0x06014CDE RID: 85214 RVA: 0x000888F0 File Offset: 0x00086AF0
		[Token(Token = "0x17003144")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014CDE")]
			[Address(RVA = "0xD3AB00", Offset = "0xD39700", VA = "0x180D3AB00", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003145 RID: 12613
		// (get) Token: 0x06014CDF RID: 85215 RVA: 0x00088908 File Offset: 0x00086B08
		[Token(Token = "0x17003145")]
		public override bool enablePause
		{
			[Token(Token = "0x6014CDF")]
			[Address(RVA = "0xD3A9E0", Offset = "0xD395E0", VA = "0x180D3A9E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003146 RID: 12614
		// (get) Token: 0x06014CE0 RID: 85216 RVA: 0x00088920 File Offset: 0x00086B20
		[Token(Token = "0x17003146")]
		public override bool enableShowRange
		{
			[Token(Token = "0x6014CE0")]
			[Address(RVA = "0xD3AA40", Offset = "0xD39640", VA = "0x180D3AA40", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003147 RID: 12615
		// (get) Token: 0x06014CE1 RID: 85217 RVA: 0x00088938 File Offset: 0x00086B38
		[Token(Token = "0x17003147")]
		public override bool enableSpeedSwitch
		{
			[Token(Token = "0x6014CE1")]
			[Address(RVA = "0xD3AAA0", Offset = "0xD396A0", VA = "0x180D3AAA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014CE2 RID: 85218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CE2")]
		[Address(RVA = "0xD3A780", Offset = "0xD39380", VA = "0x180D3A780", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06014CE3 RID: 85219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CE3")]
		[Address(RVA = "0xD3A920", Offset = "0xD39520", VA = "0x180D3A920", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014CE4 RID: 85220 RVA: 0x00088950 File Offset: 0x00086B50
		[Token(Token = "0x6014CE4")]
		[Address(RVA = "0xD3A6F0", Offset = "0xD392F0", VA = "0x180D3A6F0", Slot = "28")]
		public override bool CheckSwitchOut(int nextState)
		{
			return default(bool);
		}

		// Token: 0x06014CE5 RID: 85221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CE5")]
		[Address(RVA = "0xD3A980", Offset = "0xD39580", VA = "0x180D3A980")]
		public UIBattleStartState()
		{
		}

		// Token: 0x06014CE6 RID: 85222 RVA: 0x00088968 File Offset: 0x00086B68
		[Token(Token = "0x6014CE6")]
		[Address(RVA = "0x785E30", Offset = "0x784A30", VA = "0x180785E30")]
		private bool <>xLuaBaseProxy_get_enablePause()
		{
			return default(bool);
		}

		// Token: 0x06014CE7 RID: 85223 RVA: 0x00088980 File Offset: 0x00086B80
		[Token(Token = "0x6014CE7")]
		[Address(RVA = "0x7E9420", Offset = "0x7E8020", VA = "0x1807E9420")]
		private bool <>xLuaBaseProxy_get_enableShowRange()
		{
			return default(bool);
		}

		// Token: 0x06014CE8 RID: 85224 RVA: 0x00088998 File Offset: 0x00086B98
		[Token(Token = "0x6014CE8")]
		[Address(RVA = "0x785E40", Offset = "0x784A40", VA = "0x180785E40")]
		private bool <>xLuaBaseProxy_get_enableSpeedSwitch()
		{
			return default(bool);
		}

		// Token: 0x06014CE9 RID: 85225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014CE9")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x06014CEA RID: 85226 RVA: 0x000889B0 File Offset: 0x00086BB0
		[Token(Token = "0x6014CEA")]
		[Address(RVA = "0x7E9410", Offset = "0x7E8010", VA = "0x1807E9410")]
		private bool <>xLuaBaseProxy_CheckSwitchOut(int P0)
		{
			return default(bool);
		}

		// Token: 0x04018BEB RID: 101355
		[Token(Token = "0x4018BEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBattleStartPanel _startPanel;

		// Token: 0x04018BEC RID: 101356
		[Token(Token = "0x4018BEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018BED RID: 101357
		[Token(Token = "0x4018BED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x04018BEE RID: 101358
		[Token(Token = "0x4018BEE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableShowRange;

		// Token: 0x04018BEF RID: 101359
		[Token(Token = "0x4018BEF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_enableSpeedSwitch;

		// Token: 0x04018BF0 RID: 101360
		[Token(Token = "0x4018BF0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04018BF1 RID: 101361
		[Token(Token = "0x4018BF1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018BF2 RID: 101362
		[Token(Token = "0x4018BF2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckSwitchOut;

		// Token: 0x04018BF3 RID: 101363
		[Token(Token = "0x4018BF3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
