using System;
using Il2CppDummyDll;
using Torappu.UI.Stage.MixStory;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CD7 RID: 27863
	[Token(Token = "0x2006CD7")]
	public class TemplateActivityCGGalleryViewModel : TemplateActivityViewModel
	{
		// Token: 0x17005DD4 RID: 24020
		// (get) Token: 0x06027BE6 RID: 162790 RVA: 0x000CF330 File Offset: 0x000CD530
		[Token(Token = "0x17005DD4")]
		public bool entryOpen
		{
			[Token(Token = "0x6027BE6")]
			[Address(RVA = "0x22D6AC0", Offset = "0x22D56C0", VA = "0x1822D6AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005DD5 RID: 24021
		// (get) Token: 0x06027BE7 RID: 162791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DD5")]
		public string storylineId
		{
			[Token(Token = "0x6027BE7")]
			[Address(RVA = "0x22D6BC0", Offset = "0x22D57C0", VA = "0x1822D6BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005DD6 RID: 24022
		// (get) Token: 0x06027BE8 RID: 162792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DD6")]
		public string storySetId
		{
			[Token(Token = "0x6027BE8")]
			[Address(RVA = "0x22D6B30", Offset = "0x22D5730", VA = "0x1822D6B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027BE9 RID: 162793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BE9")]
		[Address(RVA = "0x22D69E0", Offset = "0x22D55E0", VA = "0x1822D69E0")]
		public TemplateActivityCGGalleryViewModel(object param)
		{
		}

		// Token: 0x06027BEA RID: 162794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BEA")]
		[Address(RVA = "0x22D6740", Offset = "0x22D5340", VA = "0x1822D6740")]
		private void _LoadStorySetViewModel(object raw)
		{
		}

		// Token: 0x040385DC RID: 230876
		[Token(Token = "0x40385DC")]
		[FieldOffset(Offset = "0x20")]
		private StageStorylineStorySetViewModel m_storySetViewModel;

		// Token: 0x040385DD RID: 230877
		[Token(Token = "0x40385DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryOpen;

		// Token: 0x040385DE RID: 230878
		[Token(Token = "0x40385DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_storylineId;

		// Token: 0x040385DF RID: 230879
		[Token(Token = "0x40385DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_storySetId;

		// Token: 0x040385E0 RID: 230880
		[Token(Token = "0x40385E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040385E1 RID: 230881
		[Token(Token = "0x40385E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadStorySetViewModel;

		// Token: 0x02006CD8 RID: 27864
		[Token(Token = "0x2006CD8")]
		public class Input
		{
			// Token: 0x06027BEB RID: 162795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027BEB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040385E2 RID: 230882
			[Token(Token = "0x40385E2")]
			[FieldOffset(Offset = "0x10")]
			public ActivityStageController controller;
		}
	}
}
