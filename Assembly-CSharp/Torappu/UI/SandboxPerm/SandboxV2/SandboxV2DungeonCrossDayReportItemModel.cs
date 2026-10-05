using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200419A RID: 16794
	[Token(Token = "0x200419A")]
	public class SandboxV2DungeonCrossDayReportItemModel : IHotfixable
	{
		// Token: 0x06019E82 RID: 106114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019E82")]
		[Address(RVA = "0x12C4450", Offset = "0x12C3050", VA = "0x1812C4450")]
		public SandboxV2DungeonCrossDayReportItemModel(SandboxPermItemData item, UIItemViewModel vm)
		{
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x06019E83 RID: 106115 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019E84 RID: 106116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DB6")]
		public SandboxPermItemData itemData
		{
			[Token(Token = "0x6019E83")]
			[Address(RVA = "0x12C4570", Offset = "0x12C3170", VA = "0x1812C4570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019E84")]
			[Address(RVA = "0x12C4630", Offset = "0x12C3230", VA = "0x1812C4630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x06019E85 RID: 106117 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019E86 RID: 106118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003DB7")]
		public UIItemViewModel viewModel
		{
			[Token(Token = "0x6019E85")]
			[Address(RVA = "0x12C45D0", Offset = "0x12C31D0", VA = "0x1812C45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019E86")]
			[Address(RVA = "0x12C46B0", Offset = "0x12C32B0", VA = "0x1812C46B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x04020956 RID: 133462
		[Token(Token = "0x4020956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04020957 RID: 133463
		[Token(Token = "0x4020957")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_itemData;

		// Token: 0x04020958 RID: 133464
		[Token(Token = "0x4020958")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_itemData;

		// Token: 0x04020959 RID: 133465
		[Token(Token = "0x4020959")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_viewModel;

		// Token: 0x0402095A RID: 133466
		[Token(Token = "0x402095A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_viewModel;
	}
}
