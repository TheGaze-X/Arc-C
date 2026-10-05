using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A2 RID: 17570
	[Token(Token = "0x20044A2")]
	public class RoguelikeTopicBattlePassTopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AD69 RID: 109929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD69")]
		[Address(RVA = "0x13FBE70", Offset = "0x13FAA70", VA = "0x1813FBE70")]
		public void Render(RoguelikeTopicBPTopViewModel viewModel)
		{
		}

		// Token: 0x0601AD6A RID: 109930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD6A")]
		[Address(RVA = "0x13FC4C0", Offset = "0x13FB0C0", VA = "0x1813FC4C0")]
		public RoguelikeTopicBattlePassTopView()
		{
		}

		// Token: 0x040225AE RID: 140718
		[Token(Token = "0x40225AE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _topicIcon;

		// Token: 0x040225AF RID: 140719
		[Token(Token = "0x40225AF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _topicIconBkg;

		// Token: 0x040225B0 RID: 140720
		[Token(Token = "0x40225B0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x040225B1 RID: 140721
		[Token(Token = "0x40225B1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x040225B2 RID: 140722
		[Token(Token = "0x40225B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _maxImg;

		// Token: 0x040225B3 RID: 140723
		[Token(Token = "0x40225B3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _curPoint;

		// Token: 0x040225B4 RID: 140724
		[Token(Token = "0x40225B4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _curLineImg;

		// Token: 0x040225B5 RID: 140725
		[Token(Token = "0x40225B5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _updateTimeText;

		// Token: 0x040225B6 RID: 140726
		[Token(Token = "0x40225B6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _nextUpdateCaption;

		// Token: 0x040225B7 RID: 140727
		[Token(Token = "0x40225B7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _hidePart;

		// Token: 0x040225B8 RID: 140728
		[Token(Token = "0x40225B8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelPurchaseTip;

		// Token: 0x040225B9 RID: 140729
		[Token(Token = "0x40225B9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelPurchase;

		// Token: 0x040225BA RID: 140730
		[Token(Token = "0x40225BA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelPurchaseAvailable;

		// Token: 0x040225BB RID: 140731
		[Token(Token = "0x40225BB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelPurchaseDisabled;

		// Token: 0x040225BC RID: 140732
		[Token(Token = "0x40225BC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textPurchase;

		// Token: 0x040225BD RID: 140733
		[Token(Token = "0x40225BD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _bpPurchaseTextColorAvailable;

		// Token: 0x040225BE RID: 140734
		[Token(Token = "0x40225BE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _bpPurchaseTextColorDisabled;

		// Token: 0x040225BF RID: 140735
		[Token(Token = "0x40225BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040225C0 RID: 140736
		[Token(Token = "0x40225C0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
