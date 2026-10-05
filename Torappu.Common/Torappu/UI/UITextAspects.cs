using System;
using Il2CppDummyDll;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public class UITextAspects : TextAspects, IHotfixable
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x5560230", Offset = "0x555EE30", VA = "0x185560230", Slot = "4")]
		public override void ProcessTextToShow(Text text, ref string textToShow, ref bool textNotFound)
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00007424 File Offset: 0x00005624
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x5560480", Offset = "0x555F080", VA = "0x185560480")]
		private bool _GetTextAndAssignedToTextToShow(Text text, ref string textToShow)
		{
			return default(bool);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x5560300", Offset = "0x555EF00", VA = "0x185560300", Slot = "5")]
		public override void SetText(Text text, string textToShow, string value, out bool isVerticesDirty, out bool isLayoutDirty)
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0000743C File Offset: 0x0000563C
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x5560730", Offset = "0x555F330", VA = "0x185560730")]
		private bool _LoadTextFromDBById(string textId, out string text)
		{
			return default(bool);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x5560810", Offset = "0x555F410", VA = "0x185560810")]
		private UITextAspects()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x55600E0", Offset = "0x555ECE0", VA = "0x1855600E0")]
		public static void BindToUGUI()
		{
		}

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x0")]
		private static UITextAspects s_instance;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate199 __Hotfix0_ProcessTextToShow;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate200 __Hotfix0__GetTextAndAssignedToTextToShow;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate201 __Hotfix0_SetText;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate202 __Hotfix0__LoadTextFromDBById;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate14 __Hotfix0_BindToUGUI;
	}
}
