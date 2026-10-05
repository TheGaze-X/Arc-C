using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004721 RID: 18209
	[Token(Token = "0x2004721")]
	public class RecruitSpecialGachaUpCharListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B98F RID: 113039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B98F")]
		[Address(RVA = "0x14EA1F0", Offset = "0x14E8DF0", VA = "0x1814EA1F0")]
		public void Render(RecruitSpecialGachaUpCharCardViewModel viewModel, Color colorTheme)
		{
		}

		// Token: 0x0601B990 RID: 113040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B990")]
		[Address(RVA = "0x14EA110", Offset = "0x14E8D10", VA = "0x1814EA110")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x0601B991 RID: 113041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B991")]
		[Address(RVA = "0x14EA440", Offset = "0x14E9040", VA = "0x1814EA440")]
		public RecruitSpecialGachaUpCharListItemView()
		{
		}

		// Token: 0x04023C25 RID: 146469
		[Token(Token = "0x4023C25")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04023C26 RID: 146470
		[Token(Token = "0x4023C26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04023C27 RID: 146471
		[Token(Token = "0x4023C27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgCharPortrait;

		// Token: 0x04023C28 RID: 146472
		[Token(Token = "0x4023C28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgCharProfession;

		// Token: 0x04023C29 RID: 146473
		[Token(Token = "0x4023C29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgCharRarity;

		// Token: 0x04023C2A RID: 146474
		[Token(Token = "0x4023C2A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x04023C2B RID: 146475
		[Token(Token = "0x4023C2B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgBkgShining;

		// Token: 0x04023C2C RID: 146476
		[Token(Token = "0x4023C2C")]
		[FieldOffset(Offset = "0x50")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04023C2D RID: 146477
		[Token(Token = "0x4023C2D")]
		[FieldOffset(Offset = "0x60")]
		private RarityRank m_cachedRarityRank;

		// Token: 0x04023C2E RID: 146478
		[Token(Token = "0x4023C2E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023C2F RID: 146479
		[Token(Token = "0x4023C2F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x04023C30 RID: 146480
		[Token(Token = "0x4023C30")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
