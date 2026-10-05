using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CharSelect;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AF5 RID: 6901
	[Token(Token = "0x2001AF5")]
	public abstract class BuildingCharSelectFavorRelatedPlugin<Context> : UICharacterSelectState.Plugin<Context>
	{
		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x0600AE59 RID: 44633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700149D")]
		public override string overrideNoCharText
		{
			[Token(Token = "0x600AE59")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x0600AE5A RID: 44634 RVA: 0x00043200 File Offset: 0x00041400
		[Token(Token = "0x1700149E")]
		public override bool showCharInfoEntry
		{
			[Token(Token = "0x600AE5A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5B")]
		public override void OverrideSelectCanceled(Action selfCancel)
		{
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5C")]
		public override void OverrideSkillSelect(string skillId, Action<string> selfSkillSelect)
		{
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5D")]
		public override void OverrideBranchSelect(string equipId, Action<string> selfBranchSelect)
		{
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5E")]
		public override void PostUpdateAttribute(CharAttrViewModel attrModel)
		{
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE5F")]
		public override void AddCharMultiSelectExcludeRule(int instId, List<int> excludeInstIds)
		{
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE60")]
		public override void OverrideCharListSort(List<CharacterCardViewModel> charList, CharacterSortType sortType, Action<List<CharacterCardViewModel>, CharacterSortType> selfCharListSort)
		{
		}

		// Token: 0x0600AE61 RID: 44641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE61")]
		protected BuildingCharSelectFavorRelatedPlugin()
		{
		}

		// Token: 0x0400A6F6 RID: 42742
		[Token(Token = "0x400A6F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_overrideNoCharText;

		// Token: 0x0400A6F7 RID: 42743
		[Token(Token = "0x400A6F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showCharInfoEntry;

		// Token: 0x0400A6F8 RID: 42744
		[Token(Token = "0x400A6F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideSelectCanceled;

		// Token: 0x0400A6F9 RID: 42745
		[Token(Token = "0x400A6F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideSkillSelect;

		// Token: 0x0400A6FA RID: 42746
		[Token(Token = "0x400A6FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideBranchSelect;

		// Token: 0x0400A6FB RID: 42747
		[Token(Token = "0x400A6FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PostUpdateAttribute;

		// Token: 0x0400A6FC RID: 42748
		[Token(Token = "0x400A6FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddCharMultiSelectExcludeRule;

		// Token: 0x0400A6FD RID: 42749
		[Token(Token = "0x400A6FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideCharListSort;

		// Token: 0x0400A6FE RID: 42750
		[Token(Token = "0x400A6FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
