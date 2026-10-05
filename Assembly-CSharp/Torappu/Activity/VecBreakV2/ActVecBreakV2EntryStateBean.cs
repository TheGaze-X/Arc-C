using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E35 RID: 28213
	[Token(Token = "0x2006E35")]
	public class ActVecBreakV2EntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005EE7 RID: 24295
		// (get) Token: 0x06028280 RID: 164480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EE7")]
		public ActVecBreakV2EntryProp prop
		{
			[Token(Token = "0x6028280")]
			[Address(RVA = "0x236F880", Offset = "0x236E480", VA = "0x18236F880")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028281 RID: 164481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028281")]
		[Address(RVA = "0x236F7E0", Offset = "0x236E3E0", VA = "0x18236F7E0")]
		public ActVecBreakV2EntryStateBean()
		{
		}

		// Token: 0x04039060 RID: 233568
		[Token(Token = "0x4039060")]
		[FieldOffset(Offset = "0x10")]
		private ActVecBreakV2EntryProp m_prop;

		// Token: 0x04039061 RID: 233569
		[Token(Token = "0x4039061")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04039062 RID: 233570
		[Token(Token = "0x4039062")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
