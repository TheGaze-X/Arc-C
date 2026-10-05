using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050CC RID: 20684
	[Token(Token = "0x20050CC")]
	public class EmoticonThemeItemModel : IHotfixable
	{
		// Token: 0x0601E98A RID: 125322 RVA: 0x000AF080 File Offset: 0x000AD280
		[Token(Token = "0x601E98A")]
		[Address(RVA = "0x183C740", Offset = "0x183B340", VA = "0x18183C740")]
		public bool TryLoadData(string themeId, EmojiSceneType chatSceneType)
		{
			return default(bool);
		}

		// Token: 0x0601E98B RID: 125323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E98B")]
		[Address(RVA = "0x183CB60", Offset = "0x183B760", VA = "0x18183CB60")]
		public EmoticonThemeItemModel()
		{
		}

		// Token: 0x04028FF6 RID: 167926
		[Token(Token = "0x4028FF6")]
		[FieldOffset(Offset = "0x10")]
		public string themeId;

		// Token: 0x04028FF7 RID: 167927
		[Token(Token = "0x4028FF7")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04028FF8 RID: 167928
		[Token(Token = "0x4028FF8")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04028FF9 RID: 167929
		[Token(Token = "0x4028FF9")]
		[FieldOffset(Offset = "0x28")]
		public List<EmojiItemModel> emojiItemModels;

		// Token: 0x04028FFA RID: 167930
		[Token(Token = "0x4028FFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryLoadData;

		// Token: 0x04028FFB RID: 167931
		[Token(Token = "0x4028FFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
