using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BFC RID: 15356
	[Token(Token = "0x2003BFC")]
	public class UniequipArchiveCharacterTrackpoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0601803B RID: 98363 RVA: 0x00098EF8 File Offset: 0x000970F8
		[Token(Token = "0x17003943")]
		public bool isShow
		{
			[Token(Token = "0x601803B")]
			[Address(RVA = "0x108D2D0", Offset = "0x108BED0", VA = "0x18108D2D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601803C RID: 98364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601803C")]
		[Address(RVA = "0x108D190", Offset = "0x108BD90", VA = "0x18108D190", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601803D RID: 98365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601803D")]
		[Address(RVA = "0x108D270", Offset = "0x108BE70", VA = "0x18108D270")]
		public UniequipArchiveCharacterTrackpoint()
		{
		}

		// Token: 0x0401D1CA RID: 119242
		[Token(Token = "0x401D1CA")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0401D1CB RID: 119243
		[Token(Token = "0x401D1CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401D1CC RID: 119244
		[Token(Token = "0x401D1CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401D1CD RID: 119245
		[Token(Token = "0x401D1CD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BFD RID: 15357
		[Token(Token = "0x2003BFD")]
		public class Param
		{
			// Token: 0x0601803E RID: 98366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601803E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0401D1CE RID: 119246
			[Token(Token = "0x401D1CE")]
			[FieldOffset(Offset = "0x10")]
			public bool haveTrack;
		}
	}
}
