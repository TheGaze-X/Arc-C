using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ADE RID: 27358
	[Token(Token = "0x2006ADE")]
	public class ArchiveAchievementController : ActArchiveController
	{
		// Token: 0x17005C7D RID: 23677
		// (get) Token: 0x06027215 RID: 160277 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027216 RID: 160278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C7D")]
		public Action<ArchiveAchievementListFilterViewModel.FilterType, string> onFilterChange
		{
			[Token(Token = "0x6027215")]
			[Address(RVA = "0x224EC00", Offset = "0x224D800", VA = "0x18224EC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027216")]
			[Address(RVA = "0x224ECC0", Offset = "0x224D8C0", VA = "0x18224ECC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x06027217 RID: 160279 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027218 RID: 160280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C7E")]
		public Action<ArchiveAchievementListGotFilterViewModel.GotType> onGotFilterSelectionChange
		{
			[Token(Token = "0x6027217")]
			[Address(RVA = "0x224EC60", Offset = "0x224D860", VA = "0x18224EC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027218")]
			[Address(RVA = "0x224ED40", Offset = "0x224D940", VA = "0x18224ED40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x06027219 RID: 160281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C7F")]
		public ArchiveAchievementDataBinder dataBinder
		{
			[Token(Token = "0x6027219")]
			[Address(RVA = "0x224EBA0", Offset = "0x224D7A0", VA = "0x18224EBA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602721A RID: 160282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602721A")]
		[Address(RVA = "0x224E8B0", Offset = "0x224D4B0", VA = "0x18224E8B0")]
		public void OnFilterSelectionChange(ArchiveAchievementListFilterViewModel.FilterType filterType, string value)
		{
		}

		// Token: 0x0602721B RID: 160283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602721B")]
		[Address(RVA = "0x224E9E0", Offset = "0x224D5E0", VA = "0x18224E9E0")]
		public void OnGotFilterSelectionChange(ArchiveAchievementListGotFilterViewModel.GotType type)
		{
		}

		// Token: 0x0602721C RID: 160284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602721C")]
		[Address(RVA = "0x224EB00", Offset = "0x224D700", VA = "0x18224EB00")]
		public ArchiveAchievementController()
		{
		}

		// Token: 0x04037597 RID: 226711
		[Token(Token = "0x4037597")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveAchievementDataBinder _achievementDataBinder;

		// Token: 0x0403759A RID: 226714
		[Token(Token = "0x403759A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onFilterChange;

		// Token: 0x0403759B RID: 226715
		[Token(Token = "0x403759B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onFilterChange;

		// Token: 0x0403759C RID: 226716
		[Token(Token = "0x403759C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onGotFilterSelectionChange;

		// Token: 0x0403759D RID: 226717
		[Token(Token = "0x403759D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onGotFilterSelectionChange;

		// Token: 0x0403759E RID: 226718
		[Token(Token = "0x403759E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x0403759F RID: 226719
		[Token(Token = "0x403759F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFilterSelectionChange;

		// Token: 0x040375A0 RID: 226720
		[Token(Token = "0x40375A0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnGotFilterSelectionChange;

		// Token: 0x040375A1 RID: 226721
		[Token(Token = "0x40375A1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
