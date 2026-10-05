using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF8 RID: 16120
	[Token(Token = "0x2003EF8")]
	public class SiracusaMapNavigationTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x0601907D RID: 102525 RVA: 0x0009CC90 File Offset: 0x0009AE90
		[Token(Token = "0x17003BC7")]
		public bool isShow
		{
			[Token(Token = "0x601907D")]
			[Address(RVA = "0x11B92C0", Offset = "0x11B7EC0", VA = "0x1811B92C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601907E RID: 102526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601907E")]
		[Address(RVA = "0x11B9190", Offset = "0x11B7D90", VA = "0x1811B9190", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601907F RID: 102527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601907F")]
		[Address(RVA = "0x11B9260", Offset = "0x11B7E60", VA = "0x1811B9260")]
		public SiracusaMapNavigationTrackPointModel()
		{
		}

		// Token: 0x0401EF14 RID: 126740
		[Token(Token = "0x401EF14")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0401EF15 RID: 126741
		[Token(Token = "0x401EF15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401EF16 RID: 126742
		[Token(Token = "0x401EF16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401EF17 RID: 126743
		[Token(Token = "0x401EF17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EF9 RID: 16121
		[Token(Token = "0x2003EF9")]
		public class Input
		{
			// Token: 0x06019080 RID: 102528 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019080")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401EF18 RID: 126744
			[Token(Token = "0x401EF18")]
			[FieldOffset(Offset = "0x10")]
			public bool isNew;
		}
	}
}
