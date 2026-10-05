using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Roguelike.Internal
{
	// Token: 0x0200293E RID: 10558
	[Token(Token = "0x200293E")]
	public class LInitCostAddBySquad : BasicLevelRelic
	{
		// Token: 0x06011844 RID: 71748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011844")]
		[Address(RVA = "0x955F40", Offset = "0x954B40", VA = "0x180955F40", Slot = "5")]
		public override void OnInit()
		{
		}

		// Token: 0x06011845 RID: 71749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011845")]
		[Address(RVA = "0x956060", Offset = "0x954C60", VA = "0x180956060", Slot = "7")]
		public override void Preprocess(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011846 RID: 71750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011846")]
		[Address(RVA = "0x956120", Offset = "0x954D20", VA = "0x180956120")]
		public LInitCostAddBySquad()
		{
		}

		// Token: 0x06011847 RID: 71751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011847")]
		[Address(RVA = "0x950440", Offset = "0x94F040", VA = "0x180950440")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06011848 RID: 71752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011848")]
		[Address(RVA = "0x94E430", Offset = "0x94D030", VA = "0x18094E430")]
		private void <>xLuaBaseProxy_Preprocess(ref BasicRelic.RelicInOut P0)
		{
		}

		// Token: 0x04013966 RID: 80230
		[Token(Token = "0x4013966")]
		[FieldOffset(Offset = "0x30")]
		protected int m_cnt;

		// Token: 0x04013967 RID: 80231
		[Token(Token = "0x4013967")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013968 RID: 80232
		[Token(Token = "0x4013968")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Preprocess;

		// Token: 0x04013969 RID: 80233
		[Token(Token = "0x4013969")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
