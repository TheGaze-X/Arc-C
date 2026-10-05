using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C0C RID: 23564
	[Token(Token = "0x2005C0C")]
	public class CommonCharSelectDetailDefaultViewModel : TemplateCharSelectDetailViewModelBase<TemplateCharSelectCardViewModel>
	{
		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x0602228C RID: 139916 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602228D RID: 139917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005015")]
		public CharSelectBranchGroupViewModel branchViewModel
		{
			[Token(Token = "0x602228C")]
			[Address(RVA = "0x1CAA960", Offset = "0x1CA9560", VA = "0x181CAA960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602228D")]
			[Address(RVA = "0x1CAAAE0", Offset = "0x1CA96E0", VA = "0x181CAAAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x0602228E RID: 139918 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602228F RID: 139919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005016")]
		public CharSelectSkillGroupViewModel skillViewModel
		{
			[Token(Token = "0x602228E")]
			[Address(RVA = "0x1CAAA20", Offset = "0x1CA9620", VA = "0x181CAAA20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602228F")]
			[Address(RVA = "0x1CAAB60", Offset = "0x1CA9760", VA = "0x181CAAB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x06022290 RID: 139920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005017")]
		public override TemplateCharSelectCardViewModel targetChar
		{
			[Token(Token = "0x6022290")]
			[Address(RVA = "0x1CAAA80", Offset = "0x1CA9680", VA = "0x181CAAA80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06022291 RID: 139921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005018")]
		public TemplateCharSelectController.InputParam cacheInput
		{
			[Token(Token = "0x6022291")]
			[Address(RVA = "0x1CAA9C0", Offset = "0x1CA95C0", VA = "0x181CAA9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022292 RID: 139922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022292")]
		[Address(RVA = "0x1CAA340", Offset = "0x1CA8F40", VA = "0x181CAA340", Slot = "8")]
		protected override void OnUpdateWithChar(TemplateCharSelectCardViewModel charModel, bool forceUpdate)
		{
		}

		// Token: 0x06022293 RID: 139923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022293")]
		[Address(RVA = "0x1CAA680", Offset = "0x1CA9280", VA = "0x181CAA680", Slot = "7")]
		public override void Resume()
		{
		}

		// Token: 0x06022294 RID: 139924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022294")]
		[Address(RVA = "0x1CAA820", Offset = "0x1CA9420", VA = "0x181CAA820")]
		private void _SetSkillViewModel(TemplateCharSelectCardViewModel charModel, bool forceRefresh = false)
		{
		}

		// Token: 0x06022295 RID: 139925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022295")]
		[Address(RVA = "0x1CAA750", Offset = "0x1CA9350", VA = "0x181CAA750")]
		private void _SetBranchViewModel(TemplateCharSelectCardViewModel charModel, bool forceRefresh = false)
		{
		}

		// Token: 0x06022296 RID: 139926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022296")]
		[Address(RVA = "0x1CAA5D0", Offset = "0x1CA91D0", VA = "0x181CAA5D0", Slot = "6")]
		public override void Reset(TemplateCharSelectModelResetData data)
		{
		}

		// Token: 0x06022297 RID: 139927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022297")]
		[Address(RVA = "0x1CAA8F0", Offset = "0x1CA94F0", VA = "0x181CAA8F0")]
		public CommonCharSelectDetailDefaultViewModel()
		{
		}

		// Token: 0x06022298 RID: 139928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022298")]
		[Address(RVA = "0x1CAA740", Offset = "0x1CA9340", VA = "0x181CAA740")]
		private void <>xLuaBaseProxy_Resume()
		{
		}

		// Token: 0x0402ED70 RID: 191856
		[Token(Token = "0x402ED70")]
		[FieldOffset(Offset = "0x20")]
		private TemplateCharSelectCardViewModel m_targetChar;

		// Token: 0x0402ED71 RID: 191857
		[Token(Token = "0x402ED71")]
		[FieldOffset(Offset = "0x28")]
		private TemplateCharSelectController.InputParam m_cacheInput;

		// Token: 0x0402ED72 RID: 191858
		[Token(Token = "0x402ED72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_branchViewModel;

		// Token: 0x0402ED73 RID: 191859
		[Token(Token = "0x402ED73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_branchViewModel;

		// Token: 0x0402ED74 RID: 191860
		[Token(Token = "0x402ED74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skillViewModel;

		// Token: 0x0402ED75 RID: 191861
		[Token(Token = "0x402ED75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_skillViewModel;

		// Token: 0x0402ED76 RID: 191862
		[Token(Token = "0x402ED76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_targetChar;

		// Token: 0x0402ED77 RID: 191863
		[Token(Token = "0x402ED77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_cacheInput;

		// Token: 0x0402ED78 RID: 191864
		[Token(Token = "0x402ED78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnUpdateWithChar;

		// Token: 0x0402ED79 RID: 191865
		[Token(Token = "0x402ED79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Resume;

		// Token: 0x0402ED7A RID: 191866
		[Token(Token = "0x402ED7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetSkillViewModel;

		// Token: 0x0402ED7B RID: 191867
		[Token(Token = "0x402ED7B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetBranchViewModel;

		// Token: 0x0402ED7C RID: 191868
		[Token(Token = "0x402ED7C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402ED7D RID: 191869
		[Token(Token = "0x402ED7D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
