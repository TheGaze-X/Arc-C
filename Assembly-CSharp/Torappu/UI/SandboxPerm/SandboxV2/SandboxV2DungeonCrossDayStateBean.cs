using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004198 RID: 16792
	[Token(Token = "0x2004198")]
	public class SandboxV2DungeonCrossDayStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x06019E6E RID: 106094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DAE")]
		public SandboxV2DungeonCrossDayProp crossDayProp
		{
			[Token(Token = "0x6019E6E")]
			[Address(RVA = "0x12C47D0", Offset = "0x12C33D0", VA = "0x1812C47D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019E6F RID: 106095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E6F")]
		[Address(RVA = "0x12C4730", Offset = "0x12C3330", VA = "0x1812C4730")]
		public SandboxV2DungeonCrossDayStateBean()
		{
		}

		// Token: 0x04020938 RID: 133432
		[Token(Token = "0x4020938")]
		[FieldOffset(Offset = "0x10")]
		private SandboxV2DungeonCrossDayProp m_crossDayProp;

		// Token: 0x04020939 RID: 133433
		[Token(Token = "0x4020939")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_crossDayProp;

		// Token: 0x0402093A RID: 133434
		[Token(Token = "0x402093A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
