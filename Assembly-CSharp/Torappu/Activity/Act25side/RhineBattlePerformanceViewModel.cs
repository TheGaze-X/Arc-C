using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007537 RID: 30007
	[Token(Token = "0x2007537")]
	public class RhineBattlePerformanceViewModel : IHotfixable
	{
		// Token: 0x0602A45F RID: 173151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A45F")]
		[Address(RVA = "0x25EF760", Offset = "0x25EE360", VA = "0x1825EF760")]
		public void LoadData(bool isRetro, string groupId)
		{
		}

		// Token: 0x0602A460 RID: 173152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A460")]
		[Address(RVA = "0x25EF6D0", Offset = "0x25EE2D0", VA = "0x1825EF6D0")]
		public RhineBattlePerformanceItemListModel GetItemModelByType(Act25SideData.Act25sideTechType type)
		{
			return null;
		}

		// Token: 0x0602A461 RID: 173153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A461")]
		[Address(RVA = "0x25EFC60", Offset = "0x25EE860", VA = "0x1825EFC60")]
		private RhineBattlePerformanceItemListModel _GeneDefaultListModel()
		{
			return null;
		}

		// Token: 0x0602A462 RID: 173154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A462")]
		[Address(RVA = "0x25EFCF0", Offset = "0x25EE8F0", VA = "0x1825EFCF0")]
		public RhineBattlePerformanceViewModel()
		{
		}

		// Token: 0x0403CC84 RID: 248964
		[Token(Token = "0x403CC84")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<Act25SideData.Act25sideTechType, RhineBattlePerformanceItemListModel> battlePerformanceItems;

		// Token: 0x0403CC85 RID: 248965
		[Token(Token = "0x403CC85")]
		[FieldOffset(Offset = "0x18")]
		public List<string> unlockItemIds;

		// Token: 0x0403CC86 RID: 248966
		[Token(Token = "0x403CC86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC87 RID: 248967
		[Token(Token = "0x403CC87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetItemModelByType;

		// Token: 0x0403CC88 RID: 248968
		[Token(Token = "0x403CC88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GeneDefaultListModel;

		// Token: 0x0403CC89 RID: 248969
		[Token(Token = "0x403CC89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
