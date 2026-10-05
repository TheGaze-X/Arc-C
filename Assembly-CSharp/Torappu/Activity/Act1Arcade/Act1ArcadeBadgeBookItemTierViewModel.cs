using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200793B RID: 31035
	[Token(Token = "0x200793B")]
	public class Act1ArcadeBadgeBookItemTierViewModel : IComparable<Act1ArcadeBadgeBookItemTierViewModel>, IHotfixable
	{
		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x0602B8A8 RID: 178344 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B8A9 RID: 178345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006606")]
		public string unlockDesc
		{
			[Token(Token = "0x602B8A8")]
			[Address(RVA = "0x276B250", Offset = "0x2769E50", VA = "0x18276B250")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602B8A9")]
			[Address(RVA = "0x276B370", Offset = "0x2769F70", VA = "0x18276B370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x0602B8AA RID: 178346 RVA: 0x000DC620 File Offset: 0x000DA820
		// (set) Token: 0x0602B8AB RID: 178347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006607")]
		public int unlockProgress
		{
			[Token(Token = "0x602B8AA")]
			[Address(RVA = "0x276B2B0", Offset = "0x2769EB0", VA = "0x18276B2B0")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x602B8AB")]
			[Address(RVA = "0x276B3F0", Offset = "0x2769FF0", VA = "0x18276B3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x0602B8AC RID: 178348 RVA: 0x000DC638 File Offset: 0x000DA838
		// (set) Token: 0x0602B8AD RID: 178349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006608")]
		public int unlockTarget
		{
			[Token(Token = "0x602B8AC")]
			[Address(RVA = "0x276B310", Offset = "0x2769F10", VA = "0x18276B310")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x602B8AD")]
			[Address(RVA = "0x276B460", Offset = "0x276A060", VA = "0x18276B460")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B8AE RID: 178350 RVA: 0x000DC650 File Offset: 0x000DA850
		[Token(Token = "0x602B8AE")]
		[Address(RVA = "0x276AE40", Offset = "0x2769A40", VA = "0x18276AE40", Slot = "4")]
		public int CompareTo(Act1ArcadeBadgeBookItemTierViewModel other)
		{
			return 0;
		}

		// Token: 0x0602B8AF RID: 178351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8AF")]
		[Address(RVA = "0x276AEC0", Offset = "0x2769AC0", VA = "0x18276AEC0")]
		public string GetUnlockDescWithHighlightColor(Color color)
		{
			return null;
		}

		// Token: 0x0602B8B0 RID: 178352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8B0")]
		[Address(RVA = "0x276B1F0", Offset = "0x2769DF0", VA = "0x18276B1F0")]
		public Act1ArcadeBadgeBookItemTierViewModel()
		{
		}

		// Token: 0x0403EF8F RID: 257935
		[Token(Token = "0x403EF8F")]
		[FieldOffset(Offset = "0x10")]
		public string tierId;

		// Token: 0x0403EF90 RID: 257936
		[Token(Token = "0x403EF90")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0403EF91 RID: 257937
		[Token(Token = "0x403EF91")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0403EF92 RID: 257938
		[Token(Token = "0x403EF92")]
		[FieldOffset(Offset = "0x28")]
		public string shareIconId;

		// Token: 0x0403EF93 RID: 257939
		[Token(Token = "0x403EF93")]
		[FieldOffset(Offset = "0x30")]
		public string effectId;

		// Token: 0x0403EF94 RID: 257940
		[Token(Token = "0x403EF94")]
		[FieldOffset(Offset = "0x38")]
		public string title;

		// Token: 0x0403EF95 RID: 257941
		[Token(Token = "0x403EF95")]
		[FieldOffset(Offset = "0x40")]
		public string desc;

		// Token: 0x0403EF96 RID: 257942
		[Token(Token = "0x403EF96")]
		[FieldOffset(Offset = "0x48")]
		public string rawUnlockDesc;

		// Token: 0x0403EF97 RID: 257943
		[Token(Token = "0x403EF97")]
		[FieldOffset(Offset = "0x50")]
		public RuneTable.PackedRuneData runeData;

		// Token: 0x0403EF98 RID: 257944
		[Token(Token = "0x403EF98")]
		[FieldOffset(Offset = "0x58")]
		public bool unlocked;

		// Token: 0x0403EF9C RID: 257948
		[Token(Token = "0x403EF9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_unlockDesc;

		// Token: 0x0403EF9D RID: 257949
		[Token(Token = "0x403EF9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_unlockDesc;

		// Token: 0x0403EF9E RID: 257950
		[Token(Token = "0x403EF9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_unlockProgress;

		// Token: 0x0403EF9F RID: 257951
		[Token(Token = "0x403EF9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_unlockProgress;

		// Token: 0x0403EFA0 RID: 257952
		[Token(Token = "0x403EFA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_unlockTarget;

		// Token: 0x0403EFA1 RID: 257953
		[Token(Token = "0x403EFA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_unlockTarget;

		// Token: 0x0403EFA2 RID: 257954
		[Token(Token = "0x403EFA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403EFA3 RID: 257955
		[Token(Token = "0x403EFA3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetUnlockDescWithHighlightColor;

		// Token: 0x0403EFA4 RID: 257956
		[Token(Token = "0x403EFA4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
