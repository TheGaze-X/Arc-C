using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YoStar.SDK.View
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	public class FillCreditCardContent : MonoBehaviour
	{
		// Token: 0x060006C4 RID: 1732 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5C28F10", Offset = "0x5C27B10", VA = "0x185C28F10")]
		private void Awake()
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5C2A340", Offset = "0x5C28F40", VA = "0x185C2A340")]
		private void Update()
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x5C29930", Offset = "0x5C28530", VA = "0x185C29930")]
		private void Start()
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x5C29550", Offset = "0x5C28150", VA = "0x185C29550")]
		private void OnEnable()
		{
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x5C29540", Offset = "0x5C28140", VA = "0x185C29540")]
		private void OnDisable()
		{
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x5C29710", Offset = "0x5C28310", VA = "0x185C29710")]
		private void SetDefault()
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x5C29560", Offset = "0x5C28160", VA = "0x185C29560")]
		public void SetCardListCount(int count)
		{
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x5C29380", Offset = "0x5C27F80", VA = "0x185C29380")]
		private void OnDaySelected(DateTime date)
		{
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x5C292B0", Offset = "0x5C27EB0", VA = "0x185C292B0")]
		public static string FormatDate(DateTime date)
		{
			return null;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FillCreditCardContent()
		{
		}

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x18")]
		internal InputField cardNumber;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x20")]
		internal InputField cardholderName;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x28")]
		internal InputField CVVOrCVC;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x30")]
		internal Button validity;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x38")]
		internal DatePicker datePicker;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x40")]
		internal Toggle toggle;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x48")]
		internal DateTime validityDate;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x50")]
		internal Text validityText;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x58")]
		private Text placeholder;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x60")]
		private Text saveCardTitle;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x68")]
		private ColorBlock colorBlock;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0xC0")]
		private Color sColor;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0xD0")]
		private Color nColor;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0xE0")]
		private int listCount;
	}
}
