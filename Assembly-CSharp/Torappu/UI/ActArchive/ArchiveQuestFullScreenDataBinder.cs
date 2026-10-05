using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BF2 RID: 27634
	[Token(Token = "0x2006BF2")]
	public class ArchiveQuestFullScreenDataBinder : DataBinder<ArchiveQuestProperty>
	{
		// Token: 0x17005D23 RID: 23843
		// (get) Token: 0x0602776A RID: 161642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602776B RID: 161643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D23")]
		public ActArchiveController controller
		{
			[Token(Token = "0x602776A")]
			[Address(RVA = "0x22A90F0", Offset = "0x22A7CF0", VA = "0x1822A90F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602776B")]
			[Address(RVA = "0x22A9150", Offset = "0x22A7D50", VA = "0x1822A9150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602776C RID: 161644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602776C")]
		[Address(RVA = "0x22A8D50", Offset = "0x22A7950", VA = "0x1822A8D50", Slot = "7")]
		public override void OnValueChanged(ArchiveQuestProperty property)
		{
		}

		// Token: 0x0602776D RID: 161645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602776D")]
		[Address(RVA = "0x22A9080", Offset = "0x22A7C80", VA = "0x1822A9080")]
		public ArchiveQuestFullScreenDataBinder()
		{
		}

		// Token: 0x04037ECA RID: 229066
		[Token(Token = "0x4037ECA")]
		[FieldOffset(Offset = "0x20")]
		private bool m_cachedFullScreen;

		// Token: 0x04037ECC RID: 229068
		[Token(Token = "0x4037ECC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037ECD RID: 229069
		[Token(Token = "0x4037ECD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037ECE RID: 229070
		[Token(Token = "0x4037ECE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037ECF RID: 229071
		[Token(Token = "0x4037ECF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
