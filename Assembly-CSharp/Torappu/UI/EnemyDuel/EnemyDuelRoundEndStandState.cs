using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005012 RID: 20498
	[Token(Token = "0x2005012")]
	public class EnemyDuelRoundEndStandState : EnemyDuelBattleState
	{
		// Token: 0x0601E6A2 RID: 124578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E6A2")]
		[Address(RVA = "0x1833C50", Offset = "0x1832850", VA = "0x181833C50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E6A3 RID: 124579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A3")]
		[Address(RVA = "0x1833D10", Offset = "0x1832910", VA = "0x181833D10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E6A4 RID: 124580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A4")]
		[Address(RVA = "0x1833E50", Offset = "0x1832A50", VA = "0x181833E50", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601E6A5 RID: 124581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A5")]
		[Address(RVA = "0x1833F00", Offset = "0x1832B00", VA = "0x181833F00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E6A6 RID: 124582 RVA: 0x000AE630 File Offset: 0x000AC830
		[Token(Token = "0x601E6A6")]
		[Address(RVA = "0x1833CB0", Offset = "0x18328B0", VA = "0x181833CB0", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E6A7 RID: 124583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A7")]
		[Address(RVA = "0x18340A0", Offset = "0x1832CA0", VA = "0x1818340A0")]
		public EnemyDuelRoundEndStandState()
		{
		}

		// Token: 0x0601E6A8 RID: 124584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A8")]
		[Address(RVA = "0x17FAF90", Offset = "0x17F9B90", VA = "0x1817FAF90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E6A9 RID: 124585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6A9")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04028B22 RID: 166690
		[Token(Token = "0x4028B22")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelRoundEndStandView _view;

		// Token: 0x04028B23 RID: 166691
		[Token(Token = "0x4028B23")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIRenderTextureImage _rtImage;

		// Token: 0x04028B24 RID: 166692
		[Token(Token = "0x4028B24")]
		[FieldOffset(Offset = "0x90")]
		private EnemyDuelRoundEndStandProperty m_prop;

		// Token: 0x04028B25 RID: 166693
		[Token(Token = "0x4028B25")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelBattlePage m_page;

		// Token: 0x04028B26 RID: 166694
		[Token(Token = "0x4028B26")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04028B27 RID: 166695
		[Token(Token = "0x4028B27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028B28 RID: 166696
		[Token(Token = "0x4028B28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028B29 RID: 166697
		[Token(Token = "0x4028B29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04028B2A RID: 166698
		[Token(Token = "0x4028B2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028B2B RID: 166699
		[Token(Token = "0x4028B2B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x04028B2C RID: 166700
		[Token(Token = "0x4028B2C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
