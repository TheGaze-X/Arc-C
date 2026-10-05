using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Tables;
using UnityEngine;
using UnityEngine.Events;
using YoStar.SDK.Bean;

namespace YoStar.SDK.View
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public class CreditCardListController : MonoBehaviour
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x5C25F10", Offset = "0x5C24B10", VA = "0x185C25F10")]
		private void Awake()
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x5C26460", Offset = "0x5C25060", VA = "0x185C26460")]
		private void Start()
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void OnEnable()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x5C260F0", Offset = "0x5C24CF0", VA = "0x185C260F0")]
		public void SetCreditCardList(List<CreditCardData> list)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x5C260B0", Offset = "0x5C24CB0", VA = "0x185C260B0")]
		public void ClearCreditCardList()
		{
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x5C261E0", Offset = "0x5C24DE0", VA = "0x185C261E0")]
		private void SeteventTrigger(TableRow tableRow)
		{
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x5C25E90", Offset = "0x5C24A90", VA = "0x185C25E90")]
		private IEnumerator AddRowsUsingTemplate()
		{
			return null;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2585D60", Offset = "0x2584960", VA = "0x182585D60")]
		private void OnButtonClick(CreditCardData data)
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x312CB60", Offset = "0x312B760", VA = "0x18312CB60")]
		private void OnRowClick(CreditCardData data)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
		public void SetOnRowClickCallback(UnityAction<CreditCardData> callback)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
		public void SetOnRowDeleteClickCallback(UnityAction<CreditCardData> callback)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CreditCardListController()
		{
		}

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x18")]
		private TableLayout tableLayout;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x20")]
		private TableRow rowTemplate;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform scrollviewContent;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x30")]
		private GameObject defaultRow;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x38")]
		public UnityAction<CreditCardData> OnRowClickCallback;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x40")]
		public UnityAction<CreditCardData> OnRowDeleteClickCallback;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x48")]
		private List<CreditCardData> cardlist;
	}
}
