using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002963 RID: 10595
	[Token(Token = "0x2002963")]
	public class GBuffNormal : BasicRelic
	{
		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x060118BF RID: 71871 RVA: 0x0006BD60 File Offset: 0x00069F60
		[Token(Token = "0x170026BC")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118BF")]
			[Address(RVA = "0x953FE0", Offset = "0x952BE0", VA = "0x180953FE0", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118C0 RID: 71872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C0")]
		[Address(RVA = "0x953DB0", Offset = "0x9529B0", VA = "0x180953DB0", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118C1 RID: 71873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C1")]
		[Address(RVA = "0x953F80", Offset = "0x952B80", VA = "0x180953F80")]
		public GBuffNormal()
		{
		}

		// Token: 0x060118C2 RID: 71874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118C2")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139C9 RID: 80329
		[Token(Token = "0x40139C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139CA RID: 80330
		[Token(Token = "0x40139CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040139CB RID: 80331
		[Token(Token = "0x40139CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
