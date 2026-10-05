using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002966 RID: 10598
	[Token(Token = "0x2002966")]
	public class GBuffWithLayer : BasicRelic
	{
		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x060118CB RID: 71883 RVA: 0x0006BDA8 File Offset: 0x00069FA8
		[Token(Token = "0x170026BF")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118CB")]
			[Address(RVA = "0x955500", Offset = "0x954100", VA = "0x180955500", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118CC RID: 71884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118CC")]
		[Address(RVA = "0x955290", Offset = "0x953E90", VA = "0x180955290", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118CD RID: 71885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118CD")]
		[Address(RVA = "0x9554A0", Offset = "0x9540A0", VA = "0x1809554A0")]
		public GBuffWithLayer()
		{
		}

		// Token: 0x060118CE RID: 71886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118CE")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139D2 RID: 80338
		[Token(Token = "0x40139D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139D3 RID: 80339
		[Token(Token = "0x40139D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040139D4 RID: 80340
		[Token(Token = "0x40139D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
