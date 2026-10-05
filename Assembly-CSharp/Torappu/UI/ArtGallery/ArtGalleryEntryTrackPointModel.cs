using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006622 RID: 26146
	[Token(Token = "0x2006622")]
	public class ArtGalleryEntryTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x170058AF RID: 22703
		// (get) Token: 0x060258BF RID: 153791 RVA: 0x000C82F8 File Offset: 0x000C64F8
		[Token(Token = "0x170058AF")]
		public bool isShow
		{
			[Token(Token = "0x60258BF")]
			[Address(RVA = "0x2081EE0", Offset = "0x2080AE0", VA = "0x182081EE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060258C0 RID: 153792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258C0")]
		[Address(RVA = "0x2081D60", Offset = "0x2080960", VA = "0x182081D60", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060258C1 RID: 153793 RVA: 0x000C8310 File Offset: 0x000C6510
		[Token(Token = "0x60258C1")]
		[Address(RVA = "0x2081CC0", Offset = "0x20808C0", VA = "0x182081CC0")]
		public static bool GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x060258C2 RID: 153794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60258C2")]
		[Address(RVA = "0x2081E80", Offset = "0x2080A80", VA = "0x182081E80")]
		public ArtGalleryEntryTrackPointModel()
		{
		}

		// Token: 0x04034BFF RID: 216063
		[Token(Token = "0x4034BFF")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04034C00 RID: 216064
		[Token(Token = "0x4034C00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04034C01 RID: 216065
		[Token(Token = "0x4034C01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04034C02 RID: 216066
		[Token(Token = "0x4034C02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x04034C03 RID: 216067
		[Token(Token = "0x4034C03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
