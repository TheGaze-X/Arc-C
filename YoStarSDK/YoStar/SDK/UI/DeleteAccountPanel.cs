using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;
using YoStar.SDK.Constant;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public class DeleteAccountPanel : BasePanel
	{
		// Token: 0x060008DC RID: 2268 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x5C5F110", Offset = "0x5C5DD10", VA = "0x185C5F110")]
		private new void Awake()
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x5C5F250", Offset = "0x5C5DE50", VA = "0x185C5F250")]
		private void FindComponent()
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x5C5FB80", Offset = "0x5C5E780", VA = "0x185C5FB80")]
		private void Start()
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x5C5F120", Offset = "0x5C5DD20", VA = "0x185C5F120")]
		private void Close()
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x5C5F750", Offset = "0x5C5E350", VA = "0x185C5F750")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x5C5FAE0", Offset = "0x5C5E6E0", VA = "0x185C5FAE0")]
		private void RebornLogicAsync(RebornRet ret)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x5C5FD10", Offset = "0x5C5E910", VA = "0x185C5FD10")]
		private void Update()
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x5C5FAD0", Offset = "0x5C5E6D0", VA = "0x185C5FAD0", Slot = "8")]
		public override void OnPanelResult(int requestCode, int resultCode, Dictionary<string, object> resultdataMap)
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x5C5F820", Offset = "0x5C5E420", VA = "0x185C5F820", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public DeleteAccountPanel()
		{
		}

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x50")]
		private DeleteViewType deleteViewType;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x58")]
		private Text contentText;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x60")]
		private Button cancelButton;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x68")]
		private Button confirmButton;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x70")]
		private CustomHeaderScript customHeaderScript;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x78")]
		private Action confirmAction;
	}
}
