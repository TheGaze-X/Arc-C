using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002952 RID: 10578
	[Token(Token = "0x2002952")]
	public class CSquadAttributeMul : BasicCharacterRelic
	{
		// Token: 0x06011883 RID: 71811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011883")]
		[Address(RVA = "0x952320", Offset = "0x950F20", VA = "0x180952320", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x06011884 RID: 71812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011884")]
		[Address(RVA = "0x952520", Offset = "0x951120", VA = "0x180952520", Slot = "6")]
		protected override void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011885 RID: 71813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011885")]
		[Address(RVA = "0x952810", Offset = "0x951410", VA = "0x180952810")]
		public CSquadAttributeMul()
		{
		}

		// Token: 0x06011886 RID: 71814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011886")]
		[Address(RVA = "0x950440", Offset = "0x94F040", VA = "0x180950440")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06011887 RID: 71815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011887")]
		[Address(RVA = "0x94EA20", Offset = "0x94D620", VA = "0x18094EA20")]
		private void <>xLuaBaseProxy_DoPreProcess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x04013991 RID: 80273
		[Token(Token = "0x4013991")]
		[FieldOffset(Offset = "0x30")]
		protected int m_cnt;

		// Token: 0x04013992 RID: 80274
		[Token(Token = "0x4013992")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013993 RID: 80275
		[Token(Token = "0x4013993")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x04013994 RID: 80276
		[Token(Token = "0x4013994")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
