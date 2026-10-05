using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B30 RID: 27440
	[Token(Token = "0x2006B30")]
	public class ArchiveChallengeBookModel : IHotfixable
	{
		// Token: 0x17005CAE RID: 23726
		// (get) Token: 0x06027397 RID: 160663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027398 RID: 160664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CAE")]
		public string archiveId
		{
			[Token(Token = "0x6027397")]
			[Address(RVA = "0x22684F0", Offset = "0x22670F0", VA = "0x1822684F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027398")]
			[Address(RVA = "0x22686D0", Offset = "0x22672D0", VA = "0x1822686D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005CAF RID: 23727
		// (get) Token: 0x06027399 RID: 160665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CAF")]
		public List<ChallengeBookItemModel> items
		{
			[Token(Token = "0x6027399")]
			[Address(RVA = "0x2268550", Offset = "0x2267150", VA = "0x182268550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005CB0 RID: 23728
		// (get) Token: 0x0602739A RID: 160666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602739B RID: 160667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CB0")]
		public string selectedId
		{
			[Token(Token = "0x602739A")]
			[Address(RVA = "0x22685B0", Offset = "0x22671B0", VA = "0x1822685B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602739B")]
			[Address(RVA = "0x2268750", Offset = "0x2267350", VA = "0x182268750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005CB1 RID: 23729
		// (get) Token: 0x0602739C RID: 160668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602739D RID: 160669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CB1")]
		public ChallengeBookItemModel selectedItem
		{
			[Token(Token = "0x602739C")]
			[Address(RVA = "0x2268610", Offset = "0x2267210", VA = "0x182268610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602739D")]
			[Address(RVA = "0x22687D0", Offset = "0x22673D0", VA = "0x1822687D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005CB2 RID: 23730
		// (get) Token: 0x0602739E RID: 160670 RVA: 0x000CDBA8 File Offset: 0x000CBDA8
		// (set) Token: 0x0602739F RID: 160671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CB2")]
		public bool showSwitchTween
		{
			[Token(Token = "0x602739E")]
			[Address(RVA = "0x2268670", Offset = "0x2267270", VA = "0x182268670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602739F")]
			[Address(RVA = "0x2268850", Offset = "0x2267450", VA = "0x182268850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060273A0 RID: 160672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A0")]
		[Address(RVA = "0x22679E0", Offset = "0x22665E0", VA = "0x1822679E0")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060273A1 RID: 160673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60273A1")]
		[Address(RVA = "0x22683E0", Offset = "0x2266FE0", VA = "0x1822683E0")]
		private ActArchiveResData.ChallengeBookArchiveResItemData _getArchivePicResData(string storyId)
		{
			return null;
		}

		// Token: 0x060273A2 RID: 160674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A2")]
		[Address(RVA = "0x2268040", Offset = "0x2266C40", VA = "0x182268040")]
		public void SelectItem(string storyId)
		{
		}

		// Token: 0x060273A3 RID: 160675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273A3")]
		[Address(RVA = "0x22682E0", Offset = "0x2266EE0", VA = "0x1822682E0")]
		public ArchiveChallengeBookModel()
		{
		}

		// Token: 0x040377FD RID: 227325
		[Token(Token = "0x40377FD")]
		[FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, ChallengeBookItemModel> m_items;

		// Token: 0x040377FE RID: 227326
		[Token(Token = "0x40377FE")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<ChallengeBookItemModel> m_itemList;

		// Token: 0x04037803 RID: 227331
		[Token(Token = "0x4037803")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_archiveId;

		// Token: 0x04037804 RID: 227332
		[Token(Token = "0x4037804")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_archiveId;

		// Token: 0x04037805 RID: 227333
		[Token(Token = "0x4037805")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_items;

		// Token: 0x04037806 RID: 227334
		[Token(Token = "0x4037806")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedId;

		// Token: 0x04037807 RID: 227335
		[Token(Token = "0x4037807")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_selectedId;

		// Token: 0x04037808 RID: 227336
		[Token(Token = "0x4037808")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x04037809 RID: 227337
		[Token(Token = "0x4037809")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_selectedItem;

		// Token: 0x0403780A RID: 227338
		[Token(Token = "0x403780A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_showSwitchTween;

		// Token: 0x0403780B RID: 227339
		[Token(Token = "0x403780B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_showSwitchTween;

		// Token: 0x0403780C RID: 227340
		[Token(Token = "0x403780C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403780D RID: 227341
		[Token(Token = "0x403780D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__getArchivePicResData;

		// Token: 0x0403780E RID: 227342
		[Token(Token = "0x403780E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x0403780F RID: 227343
		[Token(Token = "0x403780F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
