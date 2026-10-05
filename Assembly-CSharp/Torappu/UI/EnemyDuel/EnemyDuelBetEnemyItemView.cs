using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FBB RID: 20411
	[Token(Token = "0x2004FBB")]
	public class EnemyDuelBetEnemyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170046F1 RID: 18161
		// (get) Token: 0x0601E51C RID: 124188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170046F1")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x601E51C")]
			[Address(RVA = "0x17F8DF0", Offset = "0x17F79F0", VA = "0x1817F8DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E51D RID: 124189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E51D")]
		[Address(RVA = "0x17F8B20", Offset = "0x17F7720", VA = "0x1817F8B20")]
		public void Render(EnemyDuelBetEnemyViewModel enemyViewModel, bool isLeft)
		{
		}

		// Token: 0x0601E51E RID: 124190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E51E")]
		[Address(RVA = "0x17F8D90", Offset = "0x17F7990", VA = "0x1817F8D90")]
		public EnemyDuelBetEnemyItemView()
		{
		}

		// Token: 0x040287DE RID: 165854
		[Token(Token = "0x40287DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgEnemyIcon;

		// Token: 0x040287DF RID: 165855
		[Token(Token = "0x40287DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textEnemyCountLeft;

		// Token: 0x040287E0 RID: 165856
		[Token(Token = "0x40287E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textEnemyCountRight;

		// Token: 0x040287E1 RID: 165857
		[Token(Token = "0x40287E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlEnemyCountLeft;

		// Token: 0x040287E2 RID: 165858
		[Token(Token = "0x40287E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlEnemyCountRight;

		// Token: 0x040287E3 RID: 165859
		[Token(Token = "0x40287E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlNormal;

		// Token: 0x040287E4 RID: 165860
		[Token(Token = "0x40287E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlEmpty;

		// Token: 0x040287E5 RID: 165861
		[Token(Token = "0x40287E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040287E6 RID: 165862
		[Token(Token = "0x40287E6")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040287E7 RID: 165863
		[Token(Token = "0x40287E7")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedEnemyId;

		// Token: 0x040287E8 RID: 165864
		[Token(Token = "0x40287E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x040287E9 RID: 165865
		[Token(Token = "0x40287E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040287EA RID: 165866
		[Token(Token = "0x40287EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
