using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B08 RID: 31496
	[Token(Token = "0x2007B08")]
	public class Act12D6MileStoneItemObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C198 RID: 180632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C198")]
		[Address(RVA = "0x28101B0", Offset = "0x280EDB0", VA = "0x1828101B0")]
		private void _Inited()
		{
		}

		// Token: 0x0602C199 RID: 180633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C199")]
		[Address(RVA = "0x280FCA0", Offset = "0x280E8A0", VA = "0x18280FCA0")]
		public void OnClick()
		{
		}

		// Token: 0x0602C19A RID: 180634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C19A")]
		[Address(RVA = "0x280FD30", Offset = "0x280E930", VA = "0x18280FD30")]
		public void OnFocus()
		{
		}

		// Token: 0x0602C19B RID: 180635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C19B")]
		[Address(RVA = "0x280FDA0", Offset = "0x280E9A0", VA = "0x18280FDA0")]
		public void RenderItemPart(Act12D6MileStoneViewModel viewModel)
		{
		}

		// Token: 0x0602C19C RID: 180636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C19C")]
		[Address(RVA = "0x280F870", Offset = "0x280E470", VA = "0x18280F870")]
		public void InitData(Act12D6MileStoneViewModel viewModel)
		{
		}

		// Token: 0x0602C19D RID: 180637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C19D")]
		[Address(RVA = "0x2810350", Offset = "0x280EF50", VA = "0x182810350")]
		public Act12D6MileStoneItemObj()
		{
		}

		// Token: 0x0403FECF RID: 261839
		[Token(Token = "0x403FECF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _finishImg;

		// Token: 0x0403FED0 RID: 261840
		[Token(Token = "0x403FED0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _ableToGetImg;

		// Token: 0x0403FED1 RID: 261841
		[Token(Token = "0x403FED1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _ableToGetPart;

		// Token: 0x0403FED2 RID: 261842
		[Token(Token = "0x403FED2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _finishPart;

		// Token: 0x0403FED3 RID: 261843
		[Token(Token = "0x403FED3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cannotGetPart;

		// Token: 0x0403FED4 RID: 261844
		[Token(Token = "0x403FED4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _finishBackgroundPart;

		// Token: 0x0403FED5 RID: 261845
		[Token(Token = "0x403FED5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _scaleInfo;

		// Token: 0x0403FED6 RID: 261846
		[Token(Token = "0x403FED6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _itemViewContainer;

		// Token: 0x0403FED7 RID: 261847
		[Token(Token = "0x403FED7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _charGetPart;

		// Token: 0x0403FED8 RID: 261848
		[Token(Token = "0x403FED8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _itemGetPart;

		// Token: 0x0403FED9 RID: 261849
		[Token(Token = "0x403FED9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403FEDA RID: 261850
		[Token(Token = "0x403FEDA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _detailText_2;

		// Token: 0x0403FEDB RID: 261851
		[Token(Token = "0x403FEDB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403FEDC RID: 261852
		[Token(Token = "0x403FEDC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _countText_2;

		// Token: 0x0403FEDD RID: 261853
		[Token(Token = "0x403FEDD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _countTextActive;

		// Token: 0x0403FEDE RID: 261854
		[Token(Token = "0x403FEDE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _countTextNoActive;

		// Token: 0x0403FEDF RID: 261855
		[Token(Token = "0x403FEDF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0403FEE0 RID: 261856
		[Token(Token = "0x403FEE0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _countSymbol;

		// Token: 0x0403FEE1 RID: 261857
		[Token(Token = "0x403FEE1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _charHead;

		// Token: 0x0403FEE2 RID: 261858
		[Token(Token = "0x403FEE2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _storyObj;

		// Token: 0x0403FEE3 RID: 261859
		[Token(Token = "0x403FEE3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x0403FEE4 RID: 261860
		[Token(Token = "0x403FEE4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _ableToGetObj;

		// Token: 0x0403FEE5 RID: 261861
		[Token(Token = "0x403FEE5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Button _ableToGetButton;

		// Token: 0x0403FEE6 RID: 261862
		[Token(Token = "0x403FEE6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Button _ableToGetButtonChar;

		// Token: 0x0403FEE7 RID: 261863
		[Token(Token = "0x403FEE7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _getText;

		// Token: 0x0403FEE8 RID: 261864
		[Token(Token = "0x403FEE8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _focusLight;

		// Token: 0x0403FEE9 RID: 261865
		[Token(Token = "0x403FEE9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Color _storyTextColor;

		// Token: 0x0403FEEA RID: 261866
		[Token(Token = "0x403FEEA")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Color _itemTextColor;

		// Token: 0x0403FEEB RID: 261867
		[Token(Token = "0x403FEEB")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Color _notFinishTextColor;

		// Token: 0x0403FEEC RID: 261868
		[Token(Token = "0x403FEEC")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Color _notFinishedCountColor;

		// Token: 0x0403FEED RID: 261869
		[Token(Token = "0x403FEED")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x0403FEEE RID: 261870
		[Token(Token = "0x403FEEE")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isInited;

		// Token: 0x0403FEEF RID: 261871
		[Token(Token = "0x403FEEF")]
		[FieldOffset(Offset = "0x138")]
		private UIItemCard m_itemCard;

		// Token: 0x0403FEF0 RID: 261872
		[Token(Token = "0x403FEF0")]
		[FieldOffset(Offset = "0x140")]
		private string m_cacheId;

		// Token: 0x0403FEF1 RID: 261873
		[Token(Token = "0x403FEF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Inited;

		// Token: 0x0403FEF2 RID: 261874
		[Token(Token = "0x403FEF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403FEF3 RID: 261875
		[Token(Token = "0x403FEF3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFocus;

		// Token: 0x0403FEF4 RID: 261876
		[Token(Token = "0x403FEF4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderItemPart;

		// Token: 0x0403FEF5 RID: 261877
		[Token(Token = "0x403FEF5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403FEF6 RID: 261878
		[Token(Token = "0x403FEF6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
