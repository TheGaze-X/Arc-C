using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x0200019A RID: 410
	[Token(Token = "0x200019A")]
	public class NoticePanel : BasePanel
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x5C729C0", Offset = "0x5C715C0", VA = "0x185C729C0")]
		private new void Awake()
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x5C729D0", Offset = "0x5C715D0", VA = "0x185C729D0")]
		private void FindComponent()
		{
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x5C731F0", Offset = "0x5C71DF0", VA = "0x185C731F0")]
		private void Start()
		{
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x5C72DC0", Offset = "0x5C719C0", VA = "0x185C72DC0")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Update()
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x5C72E80", Offset = "0x5C71A80", VA = "0x185C72E80", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public NoticePanel()
		{
		}

		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		[FieldOffset(Offset = "0x50")]
		private Text contentText;

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x58")]
		private Button cancelButton;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x60")]
		private Button confirmButton;

		// Token: 0x0400068C RID: 1676
		[Token(Token = "0x400068C")]
		[FieldOffset(Offset = "0x68")]
		private GameObject buttonGO;

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x70")]
		private CustomHeaderScript customHeaderScript;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x78")]
		private Action OnLeftAction;

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		[FieldOffset(Offset = "0x80")]
		private Action OnRightAction;

		// Token: 0x04000690 RID: 1680
		[Token(Token = "0x4000690")]
		[FieldOffset(Offset = "0x88")]
		private NoticeConfig noticeConfig;
	}
}
