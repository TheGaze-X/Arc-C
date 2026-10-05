using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DCA RID: 28106
	[Token(Token = "0x2006DCA")]
	public class ActVecBreakV2AchvSquadBuffModel : IHotfixable
	{
		// Token: 0x17005EA8 RID: 24232
		// (get) Token: 0x0602805E RID: 163934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602805F RID: 163935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005EA8")]
		public string iconId
		{
			[Token(Token = "0x602805E")]
			[Address(RVA = "0x2349520", Offset = "0x2348120", VA = "0x182349520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602805F")]
			[Address(RVA = "0x2349580", Offset = "0x2348180", VA = "0x182349580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028060 RID: 163936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028060")]
		[Address(RVA = "0x2349400", Offset = "0x2348000", VA = "0x182349400")]
		public void LoadData(ActVecBreakV2BattleBuffData buffData)
		{
		}

		// Token: 0x06028061 RID: 163937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028061")]
		[Address(RVA = "0x23494C0", Offset = "0x23480C0", VA = "0x1823494C0")]
		public ActVecBreakV2AchvSquadBuffModel()
		{
		}

		// Token: 0x04038BF5 RID: 232437
		[Token(Token = "0x4038BF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x04038BF6 RID: 232438
		[Token(Token = "0x4038BF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_iconId;

		// Token: 0x04038BF7 RID: 232439
		[Token(Token = "0x4038BF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038BF8 RID: 232440
		[Token(Token = "0x4038BF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
