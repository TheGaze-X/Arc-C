using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FBC RID: 20412
	[Token(Token = "0x2004FBC")]
	public class EnemyDuelBetPlayerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x0601E51F RID: 124191 RVA: 0x000AE2B8 File Offset: 0x000AC4B8
		[Token(Token = "0x170046F2")]
		public float showPos
		{
			[Token(Token = "0x601E51F")]
			[Address(RVA = "0x17F93B0", Offset = "0x17F7FB0", VA = "0x1817F93B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601E520 RID: 124192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E520")]
		[Address(RVA = "0x17F92B0", Offset = "0x17F7EB0", VA = "0x1817F92B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E521 RID: 124193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E521")]
		[Address(RVA = "0x17F9180", Offset = "0x17F7D80", VA = "0x1817F9180")]
		public void SetShowPos(float pos)
		{
		}

		// Token: 0x0601E522 RID: 124194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E522")]
		[Address(RVA = "0x17F8E50", Offset = "0x17F7A50", VA = "0x1817F8E50")]
		public void Render(EnemyDuelBetPlayerViewModel viewModel, EnemyDuelModeType modeType, string actId)
		{
		}

		// Token: 0x0601E523 RID: 124195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E523")]
		[Address(RVA = "0x17F9350", Offset = "0x17F7F50", VA = "0x1817F9350")]
		public EnemyDuelBetPlayerView()
		{
		}

		// Token: 0x040287EB RID: 165867
		[Token(Token = "0x40287EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x040287EC RID: 165868
		[Token(Token = "0x40287EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgPlayerIcon;

		// Token: 0x040287ED RID: 165869
		[Token(Token = "0x40287ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textWinStreak;

		// Token: 0x040287EE RID: 165870
		[Token(Token = "0x40287EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlWinStreak;

		// Token: 0x040287EF RID: 165871
		[Token(Token = "0x40287EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EnemyDuelBetPlayerView.PnlBkg _pnlSelf;

		// Token: 0x040287F0 RID: 165872
		[Token(Token = "0x40287F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EnemyDuelBetPlayerView.PnlBkg _pnlOther;

		// Token: 0x040287F1 RID: 165873
		[Token(Token = "0x40287F1")]
		[FieldOffset(Offset = "0x50")]
		private float m_showPos;

		// Token: 0x040287F2 RID: 165874
		[Token(Token = "0x40287F2")]
		[FieldOffset(Offset = "0x54")]
		private bool m_cachedIsNpc;

		// Token: 0x040287F3 RID: 165875
		[Token(Token = "0x40287F3")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedAvatarId;

		// Token: 0x040287F4 RID: 165876
		[Token(Token = "0x40287F4")]
		[FieldOffset(Offset = "0x60")]
		private PlayerAvatarQuery m_cachedAvatarQuery;

		// Token: 0x040287F5 RID: 165877
		[Token(Token = "0x40287F5")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040287F6 RID: 165878
		[Token(Token = "0x40287F6")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x040287F7 RID: 165879
		[Token(Token = "0x40287F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showPos;

		// Token: 0x040287F8 RID: 165880
		[Token(Token = "0x40287F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040287F9 RID: 165881
		[Token(Token = "0x40287F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetShowPos;

		// Token: 0x040287FA RID: 165882
		[Token(Token = "0x40287FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040287FB RID: 165883
		[Token(Token = "0x40287FB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004FBD RID: 20413
		[Token(Token = "0x2004FBD")]
		[Serializable]
		private class PnlBkg : IHotfixable
		{
			// Token: 0x0601E524 RID: 124196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E524")]
			[Address(RVA = "0x180C740", Offset = "0x180B340", VA = "0x18180C740")]
			public void Render(EnemyDuelBetPlayerViewModel viewModel, bool isShow)
			{
			}

			// Token: 0x0601E525 RID: 124197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E525")]
			[Address(RVA = "0x180C890", Offset = "0x180B490", VA = "0x18180C890")]
			public PnlBkg()
			{
			}

			// Token: 0x040287FC RID: 165884
			[Token(Token = "0x40287FC")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlRoot;

			// Token: 0x040287FD RID: 165885
			[Token(Token = "0x40287FD")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlBkgNormal;

			// Token: 0x040287FE RID: 165886
			[Token(Token = "0x40287FE")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _pnlBkgExBet;

			// Token: 0x040287FF RID: 165887
			[Token(Token = "0x40287FF")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textNameNormal;

			// Token: 0x04028800 RID: 165888
			[Token(Token = "0x4028800")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textNameExBet;

			// Token: 0x04028801 RID: 165889
			[Token(Token = "0x4028801")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x04028802 RID: 165890
			[Token(Token = "0x4028802")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
