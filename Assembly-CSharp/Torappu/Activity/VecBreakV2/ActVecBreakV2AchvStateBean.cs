using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DCD RID: 28109
	[Token(Token = "0x2006DCD")]
	public class ActVecBreakV2AchvStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005EA9 RID: 24233
		// (get) Token: 0x06028065 RID: 163941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005EA9")]
		public ActVecBreakV2AchvProp prop
		{
			[Token(Token = "0x6028065")]
			[Address(RVA = "0x2349EF0", Offset = "0x2348AF0", VA = "0x182349EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028066 RID: 163942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028066")]
		[Address(RVA = "0x2349E00", Offset = "0x2348A00", VA = "0x182349E00")]
		public ActVecBreakV2AchvStateBean()
		{
		}

		// Token: 0x04038BFF RID: 232447
		[Token(Token = "0x4038BFF")]
		[FieldOffset(Offset = "0x10")]
		private ActVecBreakV2AchvProp m_prop;

		// Token: 0x04038C00 RID: 232448
		[Token(Token = "0x4038C00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04038C01 RID: 232449
		[Token(Token = "0x4038C01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
