using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200638F RID: 25487
	[Token(Token = "0x200638F")]
	public abstract class AutoChessPrepareBaseState : PopupFadeState, IHotfixable
	{
		// Token: 0x06024C32 RID: 150578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C32")]
		[Address(RVA = "0x1F9DFC0", Offset = "0x1F9CBC0", VA = "0x181F9DFC0", Slot = "14")]
		protected sealed override void OnEnter()
		{
		}

		// Token: 0x06024C33 RID: 150579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C33")]
		[Address(RVA = "0x1F9E180", Offset = "0x1F9CD80", VA = "0x181F9E180", Slot = "31")]
		protected virtual void OnStateEnter()
		{
		}

		// Token: 0x06024C34 RID: 150580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C34")]
		[Address(RVA = "0x1F9E1E0", Offset = "0x1F9CDE0", VA = "0x181F9E1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C35 RID: 150581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C35")]
		[Address(RVA = "0x1F9E320", Offset = "0x1F9CF20", VA = "0x181F9E320")]
		protected AutoChessPrepareBaseState()
		{
		}

		// Token: 0x06024C36 RID: 150582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C36")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040335C8 RID: 210376
		[Token(Token = "0x40335C8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _bkgContainer;

		// Token: 0x040335C9 RID: 210377
		[Token(Token = "0x40335C9")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x040335CA RID: 210378
		[Token(Token = "0x40335CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040335CB RID: 210379
		[Token(Token = "0x40335CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x040335CC RID: 210380
		[Token(Token = "0x40335CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040335CD RID: 210381
		[Token(Token = "0x40335CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
