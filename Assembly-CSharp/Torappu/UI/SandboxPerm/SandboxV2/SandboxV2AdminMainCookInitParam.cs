using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004096 RID: 16534
	[Token(Token = "0x2004096")]
	public class SandboxV2AdminMainCookInitParam : ISandboxV2AdminMainTabPanelInitParam, IHotfixable
	{
		// Token: 0x06019951 RID: 104785 RVA: 0x0009EB50 File Offset: 0x0009CD50
		[Token(Token = "0x6019951")]
		[Address(RVA = "0x1244690", Offset = "0x1243290", VA = "0x181244690")]
		public bool CheckTypeActive(SandboxV2AdminMainCookType type)
		{
			return default(bool);
		}

		// Token: 0x06019952 RID: 104786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019952")]
		[Address(RVA = "0x12447C0", Offset = "0x12433C0", VA = "0x1812447C0")]
		public SandboxV2AdminMainCookInitParam()
		{
		}

		// Token: 0x0401FF01 RID: 130817
		[Token(Token = "0x401FF01")]
		[FieldOffset(Offset = "0x10")]
		public IList<SandboxV2AdminMainCookType> activeTypeList;

		// Token: 0x0401FF02 RID: 130818
		[Token(Token = "0x401FF02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckTypeActive;

		// Token: 0x0401FF03 RID: 130819
		[Token(Token = "0x401FF03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
