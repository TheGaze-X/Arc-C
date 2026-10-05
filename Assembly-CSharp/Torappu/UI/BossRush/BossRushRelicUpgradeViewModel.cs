using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006190 RID: 24976
	[Token(Token = "0x2006190")]
	public class BossRushRelicUpgradeViewModel : IHotfixable
	{
		// Token: 0x17005507 RID: 21767
		// (get) Token: 0x06024073 RID: 147571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024074 RID: 147572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005507")]
		public string actId
		{
			[Token(Token = "0x6024073")]
			[Address(RVA = "0x1EA8DD0", Offset = "0x1EA79D0", VA = "0x181EA8DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024074")]
			[Address(RVA = "0x1EA8EF0", Offset = "0x1EA7AF0", VA = "0x181EA8EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005508 RID: 21768
		// (get) Token: 0x06024075 RID: 147573 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024076 RID: 147574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005508")]
		public string upgradeItemName
		{
			[Token(Token = "0x6024075")]
			[Address(RVA = "0x1EA8E90", Offset = "0x1EA7A90", VA = "0x181EA8E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024076")]
			[Address(RVA = "0x1EA8FE0", Offset = "0x1EA7BE0", VA = "0x181EA8FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005509 RID: 21769
		// (get) Token: 0x06024077 RID: 147575 RVA: 0x000C2CB8 File Offset: 0x000C0EB8
		// (set) Token: 0x06024078 RID: 147576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005509")]
		public int upgradeItemCurCount
		{
			[Token(Token = "0x6024077")]
			[Address(RVA = "0x1EA8E30", Offset = "0x1EA7A30", VA = "0x181EA8E30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6024078")]
			[Address(RVA = "0x1EA8F70", Offset = "0x1EA7B70", VA = "0x181EA8F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06024079 RID: 147577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024079")]
		[Address(RVA = "0x1EA8BC0", Offset = "0x1EA77C0", VA = "0x181EA8BC0")]
		public void LoadDataList(string aId, BossRushRelicNodeModel data, string tokenName, int curTokenCount)
		{
		}

		// Token: 0x0602407A RID: 147578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602407A")]
		[Address(RVA = "0x1EA8D70", Offset = "0x1EA7970", VA = "0x181EA8D70")]
		public BossRushRelicUpgradeViewModel()
		{
		}

		// Token: 0x040320E9 RID: 205033
		[Token(Token = "0x40320E9")]
		[FieldOffset(Offset = "0x18")]
		public BossRushRelicNodeModel relicData;

		// Token: 0x040320EC RID: 205036
		[Token(Token = "0x40320EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040320ED RID: 205037
		[Token(Token = "0x40320ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x040320EE RID: 205038
		[Token(Token = "0x40320EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_upgradeItemName;

		// Token: 0x040320EF RID: 205039
		[Token(Token = "0x40320EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_upgradeItemName;

		// Token: 0x040320F0 RID: 205040
		[Token(Token = "0x40320F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_upgradeItemCurCount;

		// Token: 0x040320F1 RID: 205041
		[Token(Token = "0x40320F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_upgradeItemCurCount;

		// Token: 0x040320F2 RID: 205042
		[Token(Token = "0x40320F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadDataList;

		// Token: 0x040320F3 RID: 205043
		[Token(Token = "0x40320F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
