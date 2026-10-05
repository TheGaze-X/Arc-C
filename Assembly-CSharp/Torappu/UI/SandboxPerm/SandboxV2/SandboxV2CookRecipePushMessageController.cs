using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043A8 RID: 17320
	[Token(Token = "0x20043A8")]
	public class SandboxV2CookRecipePushMessageController : PageSingleComponent, IHotfixable
	{
		// Token: 0x0601A938 RID: 108856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A938")]
		[Address(RVA = "0x13A97E0", Offset = "0x13A83E0", VA = "0x1813A97E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601A939 RID: 108857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A939")]
		[Address(RVA = "0x13A9410", Offset = "0x13A8010", VA = "0x1813A9410")]
		public void HandleCookRecipeWithToast(List<string> itemIds)
		{
		}

		// Token: 0x0601A93A RID: 108858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A93A")]
		[Address(RVA = "0x13A9960", Offset = "0x13A8560", VA = "0x1813A9960")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A93B RID: 108859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A93B")]
		[Address(RVA = "0x13A9AA0", Offset = "0x13A86A0", VA = "0x1813A9AA0")]
		public SandboxV2CookRecipePushMessageController()
		{
		}

		// Token: 0x0601A93C RID: 108860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A93C")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x04021DD0 RID: 138704
		[Token(Token = "0x4021DD0")]
		[FieldOffset(Offset = "0x20")]
		private string m_topicId;

		// Token: 0x04021DD1 RID: 138705
		[Token(Token = "0x4021DD1")]
		[FieldOffset(Offset = "0x28")]
		private bool m_hasInited;

		// Token: 0x04021DD2 RID: 138706
		[Token(Token = "0x4021DD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04021DD3 RID: 138707
		[Token(Token = "0x4021DD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCookRecipeWithToast;

		// Token: 0x04021DD4 RID: 138708
		[Token(Token = "0x4021DD4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021DD5 RID: 138709
		[Token(Token = "0x4021DD5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
