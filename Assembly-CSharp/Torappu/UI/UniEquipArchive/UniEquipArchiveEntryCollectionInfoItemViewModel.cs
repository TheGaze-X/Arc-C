using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C05 RID: 15365
	[Token(Token = "0x2003C05")]
	public class UniEquipArchiveEntryCollectionInfoItemViewModel : IHotfixable
	{
		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x06018064 RID: 98404 RVA: 0x00099000 File Offset: 0x00097200
		// (set) Token: 0x06018065 RID: 98405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003951")]
		public UniEquipArchiveCollectionInfoType type
		{
			[Token(Token = "0x6018064")]
			[Address(RVA = "0x107AD50", Offset = "0x1079950", VA = "0x18107AD50")]
			[CompilerGenerated]
			get
			{
				return UniEquipArchiveCollectionInfoType.NONE;
			}
			[Token(Token = "0x6018065")]
			[Address(RVA = "0x107AFF0", Offset = "0x1079BF0", VA = "0x18107AFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x06018066 RID: 98406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06018067 RID: 98407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003952")]
		public string infoName
		{
			[Token(Token = "0x6018066")]
			[Address(RVA = "0x107ABD0", Offset = "0x10797D0", VA = "0x18107ABD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6018067")]
			[Address(RVA = "0x107AE20", Offset = "0x1079A20", VA = "0x18107AE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x06018068 RID: 98408 RVA: 0x00099018 File Offset: 0x00097218
		// (set) Token: 0x06018069 RID: 98409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003953")]
		public bool showTotalCount
		{
			[Token(Token = "0x6018068")]
			[Address(RVA = "0x107AC90", Offset = "0x1079890", VA = "0x18107AC90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6018069")]
			[Address(RVA = "0x107AF10", Offset = "0x1079B10", VA = "0x18107AF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0601806A RID: 98410 RVA: 0x00099030 File Offset: 0x00097230
		// (set) Token: 0x0601806B RID: 98411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003954")]
		public int curCount
		{
			[Token(Token = "0x601806A")]
			[Address(RVA = "0x107AB70", Offset = "0x1079770", VA = "0x18107AB70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601806B")]
			[Address(RVA = "0x107ADB0", Offset = "0x10799B0", VA = "0x18107ADB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0601806C RID: 98412 RVA: 0x00099048 File Offset: 0x00097248
		// (set) Token: 0x0601806D RID: 98413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003955")]
		public int totalCount
		{
			[Token(Token = "0x601806C")]
			[Address(RVA = "0x107ACF0", Offset = "0x10798F0", VA = "0x18107ACF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601806D")]
			[Address(RVA = "0x107AF80", Offset = "0x1079B80", VA = "0x18107AF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0601806E RID: 98414 RVA: 0x00099060 File Offset: 0x00097260
		// (set) Token: 0x0601806F RID: 98415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003956")]
		public bool showSplitLine
		{
			[Token(Token = "0x601806E")]
			[Address(RVA = "0x107AC30", Offset = "0x1079830", VA = "0x18107AC30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601806F")]
			[Address(RVA = "0x107AEA0", Offset = "0x1079AA0", VA = "0x18107AEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06018070 RID: 98416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018070")]
		[Address(RVA = "0x107A7D0", Offset = "0x10793D0", VA = "0x18107A7D0")]
		public void LoadData(UniEquipArchiveCollectionInfoType infoType, bool isLastOne, bool showTotal = false)
		{
		}

		// Token: 0x06018071 RID: 98417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018071")]
		[Address(RVA = "0x107A980", Offset = "0x1079580", VA = "0x18107A980")]
		public void RefreshCountData(UniEquipArchiveEntryCollectionInfoData infoData)
		{
		}

		// Token: 0x06018072 RID: 98418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018072")]
		[Address(RVA = "0x107AA90", Offset = "0x1079690", VA = "0x18107AA90")]
		public void RefreshShowTotal(bool showTotal)
		{
		}

		// Token: 0x06018073 RID: 98419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018073")]
		[Address(RVA = "0x107AB10", Offset = "0x1079710", VA = "0x18107AB10")]
		public UniEquipArchiveEntryCollectionInfoItemViewModel()
		{
		}

		// Token: 0x0401D214 RID: 119316
		[Token(Token = "0x401D214")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0401D215 RID: 119317
		[Token(Token = "0x401D215")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x0401D216 RID: 119318
		[Token(Token = "0x401D216")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_infoName;

		// Token: 0x0401D217 RID: 119319
		[Token(Token = "0x401D217")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_infoName;

		// Token: 0x0401D218 RID: 119320
		[Token(Token = "0x401D218")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showTotalCount;

		// Token: 0x0401D219 RID: 119321
		[Token(Token = "0x401D219")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_showTotalCount;

		// Token: 0x0401D21A RID: 119322
		[Token(Token = "0x401D21A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_curCount;

		// Token: 0x0401D21B RID: 119323
		[Token(Token = "0x401D21B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_curCount;

		// Token: 0x0401D21C RID: 119324
		[Token(Token = "0x401D21C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0401D21D RID: 119325
		[Token(Token = "0x401D21D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_totalCount;

		// Token: 0x0401D21E RID: 119326
		[Token(Token = "0x401D21E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_showSplitLine;

		// Token: 0x0401D21F RID: 119327
		[Token(Token = "0x401D21F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_showSplitLine;

		// Token: 0x0401D220 RID: 119328
		[Token(Token = "0x401D220")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D221 RID: 119329
		[Token(Token = "0x401D221")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshCountData;

		// Token: 0x0401D222 RID: 119330
		[Token(Token = "0x401D222")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshShowTotal;

		// Token: 0x0401D223 RID: 119331
		[Token(Token = "0x401D223")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
