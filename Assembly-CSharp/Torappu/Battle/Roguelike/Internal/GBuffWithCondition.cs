using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002969 RID: 10601
	[Token(Token = "0x2002969")]
	public class GBuffWithCondition : BasicRelic
	{
		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x060118D5 RID: 71893 RVA: 0x0006BDF0 File Offset: 0x00069FF0
		[Token(Token = "0x170026C1")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118D5")]
			[Address(RVA = "0x955230", Offset = "0x953E30", VA = "0x180955230", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118D6 RID: 71894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118D6")]
		[Address(RVA = "0x954AA0", Offset = "0x9536A0", VA = "0x180954AA0", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118D7 RID: 71895 RVA: 0x0006BE08 File Offset: 0x0006A008
		[Token(Token = "0x60118D7")]
		[Address(RVA = "0x9550A0", Offset = "0x953CA0", VA = "0x1809550A0")]
		private int _GetSquadProfessionCnt()
		{
			return 0;
		}

		// Token: 0x060118D8 RID: 71896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118D8")]
		[Address(RVA = "0x9551D0", Offset = "0x953DD0", VA = "0x1809551D0")]
		public GBuffWithCondition()
		{
		}

		// Token: 0x060118D9 RID: 71897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118D9")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139D9 RID: 80345
		[Token(Token = "0x40139D9")]
		private const string DEFAULT_COND_TYPE = "GE";

		// Token: 0x040139DA RID: 80346
		[Token(Token = "0x40139DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139DB RID: 80347
		[Token(Token = "0x40139DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040139DC RID: 80348
		[Token(Token = "0x40139DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetSquadProfessionCnt;

		// Token: 0x040139DD RID: 80349
		[Token(Token = "0x40139DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
