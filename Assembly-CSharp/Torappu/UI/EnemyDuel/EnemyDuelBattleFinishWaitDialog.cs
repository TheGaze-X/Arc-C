using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FED RID: 20461
	[Token(Token = "0x2004FED")]
	public class EnemyDuelBattleFinishWaitDialog : UICompDialog<EnemyDuelBattleFinishWaitDialog.Input>
	{
		// Token: 0x0601E605 RID: 124421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E605")]
		[Address(RVA = "0x18104F0", Offset = "0x180F0F0", VA = "0x1818104F0", Slot = "18")]
		protected override void OnRender(EnemyDuelBattleFinishWaitDialog.Input input)
		{
		}

		// Token: 0x0601E606 RID: 124422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E606")]
		[Address(RVA = "0x1810430", Offset = "0x180F030", VA = "0x181810430")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601E607 RID: 124423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E607")]
		[Address(RVA = "0x1810660", Offset = "0x180F260", VA = "0x181810660")]
		public EnemyDuelBattleFinishWaitDialog()
		{
		}

		// Token: 0x040289CA RID: 166346
		[Token(Token = "0x40289CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x040289CB RID: 166347
		[Token(Token = "0x40289CB")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_loopTween;

		// Token: 0x040289CC RID: 166348
		[Token(Token = "0x40289CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040289CD RID: 166349
		[Token(Token = "0x40289CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x040289CE RID: 166350
		[Token(Token = "0x40289CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FEE RID: 20462
		[Token(Token = "0x2004FEE")]
		public class Input
		{
			// Token: 0x0601E608 RID: 124424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E608")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}
	}
}
