using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002965 RID: 10597
	[Token(Token = "0x2002965")]
	public class GBuffStackBaseOne : BasicRelic
	{
		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x060118C7 RID: 71879 RVA: 0x0006BD90 File Offset: 0x00069F90
		[Token(Token = "0x170026BE")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118C7")]
			[Address(RVA = "0x9546D0", Offset = "0x9532D0", VA = "0x1809546D0", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118C8 RID: 71880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C8")]
		[Address(RVA = "0x9543C0", Offset = "0x952FC0", VA = "0x1809543C0", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118C9 RID: 71881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C9")]
		[Address(RVA = "0x954670", Offset = "0x953270", VA = "0x180954670")]
		public GBuffStackBaseOne()
		{
		}

		// Token: 0x060118CA RID: 71882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118CA")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139CF RID: 80335
		[Token(Token = "0x40139CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139D0 RID: 80336
		[Token(Token = "0x40139D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040139D1 RID: 80337
		[Token(Token = "0x40139D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
