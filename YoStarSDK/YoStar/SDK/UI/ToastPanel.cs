using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace YoStar.SDK.UI
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public class ToastPanel : BasePanel
	{
		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x5C8FCA0", Offset = "0x5C8E8A0", VA = "0x185C8FCA0", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x5C8FFB0", Offset = "0x5C8EBB0", VA = "0x185C8FFB0")]
		private void Update()
		{
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x5C90240", Offset = "0x5C8EE40", VA = "0x185C90240")]
		public ToastPanel()
		{
		}

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x50")]
		private float delayTime;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x54")]
		private float time;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x58")]
		private Text textComponent;
	}
}
