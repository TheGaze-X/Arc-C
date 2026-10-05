using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B1B RID: 27419
	[Token(Token = "0x2006B1B")]
	public class ArchiveBuffGroupModel : IHotfixable
	{
		// Token: 0x0602732E RID: 160558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602732E")]
		[Address(RVA = "0x22628B0", Offset = "0x22614B0", VA = "0x1822628B0")]
		public ArchiveBuffGroupModel()
		{
		}

		// Token: 0x04037759 RID: 227161
		[Token(Token = "0x4037759")]
		[FieldOffset(Offset = "0x10")]
		public int groupIndex;

		// Token: 0x0403775A RID: 227162
		[Token(Token = "0x403775A")]
		[FieldOffset(Offset = "0x18")]
		public List<BuffItemModel> buffs;

		// Token: 0x0403775B RID: 227163
		[Token(Token = "0x403775B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
