using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BFD RID: 23549
	[Token(Token = "0x2005BFD")]
	public class TemplateCharSelectMainViewModel : IHotfixable
	{
		// Token: 0x17004FE3 RID: 20451
		// (get) Token: 0x06022219 RID: 139801 RVA: 0x000BC640 File Offset: 0x000BA840
		// (set) Token: 0x0602221A RID: 139802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FE3")]
		public TemplateCharSelectMainViewModelSetupData setupParam
		{
			[Token(Token = "0x6022219")]
			[Address(RVA = "0x1C9DF30", Offset = "0x1C9CB30", VA = "0x181C9DF30")]
			[CompilerGenerated]
			get
			{
				return default(TemplateCharSelectMainViewModelSetupData);
			}
			[Token(Token = "0x602221A")]
			[Address(RVA = "0x1C9E1A0", Offset = "0x1C9CDA0", VA = "0x181C9E1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FE4 RID: 20452
		// (get) Token: 0x0602221B RID: 139803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602221C RID: 139804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FE4")]
		public TemplateCharSelectPoolViewModel poolViewModel
		{
			[Token(Token = "0x602221B")]
			[Address(RVA = "0x1C9DE00", Offset = "0x1C9CA00", VA = "0x181C9DE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602221C")]
			[Address(RVA = "0x1C9E120", Offset = "0x1C9CD20", VA = "0x181C9E120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FE5 RID: 20453
		// (get) Token: 0x0602221D RID: 139805 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602221E RID: 139806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FE5")]
		public TemplateCharSelectShuffleViewModel shuffleViewModel
		{
			[Token(Token = "0x602221D")]
			[Address(RVA = "0x1C9DFC0", Offset = "0x1C9CBC0", VA = "0x181C9DFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602221E")]
			[Address(RVA = "0x1C9E240", Offset = "0x1C9CE40", VA = "0x181C9E240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FE6 RID: 20454
		// (get) Token: 0x0602221F RID: 139807 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022220 RID: 139808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FE6")]
		public TemplateCharSelectDetailViewModel detailViewModel
		{
			[Token(Token = "0x602221F")]
			[Address(RVA = "0x1C9DCF0", Offset = "0x1C9C8F0", VA = "0x181C9DCF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022220")]
			[Address(RVA = "0x1C9E0A0", Offset = "0x1C9CCA0", VA = "0x181C9E0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FE7 RID: 20455
		// (get) Token: 0x06022221 RID: 139809 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022222 RID: 139810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004FE7")]
		public TemplateCharSelectController.InputParam cacheInput
		{
			[Token(Token = "0x6022221")]
			[Address(RVA = "0x1C9DC90", Offset = "0x1C9C890", VA = "0x181C9DC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6022222")]
			[Address(RVA = "0x1C9E020", Offset = "0x1C9CC20", VA = "0x181C9E020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06022223 RID: 139811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FE8")]
		public List<TemplateCharSelectCardViewModel> selectedList
		{
			[Token(Token = "0x6022223")]
			[Address(RVA = "0x1C9DE60", Offset = "0x1C9CA60", VA = "0x181C9DE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x06022224 RID: 139812 RVA: 0x000BC658 File Offset: 0x000BA858
		[Token(Token = "0x17004FE9")]
		public TemplateCharSelectMode mode
		{
			[Token(Token = "0x6022224")]
			[Address(RVA = "0x1C9DD50", Offset = "0x1C9C950", VA = "0x181C9DD50")]
			get
			{
				return TemplateCharSelectMode.MULTI;
			}
		}

		// Token: 0x06022225 RID: 139813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022225")]
		[Address(RVA = "0x1C9D6E0", Offset = "0x1C9C2E0", VA = "0x181C9D6E0")]
		public void Setup(TemplateCharSelectMainViewModelSetupData setup)
		{
		}

		// Token: 0x06022226 RID: 139814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022226")]
		[Address(RVA = "0x1C9D180", Offset = "0x1C9BD80", VA = "0x181C9D180", Slot = "4")]
		public virtual void ResetByInput(TemplateCharSelectController.InputParam param)
		{
		}

		// Token: 0x06022227 RID: 139815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022227")]
		[Address(RVA = "0x1C9DA60", Offset = "0x1C9C660", VA = "0x181C9DA60")]
		public void TriggerResume()
		{
		}

		// Token: 0x06022228 RID: 139816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022228")]
		[Address(RVA = "0x1C9DC30", Offset = "0x1C9C830", VA = "0x181C9DC30")]
		public TemplateCharSelectMainViewModel()
		{
		}

		// Token: 0x0402ECCB RID: 191691
		[Token(Token = "0x402ECCB")]
		[FieldOffset(Offset = "0x58")]
		public bool ensured;

		// Token: 0x0402ECCC RID: 191692
		[Token(Token = "0x402ECCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_setupParam;

		// Token: 0x0402ECCD RID: 191693
		[Token(Token = "0x402ECCD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_setupParam;

		// Token: 0x0402ECCE RID: 191694
		[Token(Token = "0x402ECCE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_poolViewModel;

		// Token: 0x0402ECCF RID: 191695
		[Token(Token = "0x402ECCF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_poolViewModel;

		// Token: 0x0402ECD0 RID: 191696
		[Token(Token = "0x402ECD0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_shuffleViewModel;

		// Token: 0x0402ECD1 RID: 191697
		[Token(Token = "0x402ECD1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_shuffleViewModel;

		// Token: 0x0402ECD2 RID: 191698
		[Token(Token = "0x402ECD2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_detailViewModel;

		// Token: 0x0402ECD3 RID: 191699
		[Token(Token = "0x402ECD3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_detailViewModel;

		// Token: 0x0402ECD4 RID: 191700
		[Token(Token = "0x402ECD4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_cacheInput;

		// Token: 0x0402ECD5 RID: 191701
		[Token(Token = "0x402ECD5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_cacheInput;

		// Token: 0x0402ECD6 RID: 191702
		[Token(Token = "0x402ECD6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_selectedList;

		// Token: 0x0402ECD7 RID: 191703
		[Token(Token = "0x402ECD7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_mode;

		// Token: 0x0402ECD8 RID: 191704
		[Token(Token = "0x402ECD8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0402ECD9 RID: 191705
		[Token(Token = "0x402ECD9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ResetByInput;

		// Token: 0x0402ECDA RID: 191706
		[Token(Token = "0x402ECDA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_TriggerResume;

		// Token: 0x0402ECDB RID: 191707
		[Token(Token = "0x402ECDB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
