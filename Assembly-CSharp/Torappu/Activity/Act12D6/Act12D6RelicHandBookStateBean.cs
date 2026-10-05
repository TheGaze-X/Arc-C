using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007B10 RID: 31504
	[Token(Token = "0x2007B10")]
	public class Act12D6RelicHandBookStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17006753 RID: 26451
		// (get) Token: 0x0602C1B1 RID: 180657 RVA: 0x000DE1E0 File Offset: 0x000DC3E0
		[Token(Token = "0x17006753")]
		public int RelicCount
		{
			[Token(Token = "0x602C1B1")]
			[Address(RVA = "0x28127B0", Offset = "0x28113B0", VA = "0x1828127B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602C1B2 RID: 180658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1B2")]
		[Address(RVA = "0x2811B30", Offset = "0x2810730", VA = "0x182811B30")]
		public void LoadData(bool force = false)
		{
		}

		// Token: 0x0602C1B3 RID: 180659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1B3")]
		[Address(RVA = "0x2812210", Offset = "0x2810E10", VA = "0x182812210")]
		public void SortData(eRelicSortType sortType)
		{
		}

		// Token: 0x0602C1B4 RID: 180660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C1B4")]
		[Address(RVA = "0x2811A20", Offset = "0x2810620", VA = "0x182811A20")]
		public PlayerRelicHandBookData GetPlayerRelicData(string relicId)
		{
			return null;
		}

		// Token: 0x0602C1B5 RID: 180661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1B5")]
		[Address(RVA = "0x28120E0", Offset = "0x2810CE0", VA = "0x1828120E0")]
		public void SetRelicRead(string relicId)
		{
		}

		// Token: 0x0602C1B6 RID: 180662 RVA: 0x000DE1F8 File Offset: 0x000DC3F8
		[Token(Token = "0x602C1B6")]
		[Address(RVA = "0x2812520", Offset = "0x2811120", VA = "0x182812520")]
		private bool _GenPlayerRelicGotStatus(string relicId)
		{
			return default(bool);
		}

		// Token: 0x0602C1B7 RID: 180663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C1B7")]
		[Address(RVA = "0x2812620", Offset = "0x2811220", VA = "0x182812620")]
		public Act12D6RelicHandBookStateBean()
		{
		}

		// Token: 0x0403FF22 RID: 261922
		[Token(Token = "0x403FF22")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerRelicHandBookData> relicDataList;

		// Token: 0x0403FF23 RID: 261923
		[Token(Token = "0x403FF23")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, PlayerRelicHandBookData> m_relicDataDict;

		// Token: 0x0403FF24 RID: 261924
		[Token(Token = "0x403FF24")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, PlayerRoguelike.StableData.RelicRecord> m_playerRelicDict;

		// Token: 0x0403FF25 RID: 261925
		[Token(Token = "0x403FF25")]
		[FieldOffset(Offset = "0x28")]
		public List<PlayerRelicHandBookData> sortedRelicDataList;

		// Token: 0x0403FF26 RID: 261926
		[Token(Token = "0x403FF26")]
		[FieldOffset(Offset = "0x30")]
		private int m_gotCount;

		// Token: 0x0403FF27 RID: 261927
		[Token(Token = "0x403FF27")]
		[FieldOffset(Offset = "0x34")]
		private bool m_inited;

		// Token: 0x0403FF28 RID: 261928
		[Token(Token = "0x403FF28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_RelicCount;

		// Token: 0x0403FF29 RID: 261929
		[Token(Token = "0x403FF29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403FF2A RID: 261930
		[Token(Token = "0x403FF2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SortData;

		// Token: 0x0403FF2B RID: 261931
		[Token(Token = "0x403FF2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPlayerRelicData;

		// Token: 0x0403FF2C RID: 261932
		[Token(Token = "0x403FF2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRelicRead;

		// Token: 0x0403FF2D RID: 261933
		[Token(Token = "0x403FF2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenPlayerRelicGotStatus;

		// Token: 0x0403FF2E RID: 261934
		[Token(Token = "0x403FF2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
