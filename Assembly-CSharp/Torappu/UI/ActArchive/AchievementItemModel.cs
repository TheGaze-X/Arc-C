using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE4 RID: 27364
	[Token(Token = "0x2006AE4")]
	public class AchievementItemModel : ArchiveItemModel, IComparable<AchievementItemModel>
	{
		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x0602722A RID: 160298 RVA: 0x000CD740 File Offset: 0x000CB940
		[Token(Token = "0x17005C82")]
		public float progressPercent
		{
			[Token(Token = "0x602722A")]
			[Address(RVA = "0x224A310", Offset = "0x2248F10", VA = "0x18224A310")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x0602722B RID: 160299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C83")]
		public string achievementDesc
		{
			[Token(Token = "0x602722B")]
			[Address(RVA = "0x224A200", Offset = "0x2248E00", VA = "0x18224A200")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602722C RID: 160300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602722C")]
		[Address(RVA = "0x224A140", Offset = "0x2248D40", VA = "0x18224A140", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x0602722D RID: 160301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602722D")]
		[Address(RVA = "0x224A0E0", Offset = "0x2248CE0", VA = "0x18224A0E0", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x0602722E RID: 160302 RVA: 0x000CD758 File Offset: 0x000CB958
		[Token(Token = "0x602722E")]
		[Address(RVA = "0x2249FE0", Offset = "0x2248BE0", VA = "0x182249FE0", Slot = "7")]
		public int CompareTo(AchievementItemModel other)
		{
			return 0;
		}

		// Token: 0x0602722F RID: 160303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602722F")]
		[Address(RVA = "0x224A1A0", Offset = "0x2248DA0", VA = "0x18224A1A0")]
		public AchievementItemModel()
		{
		}

		// Token: 0x040375C0 RID: 226752
		[Token(Token = "0x40375C0")]
		[FieldOffset(Offset = "0x30")]
		public string achievementId;

		// Token: 0x040375C1 RID: 226753
		[Token(Token = "0x40375C1")]
		[FieldOffset(Offset = "0x38")]
		public List<string> achievementType;

		// Token: 0x040375C2 RID: 226754
		[Token(Token = "0x40375C2")]
		[FieldOffset(Offset = "0x40")]
		public int raritySortId;

		// Token: 0x040375C3 RID: 226755
		[Token(Token = "0x40375C3")]
		[FieldOffset(Offset = "0x44")]
		public int sortId;

		// Token: 0x040375C4 RID: 226756
		[Token(Token = "0x40375C4")]
		[FieldOffset(Offset = "0x48")]
		public string achievementName;

		// Token: 0x040375C5 RID: 226757
		[Token(Token = "0x40375C5")]
		[FieldOffset(Offset = "0x50")]
		public string achievementRawDesc;

		// Token: 0x040375C6 RID: 226758
		[Token(Token = "0x40375C6")]
		[FieldOffset(Offset = "0x58")]
		public int progressTarget;

		// Token: 0x040375C7 RID: 226759
		[Token(Token = "0x40375C7")]
		[FieldOffset(Offset = "0x5C")]
		public int progressValue;

		// Token: 0x040375C8 RID: 226760
		[Token(Token = "0x40375C8")]
		[FieldOffset(Offset = "0x60")]
		public bool isCompleted;

		// Token: 0x040375C9 RID: 226761
		[Token(Token = "0x40375C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_progressPercent;

		// Token: 0x040375CA RID: 226762
		[Token(Token = "0x40375CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_achievementDesc;

		// Token: 0x040375CB RID: 226763
		[Token(Token = "0x40375CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040375CC RID: 226764
		[Token(Token = "0x40375CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040375CD RID: 226765
		[Token(Token = "0x40375CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040375CE RID: 226766
		[Token(Token = "0x40375CE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
