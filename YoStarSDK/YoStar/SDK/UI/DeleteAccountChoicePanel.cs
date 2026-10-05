using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.Constant;

namespace YoStar.SDK.UI
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public class DeleteAccountChoicePanel : BasePanel
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x5C5DC50", Offset = "0x5C5C850", VA = "0x185C5DC50")]
		private new void Awake()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x5C5E530", Offset = "0x5C5D130", VA = "0x185C5E530")]
		private void OnClearAction(Button clearButton)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x5C5EAD0", Offset = "0x5C5D6D0", VA = "0x185C5EAD0")]
		private void Update()
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x5C5EA10", Offset = "0x5C5D610", VA = "0x185C5EA10")]
		private void OnValueChanged(string value)
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x5C5E610", Offset = "0x5C5D210", VA = "0x185C5E610")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x5C5E940", Offset = "0x5C5D540", VA = "0x185C5E940", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public DeleteAccountChoicePanel()
		{
		}

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x50")]
		private Text msgText;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x58")]
		private Text choiceText;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x60")]
		private bool choiced;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x68")]
		private Button cancelButton;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x70")]
		private Button confirmButton;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x78")]
		private Button closeButton;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x80")]
		private DeleteViewType deleteViewType;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x88")]
		private InputField deleteInputField;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x90")]
		private Button clearButton;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x98")]
		private GameObject choiceGO;
	}
}
