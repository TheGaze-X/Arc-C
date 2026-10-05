using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D5E RID: 19806
	[Token(Token = "0x2004D5E")]
	public class FriendNameCardMedalState : PopupFloatState
	{
		// Token: 0x0601DA20 RID: 121376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DA20")]
		[Address(RVA = "0x1729890", Offset = "0x1728490", VA = "0x181729890", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601DA21 RID: 121377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA21")]
		[Address(RVA = "0x1729EC0", Offset = "0x1728AC0", VA = "0x181729EC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DA22 RID: 121378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA22")]
		[Address(RVA = "0x1729CB0", Offset = "0x17288B0", VA = "0x181729CB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601DA23 RID: 121379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA23")]
		[Address(RVA = "0x17298F0", Offset = "0x17284F0", VA = "0x1817298F0")]
		public void OnClickEvent(NameCardMedalType type, string groupId)
		{
		}

		// Token: 0x0601DA24 RID: 121380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA24")]
		[Address(RVA = "0x17299E0", Offset = "0x17285E0", VA = "0x1817299E0")]
		public void OnClickSendNewState()
		{
		}

		// Token: 0x0601DA25 RID: 121381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA25")]
		[Address(RVA = "0x1729FF0", Offset = "0x1728BF0", VA = "0x181729FF0")]
		public FriendNameCardMedalState()
		{
		}

		// Token: 0x0601DA27 RID: 121383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DA27")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04027237 RID: 160311
		[Token(Token = "0x4027237")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FriendNameCardMedalHolder _holder;

		// Token: 0x04027238 RID: 160312
		[Token(Token = "0x4027238")]
		[FieldOffset(Offset = "0x78")]
		private FriendNameCardMedalStateBean m_stateBean;

		// Token: 0x04027239 RID: 160313
		[Token(Token = "0x4027239")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402723A RID: 160314
		[Token(Token = "0x402723A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402723B RID: 160315
		[Token(Token = "0x402723B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402723C RID: 160316
		[Token(Token = "0x402723C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402723D RID: 160317
		[Token(Token = "0x402723D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0402723E RID: 160318
		[Token(Token = "0x402723E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickSendNewState;

		// Token: 0x0402723F RID: 160319
		[Token(Token = "0x402723F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
