using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006806 RID: 26630
	[Token(Token = "0x2006806")]
	public class RetroTrailRewardCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026287 RID: 156295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026287")]
		[Address(RVA = "0x2132B80", Offset = "0x2131780", VA = "0x182132B80")]
		public void _InitIfNot()
		{
		}

		// Token: 0x06026288 RID: 156296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026288")]
		[Address(RVA = "0x2132500", Offset = "0x2131100", VA = "0x182132500")]
		public void OnClick()
		{
		}

		// Token: 0x06026289 RID: 156297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026289")]
		[Address(RVA = "0x2132D80", Offset = "0x2131980", VA = "0x182132D80")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x0602628A RID: 156298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602628A")]
		[Address(RVA = "0x21325C0", Offset = "0x21311C0", VA = "0x1821325C0")]
		public void Render(SideStoryTrailViewModel viewModel, Color themeColor)
		{
		}

		// Token: 0x0602628B RID: 156299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602628B")]
		[Address(RVA = "0x2132E80", Offset = "0x2131A80", VA = "0x182132E80")]
		public RetroTrailRewardCard()
		{
		}

		// Token: 0x04035BDE RID: 220126
		[Token(Token = "0x4035BDE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _backImgAbleToGet;

		// Token: 0x04035BDF RID: 220127
		[Token(Token = "0x4035BDF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _backImgHaveEnoughStar;

		// Token: 0x04035BE0 RID: 220128
		[Token(Token = "0x4035BE0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _backImgNormal;

		// Token: 0x04035BE1 RID: 220129
		[Token(Token = "0x4035BE1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _backImgAlreadyGet;

		// Token: 0x04035BE2 RID: 220130
		[Token(Token = "0x4035BE2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _clickAblePart;

		// Token: 0x04035BE3 RID: 220131
		[Token(Token = "0x4035BE3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _coloredText1;

		// Token: 0x04035BE4 RID: 220132
		[Token(Token = "0x4035BE4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _coloredText2;

		// Token: 0x04035BE5 RID: 220133
		[Token(Token = "0x4035BE5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04035BE6 RID: 220134
		[Token(Token = "0x4035BE6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _starCount;

		// Token: 0x04035BE7 RID: 220135
		[Token(Token = "0x4035BE7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04035BE8 RID: 220136
		[Token(Token = "0x4035BE8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _scalePercent;

		// Token: 0x04035BE9 RID: 220137
		[Token(Token = "0x4035BE9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04035BEA RID: 220138
		[Token(Token = "0x4035BEA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _coloredImg1;

		// Token: 0x04035BEB RID: 220139
		[Token(Token = "0x4035BEB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _coloredImg2;

		// Token: 0x04035BEC RID: 220140
		[Token(Token = "0x4035BEC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _coloredImg3;

		// Token: 0x04035BED RID: 220141
		[Token(Token = "0x4035BED")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _nameBack;

		// Token: 0x04035BEE RID: 220142
		[Token(Token = "0x4035BEE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04035BEF RID: 220143
		[Token(Token = "0x4035BEF")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public UIStringEvent onClickEvent;

		// Token: 0x04035BF0 RID: 220144
		[Token(Token = "0x4035BF0")]
		[FieldOffset(Offset = "0xA8")]
		private SideStoryTrailViewModel m_viewModel;

		// Token: 0x04035BF1 RID: 220145
		[Token(Token = "0x4035BF1")]
		[FieldOffset(Offset = "0xB0")]
		private UIItemCard m_itemCard;

		// Token: 0x04035BF2 RID: 220146
		[Token(Token = "0x4035BF2")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04035BF3 RID: 220147
		[Token(Token = "0x4035BF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035BF4 RID: 220148
		[Token(Token = "0x4035BF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04035BF5 RID: 220149
		[Token(Token = "0x4035BF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04035BF6 RID: 220150
		[Token(Token = "0x4035BF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035BF7 RID: 220151
		[Token(Token = "0x4035BF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
