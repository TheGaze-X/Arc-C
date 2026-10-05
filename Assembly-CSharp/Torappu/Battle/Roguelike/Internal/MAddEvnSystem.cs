using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002972 RID: 10610
	[Token(Token = "0x2002972")]
	public class MAddEvnSystem : BasicRelic
	{
		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x060118F4 RID: 71924 RVA: 0x0006BE38 File Offset: 0x0006A038
		[Token(Token = "0x170026C2")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60118F4")]
			[Address(RVA = "0x957310", Offset = "0x955F10", VA = "0x180957310", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060118F5 RID: 71925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118F5")]
		[Address(RVA = "0x957150", Offset = "0x955D50", VA = "0x180957150", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060118F6 RID: 71926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118F6")]
		[Address(RVA = "0x9572B0", Offset = "0x955EB0", VA = "0x1809572B0")]
		public MAddEvnSystem()
		{
		}

		// Token: 0x060118F7 RID: 71927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60118F7")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040139F1 RID: 80369
		[Token(Token = "0x40139F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040139F2 RID: 80370
		[Token(Token = "0x40139F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040139F3 RID: 80371
		[Token(Token = "0x40139F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
