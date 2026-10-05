using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C29 RID: 19497
	[Token(Token = "0x2004C29")]
	public class HomeMailDetailView : MonoBehaviour
	{
		// Token: 0x0601D480 RID: 119936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D480")]
		[Address(RVA = "0x16D18F0", Offset = "0x16D04F0", VA = "0x1816D18F0")]
		public void InitData(MailItemViewModel viewModel)
		{
		}

		// Token: 0x0601D481 RID: 119937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D481")]
		[Address(RVA = "0x16D2190", Offset = "0x16D0D90", VA = "0x1816D2190")]
		public HomeMailDetailView()
		{
		}

		// Token: 0x04026834 RID: 157748
		[Token(Token = "0x4026834")]
		private const float MAIL_REWARD_ITEM_CARD_MIN_HEIGHT = 134.688f;

		// Token: 0x04026835 RID: 157749
		[Token(Token = "0x4026835")]
		private const float MAIL_REWARD_ITEM_CARD_MIN_WIDTH = 134.688f;

		// Token: 0x04026836 RID: 157750
		[Token(Token = "0x4026836")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageAvatar;

		// Token: 0x04026837 RID: 157751
		[Token(Token = "0x4026837")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04026838 RID: 157752
		[Token(Token = "0x4026838")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textFrom;

		// Token: 0x04026839 RID: 157753
		[Token(Token = "0x4026839")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0402683A RID: 157754
		[Token(Token = "0x402683A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _rewardCardHolder;

		// Token: 0x0402683B RID: 157755
		[Token(Token = "0x402683B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x0402683C RID: 157756
		[Token(Token = "0x402683C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _isReceivedPart;

		// Token: 0x0402683D RID: 157757
		[Token(Token = "0x402683D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _noReceivePart;

		// Token: 0x0402683E RID: 157758
		[Token(Token = "0x402683E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _itemAlpha;

		// Token: 0x0402683F RID: 157759
		[Token(Token = "0x402683F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _timeCreate;

		// Token: 0x04026840 RID: 157760
		[Token(Token = "0x4026840")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _timeExpire;

		// Token: 0x04026841 RID: 157761
		[Token(Token = "0x4026841")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _mailDetail;

		// Token: 0x04026842 RID: 157762
		[Token(Token = "0x4026842")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x04026843 RID: 157763
		[Token(Token = "0x4026843")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _toMonthlySubPart;

		// Token: 0x04026844 RID: 157764
		[Token(Token = "0x4026844")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _surveyItemButton;

		// Token: 0x04026845 RID: 157765
		[Token(Token = "0x4026845")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelNormalBkg;

		// Token: 0x04026846 RID: 157766
		[Token(Token = "0x4026846")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelSpecialBkg;

		// Token: 0x04026847 RID: 157767
		[Token(Token = "0x4026847")]
		[FieldOffset(Offset = "0xA0")]
		private List<UIItemCard> m_itemCardsList;
	}
}
