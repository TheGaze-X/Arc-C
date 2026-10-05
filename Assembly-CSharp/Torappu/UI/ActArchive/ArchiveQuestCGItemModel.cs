using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BFE RID: 27646
	[Token(Token = "0x2006BFE")]
	public class ArchiveQuestCGItemModel : IHotfixable
	{
		// Token: 0x0602779A RID: 161690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602779A")]
		[Address(RVA = "0x22A8CF0", Offset = "0x22A78F0", VA = "0x1822A8CF0")]
		public ArchiveQuestCGItemModel()
		{
		}

		// Token: 0x04037F2C RID: 229164
		[Token(Token = "0x4037F2C")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ArchiveQuestCgData cgData;

		// Token: 0x04037F2D RID: 229165
		[Token(Token = "0x4037F2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
