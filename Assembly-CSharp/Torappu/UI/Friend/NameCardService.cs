using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D50 RID: 19792
	[Token(Token = "0x2004D50")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class NameCardService
	{
		// Token: 0x0601D9DA RID: 121306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9DA")]
		[Address(RVA = "0x1735D10", Offset = "0x1734910", VA = "0x181735D10")]
		public static void SendNameCardEditRequest(EditNameCardFlag flag, EditNameCardContent content, [Optional] Action<EditNameCardResponse> callback, NameCardV2ViewModel.MiscFlag miscFlag = NameCardV2ViewModel.MiscFlag.NONE)
		{
		}

		// Token: 0x0601D9DB RID: 121307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9DB")]
		[Address(RVA = "0x1736020", Offset = "0x1734C20", VA = "0x181736020")]
		private static void _FillContentMisc(NameCardV2ViewModel.MiscFlag miscFlag, ref EditNameCardContent content)
		{
		}

		// Token: 0x040271EC RID: 160236
		[Token(Token = "0x40271EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendNameCardEditRequest;

		// Token: 0x040271ED RID: 160237
		[Token(Token = "0x40271ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FillContentMisc;
	}
}
