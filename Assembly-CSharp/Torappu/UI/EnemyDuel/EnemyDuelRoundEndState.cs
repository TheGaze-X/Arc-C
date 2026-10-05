using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005018 RID: 20504
	[Token(Token = "0x2005018")]
	public class EnemyDuelRoundEndState : EnemyDuelBattleState, IValueMsgReceiver
	{
		// Token: 0x0601E6B9 RID: 124601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E6B9")]
		[Address(RVA = "0x1834FB0", Offset = "0x1833BB0", VA = "0x181834FB0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E6BA RID: 124602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6BA")]
		[Address(RVA = "0x18351B0", Offset = "0x1833DB0", VA = "0x1818351B0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E6BB RID: 124603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6BB")]
		[Address(RVA = "0x1835070", Offset = "0x1833C70", VA = "0x181835070", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E6BC RID: 124604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6BC")]
		[Address(RVA = "0x1835450", Offset = "0x1834050", VA = "0x181835450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E6BD RID: 124605 RVA: 0x000AE678 File Offset: 0x000AC878
		[Token(Token = "0x601E6BD")]
		[Address(RVA = "0x1835010", Offset = "0x1833C10", VA = "0x181835010", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E6BE RID: 124606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6BE")]
		[Address(RVA = "0x18355F0", Offset = "0x18341F0", VA = "0x1818355F0")]
		public EnemyDuelRoundEndState()
		{
		}

		// Token: 0x0601E6BF RID: 124607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6BF")]
		[Address(RVA = "0x17FAF90", Offset = "0x17F9B90", VA = "0x1817FAF90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04028B47 RID: 166727
		[Token(Token = "0x4028B47")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelRoundEndView _view;

		// Token: 0x04028B48 RID: 166728
		[Token(Token = "0x4028B48")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIRenderTextureImage _rtImage;

		// Token: 0x04028B49 RID: 166729
		[Token(Token = "0x4028B49")]
		[NonSerialized]
		public const int MSG_GO_TO_RANK_STATE = 0;

		// Token: 0x04028B4A RID: 166730
		[Token(Token = "0x4028B4A")]
		[FieldOffset(Offset = "0x90")]
		private EnemyDuelRoundEndProperty m_prop;

		// Token: 0x04028B4B RID: 166731
		[Token(Token = "0x4028B4B")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelBattlePage m_page;

		// Token: 0x04028B4C RID: 166732
		[Token(Token = "0x4028B4C")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04028B4D RID: 166733
		[Token(Token = "0x4028B4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028B4E RID: 166734
		[Token(Token = "0x4028B4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04028B4F RID: 166735
		[Token(Token = "0x4028B4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028B50 RID: 166736
		[Token(Token = "0x4028B50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028B51 RID: 166737
		[Token(Token = "0x4028B51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x04028B52 RID: 166738
		[Token(Token = "0x4028B52")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
