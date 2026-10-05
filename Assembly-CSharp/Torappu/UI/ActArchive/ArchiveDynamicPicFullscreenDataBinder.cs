using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BD2 RID: 27602
	[Token(Token = "0x2006BD2")]
	public class ArchiveDynamicPicFullscreenDataBinder : DataBinder<PicProperty>
	{
		// Token: 0x17005D12 RID: 23826
		// (get) Token: 0x060276B7 RID: 161463 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060276B8 RID: 161464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D12")]
		public ActArchiveController controller
		{
			[Token(Token = "0x60276B7")]
			[Address(RVA = "0x22907F0", Offset = "0x228F3F0", VA = "0x1822907F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60276B8")]
			[Address(RVA = "0x2290850", Offset = "0x228F450", VA = "0x182290850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060276B9 RID: 161465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276B9")]
		[Address(RVA = "0x2290450", Offset = "0x228F050", VA = "0x182290450", Slot = "7")]
		public override void OnValueChanged(PicProperty property)
		{
		}

		// Token: 0x060276BA RID: 161466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276BA")]
		[Address(RVA = "0x2290780", Offset = "0x228F380", VA = "0x182290780")]
		public ArchiveDynamicPicFullscreenDataBinder()
		{
		}

		// Token: 0x04037D99 RID: 228761
		[Token(Token = "0x4037D99")]
		[FieldOffset(Offset = "0x20")]
		private bool m_cachedFullscreen;

		// Token: 0x04037D9B RID: 228763
		[Token(Token = "0x4037D9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037D9C RID: 228764
		[Token(Token = "0x4037D9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037D9D RID: 228765
		[Token(Token = "0x4037D9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037D9E RID: 228766
		[Token(Token = "0x4037D9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
