using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005013 RID: 20499
	[Token(Token = "0x2005013")]
	public class EnemyDuelRoundEndStandView : DataBinder<EnemyDuelRoundEndStandProperty>
	{
		// Token: 0x0601E6AA RID: 124586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6AA")]
		[Address(RVA = "0x1834910", Offset = "0x1833510", VA = "0x181834910", Slot = "7")]
		public override void OnValueChanged(EnemyDuelRoundEndStandProperty property)
		{
		}

		// Token: 0x0601E6AB RID: 124587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6AB")]
		[Address(RVA = "0x18348A0", Offset = "0x18334A0", VA = "0x1818348A0")]
		public void OnStatePause()
		{
		}

		// Token: 0x0601E6AC RID: 124588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6AC")]
		[Address(RVA = "0x1834CB0", Offset = "0x18338B0", VA = "0x181834CB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E6AD RID: 124589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6AD")]
		[Address(RVA = "0x1834DD0", Offset = "0x18339D0", VA = "0x181834DD0")]
		private void _PlayAnim()
		{
		}

		// Token: 0x0601E6AE RID: 124590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E6AE")]
		[Address(RVA = "0x1834F40", Offset = "0x1833B40", VA = "0x181834F40")]
		public EnemyDuelRoundEndStandView()
		{
		}

		// Token: 0x04028B2D RID: 166701
		[Token(Token = "0x4028B2D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyDuelRoundEndBarView _barView;

		// Token: 0x04028B2E RID: 166702
		[Token(Token = "0x4028B2E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Player List")]
		private SimpleLayoutContent _playerList;

		// Token: 0x04028B2F RID: 166703
		[Token(Token = "0x4028B2F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _anim;

		// Token: 0x04028B30 RID: 166704
		[Token(Token = "0x4028B30")]
		[FieldOffset(Offset = "0x40")]
		private EnemyDuelRoundEndStandView.PlayerItemAdapter m_adapter;

		// Token: 0x04028B31 RID: 166705
		[Token(Token = "0x4028B31")]
		[FieldOffset(Offset = "0x48")]
		private EnemyDuelRoundEndStandViewModel m_cachedModel;

		// Token: 0x04028B32 RID: 166706
		[Token(Token = "0x4028B32")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInitialized;

		// Token: 0x04028B33 RID: 166707
		[Token(Token = "0x4028B33")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x04028B34 RID: 166708
		[Token(Token = "0x4028B34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028B35 RID: 166709
		[Token(Token = "0x4028B35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStatePause;

		// Token: 0x04028B36 RID: 166710
		[Token(Token = "0x4028B36")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028B37 RID: 166711
		[Token(Token = "0x4028B37")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x04028B38 RID: 166712
		[Token(Token = "0x4028B38")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005014 RID: 20500
		[Token(Token = "0x2005014")]
		private class PlayerItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E6B0 RID: 124592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E6B0")]
			[Address(RVA = "0x1836C50", Offset = "0x1835850", VA = "0x181836C50")]
			public PlayerItemAdapter(EnemyDuelRoundEndStandView closure)
			{
			}

			// Token: 0x17004708 RID: 18184
			// (get) Token: 0x0601E6B1 RID: 124593 RVA: 0x000AE648 File Offset: 0x000AC848
			[Token(Token = "0x17004708")]
			public override int count
			{
				[Token(Token = "0x601E6B1")]
				[Address(RVA = "0x1836CD0", Offset = "0x18358D0", VA = "0x181836CD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E6B2 RID: 124594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E6B2")]
			[Address(RVA = "0x1836A70", Offset = "0x1835670", VA = "0x181836A70", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04028B39 RID: 166713
			[Token(Token = "0x4028B39")]
			[FieldOffset(Offset = "0x20")]
			private readonly EnemyDuelRoundEndStandView m_closure;

			// Token: 0x04028B3A RID: 166714
			[Token(Token = "0x4028B3A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028B3B RID: 166715
			[Token(Token = "0x4028B3B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04028B3C RID: 166716
			[Token(Token = "0x4028B3C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
