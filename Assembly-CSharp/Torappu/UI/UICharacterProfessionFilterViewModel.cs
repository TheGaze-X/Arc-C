using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003521 RID: 13601
	[Token(Token = "0x2003521")]
	public class UICharacterProfessionFilterViewModel : IHotfixable
	{
		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x06015ADE RID: 88798 RVA: 0x0008D678 File Offset: 0x0008B878
		[Token(Token = "0x17003380")]
		public int fastSeq
		{
			[Token(Token = "0x6015ADE")]
			[Address(RVA = "0xE424E0", Offset = "0xE410E0", VA = "0x180E424E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x06015ADF RID: 88799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003381")]
		public ListDict<int, ProfessionFilterProfItemViewModel> profItems
		{
			[Token(Token = "0x6015ADF")]
			[Address(RVA = "0xE425C0", Offset = "0xE411C0", VA = "0x180E425C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x06015AE0 RID: 88800 RVA: 0x0008D690 File Offset: 0x0008B890
		[Token(Token = "0x17003382")]
		public bool isAll
		{
			[Token(Token = "0x6015AE0")]
			[Address(RVA = "0xE42550", Offset = "0xE41150", VA = "0x180E42550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x06015AE1 RID: 88801 RVA: 0x0008D6A8 File Offset: 0x0008B8A8
		[Token(Token = "0x17003383")]
		public ProfessionCategory selectedProf
		{
			[Token(Token = "0x6015AE1")]
			[Address(RVA = "0xE42630", Offset = "0xE41230", VA = "0x180E42630")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x06015AE2 RID: 88802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003384")]
		public string selectedSubProf
		{
			[Token(Token = "0x6015AE2")]
			[Address(RVA = "0xE426A0", Offset = "0xE412A0", VA = "0x180E426A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015AE3 RID: 88803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AE3")]
		[Address(RVA = "0xE40FA0", Offset = "0xE3FBA0", VA = "0x180E40FA0")]
		public void NotifyFastSeq()
		{
		}

		// Token: 0x06015AE4 RID: 88804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AE4")]
		[Address(RVA = "0xE40CF0", Offset = "0xE3F8F0", VA = "0x180E40CF0")]
		public void InitData()
		{
		}

		// Token: 0x06015AE5 RID: 88805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AE5")]
		[Address(RVA = "0xE41890", Offset = "0xE40490", VA = "0x180E41890")]
		private void _LoadProfessionData()
		{
		}

		// Token: 0x06015AE6 RID: 88806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AE6")]
		[Address(RVA = "0xE41B70", Offset = "0xE40770", VA = "0x180E41B70")]
		private void _LoadSubProfessionData()
		{
		}

		// Token: 0x06015AE7 RID: 88807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AE7")]
		[Address(RVA = "0xE413F0", Offset = "0xE3FFF0", VA = "0x180E413F0")]
		public void UpdateInvalidSubProf()
		{
		}

		// Token: 0x06015AE8 RID: 88808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AE8")]
		[Address(RVA = "0xE41210", Offset = "0xE3FE10", VA = "0x180E41210")]
		public void UpdateBannedProf()
		{
		}

		// Token: 0x06015AE9 RID: 88809 RVA: 0x0008D6C0 File Offset: 0x0008B8C0
		[Token(Token = "0x6015AE9")]
		[Address(RVA = "0xE40E10", Offset = "0xE3FA10", VA = "0x180E40E10")]
		public static bool IsProfessionValid(ProfessionCategory prof)
		{
			return default(bool);
		}

		// Token: 0x06015AEA RID: 88810 RVA: 0x0008D6D8 File Offset: 0x0008B8D8
		[Token(Token = "0x6015AEA")]
		[Address(RVA = "0xE40E90", Offset = "0xE3FA90", VA = "0x180E40E90")]
		public int LoadSelectedProfItem(out ProfessionFilterProfItemViewModel itemModel)
		{
			return 0;
		}

		// Token: 0x06015AEB RID: 88811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015AEB")]
		[Address(RVA = "0xE40BE0", Offset = "0xE3F7E0", VA = "0x180E40BE0")]
		public ProfessionFilterSubProfItemViewModel GetSelectedSubProfItem()
		{
			return null;
		}

		// Token: 0x06015AEC RID: 88812 RVA: 0x0008D6F0 File Offset: 0x0008B8F0
		[Token(Token = "0x6015AEC")]
		[Address(RVA = "0xE41010", Offset = "0xE3FC10", VA = "0x180E41010")]
		public bool SetProfession(bool isAll, ProfessionCategory prof, string subProfId)
		{
			return default(bool);
		}

		// Token: 0x06015AED RID: 88813 RVA: 0x0008D708 File Offset: 0x0008B908
		[Token(Token = "0x6015AED")]
		[Address(RVA = "0xE41750", Offset = "0xE40350", VA = "0x180E41750")]
		private int _LoadProfItemOrNull(ProfessionCategory prof, out ProfessionFilterProfItemViewModel itemModel)
		{
			return 0;
		}

		// Token: 0x06015AEE RID: 88814 RVA: 0x0008D720 File Offset: 0x0008B920
		[Token(Token = "0x6015AEE")]
		[Address(RVA = "0xE415E0", Offset = "0xE401E0", VA = "0x180E415E0")]
		private bool _IsValidProfParam(ProfessionCategory prof, string subProfId)
		{
			return default(bool);
		}

		// Token: 0x06015AEF RID: 88815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AEF")]
		[Address(RVA = "0xE423C0", Offset = "0xE40FC0", VA = "0x180E423C0")]
		public UICharacterProfessionFilterViewModel()
		{
		}

		// Token: 0x0401A074 RID: 106612
		[Token(Token = "0x401A074")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<int, ProfessionFilterProfItemViewModel> m_profItems;

		// Token: 0x0401A075 RID: 106613
		[Token(Token = "0x401A075")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isAll;

		// Token: 0x0401A076 RID: 106614
		[Token(Token = "0x401A076")]
		[FieldOffset(Offset = "0x1C")]
		private ProfessionCategory m_selectedProf;

		// Token: 0x0401A077 RID: 106615
		[Token(Token = "0x401A077")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectedSubProf;

		// Token: 0x0401A078 RID: 106616
		[Token(Token = "0x401A078")]
		[FieldOffset(Offset = "0x28")]
		private int m_fastSeq;

		// Token: 0x0401A079 RID: 106617
		[Token(Token = "0x401A079")]
		[FieldOffset(Offset = "0x2C")]
		public bool showProf;

		// Token: 0x0401A07A RID: 106618
		[Token(Token = "0x401A07A")]
		[FieldOffset(Offset = "0x2D")]
		public bool showSubProf;

		// Token: 0x0401A07B RID: 106619
		[Token(Token = "0x401A07B")]
		[FieldOffset(Offset = "0x30")]
		public HashSet<string> validSubProfs;

		// Token: 0x0401A07C RID: 106620
		[Token(Token = "0x401A07C")]
		[FieldOffset(Offset = "0x38")]
		public ProfessionCategory bannedProf;

		// Token: 0x0401A07D RID: 106621
		[Token(Token = "0x401A07D")]
		[FieldOffset(Offset = "0x3C")]
		public bool enableValidSubProf;

		// Token: 0x0401A07E RID: 106622
		[Token(Token = "0x401A07E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<ProfessionCategory> s_PROFESSION_ORDER_LIST;

		// Token: 0x0401A07F RID: 106623
		[Token(Token = "0x401A07F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_fastSeq;

		// Token: 0x0401A080 RID: 106624
		[Token(Token = "0x401A080")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_profItems;

		// Token: 0x0401A081 RID: 106625
		[Token(Token = "0x401A081")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isAll;

		// Token: 0x0401A082 RID: 106626
		[Token(Token = "0x401A082")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedProf;

		// Token: 0x0401A083 RID: 106627
		[Token(Token = "0x401A083")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectedSubProf;

		// Token: 0x0401A084 RID: 106628
		[Token(Token = "0x401A084")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyFastSeq;

		// Token: 0x0401A085 RID: 106629
		[Token(Token = "0x401A085")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401A086 RID: 106630
		[Token(Token = "0x401A086")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadProfessionData;

		// Token: 0x0401A087 RID: 106631
		[Token(Token = "0x401A087")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadSubProfessionData;

		// Token: 0x0401A088 RID: 106632
		[Token(Token = "0x401A088")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateInvalidSubProf;

		// Token: 0x0401A089 RID: 106633
		[Token(Token = "0x401A089")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateBannedProf;

		// Token: 0x0401A08A RID: 106634
		[Token(Token = "0x401A08A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_IsProfessionValid;

		// Token: 0x0401A08B RID: 106635
		[Token(Token = "0x401A08B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadSelectedProfItem;

		// Token: 0x0401A08C RID: 106636
		[Token(Token = "0x401A08C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetSelectedSubProfItem;

		// Token: 0x0401A08D RID: 106637
		[Token(Token = "0x401A08D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetProfession;

		// Token: 0x0401A08E RID: 106638
		[Token(Token = "0x401A08E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadProfItemOrNull;

		// Token: 0x0401A08F RID: 106639
		[Token(Token = "0x401A08F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IsValidProfParam;

		// Token: 0x0401A090 RID: 106640
		[Token(Token = "0x401A090")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
