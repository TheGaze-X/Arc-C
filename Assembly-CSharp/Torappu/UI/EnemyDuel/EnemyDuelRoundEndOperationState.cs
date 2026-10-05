using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200500A RID: 20490
	[Token(Token = "0x200500A")]
	public class EnemyDuelRoundEndOperationState : EnemyDuelBattleState
	{
		// Token: 0x0601E68B RID: 124555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E68B")]
		[Address(RVA = "0x181E060", Offset = "0x181CC60", VA = "0x18181E060", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E68C RID: 124556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E68C")]
		[Address(RVA = "0x181E120", Offset = "0x181CD20", VA = "0x18181E120", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E68D RID: 124557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E68D")]
		[Address(RVA = "0x181E320", Offset = "0x181CF20", VA = "0x18181E320", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601E68E RID: 124558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E68E")]
		[Address(RVA = "0x181E470", Offset = "0x181D070", VA = "0x18181E470")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E68F RID: 124559 RVA: 0x000AE618 File Offset: 0x000AC818
		[Token(Token = "0x601E68F")]
		[Address(RVA = "0x181E0C0", Offset = "0x181CCC0", VA = "0x18181E0C0", Slot = "31")]
		protected override EnemyDuelServiceGameState GetSupportedGameState()
		{
			return EnemyDuelServiceGameState.NONE;
		}

		// Token: 0x0601E690 RID: 124560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E690")]
		[Address(RVA = "0x181E610", Offset = "0x181D210", VA = "0x18181E610")]
		public EnemyDuelRoundEndOperationState()
		{
		}

		// Token: 0x0601E691 RID: 124561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E691")]
		[Address(RVA = "0x17FAF90", Offset = "0x17F9B90", VA = "0x1817FAF90")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601E692 RID: 124562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E692")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x04028ACE RID: 166606
		[Token(Token = "0x4028ACE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyDuelRoundEndOperationView _view;

		// Token: 0x04028ACF RID: 166607
		[Token(Token = "0x4028ACF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIRenderTextureImage _rtImage;

		// Token: 0x04028AD0 RID: 166608
		[Token(Token = "0x4028AD0")]
		[FieldOffset(Offset = "0x90")]
		private EnemyDuelRoundEndOperationProperty m_prop;

		// Token: 0x04028AD1 RID: 166609
		[Token(Token = "0x4028AD1")]
		[FieldOffset(Offset = "0x98")]
		private EnemyDuelBattlePage m_page;

		// Token: 0x04028AD2 RID: 166610
		[Token(Token = "0x4028AD2")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04028AD3 RID: 166611
		[Token(Token = "0x4028AD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028AD4 RID: 166612
		[Token(Token = "0x4028AD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04028AD5 RID: 166613
		[Token(Token = "0x4028AD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04028AD6 RID: 166614
		[Token(Token = "0x4028AD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028AD7 RID: 166615
		[Token(Token = "0x4028AD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSupportedGameState;

		// Token: 0x04028AD8 RID: 166616
		[Token(Token = "0x4028AD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
