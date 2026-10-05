using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x0200296C RID: 10604
	[Token(Token = "0x200296C")]
	public class DCandleEffectBuff : BasicDeckCardRelic
	{
		// Token: 0x060118E0 RID: 71904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118E0")]
		[Address(RVA = "0x9528B0", Offset = "0x9514B0", VA = "0x1809528B0", Slot = "6")]
		protected override void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118E1 RID: 71905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118E1")]
		[Address(RVA = "0x952AB0", Offset = "0x9516B0", VA = "0x180952AB0")]
		public DCandleEffectBuff()
		{
		}

		// Token: 0x060118E2 RID: 71906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118E2")]
		[Address(RVA = "0x94EA20", Offset = "0x94D620", VA = "0x18094EA20")]
		private void <>xLuaBaseProxy_DoPreProcess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139E2 RID: 80354
		[Token(Token = "0x40139E2")]
		private const string ROGUELIKE_CHARACTER_IN_CANDLE_BUFF = "roguelike_character_in_candle_buff";

		// Token: 0x040139E3 RID: 80355
		[Token(Token = "0x40139E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x040139E4 RID: 80356
		[Token(Token = "0x40139E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
