using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using YoStar.SDK.View;

namespace YoStar.SDK.UI
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class CommonPopPanel : BasePanel
	{
		// Token: 0x0600084E RID: 2126 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x5C56C80", Offset = "0x5C55880", VA = "0x185C56C80")]
		private new void Awake()
		{
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x5C56C90", Offset = "0x5C55890", VA = "0x185C56C90")]
		private void FindComponent()
		{
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000851")]
		[Address(RVA = "0x5C57880", Offset = "0x5C56480", VA = "0x185C57880")]
		private void Start()
		{
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x5C57220", Offset = "0x5C55E20", VA = "0x185C57220")]
		private void OnClick(Button button)
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x5C57330", Offset = "0x5C55F30", VA = "0x185C57330", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public CommonPopPanel()
		{
		}

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x50")]
		private Text contentText;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x58")]
		private Button cancelButton;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x60")]
		private Button confirmButton;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x68")]
		private CustomHeaderScript customHeaderScript;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x70")]
		private Action backAction;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x78")]
		private Action closeAction;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x80")]
		private Action confirmAction;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x88")]
		private Action cancelAction;
	}
}
