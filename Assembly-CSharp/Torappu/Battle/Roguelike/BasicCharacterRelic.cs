using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x02002929 RID: 10537
	[Token(Token = "0x2002929")]
	public abstract class BasicCharacterRelic : BasicRelic
	{
		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0601178F RID: 71567 RVA: 0x0006B820 File Offset: 0x00069A20
		[Token(Token = "0x170026A7")]
		public override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x601178F")]
			[Address(RVA = "0x94E4A0", Offset = "0x94D0A0", VA = "0x18094E4A0", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x06011790 RID: 71568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011790")]
		[Address(RVA = "0x94E240", Offset = "0x94CE40", VA = "0x18094E240", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011791 RID: 71569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011791")]
		[Address(RVA = "0x94E440", Offset = "0x94D040", VA = "0x18094E440")]
		protected BasicCharacterRelic()
		{
		}

		// Token: 0x06011792 RID: 71570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011792")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040138A5 RID: 80037
		[Token(Token = "0x40138A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040138A6 RID: 80038
		[Token(Token = "0x40138A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040138A7 RID: 80039
		[Token(Token = "0x40138A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
