using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044DB RID: 17627
	[Token(Token = "0x20044DB")]
	public class RoguelikeTopicMonthSquadCharPortraitView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AEB0 RID: 110256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB0")]
		[Address(RVA = "0x1410630", Offset = "0x140F230", VA = "0x181410630")]
		public void Render(RoguelikeTopicMonthSquadTeamChar teamCharModel, bool showBtn = true, bool showCharName = true)
		{
		}

		// Token: 0x0601AEB1 RID: 110257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB1")]
		[Address(RVA = "0x14109B0", Offset = "0x140F5B0", VA = "0x1814109B0")]
		public void TweenToChar(bool toPrev, RoguelikeTopicMonthSquadTeamChar teamChar, bool showBtn)
		{
		}

		// Token: 0x0601AEB2 RID: 110258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB2")]
		[Address(RVA = "0x14104F0", Offset = "0x140F0F0", VA = "0x1814104F0")]
		public void OnBtnCharProtraitClicked()
		{
		}

		// Token: 0x0601AEB3 RID: 110259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEB3")]
		[Address(RVA = "0x1410C50", Offset = "0x140F850", VA = "0x181410C50")]
		public RoguelikeTopicMonthSquadCharPortraitView()
		{
		}

		// Token: 0x04022829 RID: 141353
		[Token(Token = "0x4022829")]
		private const float CHAR_CARD_WIDTH = 130f;

		// Token: 0x0402282A RID: 141354
		[Token(Token = "0x402282A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x0402282B RID: 141355
		[Token(Token = "0x402282B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x0402282C RID: 141356
		[Token(Token = "0x402282C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _charName;

		// Token: 0x0402282D RID: 141357
		[Token(Token = "0x402282D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x0402282E RID: 141358
		[Token(Token = "0x402282E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelBtn;

		// Token: 0x0402282F RID: 141359
		[Token(Token = "0x402282F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Animation")]
		private RectTransform _anchor;

		// Token: 0x04022830 RID: 141360
		[Token(Token = "0x4022830")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Animation")]
		private CanvasGroup _anchorCanvasGroup;

		// Token: 0x04022831 RID: 141361
		[Token(Token = "0x4022831")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicMonthSquadTeamChar m_cachedTeamCharModel;

		// Token: 0x04022832 RID: 141362
		[Token(Token = "0x4022832")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedCharId;

		// Token: 0x04022833 RID: 141363
		[Token(Token = "0x4022833")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween.TweenWrapper m_tween;

		// Token: 0x04022834 RID: 141364
		[Token(Token = "0x4022834")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022835 RID: 141365
		[Token(Token = "0x4022835")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TweenToChar;

		// Token: 0x04022836 RID: 141366
		[Token(Token = "0x4022836")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnCharProtraitClicked;

		// Token: 0x04022837 RID: 141367
		[Token(Token = "0x4022837")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
