using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE0 RID: 27360
	[Token(Token = "0x2006AE0")]
	public class ArchiveAchievementItemHolder : IHotfixable
	{
		// Token: 0x06027222 RID: 160290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027222")]
		[Address(RVA = "0x224FE20", Offset = "0x224EA20", VA = "0x18224FE20")]
		public ArchiveAchievementItemHolder()
		{
		}

		// Token: 0x040375AF RID: 226735
		[Token(Token = "0x40375AF")]
		[FieldOffset(Offset = "0x10")]
		public ArchiveAchievementItemView itemView;

		// Token: 0x040375B0 RID: 226736
		[Token(Token = "0x40375B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
