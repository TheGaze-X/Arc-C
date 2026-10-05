using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F9F RID: 20383
	[Token(Token = "0x2004F9F")]
	public class EnemyDuelEntryDailyViewModel : IHotfixable
	{
		// Token: 0x0601E4CB RID: 124107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4CB")]
		[Address(RVA = "0x17FC560", Offset = "0x17FB160", VA = "0x1817FC560")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601E4CC RID: 124108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4CC")]
		[Address(RVA = "0x17FC690", Offset = "0x17FB290", VA = "0x1817FC690")]
		public EnemyDuelEntryDailyViewModel()
		{
		}

		// Token: 0x04028733 RID: 165683
		[Token(Token = "0x4028733")]
		[FieldOffset(Offset = "0x10")]
		public int process;

		// Token: 0x04028734 RID: 165684
		[Token(Token = "0x4028734")]
		[FieldOffset(Offset = "0x14")]
		public int target;

		// Token: 0x04028735 RID: 165685
		[Token(Token = "0x4028735")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04028736 RID: 165686
		[Token(Token = "0x4028736")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028737 RID: 165687
		[Token(Token = "0x4028737")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
