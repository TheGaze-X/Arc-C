using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x02002953 RID: 10579
	[Token(Token = "0x2002953")]
	public class CSquadAttributeAdd : BasicCharacterRelic
	{
		// Token: 0x06011888 RID: 71816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011888")]
		[Address(RVA = "0x951C70", Offset = "0x950870", VA = "0x180951C70", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x06011889 RID: 71817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011889")]
		[Address(RVA = "0x951E70", Offset = "0x950A70", VA = "0x180951E70", Slot = "6")]
		protected override void DoPreProcess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x0601188A RID: 71818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601188A")]
		[Address(RVA = "0x952160", Offset = "0x950D60", VA = "0x180952160")]
		public CSquadAttributeAdd()
		{
		}

		// Token: 0x0601188B RID: 71819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601188B")]
		[Address(RVA = "0x950440", Offset = "0x94F040", VA = "0x180950440")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601188C RID: 71820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601188C")]
		[Address(RVA = "0x94EA20", Offset = "0x94D620", VA = "0x18094EA20")]
		private void <>xLuaBaseProxy_DoPreProcess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x04013995 RID: 80277
		[Token(Token = "0x4013995")]
		[FieldOffset(Offset = "0x30")]
		protected int m_cnt;

		// Token: 0x04013996 RID: 80278
		[Token(Token = "0x4013996")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013997 RID: 80279
		[Token(Token = "0x4013997")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreProcess;

		// Token: 0x04013998 RID: 80280
		[Token(Token = "0x4013998")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
