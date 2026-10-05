using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YoStar.SDK.UI
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	public class InitFiledPanel : BasePanel
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x5C64610", Offset = "0x5C63210", VA = "0x185C64610")]
		private void RetryInit()
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x5C63950", Offset = "0x5C62550", VA = "0x185C63950", Slot = "9")]
		public override void OnCreate()
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0", Slot = "7")]
		public override void UpdateView()
		{
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x5C646B0", Offset = "0x5C632B0", VA = "0x185C646B0")]
		private void StartCheck()
		{
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x5C638F0", Offset = "0x5C624F0", VA = "0x185C638F0")]
		private void CustomService()
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x5C637C0", Offset = "0x5C623C0", VA = "0x185C637C0")]
		private void ClosePanel()
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void InitView()
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public InitFiledPanel()
		{
		}

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		public const string code = "code";

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		public const string msg = "msg";

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		public const string initModel = "model";

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, string> dictData;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x58")]
		private InitRet initRet;
	}
}
