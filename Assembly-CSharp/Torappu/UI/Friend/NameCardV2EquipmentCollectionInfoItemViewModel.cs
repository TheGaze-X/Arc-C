using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.UniEquipArchive;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D92 RID: 19858
	[Token(Token = "0x2004D92")]
	public class NameCardV2EquipmentCollectionInfoItemViewModel : IHotfixable
	{
		// Token: 0x170045A5 RID: 17829
		// (get) Token: 0x0601DB5C RID: 121692 RVA: 0x000AC548 File Offset: 0x000AA748
		// (set) Token: 0x0601DB5D RID: 121693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045A5")]
		public UniEquipArchiveCollectionInfoType type
		{
			[Token(Token = "0x601DB5C")]
			[Address(RVA = "0x1747A00", Offset = "0x1746600", VA = "0x181747A00")]
			[CompilerGenerated]
			get
			{
				return UniEquipArchiveCollectionInfoType.NONE;
			}
			[Token(Token = "0x601DB5D")]
			[Address(RVA = "0x1747C30", Offset = "0x1746830", VA = "0x181747C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x0601DB5E RID: 121694 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DB5F RID: 121695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045A6")]
		public string infoName
		{
			[Token(Token = "0x601DB5E")]
			[Address(RVA = "0x17478E0", Offset = "0x17464E0", VA = "0x1817478E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DB5F")]
			[Address(RVA = "0x1747AD0", Offset = "0x17466D0", VA = "0x181747AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170045A7 RID: 17831
		// (get) Token: 0x0601DB60 RID: 121696 RVA: 0x000AC560 File Offset: 0x000AA760
		// (set) Token: 0x0601DB61 RID: 121697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045A7")]
		public int curCount
		{
			[Token(Token = "0x601DB60")]
			[Address(RVA = "0x1747880", Offset = "0x1746480", VA = "0x181747880")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601DB61")]
			[Address(RVA = "0x1747A60", Offset = "0x1746660", VA = "0x181747A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170045A8 RID: 17832
		// (get) Token: 0x0601DB62 RID: 121698 RVA: 0x000AC578 File Offset: 0x000AA778
		// (set) Token: 0x0601DB63 RID: 121699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045A8")]
		public int totalCount
		{
			[Token(Token = "0x601DB62")]
			[Address(RVA = "0x17479A0", Offset = "0x17465A0", VA = "0x1817479A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601DB63")]
			[Address(RVA = "0x1747BC0", Offset = "0x17467C0", VA = "0x181747BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170045A9 RID: 17833
		// (get) Token: 0x0601DB64 RID: 121700 RVA: 0x000AC590 File Offset: 0x000AA790
		// (set) Token: 0x0601DB65 RID: 121701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170045A9")]
		public bool showTotalCount
		{
			[Token(Token = "0x601DB64")]
			[Address(RVA = "0x1747940", Offset = "0x1746540", VA = "0x181747940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601DB65")]
			[Address(RVA = "0x1747B50", Offset = "0x1746750", VA = "0x181747B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601DB66 RID: 121702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB66")]
		[Address(RVA = "0x1747590", Offset = "0x1746190", VA = "0x181747590")]
		public void LoadData(UniEquipArchiveCollectionInfoType infoType, int curCnt, int totalCnt, bool showTotal = false)
		{
		}

		// Token: 0x0601DB67 RID: 121703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB67")]
		[Address(RVA = "0x17477A0", Offset = "0x17463A0", VA = "0x1817477A0")]
		public void RefreshShowTotal(bool showTotal)
		{
		}

		// Token: 0x0601DB68 RID: 121704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB68")]
		[Address(RVA = "0x1747820", Offset = "0x1746420", VA = "0x181747820")]
		public NameCardV2EquipmentCollectionInfoItemViewModel()
		{
		}

		// Token: 0x04027444 RID: 160836
		[Token(Token = "0x4027444")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04027445 RID: 160837
		[Token(Token = "0x4027445")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x04027446 RID: 160838
		[Token(Token = "0x4027446")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_infoName;

		// Token: 0x04027447 RID: 160839
		[Token(Token = "0x4027447")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_infoName;

		// Token: 0x04027448 RID: 160840
		[Token(Token = "0x4027448")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curCount;

		// Token: 0x04027449 RID: 160841
		[Token(Token = "0x4027449")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_curCount;

		// Token: 0x0402744A RID: 160842
		[Token(Token = "0x402744A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0402744B RID: 160843
		[Token(Token = "0x402744B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_totalCount;

		// Token: 0x0402744C RID: 160844
		[Token(Token = "0x402744C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_showTotalCount;

		// Token: 0x0402744D RID: 160845
		[Token(Token = "0x402744D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_showTotalCount;

		// Token: 0x0402744E RID: 160846
		[Token(Token = "0x402744E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402744F RID: 160847
		[Token(Token = "0x402744F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshShowTotal;

		// Token: 0x04027450 RID: 160848
		[Token(Token = "0x4027450")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
