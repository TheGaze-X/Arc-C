using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200292D RID: 10541
	[Token(Token = "0x200292D")]
	public abstract class BasicMiscRelic : BasicRelic
	{
		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x060117A1 RID: 71585 RVA: 0x0006B898 File Offset: 0x00069A98
		[Token(Token = "0x170026AB")]
		public sealed override BasicRelic.RelicType relicType
		{
			[Token(Token = "0x60117A1")]
			[Address(RVA = "0x94EA90", Offset = "0x94D690", VA = "0x18094EA90", Slot = "4")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x060117A2 RID: 71586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A2")]
		[Address(RVA = "0x94E9C0", Offset = "0x94D5C0", VA = "0x18094E9C0", Slot = "7")]
		public sealed override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060117A3 RID: 71587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A3")]
		[Address(RVA = "0x94E960", Offset = "0x94D560", VA = "0x18094E960", Slot = "6")]
		protected sealed override void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x060117A4 RID: 71588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A4")]
		[Address(RVA = "0x94EA30", Offset = "0x94D630", VA = "0x18094EA30")]
		protected BasicMiscRelic()
		{
		}

		// Token: 0x060117A5 RID: 71589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A5")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x060117A6 RID: 71590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A6")]
		[Address(RVA = "0x94EA20", Offset = "0x94D620", VA = "0x18094EA20")]
		private void <>xLuaBaseProxy_DoPreProcess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x040138B0 RID: 80048
		[Token(Token = "0x40138B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relicType;

		// Token: 0x040138B1 RID: 80049
		[Token(Token = "0x40138B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x040138B2 RID: 80050
		[Token(Token = "0x40138B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x040138B3 RID: 80051
		[Token(Token = "0x40138B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
