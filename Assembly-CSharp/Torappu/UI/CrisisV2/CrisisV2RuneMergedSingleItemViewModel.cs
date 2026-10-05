using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005983 RID: 22915
	[Token(Token = "0x2005983")]
	public class CrisisV2RuneMergedSingleItemViewModel : ICrisisV2RuneSingleItemInfo, IHotfixable, IComparable<CrisisV2RuneMergedSingleItemViewModel>
	{
		// Token: 0x0602169A RID: 136858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602169A")]
		[Address(RVA = "0x1BCCF80", Offset = "0x1BCBB80", VA = "0x181BCCF80", Slot = "4")]
		public string GetDesc()
		{
			return null;
		}

		// Token: 0x0602169B RID: 136859 RVA: 0x000BA330 File Offset: 0x000B8530
		[Token(Token = "0x602169B")]
		[Address(RVA = "0x1BCCFE0", Offset = "0x1BCBBE0", VA = "0x181BCCFE0", Slot = "5")]
		public int GetPoint()
		{
			return 0;
		}

		// Token: 0x0602169C RID: 136860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602169C")]
		[Address(RVA = "0x1BCD040", Offset = "0x1BCBC40", VA = "0x181BCD040", Slot = "6")]
		public string GetTutorialHighLightKey()
		{
			return null;
		}

		// Token: 0x0602169D RID: 136861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602169D")]
		[Address(RVA = "0x1BCD0B0", Offset = "0x1BCBCB0", VA = "0x181BCD0B0")]
		public void LoadData(string runeGroupId, List<string> runesInGroupList, CrisisV2MapDetailData mapDetailData)
		{
		}

		// Token: 0x0602169E RID: 136862 RVA: 0x000BA348 File Offset: 0x000B8548
		[Token(Token = "0x602169E")]
		[Address(RVA = "0x1BCCEE0", Offset = "0x1BCBAE0", VA = "0x181BCCEE0", Slot = "7")]
		public int CompareTo(CrisisV2RuneMergedSingleItemViewModel other)
		{
			return 0;
		}

		// Token: 0x0602169F RID: 136863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602169F")]
		[Address(RVA = "0x1BCDC00", Offset = "0x1BCC800", VA = "0x181BCDC00")]
		private CrisisV2RuneData _TryGetRuneData(string runeId)
		{
			return null;
		}

		// Token: 0x060216A0 RID: 136864 RVA: 0x000BA360 File Offset: 0x000B8560
		[Token(Token = "0x60216A0")]
		[Address(RVA = "0x1BCDA30", Offset = "0x1BCC630", VA = "0x181BCDA30")]
		private int _GetGroupSortId()
		{
			return 0;
		}

		// Token: 0x060216A1 RID: 136865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60216A1")]
		[Address(RVA = "0x1BCD950", Offset = "0x1BCC550", VA = "0x181BCD950")]
		private string _GetGroupDescFormat()
		{
			return null;
		}

		// Token: 0x060216A2 RID: 136866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60216A2")]
		[Address(RVA = "0x1BCD4E0", Offset = "0x1BCC0E0", VA = "0x181BCD4E0")]
		private string _GetDescription()
		{
			return null;
		}

		// Token: 0x060216A3 RID: 136867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216A3")]
		[Address(RVA = "0x1BCDB00", Offset = "0x1BCC700", VA = "0x181BCDB00")]
		private void _ResetData()
		{
		}

		// Token: 0x060216A4 RID: 136868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216A4")]
		[Address(RVA = "0x1BCDD30", Offset = "0x1BCC930", VA = "0x181BCDD30")]
		public CrisisV2RuneMergedSingleItemViewModel()
		{
		}

		// Token: 0x0402D92A RID: 186666
		[Token(Token = "0x402D92A")]
		[FieldOffset(Offset = "0x10")]
		private CrisisV2MapDetailData m_mapDetailData;

		// Token: 0x0402D92B RID: 186667
		[Token(Token = "0x402D92B")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_runeIdList;

		// Token: 0x0402D92C RID: 186668
		[Token(Token = "0x402D92C")]
		[FieldOffset(Offset = "0x20")]
		private string m_groupId;

		// Token: 0x0402D92D RID: 186669
		[Token(Token = "0x402D92D")]
		[FieldOffset(Offset = "0x28")]
		private int m_groupSortId;

		// Token: 0x0402D92E RID: 186670
		[Token(Token = "0x402D92E")]
		[FieldOffset(Offset = "0x2C")]
		private int m_mergedPoint;

		// Token: 0x0402D92F RID: 186671
		[Token(Token = "0x402D92F")]
		[FieldOffset(Offset = "0x30")]
		private string m_description;

		// Token: 0x0402D930 RID: 186672
		[Token(Token = "0x402D930")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x0402D931 RID: 186673
		[Token(Token = "0x402D931")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPoint;

		// Token: 0x0402D932 RID: 186674
		[Token(Token = "0x402D932")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTutorialHighLightKey;

		// Token: 0x0402D933 RID: 186675
		[Token(Token = "0x402D933")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D934 RID: 186676
		[Token(Token = "0x402D934")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D935 RID: 186677
		[Token(Token = "0x402D935")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetRuneData;

		// Token: 0x0402D936 RID: 186678
		[Token(Token = "0x402D936")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetGroupSortId;

		// Token: 0x0402D937 RID: 186679
		[Token(Token = "0x402D937")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetGroupDescFormat;

		// Token: 0x0402D938 RID: 186680
		[Token(Token = "0x402D938")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetDescription;

		// Token: 0x0402D939 RID: 186681
		[Token(Token = "0x402D939")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetData;

		// Token: 0x0402D93A RID: 186682
		[Token(Token = "0x402D93A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
