using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C30 RID: 19504
	[Token(Token = "0x2004C30")]
	public class HomeMailItemView : MonoBehaviour
	{
		// Token: 0x0601D4A2 RID: 119970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A2")]
		[Address(RVA = "0x16D3C20", Offset = "0x16D2820", VA = "0x1816D3C20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D4A3 RID: 119971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A3")]
		[Address(RVA = "0x16D3270", Offset = "0x16D1E70", VA = "0x1816D3270")]
		public void Render(long inputIndex, MailItemViewModel viewModel)
		{
		}

		// Token: 0x0601D4A4 RID: 119972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A4")]
		[Address(RVA = "0x16D3D80", Offset = "0x16D2980", VA = "0x1816D3D80")]
		private static void _SetGameObjectGroupActive(GameObject[] group, bool isActive)
		{
		}

		// Token: 0x0601D4A5 RID: 119973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A5")]
		[Address(RVA = "0x16D3230", Offset = "0x16D1E30", VA = "0x1816D3230")]
		public void EventOnMailClick()
		{
		}

		// Token: 0x0601D4A6 RID: 119974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A6")]
		[Address(RVA = "0x16D31F0", Offset = "0x16D1DF0", VA = "0x1816D31F0")]
		public void EventOnDetailClick()
		{
		}

		// Token: 0x0601D4A7 RID: 119975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4A7")]
		[Address(RVA = "0x16D3E20", Offset = "0x16D2A20", VA = "0x1816D3E20")]
		public HomeMailItemView()
		{
		}

		// Token: 0x0402686B RID: 157803
		[Token(Token = "0x402686B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageAvatar;

		// Token: 0x0402686C RID: 157804
		[Token(Token = "0x402686C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _itemPart;

		// Token: 0x0402686D RID: 157805
		[Token(Token = "0x402686D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _noItemPart;

		// Token: 0x0402686E RID: 157806
		[Token(Token = "0x402686E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x0402686F RID: 157807
		[Token(Token = "0x402686F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x04026870 RID: 157808
		[Token(Token = "0x4026870")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textTimeWithItem;

		// Token: 0x04026871 RID: 157809
		[Token(Token = "0x4026871")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFrom;

		// Token: 0x04026872 RID: 157810
		[Token(Token = "0x4026872")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _readMask;

		// Token: 0x04026873 RID: 157811
		[Token(Token = "0x4026873")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x04026874 RID: 157812
		[Token(Token = "0x4026874")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _getText;

		// Token: 0x04026875 RID: 157813
		[Token(Token = "0x4026875")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _priceImage;

		// Token: 0x04026876 RID: 157814
		[Token(Token = "0x4026876")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _itemScaleFactor;

		// Token: 0x04026877 RID: 157815
		[Token(Token = "0x4026877")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _mailStyleImg;

		// Token: 0x04026878 RID: 157816
		[Token(Token = "0x4026878")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] _panelSpecialMail;

		// Token: 0x04026879 RID: 157817
		[Token(Token = "0x4026879")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action<HomeMailIndex> onMailClick;

		// Token: 0x0402687A RID: 157818
		[Token(Token = "0x402687A")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<HomeMailIndex> onMailDetailClick;

		// Token: 0x0402687B RID: 157819
		[Token(Token = "0x402687B")]
		[FieldOffset(Offset = "0x98")]
		private HomeMailIndex m_cacheId;

		// Token: 0x0402687C RID: 157820
		[Token(Token = "0x402687C")]
		[FieldOffset(Offset = "0xB0")]
		private UIItemCard m_itemCard;

		// Token: 0x0402687D RID: 157821
		[Token(Token = "0x402687D")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;
	}
}
