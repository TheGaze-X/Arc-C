using System;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using Torappu.UI.TemplateCharSelect;
using Torappu.UI.TemplateCharSelect.Common;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076FF RID: 30463
	[Token(Token = "0x20076FF")]
	public class Act1VHalfIdleCharSelectCardViewModel : CommonCharSelectCardDefaultViewModel
	{
		// Token: 0x0602ACD2 RID: 175314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACD2")]
		[Address(RVA = "0x2698350", Offset = "0x2696F50", VA = "0x182698350", Slot = "15")]
		public override CharSelectSkillGroupViewModel SetSkillViewModel(bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x0602ACD3 RID: 175315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACD3")]
		[Address(RVA = "0x2697F00", Offset = "0x2696B00", VA = "0x182697F00", Slot = "16")]
		public override CharSelectBranchGroupViewModel SetBranchViewModel(bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x0602ACD4 RID: 175316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACD4")]
		[Address(RVA = "0x2698560", Offset = "0x2697160", VA = "0x182698560", Slot = "10")]
		public override void SynWithPlayerData(TemplateCharSelectController.InputParam cacheInput)
		{
		}

		// Token: 0x0602ACD5 RID: 175317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACD5")]
		[Address(RVA = "0x2698720", Offset = "0x2697320", VA = "0x182698720")]
		public Act1VHalfIdleCharSelectCardViewModel()
		{
		}

		// Token: 0x0602ACD6 RID: 175318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACD6")]
		[Address(RVA = "0x2698700", Offset = "0x2697300", VA = "0x182698700")]
		private CharSelectSkillGroupViewModel <>xLuaBaseProxy_SetSkillViewModel(bool P0)
		{
			return null;
		}

		// Token: 0x0602ACD7 RID: 175319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ACD7")]
		[Address(RVA = "0x26986F0", Offset = "0x26972F0", VA = "0x1826986F0")]
		private CharSelectBranchGroupViewModel <>xLuaBaseProxy_SetBranchViewModel(bool P0)
		{
			return null;
		}

		// Token: 0x0602ACD8 RID: 175320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACD8")]
		[Address(RVA = "0x2698710", Offset = "0x2697310", VA = "0x182698710")]
		private void <>xLuaBaseProxy_SynWithPlayerData(TemplateCharSelectController.InputParam P0)
		{
		}

		// Token: 0x0403DAE1 RID: 252641
		[Token(Token = "0x403DAE1")]
		[FieldOffset(Offset = "0x40")]
		private DataBundle m_updateCache;

		// Token: 0x0403DAE2 RID: 252642
		[Token(Token = "0x403DAE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetSkillViewModel;

		// Token: 0x0403DAE3 RID: 252643
		[Token(Token = "0x403DAE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetBranchViewModel;

		// Token: 0x0403DAE4 RID: 252644
		[Token(Token = "0x403DAE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SynWithPlayerData;

		// Token: 0x0403DAE5 RID: 252645
		[Token(Token = "0x403DAE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
