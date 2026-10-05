using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005987 RID: 22919
	[Token(Token = "0x2005987")]
	public class CrisisV2StageDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060216B3 RID: 136883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B3")]
		[Address(RVA = "0x1BCF710", Offset = "0x1BCE310", VA = "0x181BCF710")]
		public CrisisV2StageDetailStateBean()
		{
		}

		// Token: 0x0402D955 RID: 186709
		[Token(Token = "0x402D955")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2StageDetailProperty property;

		// Token: 0x0402D956 RID: 186710
		[Token(Token = "0x402D956")]
		[FieldOffset(Offset = "0x18")]
		public string mapId;

		// Token: 0x0402D957 RID: 186711
		[Token(Token = "0x402D957")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
