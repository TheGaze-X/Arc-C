using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YoStar.SDK.UI;

namespace YoStar.SDK.Extension
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public static class UIManagerExtension
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x5CB4D70", Offset = "0x5CB3970", VA = "0x185CB4D70")]
		public static void PushPanelDelay(this UIManager uiManager, string panelPath, bool isCover = false, [Optional] Dictionary<string, object> dataMap, float delay = 0.2f, [Optional] Action<object> action)
		{
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x5CB4D00", Offset = "0x5CB3900", VA = "0x185CB4D00")]
		public static void PopAllPanelAndLoading(this UIManager uiManager)
		{
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x5CB4A90", Offset = "0x5CB3690", VA = "0x185CB4A90")]
		public static void LoginDoneUI(this UIManager uiManager)
		{
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E5D")]
		[Address(RVA = "0x5CB5620", Offset = "0x5CB4220", VA = "0x185CB5620")]
		public static void ShowWarnPop(this UIManager uiManager, string title, string subTitle = "", string left = "", string right = "", [Optional] Action<bool> action)
		{
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x5CB5530", Offset = "0x5CB4130", VA = "0x185CB5530")]
		public static void ShowToast(this UIManager uiManager, string msg)
		{
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x5CB4EB0", Offset = "0x5CB3AB0", VA = "0x185CB4EB0")]
		public static void ShowCommon(this UIManager uiManager, int code, bool pop = false, bool isCover = true, [Optional] Action closeAction, [Optional] Action backAction, [Optional] Action cancelAction, [Optional] Action confirmAction)
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x5CB5380", Offset = "0x5CB3F80", VA = "0x185CB5380")]
		private static void ShowPop(this UIManager uiManager, string msg, bool isCover = true, [Optional] Action closeAction, [Optional] Action backAction, [Optional] Action cancelAction, [Optional] Action confirmAction)
		{
		}
	}
}
