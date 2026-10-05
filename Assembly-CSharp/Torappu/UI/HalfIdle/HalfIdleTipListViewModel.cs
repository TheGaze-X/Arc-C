using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006756 RID: 26454
	[Token(Token = "0x2006756")]
	public class HalfIdleTipListViewModel : IHotfixable
	{
		// Token: 0x06025F72 RID: 155506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F72")]
		[Address(RVA = "0x20F1400", Offset = "0x20F0000", VA = "0x1820F1400")]
		public void UpdateData()
		{
		}

		// Token: 0x06025F73 RID: 155507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F73")]
		[Address(RVA = "0x20F14B0", Offset = "0x20F00B0", VA = "0x1820F14B0")]
		public HalfIdleTipListViewModel()
		{
		}

		// Token: 0x04035674 RID: 218740
		[Token(Token = "0x4035674")]
		[FieldOffset(Offset = "0x10")]
		public bool isEnemyOverload;

		// Token: 0x04035675 RID: 218741
		[Token(Token = "0x4035675")]
		[FieldOffset(Offset = "0x11")]
		public bool isEnemyOverloadWarning;

		// Token: 0x04035676 RID: 218742
		[Token(Token = "0x4035676")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04035677 RID: 218743
		[Token(Token = "0x4035677")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
