using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side.Battle.UI
{
	// Token: 0x0200761D RID: 30237
	[Token(Token = "0x200761D")]
	public class Act24sideUIPlugin : UIController.Plugin
	{
		// Token: 0x0602A913 RID: 174355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A913")]
		[Address(RVA = "0x2664040", Offset = "0x2662C40", VA = "0x182664040", Slot = "12")]
		public override void OnInitStateMachine(UIStateMachine stateMachine)
		{
		}

		// Token: 0x0602A914 RID: 174356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A914")]
		[Address(RVA = "0x2664200", Offset = "0x2662E00", VA = "0x182664200")]
		public Act24sideUIPlugin()
		{
		}

		// Token: 0x0602A916 RID: 174358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A916")]
		[Address(RVA = "0x7D24C0", Offset = "0x7D10C0", VA = "0x1807D24C0")]
		private void <>xLuaBaseProxy_OnInitStateMachine(UIStateMachine P0)
		{
		}

		// Token: 0x0403D49F RID: 251039
		[Token(Token = "0x403D49F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIStateEnum UI_STATE_MOVE_CAMERA;

		// Token: 0x0403D4A0 RID: 251040
		[Token(Token = "0x403D4A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStateNode[] _states;

		// Token: 0x0403D4A1 RID: 251041
		[Token(Token = "0x403D4A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInitStateMachine;

		// Token: 0x0403D4A2 RID: 251042
		[Token(Token = "0x403D4A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
