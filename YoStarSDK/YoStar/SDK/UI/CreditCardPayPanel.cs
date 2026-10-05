using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.Bean;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public class CreditCardPayPanel : BasePanel
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Start()
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Update()
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x5C5D620", Offset = "0x5C5C220", VA = "0x185C5D620")]
		public void OnGoBack()
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x5C5CFB0", Offset = "0x5C5BBB0", VA = "0x185C5CFB0")]
		public void OnClose()
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x5C5C380", Offset = "0x5C5AF80", VA = "0x185C5C380", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x5C5D280", Offset = "0x5C5BE80", VA = "0x185C5D280", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x5C5DBB0", Offset = "0x5C5C7B0", VA = "0x185C5DBB0")]
		private void UpdateDataSource()
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x5C5D9A0", Offset = "0x5C5C5A0", VA = "0x185C5D9A0")]
		private void UpdateButtonState(Toggle button)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x5C5D510", Offset = "0x5C5C110", VA = "0x185C5D510")]
		private void OnCreditCardListValueChanged(bool isOn)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x5C5D680", Offset = "0x5C5C280", VA = "0x185C5D680")]
		private void OnOtherCreditCardValueChanged(bool isOn)
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x5C5C050", Offset = "0x5C5AC50", VA = "0x185C5C050")]
		private IEnumerator AddRows()
		{
			return null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x5C5D6E0", Offset = "0x5C5C2E0", VA = "0x185C5D6E0")]
		private void OnRowClickChanged(CreditCardData value)
		{
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x5C5D710", Offset = "0x5C5C310", VA = "0x185C5D710")]
		private void OnRowDeleteChanged(CreditCardData value)
		{
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x5C5D010", Offset = "0x5C5BC10", VA = "0x185C5D010")]
		private void OnConfirmButtonClick()
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0000353C File Offset: 0x0000173C
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x5C5C0D0", Offset = "0x5C5ACD0", VA = "0x185C5C0D0")]
		private bool ContentVerification()
		{
			return default(bool);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public CreditCardPayPanel()
		{
		}

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x50")]
		private Toggle creditCardListBtn;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x58")]
		private Toggle otherCreditCardBtn;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x60")]
		private GameObject creditCardList;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x68")]
		private GameObject otherCreditCard;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x70")]
		private Button confirmButton;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0x78")]
		private CreditCardListController listController;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0x80")]
		private FillCreditCardContent fillController;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0x88")]
		private List<CreditCardData> cardlist;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0x90")]
		private string cardSeq;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, object> eventParam;
	}
}
