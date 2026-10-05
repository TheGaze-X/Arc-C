using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C16 RID: 19478
	[Token(Token = "0x2004C16")]
	public class HomeSecretaryChangeCardView : MonoBehaviour, IBasicCharInfo, IHotfixable
	{
		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x0601D427 RID: 119847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170044C7")]
		public BasicCharInfoModel basicCharInfo
		{
			[Token(Token = "0x601D427")]
			[Address(RVA = "0x16D6390", Offset = "0x16D4F90", VA = "0x1816D6390", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D428 RID: 119848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D428")]
		[Address(RVA = "0x16D6040", Offset = "0x16D4C40", VA = "0x1816D6040")]
		public void RenderCard(HomeSecretaryCardViewModel cardModel, HomeSecretaryChangeCardView.ExtraInput input)
		{
		}

		// Token: 0x0601D429 RID: 119849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D429")]
		[Address(RVA = "0x16D5FD0", Offset = "0x16D4BD0", VA = "0x1816D5FD0")]
		public void OnClick()
		{
		}

		// Token: 0x0601D42A RID: 119850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D42A")]
		[Address(RVA = "0x16D62F0", Offset = "0x16D4EF0", VA = "0x1816D62F0")]
		public HomeSecretaryChangeCardView()
		{
		}

		// Token: 0x0402676B RID: 157547
		[Token(Token = "0x402676B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _headIcon;

		// Token: 0x0402676C RID: 157548
		[Token(Token = "0x402676C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNotSelected;

		// Token: 0x0402676D RID: 157549
		[Token(Token = "0x402676D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _objListSelected;

		// Token: 0x0402676E RID: 157550
		[Token(Token = "0x402676E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objStarMark;

		// Token: 0x0402676F RID: 157551
		[Token(Token = "0x402676F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _selectedSkinNum;

		// Token: 0x04026770 RID: 157552
		[Token(Token = "0x4026770")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objInPreview;

		// Token: 0x04026771 RID: 157553
		[Token(Token = "0x4026771")]
		[FieldOffset(Offset = "0x48")]
		private int m_instId;

		// Token: 0x04026772 RID: 157554
		[Token(Token = "0x4026772")]
		[FieldOffset(Offset = "0x50")]
		private BasicCharInfoModel m_charInfoModel;

		// Token: 0x04026773 RID: 157555
		[Token(Token = "0x4026773")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Action<int> onClick;

		// Token: 0x04026774 RID: 157556
		[Token(Token = "0x4026774")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_basicCharInfo;

		// Token: 0x04026775 RID: 157557
		[Token(Token = "0x4026775")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x04026776 RID: 157558
		[Token(Token = "0x4026776")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04026777 RID: 157559
		[Token(Token = "0x4026777")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C17 RID: 19479
		[Token(Token = "0x2004C17")]
		public struct ExtraInput
		{
			// Token: 0x04026778 RID: 157560
			[Token(Token = "0x4026778")]
			[FieldOffset(Offset = "0x0")]
			public bool isSelected;

			// Token: 0x04026779 RID: 157561
			[Token(Token = "0x4026779")]
			[FieldOffset(Offset = "0x1")]
			public bool isStarMarked;

			// Token: 0x0402677A RID: 157562
			[Token(Token = "0x402677A")]
			[FieldOffset(Offset = "0x2")]
			public bool isInPreview;

			// Token: 0x0402677B RID: 157563
			[Token(Token = "0x402677B")]
			[FieldOffset(Offset = "0x4")]
			public int skinNum;
		}
	}
}
