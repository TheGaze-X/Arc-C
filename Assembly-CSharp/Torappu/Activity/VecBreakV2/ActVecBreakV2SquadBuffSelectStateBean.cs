using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E76 RID: 28278
	[Token(Token = "0x2006E76")]
	public class ActVecBreakV2SquadBuffSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060283D1 RID: 164817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D1")]
		[Address(RVA = "0x2383010", Offset = "0x2381C10", VA = "0x182383010")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060283D2 RID: 164818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D2")]
		[Address(RVA = "0x23831B0", Offset = "0x2381DB0", VA = "0x1823831B0")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x060283D3 RID: 164819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D3")]
		[Address(RVA = "0x2383270", Offset = "0x2381E70", VA = "0x182383270")]
		public void SelectBuffByStageId(string stageId)
		{
		}

		// Token: 0x060283D4 RID: 164820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D4")]
		[Address(RVA = "0x2383460", Offset = "0x2382060", VA = "0x182383460")]
		public void UnselectBuff(string buffId)
		{
		}

		// Token: 0x060283D5 RID: 164821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D5")]
		[Address(RVA = "0x2383330", Offset = "0x2381F30", VA = "0x182383330")]
		public void UnselectAllBuff()
		{
		}

		// Token: 0x060283D6 RID: 164822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60283D6")]
		[Address(RVA = "0x23835A0", Offset = "0x23821A0", VA = "0x1823835A0")]
		public ActVecBreakV2SquadBuffSelectStateBean()
		{
		}

		// Token: 0x04039310 RID: 234256
		[Token(Token = "0x4039310")]
		[FieldOffset(Offset = "0x10")]
		public ActVecBreakV2SquadBuffSelectProperty property;

		// Token: 0x04039311 RID: 234257
		[Token(Token = "0x4039311")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039312 RID: 234258
		[Token(Token = "0x4039312")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04039313 RID: 234259
		[Token(Token = "0x4039313")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectBuffByStageId;

		// Token: 0x04039314 RID: 234260
		[Token(Token = "0x4039314")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnselectBuff;

		// Token: 0x04039315 RID: 234261
		[Token(Token = "0x4039315")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnselectAllBuff;

		// Token: 0x04039316 RID: 234262
		[Token(Token = "0x4039316")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
