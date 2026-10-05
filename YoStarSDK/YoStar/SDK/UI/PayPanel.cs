using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	public class PayPanel : BasePanel
	{
		// Token: 0x06000A1D RID: 2589 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x5C74A60", Offset = "0x5C73660", VA = "0x185C74A60")]
		private new void Awake()
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x5C75640", Offset = "0x5C74240", VA = "0x185C75640")]
		private void FindComponent()
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x5C75B70", Offset = "0x5C74770", VA = "0x185C75B70", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x5C74A70", Offset = "0x5C73670", VA = "0x185C74A70")]
		private void CreatePay()
		{
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x5C75340", Offset = "0x5C73F40", VA = "0x185C75340")]
		private void DealEvent(GameObject gameObject)
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x5C764A0", Offset = "0x5C750A0", VA = "0x185C764A0")]
		private void OnPayClick()
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x5C766F0", Offset = "0x5C752F0", VA = "0x185C766F0")]
		private void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x5C76A10", Offset = "0x5C75610", VA = "0x185C76A10")]
		private new void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x5C76CC0", Offset = "0x5C758C0", VA = "0x185C76CC0")]
		private new void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x5C77190", Offset = "0x5C75D90", VA = "0x185C77190")]
		public PayPanel()
		{
		}

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x50")]
		private Button closeBtn;

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x58")]
		private Button payBtn;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x60")]
		private Text payText;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x68")]
		private Text orderName;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x70")]
		private Text orderPrice;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x78")]
		private Image orderBg;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0x80")]
		private Text orderText;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0x88")]
		private Text paySelectText;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0x90")]
		private Text payButtonText;

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0x98")]
		private GameObject payView;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0xA0")]
		private List<Dictionary<string, object>> payList;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, object> eventParam;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0xB0")]
		private List<GameObject> paySubGameObjectList;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<string, GameObject> paySubGameObjectDic;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0xC0")]
		private string selectedName;
	}
}
