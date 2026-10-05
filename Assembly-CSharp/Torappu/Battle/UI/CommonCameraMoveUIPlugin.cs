using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003338 RID: 13112
	[Token(Token = "0x2003338")]
	public class CommonCameraMoveUIPlugin : UIController.Plugin
	{
		// Token: 0x06014EAA RID: 85674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EAA")]
		[Address(RVA = "0xD56EC0", Offset = "0xD55AC0", VA = "0x180D56EC0", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014EAB RID: 85675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EAB")]
		[Address(RVA = "0xD570B0", Offset = "0xD55CB0", VA = "0x180D570B0")]
		public CommonCameraMoveUIPlugin()
		{
		}

		// Token: 0x06014EAD RID: 85677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EAD")]
		[Address(RVA = "0xD521A0", Offset = "0xD50DA0", VA = "0x180D521A0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x04018E03 RID: 101891
		[Token(Token = "0x4018E03")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_MOVE_CAMERA;

		// Token: 0x04018E04 RID: 101892
		[Token(Token = "0x4018E04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x04018E05 RID: 101893
		[Token(Token = "0x4018E05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x04018E06 RID: 101894
		[Token(Token = "0x4018E06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
