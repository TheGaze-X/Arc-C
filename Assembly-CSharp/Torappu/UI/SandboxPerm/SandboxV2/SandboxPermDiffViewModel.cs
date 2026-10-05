using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200401B RID: 16411
	[Token(Token = "0x200401B")]
	public class SandboxPermDiffViewModel : IHotfixable
	{
		// Token: 0x06019691 RID: 104081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019691")]
		[Address(RVA = "0x1216700", Offset = "0x1215300", VA = "0x181216700")]
		public SandboxPermDiffViewModel()
		{
		}

		// Token: 0x0401F9D1 RID: 129489
		[Token(Token = "0x401F9D1")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0401F9D2 RID: 129490
		[Token(Token = "0x401F9D2")]
		[FieldOffset(Offset = "0x18")]
		public bool isSelected;

		// Token: 0x0401F9D3 RID: 129491
		[Token(Token = "0x401F9D3")]
		[FieldOffset(Offset = "0x1C")]
		public int index;

		// Token: 0x0401F9D4 RID: 129492
		[Token(Token = "0x401F9D4")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0401F9D5 RID: 129493
		[Token(Token = "0x401F9D5")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		// Token: 0x0401F9D6 RID: 129494
		[Token(Token = "0x401F9D6")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x0401F9D7 RID: 129495
		[Token(Token = "0x401F9D7")]
		[FieldOffset(Offset = "0x38")]
		public string detailList;

		// Token: 0x0401F9D8 RID: 129496
		[Token(Token = "0x401F9D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
