using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004315 RID: 17173
	[Token(Token = "0x2004315")]
	public class SandboxV2HomeArchiveTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0601A60B RID: 108043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A60B")]
		[Address(RVA = "0x134C600", Offset = "0x134B200", VA = "0x18134C600", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0601A60C RID: 108044 RVA: 0x000A19D0 File Offset: 0x0009FBD0
		[Token(Token = "0x17003E97")]
		public bool isShow
		{
			[Token(Token = "0x601A60C")]
			[Address(RVA = "0x134C780", Offset = "0x134B380", VA = "0x18134C780", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601A60D RID: 108045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A60D")]
		[Address(RVA = "0x134C720", Offset = "0x134B320", VA = "0x18134C720")]
		public SandboxV2HomeArchiveTrackPointModel()
		{
		}

		// Token: 0x040217F8 RID: 137208
		[Token(Token = "0x40217F8")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x040217F9 RID: 137209
		[Token(Token = "0x40217F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040217FA RID: 137210
		[Token(Token = "0x40217FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040217FB RID: 137211
		[Token(Token = "0x40217FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004316 RID: 17174
		[Token(Token = "0x2004316")]
		public class Param
		{
			// Token: 0x0601A60E RID: 108046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A60E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040217FC RID: 137212
			[Token(Token = "0x40217FC")]
			[FieldOffset(Offset = "0x10")]
			public string archiveId;
		}
	}
}
