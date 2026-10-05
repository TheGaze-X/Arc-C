using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B02 RID: 27394
	[Token(Token = "0x2006B02")]
	public class ArchiveActivityEntryMusicDataBinder : DataBinder<ArchiveActivityEntryProperty>
	{
		// Token: 0x17005C93 RID: 23699
		// (get) Token: 0x060272B3 RID: 160435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060272B4 RID: 160436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C93")]
		public ArchiveActivityEntryController controller
		{
			[Token(Token = "0x60272B3")]
			[Address(RVA = "0x2253700", Offset = "0x2252300", VA = "0x182253700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60272B4")]
			[Address(RVA = "0x2253760", Offset = "0x2252360", VA = "0x182253760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060272B5 RID: 160437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272B5")]
		[Address(RVA = "0x22534C0", Offset = "0x22520C0", VA = "0x1822534C0", Slot = "7")]
		public override void OnValueChanged(ArchiveActivityEntryProperty property)
		{
		}

		// Token: 0x060272B6 RID: 160438 RVA: 0x000CD938 File Offset: 0x000CBB38
		[Token(Token = "0x60272B6")]
		[Address(RVA = "0x2253630", Offset = "0x2252230", VA = "0x182253630")]
		private long _GetBgmInstId()
		{
			return 0L;
		}

		// Token: 0x060272B7 RID: 160439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272B7")]
		[Address(RVA = "0x2253570", Offset = "0x2252170", VA = "0x182253570")]
		public void RefreshBGM()
		{
		}

		// Token: 0x060272B8 RID: 160440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272B8")]
		[Address(RVA = "0x22533E0", Offset = "0x2251FE0", VA = "0x1822533E0")]
		public void ClearBGM()
		{
		}

		// Token: 0x060272B9 RID: 160441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272B9")]
		[Address(RVA = "0x2253690", Offset = "0x2252290", VA = "0x182253690")]
		public ArchiveActivityEntryMusicDataBinder()
		{
		}

		// Token: 0x04037681 RID: 226945
		[Token(Token = "0x4037681")]
		[FieldOffset(Offset = "0x20")]
		private string m_musicId;

		// Token: 0x04037683 RID: 226947
		[Token(Token = "0x4037683")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037684 RID: 226948
		[Token(Token = "0x4037684")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037685 RID: 226949
		[Token(Token = "0x4037685")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037686 RID: 226950
		[Token(Token = "0x4037686")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetBgmInstId;

		// Token: 0x04037687 RID: 226951
		[Token(Token = "0x4037687")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshBGM;

		// Token: 0x04037688 RID: 226952
		[Token(Token = "0x4037688")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearBGM;

		// Token: 0x04037689 RID: 226953
		[Token(Token = "0x4037689")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
