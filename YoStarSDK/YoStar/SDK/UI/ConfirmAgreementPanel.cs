using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class ConfirmAgreementPanel : BasePanel
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x5C57B50", Offset = "0x5C56750", VA = "0x185C57B50")]
		private new void Awake()
		{
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x5C58C80", Offset = "0x5C57880", VA = "0x185C58C80")]
		private void Start()
		{
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x5C58090", Offset = "0x5C56C90", VA = "0x185C58090")]
		private void SetAgreementContent(List<GameObject> gameObjects)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x5C57F00", Offset = "0x5C56B00", VA = "0x185C57F00")]
		private string DealAgreementContent(string content, string highlightedContent, string type)
		{
			return null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x5C57FB0", Offset = "0x5C56BB0", VA = "0x185C57FB0")]
		private void OnClick(Button btn)
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x5C59720", Offset = "0x5C58320", VA = "0x185C59720")]
		public ConfirmAgreementPanel()
		{
		}

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x50")]
		private Button leftBtn;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x58")]
		private Button rightBtn;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x60")]
		private bool isENOrTw;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x68")]
		private List<GameObject> choiceList;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x70")]
		private List<bool> agreementSelected;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x78")]
		private List<HyperlinkText> textMeshProUGUIs;
	}
}
