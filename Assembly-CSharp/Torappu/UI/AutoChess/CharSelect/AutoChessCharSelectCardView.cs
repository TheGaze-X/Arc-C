using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063B0 RID: 25520
	[Token(Token = "0x20063B0")]
	public class AutoChessCharSelectCardView : TemplateCharSelectCardView
	{
		// Token: 0x06024C98 RID: 150680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C98")]
		[Address(RVA = "0x1F9A6F0", Offset = "0x1F992F0", VA = "0x181F9A6F0", Slot = "6")]
		protected override void DoRender(TemplateCharSelectCardViewModel viewModel)
		{
		}

		// Token: 0x06024C99 RID: 150681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C99")]
		[Address(RVA = "0x1F9AA00", Offset = "0x1F99600", VA = "0x181F9AA00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C9A RID: 150682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C9A")]
		[Address(RVA = "0x1F9A990", Offset = "0x1F99590", VA = "0x181F9A990")]
		private void _EventOnChessCardClick(string chessId)
		{
		}

		// Token: 0x06024C9B RID: 150683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C9B")]
		[Address(RVA = "0x1F9AB60", Offset = "0x1F99760", VA = "0x181F9AB60")]
		public AutoChessCharSelectCardView()
		{
		}

		// Token: 0x040336AA RID: 210602
		[Token(Token = "0x40336AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessShopCharChessCardView _cardPrefab;

		// Token: 0x040336AB RID: 210603
		[Token(Token = "0x40336AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _cardContainer;

		// Token: 0x040336AC RID: 210604
		[Token(Token = "0x40336AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _selectedIndex;

		// Token: 0x040336AD RID: 210605
		[Token(Token = "0x40336AD")]
		[FieldOffset(Offset = "0x60")]
		private AutoChessShopCharChessCardView m_chessCard;

		// Token: 0x040336AE RID: 210606
		[Token(Token = "0x40336AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x040336AF RID: 210607
		[Token(Token = "0x40336AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040336B0 RID: 210608
		[Token(Token = "0x40336B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnChessCardClick;

		// Token: 0x040336B1 RID: 210609
		[Token(Token = "0x40336B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
