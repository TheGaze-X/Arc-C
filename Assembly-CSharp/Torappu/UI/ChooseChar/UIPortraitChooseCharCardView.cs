using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A27 RID: 23079
	[Token(Token = "0x2005A27")]
	public class UIPortraitChooseCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060219C7 RID: 137671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C7")]
		[Address(RVA = "0x1C14B60", Offset = "0x1C13760", VA = "0x181C14B60")]
		public void Render(UIPortraitChooseCharCardViewModel model, bool isSelected)
		{
		}

		// Token: 0x060219C8 RID: 137672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C8")]
		[Address(RVA = "0x1C14960", Offset = "0x1C13560", VA = "0x181C14960")]
		public void EventOnCardClicked()
		{
		}

		// Token: 0x060219C9 RID: 137673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C9")]
		[Address(RVA = "0x1C14A60", Offset = "0x1C13660", VA = "0x181C14A60")]
		public void EventOnCardDetailClicked()
		{
		}

		// Token: 0x060219CA RID: 137674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219CA")]
		[Address(RVA = "0x1C14DC0", Offset = "0x1C139C0", VA = "0x181C14DC0")]
		public UIPortraitChooseCharCardView()
		{
		}

		// Token: 0x0402DF32 RID: 188210
		[Token(Token = "0x402DF32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelOwned;

		// Token: 0x0402DF33 RID: 188211
		[Token(Token = "0x402DF33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgPotential;

		// Token: 0x0402DF34 RID: 188212
		[Token(Token = "0x402DF34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0402DF35 RID: 188213
		[Token(Token = "0x402DF35")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgSelected;

		// Token: 0x0402DF36 RID: 188214
		[Token(Token = "0x402DF36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgCharPortrait;

		// Token: 0x0402DF37 RID: 188215
		[Token(Token = "0x402DF37")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgProfessor;

		// Token: 0x0402DF38 RID: 188216
		[Token(Token = "0x402DF38")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgRarityRank;

		// Token: 0x0402DF39 RID: 188217
		[Token(Token = "0x402DF39")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402DF3A RID: 188218
		[Token(Token = "0x402DF3A")]
		[FieldOffset(Offset = "0x58")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402DF3B RID: 188219
		[Token(Token = "0x402DF3B")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedCharId;

		// Token: 0x0402DF3C RID: 188220
		[Token(Token = "0x402DF3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DF3D RID: 188221
		[Token(Token = "0x402DF3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCardClicked;

		// Token: 0x0402DF3E RID: 188222
		[Token(Token = "0x402DF3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCardDetailClicked;

		// Token: 0x0402DF3F RID: 188223
		[Token(Token = "0x402DF3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
