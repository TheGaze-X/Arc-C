using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200593A RID: 22842
	[Token(Token = "0x200593A")]
	public class CrisisV2SettleRuneItemViewModel : IComparable, IHotfixable
	{
		// Token: 0x17004E0C RID: 19980
		// (get) Token: 0x06021459 RID: 136281 RVA: 0x000B92F8 File Offset: 0x000B74F8
		// (set) Token: 0x0602145A RID: 136282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E0C")]
		public bool isEmpty
		{
			[Token(Token = "0x6021459")]
			[Address(RVA = "0x1B942B0", Offset = "0x1B92EB0", VA = "0x181B942B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602145A")]
			[Address(RVA = "0x1B94400", Offset = "0x1B93000", VA = "0x181B94400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004E0D RID: 19981
		// (get) Token: 0x0602145B RID: 136283 RVA: 0x000B9310 File Offset: 0x000B7510
		// (set) Token: 0x0602145C RID: 136284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E0D")]
		public int point
		{
			[Token(Token = "0x602145B")]
			[Address(RVA = "0x1B94320", Offset = "0x1B92F20", VA = "0x181B94320")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602145C")]
			[Address(RVA = "0x1B94490", Offset = "0x1B93090", VA = "0x181B94490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004E0E RID: 19982
		// (get) Token: 0x0602145D RID: 136285 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602145E RID: 136286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004E0E")]
		public string runeIconId
		{
			[Token(Token = "0x602145D")]
			[Address(RVA = "0x1B94390", Offset = "0x1B92F90", VA = "0x181B94390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602145E")]
			[Address(RVA = "0x1B94510", Offset = "0x1B93110", VA = "0x181B94510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602145F RID: 136287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602145F")]
		[Address(RVA = "0x1B940E0", Offset = "0x1B92CE0", VA = "0x181B940E0")]
		public void LoadData(CrisisV2AchievementRuneViewModel model)
		{
		}

		// Token: 0x06021460 RID: 136288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021460")]
		[Address(RVA = "0x1B93E70", Offset = "0x1B92A70", VA = "0x181B93E70")]
		public void LoadData(string runeId, CrisisV2MapDetailData stageDetailData, List<RuneTable.PackedRuneData> packedRuneList)
		{
		}

		// Token: 0x06021461 RID: 136289 RVA: 0x000B9328 File Offset: 0x000B7528
		[Token(Token = "0x6021461")]
		[Address(RVA = "0x1B93D30", Offset = "0x1B92930", VA = "0x181B93D30", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06021462 RID: 136290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021462")]
		[Address(RVA = "0x1B94230", Offset = "0x1B92E30", VA = "0x181B94230")]
		public CrisisV2SettleRuneItemViewModel()
		{
		}

		// Token: 0x0402D5CD RID: 185805
		[Token(Token = "0x402D5CD")]
		[FieldOffset(Offset = "0x20")]
		private int m_sortId;

		// Token: 0x0402D5CE RID: 185806
		[Token(Token = "0x402D5CE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CrisisV2SettleRuneItemViewModel EMPTY;

		// Token: 0x0402D5CF RID: 185807
		[Token(Token = "0x402D5CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402D5D0 RID: 185808
		[Token(Token = "0x402D5D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isEmpty;

		// Token: 0x0402D5D1 RID: 185809
		[Token(Token = "0x402D5D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_point;

		// Token: 0x0402D5D2 RID: 185810
		[Token(Token = "0x402D5D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_point;

		// Token: 0x0402D5D3 RID: 185811
		[Token(Token = "0x402D5D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_runeIconId;

		// Token: 0x0402D5D4 RID: 185812
		[Token(Token = "0x402D5D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_runeIconId;

		// Token: 0x0402D5D5 RID: 185813
		[Token(Token = "0x402D5D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D5D6 RID: 185814
		[Token(Token = "0x402D5D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0402D5D7 RID: 185815
		[Token(Token = "0x402D5D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D5D8 RID: 185816
		[Token(Token = "0x402D5D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
