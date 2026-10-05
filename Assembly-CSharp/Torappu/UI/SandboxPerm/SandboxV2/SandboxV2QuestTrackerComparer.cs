using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004234 RID: 16948
	[Token(Token = "0x2004234")]
	public class SandboxV2QuestTrackerComparer : IComparer<KeyValuePair<string, SandboxV2QuestTrackerItemViewModel>>, IHotfixable
	{
		// Token: 0x0601A21A RID: 107034 RVA: 0x000A0590 File Offset: 0x0009E790
		[Token(Token = "0x601A21A")]
		[Address(RVA = "0x130C6F0", Offset = "0x130B2F0", VA = "0x18130C6F0", Slot = "4")]
		public int Compare(KeyValuePair<string, SandboxV2QuestTrackerItemViewModel> x, KeyValuePair<string, SandboxV2QuestTrackerItemViewModel> y)
		{
			return 0;
		}

		// Token: 0x0601A21B RID: 107035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A21B")]
		[Address(RVA = "0x130C830", Offset = "0x130B430", VA = "0x18130C830")]
		public SandboxV2QuestTrackerComparer()
		{
		}

		// Token: 0x04020FE6 RID: 135142
		[Token(Token = "0x4020FE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x04020FE7 RID: 135143
		[Token(Token = "0x4020FE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
