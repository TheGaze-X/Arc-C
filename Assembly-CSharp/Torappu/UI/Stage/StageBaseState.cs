using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200687C RID: 26748
	[Token(Token = "0x200687C")]
	public abstract class StageBaseState : State
	{
		// Token: 0x060264F8 RID: 156920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264F8")]
		[Address(RVA = "0x2161940", Offset = "0x2160540", VA = "0x182161940", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060264F9 RID: 156921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264F9")]
		[Address(RVA = "0x2161A00", Offset = "0x2160600", VA = "0x182161A00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060264FA RID: 156922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264FA")]
		[Address(RVA = "0x2161AC0", Offset = "0x21606C0", VA = "0x182161AC0")]
		protected StageBaseState()
		{
		}

		// Token: 0x060264FB RID: 156923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264FB")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x060264FC RID: 156924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60264FC")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04035F78 RID: 221048
		[Token(Token = "0x4035F78")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Block the events when state changes")]
		protected GameObject _globalEventMask;

		// Token: 0x04035F79 RID: 221049
		[Token(Token = "0x4035F79")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04035F7A RID: 221050
		[Token(Token = "0x4035F7A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04035F7B RID: 221051
		[Token(Token = "0x4035F7B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
