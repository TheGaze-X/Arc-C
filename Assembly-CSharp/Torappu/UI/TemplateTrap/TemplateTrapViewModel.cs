using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D3A RID: 15674
	[Token(Token = "0x2003D3A")]
	public class TemplateTrapViewModel : IHotfixable
	{
		// Token: 0x060186B6 RID: 100022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B6")]
		[Address(RVA = "0x10FF9B0", Offset = "0x10FE5B0", VA = "0x1810FF9B0")]
		public TemplateTrapViewModel()
		{
		}

		// Token: 0x0401DDF7 RID: 122359
		[Token(Token = "0x401DDF7")]
		[FieldOffset(Offset = "0x10")]
		public string trapId;

		// Token: 0x0401DDF8 RID: 122360
		[Token(Token = "0x401DDF8")]
		[FieldOffset(Offset = "0x18")]
		public string trapName;

		// Token: 0x0401DDF9 RID: 122361
		[Token(Token = "0x401DDF9")]
		[FieldOffset(Offset = "0x20")]
		public bool isSelected;

		// Token: 0x0401DDFA RID: 122362
		[Token(Token = "0x401DDFA")]
		[FieldOffset(Offset = "0x24")]
		public int selectPos;

		// Token: 0x0401DDFB RID: 122363
		[Token(Token = "0x401DDFB")]
		[FieldOffset(Offset = "0x28")]
		public int count;

		// Token: 0x0401DDFC RID: 122364
		[Token(Token = "0x401DDFC")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;

		// Token: 0x0401DDFD RID: 122365
		[Token(Token = "0x401DDFD")]
		[FieldOffset(Offset = "0x30")]
		public string taskId;

		// Token: 0x0401DDFE RID: 122366
		[Token(Token = "0x401DDFE")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x0401DDFF RID: 122367
		[Token(Token = "0x401DDFF")]
		[FieldOffset(Offset = "0x40")]
		public string trapUnlockDesc;

		// Token: 0x0401DE00 RID: 122368
		[Token(Token = "0x401DE00")]
		[FieldOffset(Offset = "0x48")]
		public string trapBuffId;

		// Token: 0x0401DE01 RID: 122369
		[Token(Token = "0x401DE01")]
		[FieldOffset(Offset = "0x50")]
		public string domainId;

		// Token: 0x0401DE02 RID: 122370
		[Token(Token = "0x401DE02")]
		[FieldOffset(Offset = "0x58")]
		public int availableCount;

		// Token: 0x0401DE03 RID: 122371
		[Token(Token = "0x401DE03")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
