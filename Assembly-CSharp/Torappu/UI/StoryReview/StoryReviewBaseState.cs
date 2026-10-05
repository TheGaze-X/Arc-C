using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048E6 RID: 18662
	[Token(Token = "0x20048E6")]
	public abstract class StoryReviewBaseState : State
	{
		// Token: 0x0601C27C RID: 115324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C27C")]
		[Address(RVA = "0x15A2EE0", Offset = "0x15A1AE0", VA = "0x1815A2EE0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601C27D RID: 115325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C27D")]
		[Address(RVA = "0x15A2FA0", Offset = "0x15A1BA0", VA = "0x1815A2FA0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C27E RID: 115326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C27E")]
		[Address(RVA = "0x15A3060", Offset = "0x15A1C60", VA = "0x1815A3060")]
		protected StoryReviewBaseState()
		{
		}

		// Token: 0x0601C27F RID: 115327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C27F")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601C280 RID: 115328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C280")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04024CE8 RID: 150760
		[Token(Token = "0x4024CE8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Block the events when state changes")]
		protected GameObject _globalEventMask;

		// Token: 0x04024CE9 RID: 150761
		[Token(Token = "0x4024CE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04024CEA RID: 150762
		[Token(Token = "0x4024CEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04024CEB RID: 150763
		[Token(Token = "0x4024CEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
