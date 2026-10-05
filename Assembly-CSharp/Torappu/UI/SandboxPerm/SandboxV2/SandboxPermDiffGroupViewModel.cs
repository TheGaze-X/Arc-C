using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200401C RID: 16412
	[Token(Token = "0x200401C")]
	public class SandboxPermDiffGroupViewModel : IHotfixable
	{
		// Token: 0x06019692 RID: 104082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019692")]
		[Address(RVA = "0x12151D0", Offset = "0x1213DD0", VA = "0x1812151D0")]
		public SandboxPermDiffGroupViewModel()
		{
		}

		// Token: 0x0401F9D9 RID: 129497
		[Token(Token = "0x401F9D9")]
		[FieldOffset(Offset = "0x10")]
		public List<SandboxPermDiffViewModel> diffList;

		// Token: 0x0401F9DA RID: 129498
		[Token(Token = "0x401F9DA")]
		[FieldOffset(Offset = "0x18")]
		public string tip;

		// Token: 0x0401F9DB RID: 129499
		[Token(Token = "0x401F9DB")]
		[FieldOffset(Offset = "0x20")]
		public int currentMode;

		// Token: 0x0401F9DC RID: 129500
		[Token(Token = "0x401F9DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
