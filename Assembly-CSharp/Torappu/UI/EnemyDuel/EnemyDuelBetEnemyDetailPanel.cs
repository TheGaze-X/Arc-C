using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FB9 RID: 20409
	[Token(Token = "0x2004FB9")]
	public class EnemyDuelBetEnemyDetailPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E515 RID: 124181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E515")]
		[Address(RVA = "0x17F88F0", Offset = "0x17F74F0", VA = "0x1817F88F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E516 RID: 124182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E516")]
		[Address(RVA = "0x17F8620", Offset = "0x17F7220", VA = "0x1817F8620")]
		public void Render(EnemyDuelBetViewModel model, bool isLeft)
		{
		}

		// Token: 0x0601E517 RID: 124183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E517")]
		[Address(RVA = "0x17F8580", Offset = "0x17F7180", VA = "0x1817F8580")]
		public void OnBtnHideClicked()
		{
		}

		// Token: 0x0601E518 RID: 124184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E518")]
		[Address(RVA = "0x17F8AC0", Offset = "0x17F76C0", VA = "0x1817F8AC0")]
		public EnemyDuelBetEnemyDetailPanel()
		{
		}

		// Token: 0x040287CD RID: 165837
		[Token(Token = "0x40287CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x040287CE RID: 165838
		[Token(Token = "0x40287CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _layoutEnemyDetailList;

		// Token: 0x040287CF RID: 165839
		[Token(Token = "0x40287CF")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween m_showTween;

		// Token: 0x040287D0 RID: 165840
		[Token(Token = "0x40287D0")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x040287D1 RID: 165841
		[Token(Token = "0x40287D1")]
		[FieldOffset(Offset = "0x40")]
		private List<EnemyDuelBetEnemyViewModel> m_cachedEnemyList;

		// Token: 0x040287D2 RID: 165842
		[Token(Token = "0x40287D2")]
		[FieldOffset(Offset = "0x48")]
		private bool m_cachedIsLeft;

		// Token: 0x040287D3 RID: 165843
		[Token(Token = "0x40287D3")]
		[FieldOffset(Offset = "0x50")]
		private EnemyDuelBetEnemyDetailPanel.Adapter m_adapter;

		// Token: 0x040287D4 RID: 165844
		[Token(Token = "0x40287D4")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040287D5 RID: 165845
		[Token(Token = "0x40287D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040287D6 RID: 165846
		[Token(Token = "0x40287D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040287D7 RID: 165847
		[Token(Token = "0x40287D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnHideClicked;

		// Token: 0x040287D8 RID: 165848
		[Token(Token = "0x40287D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FBA RID: 20410
		[Token(Token = "0x2004FBA")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E519 RID: 124185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E519")]
			[Address(RVA = "0x17F7830", Offset = "0x17F6430", VA = "0x1817F7830")]
			public Adapter(EnemyDuelBetEnemyDetailPanel closure)
			{
			}

			// Token: 0x170046F0 RID: 18160
			// (get) Token: 0x0601E51A RID: 124186 RVA: 0x000AE2A0 File Offset: 0x000AC4A0
			[Token(Token = "0x170046F0")]
			public override int count
			{
				[Token(Token = "0x601E51A")]
				[Address(RVA = "0x17F78B0", Offset = "0x17F64B0", VA = "0x1817F78B0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E51B RID: 124187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E51B")]
			[Address(RVA = "0x17F7140", Offset = "0x17F5D40", VA = "0x1817F7140", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040287D9 RID: 165849
			[Token(Token = "0x40287D9")]
			private const int ENEMY_ITEM_COUNT = 3;

			// Token: 0x040287DA RID: 165850
			[Token(Token = "0x40287DA")]
			[FieldOffset(Offset = "0x20")]
			private EnemyDuelBetEnemyDetailPanel m_closure;

			// Token: 0x040287DB RID: 165851
			[Token(Token = "0x40287DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040287DC RID: 165852
			[Token(Token = "0x40287DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040287DD RID: 165853
			[Token(Token = "0x40287DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
