using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD2 RID: 27346
	[Token(Token = "0x2006AD2")]
	public class AchievementProxy : ActArchiveCompProxy<ArchiveAchievementController>
	{
		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x060271DB RID: 160219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C75")]
		protected override string compType
		{
			[Token(Token = "0x60271DB")]
			[Address(RVA = "0x224AC10", Offset = "0x2249810", VA = "0x18224AC10", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271DC RID: 160220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271DC")]
		[Address(RVA = "0x224A390", Offset = "0x2248F90", VA = "0x18224A390", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271DD RID: 160221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271DD")]
		[Address(RVA = "0x224A400", Offset = "0x2249000", VA = "0x18224A400", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271DE RID: 160222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271DE")]
		[Address(RVA = "0x224A9A0", Offset = "0x22495A0", VA = "0x18224A9A0")]
		private void _OnGotFilterSelectionChange(ArchiveAchievementListGotFilterViewModel.GotType type)
		{
		}

		// Token: 0x060271DF RID: 160223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271DF")]
		[Address(RVA = "0x224A770", Offset = "0x2249370", VA = "0x18224A770")]
		private void _OnFilterChange(ArchiveAchievementListFilterViewModel.FilterType filterType, string value)
		{
		}

		// Token: 0x060271E0 RID: 160224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271E0")]
		[Address(RVA = "0x224ABA0", Offset = "0x22497A0", VA = "0x18224ABA0")]
		public AchievementProxy()
		{
		}

		// Token: 0x0403754A RID: 226634
		[Token(Token = "0x403754A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403754B RID: 226635
		[Token(Token = "0x403754B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x0403754C RID: 226636
		[Token(Token = "0x403754C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403754D RID: 226637
		[Token(Token = "0x403754D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnGotFilterSelectionChange;

		// Token: 0x0403754E RID: 226638
		[Token(Token = "0x403754E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnFilterChange;

		// Token: 0x0403754F RID: 226639
		[Token(Token = "0x403754F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
