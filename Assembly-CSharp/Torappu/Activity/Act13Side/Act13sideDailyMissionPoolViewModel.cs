using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A10 RID: 31248
	[Token(Token = "0x2007A10")]
	public class Act13sideDailyMissionPoolViewModel : IHotfixable
	{
		// Token: 0x1700669D RID: 26269
		// (get) Token: 0x0602BCC7 RID: 179399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700669D")]
		public List<Act13sideDailyMissionItemViewModel> missionPoolList
		{
			[Token(Token = "0x602BCC7")]
			[Address(RVA = "0x27AEC80", Offset = "0x27AD880", VA = "0x1827AEC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700669E RID: 26270
		// (get) Token: 0x0602BCC8 RID: 179400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700669E")]
		public Act13sideDailyMissionItemViewModel selectedModel
		{
			[Token(Token = "0x602BCC8")]
			[Address(RVA = "0x27AED40", Offset = "0x27AD940", VA = "0x1827AED40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700669F RID: 26271
		// (get) Token: 0x0602BCC9 RID: 179401 RVA: 0x000DD370 File Offset: 0x000DB570
		// (set) Token: 0x0602BCCA RID: 179402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700669F")]
		public int selectedPoolIdx
		{
			[Token(Token = "0x602BCC9")]
			[Address(RVA = "0x27AEDB0", Offset = "0x27AD9B0", VA = "0x1827AEDB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x602BCCA")]
			[Address(RVA = "0x27AEE10", Offset = "0x27ADA10", VA = "0x1827AEE10")]
			set
			{
			}
		}

		// Token: 0x170066A0 RID: 26272
		// (get) Token: 0x0602BCCB RID: 179403 RVA: 0x000DD388 File Offset: 0x000DB588
		[Token(Token = "0x170066A0")]
		public int agenda
		{
			[Token(Token = "0x602BCCB")]
			[Address(RVA = "0x27AEBC0", Offset = "0x27AD7C0", VA = "0x1827AEBC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066A1 RID: 26273
		// (get) Token: 0x0602BCCC RID: 179404 RVA: 0x000DD3A0 File Offset: 0x000DB5A0
		[Token(Token = "0x170066A1")]
		public int boardCount
		{
			[Token(Token = "0x602BCCC")]
			[Address(RVA = "0x27AEC20", Offset = "0x27AD820", VA = "0x1827AEC20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170066A2 RID: 26274
		// (get) Token: 0x0602BCCD RID: 179405 RVA: 0x000DD3B8 File Offset: 0x000DB5B8
		[Token(Token = "0x170066A2")]
		public int searchCount
		{
			[Token(Token = "0x602BCCD")]
			[Address(RVA = "0x27AECE0", Offset = "0x27AD8E0", VA = "0x1827AECE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602BCCE RID: 179406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCCE")]
		[Address(RVA = "0x27AE690", Offset = "0x27AD290", VA = "0x1827AE690")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602BCCF RID: 179407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCCF")]
		[Address(RVA = "0x27AEA70", Offset = "0x27AD670", VA = "0x1827AEA70")]
		private void _UpdateMissionIdx()
		{
		}

		// Token: 0x0602BCD0 RID: 179408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCD0")]
		[Address(RVA = "0x27AE9D0", Offset = "0x27AD5D0", VA = "0x1827AE9D0")]
		private void _ClearData()
		{
		}

		// Token: 0x0602BCD1 RID: 179409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCD1")]
		[Address(RVA = "0x27AEB10", Offset = "0x27AD710", VA = "0x1827AEB10")]
		public Act13sideDailyMissionPoolViewModel()
		{
		}

		// Token: 0x0403F5EF RID: 259567
		[Token(Token = "0x403F5EF")]
		[FieldOffset(Offset = "0x10")]
		private int m_agenda;

		// Token: 0x0403F5F0 RID: 259568
		[Token(Token = "0x403F5F0")]
		[FieldOffset(Offset = "0x14")]
		private int m_boardCount;

		// Token: 0x0403F5F1 RID: 259569
		[Token(Token = "0x403F5F1")]
		[FieldOffset(Offset = "0x18")]
		private int m_searchCount;

		// Token: 0x0403F5F2 RID: 259570
		[Token(Token = "0x403F5F2")]
		[FieldOffset(Offset = "0x1C")]
		private int m_selectedPoolIdx;

		// Token: 0x0403F5F3 RID: 259571
		[Token(Token = "0x403F5F3")]
		[FieldOffset(Offset = "0x20")]
		private List<Act13sideDailyMissionItemViewModel> m_missionPoolList;

		// Token: 0x0403F5F4 RID: 259572
		[Token(Token = "0x403F5F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_missionPoolList;

		// Token: 0x0403F5F5 RID: 259573
		[Token(Token = "0x403F5F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedModel;

		// Token: 0x0403F5F6 RID: 259574
		[Token(Token = "0x403F5F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedPoolIdx;

		// Token: 0x0403F5F7 RID: 259575
		[Token(Token = "0x403F5F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectedPoolIdx;

		// Token: 0x0403F5F8 RID: 259576
		[Token(Token = "0x403F5F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_agenda;

		// Token: 0x0403F5F9 RID: 259577
		[Token(Token = "0x403F5F9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_boardCount;

		// Token: 0x0403F5FA RID: 259578
		[Token(Token = "0x403F5FA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_searchCount;

		// Token: 0x0403F5FB RID: 259579
		[Token(Token = "0x403F5FB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403F5FC RID: 259580
		[Token(Token = "0x403F5FC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateMissionIdx;

		// Token: 0x0403F5FD RID: 259581
		[Token(Token = "0x403F5FD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearData;

		// Token: 0x0403F5FE RID: 259582
		[Token(Token = "0x403F5FE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
