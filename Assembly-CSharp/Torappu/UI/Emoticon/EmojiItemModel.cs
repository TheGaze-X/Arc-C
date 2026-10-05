using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050CE RID: 20686
	[Token(Token = "0x20050CE")]
	public class EmojiItemModel : IHotfixable
	{
		// Token: 0x0601E98F RID: 125327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E98F")]
		[Address(RVA = "0x1839400", Offset = "0x1838000", VA = "0x181839400")]
		public void LoadData(EmoticonData.EmojiData emojiData, string themeId)
		{
		}

		// Token: 0x0601E990 RID: 125328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E990")]
		[Address(RVA = "0x18394D0", Offset = "0x18380D0", VA = "0x1818394D0")]
		public EmojiItemModel()
		{
		}

		// Token: 0x04028FFE RID: 167934
		[Token(Token = "0x4028FFE")]
		[FieldOffset(Offset = "0x10")]
		public string emojiId;

		// Token: 0x04028FFF RID: 167935
		[Token(Token = "0x4028FFF")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04029000 RID: 167936
		[Token(Token = "0x4029000")]
		[FieldOffset(Offset = "0x20")]
		public string picId;

		// Token: 0x04029001 RID: 167937
		[Token(Token = "0x4029001")]
		[FieldOffset(Offset = "0x28")]
		public string txt;

		// Token: 0x04029002 RID: 167938
		[Token(Token = "0x4029002")]
		[FieldOffset(Offset = "0x30")]
		public string themeId;

		// Token: 0x04029003 RID: 167939
		[Token(Token = "0x4029003")]
		[FieldOffset(Offset = "0x38")]
		public SeqNumSource onSendSeq;

		// Token: 0x04029004 RID: 167940
		[Token(Token = "0x4029004")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029005 RID: 167941
		[Token(Token = "0x4029005")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
