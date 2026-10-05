using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C39 RID: 15417
	[Token(Token = "0x2003C39")]
	public class UniEquipLevelUpBoardObjViewModel : IHotfixable
	{
		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x060181B8 RID: 98744 RVA: 0x000995D0 File Offset: 0x000977D0
		// (set) Token: 0x060181B7 RID: 98743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003991")]
		public int equipLevel
		{
			[Token(Token = "0x60181B8")]
			[Address(RVA = "0x1091410", Offset = "0x1090010", VA = "0x181091410")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60181B7")]
			[Address(RVA = "0x1091590", Offset = "0x1090190", VA = "0x181091590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x060181BA RID: 98746 RVA: 0x000995E8 File Offset: 0x000977E8
		// (set) Token: 0x060181B9 RID: 98745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003992")]
		public bool isIncludedInLevelUp
		{
			[Token(Token = "0x60181BA")]
			[Address(RVA = "0x10914D0", Offset = "0x10900D0", VA = "0x1810914D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60181B9")]
			[Address(RVA = "0x1091670", Offset = "0x1090270", VA = "0x181091670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x060181BC RID: 98748 RVA: 0x00099600 File Offset: 0x00097800
		// (set) Token: 0x060181BB RID: 98747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003993")]
		public bool isLastTargetLevel
		{
			[Token(Token = "0x60181BC")]
			[Address(RVA = "0x1091530", Offset = "0x1090130", VA = "0x181091530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60181BB")]
			[Address(RVA = "0x10916E0", Offset = "0x10902E0", VA = "0x1810916E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x060181BE RID: 98750 RVA: 0x00099618 File Offset: 0x00097818
		// (set) Token: 0x060181BD RID: 98749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003994")]
		public bool isCurLevel
		{
			[Token(Token = "0x60181BE")]
			[Address(RVA = "0x1091470", Offset = "0x1090070", VA = "0x181091470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60181BD")]
			[Address(RVA = "0x1091600", Offset = "0x1090200", VA = "0x181091600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060181BF RID: 98751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60181BF")]
		[Address(RVA = "0x1091160", Offset = "0x108FD60", VA = "0x181091160")]
		public UniEquipLevelUpBoardObjViewModel(int equipLevel, int curLevel, int tarLevel)
		{
		}

		// Token: 0x0401D46E RID: 119918
		[Token(Token = "0x401D46E")]
		[FieldOffset(Offset = "0x18")]
		public UniEquipNormalInfoViewModel basicInfoViewModel;

		// Token: 0x0401D46F RID: 119919
		[Token(Token = "0x401D46F")]
		[FieldOffset(Offset = "0x30")]
		public UniEquipSubProfessionViewModel subProfessionViewModel;

		// Token: 0x0401D470 RID: 119920
		[Token(Token = "0x401D470")]
		[FieldOffset(Offset = "0x68")]
		public UniEquipNormalInfoViewModel talentViewModel;

		// Token: 0x0401D471 RID: 119921
		[Token(Token = "0x401D471")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_equipLevel;

		// Token: 0x0401D472 RID: 119922
		[Token(Token = "0x401D472")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_equipLevel;

		// Token: 0x0401D473 RID: 119923
		[Token(Token = "0x401D473")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isIncludedInLevelUp;

		// Token: 0x0401D474 RID: 119924
		[Token(Token = "0x401D474")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isIncludedInLevelUp;

		// Token: 0x0401D475 RID: 119925
		[Token(Token = "0x401D475")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isLastTargetLevel;

		// Token: 0x0401D476 RID: 119926
		[Token(Token = "0x401D476")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isLastTargetLevel;

		// Token: 0x0401D477 RID: 119927
		[Token(Token = "0x401D477")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_isCurLevel;

		// Token: 0x0401D478 RID: 119928
		[Token(Token = "0x401D478")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isCurLevel;

		// Token: 0x0401D479 RID: 119929
		[Token(Token = "0x401D479")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
