using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200794C RID: 31052
	[Token(Token = "0x200794C")]
	public class Act1ArcadeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602B926 RID: 178470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B926")]
		[Address(RVA = "0x2778510", Offset = "0x2777110", VA = "0x182778510")]
		public Act1ArcadeStateBean()
		{
		}

		// Token: 0x0403F073 RID: 258163
		[Token(Token = "0x403F073")]
		[FieldOffset(Offset = "0x10")]
		public Act1ArcadeEntryProperty m_prop;

		// Token: 0x0403F074 RID: 258164
		[Token(Token = "0x403F074")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
