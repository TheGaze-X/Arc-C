using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BDA RID: 27610
	[Token(Token = "0x2006BDA")]
	public class ArchivePicFullscreenDataBinder : DataBinder<PicProperty>
	{
		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x060276E1 RID: 161505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060276E2 RID: 161506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D16")]
		public ActArchiveController controller
		{
			[Token(Token = "0x60276E1")]
			[Address(RVA = "0x229A280", Offset = "0x2298E80", VA = "0x18229A280")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60276E2")]
			[Address(RVA = "0x229A2E0", Offset = "0x2298EE0", VA = "0x18229A2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060276E3 RID: 161507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276E3")]
		[Address(RVA = "0x2299EE0", Offset = "0x2298AE0", VA = "0x182299EE0", Slot = "7")]
		public override void OnValueChanged(PicProperty property)
		{
		}

		// Token: 0x060276E4 RID: 161508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60276E4")]
		[Address(RVA = "0x229A210", Offset = "0x2298E10", VA = "0x18229A210")]
		public ArchivePicFullscreenDataBinder()
		{
		}

		// Token: 0x04037DD4 RID: 228820
		[Token(Token = "0x4037DD4")]
		[FieldOffset(Offset = "0x20")]
		private bool m_cachedFullscreen;

		// Token: 0x04037DD6 RID: 228822
		[Token(Token = "0x4037DD6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037DD7 RID: 228823
		[Token(Token = "0x4037DD7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037DD8 RID: 228824
		[Token(Token = "0x4037DD8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037DD9 RID: 228825
		[Token(Token = "0x4037DD9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
