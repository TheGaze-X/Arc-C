using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C0B RID: 15371
	[Token(Token = "0x2003C0B")]
	public class UniEquipArchiveEntryTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x060180A0 RID: 98464 RVA: 0x00099198 File Offset: 0x00097398
		[Token(Token = "0x1700396A")]
		public bool isShow
		{
			[Token(Token = "0x60180A0")]
			[Address(RVA = "0x107E950", Offset = "0x107D550", VA = "0x18107E950", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060180A1 RID: 98465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180A1")]
		[Address(RVA = "0x107E800", Offset = "0x107D400", VA = "0x18107E800", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060180A2 RID: 98466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180A2")]
		[Address(RVA = "0x107E8F0", Offset = "0x107D4F0", VA = "0x18107E8F0")]
		public UniEquipArchiveEntryTrackPointModel()
		{
		}

		// Token: 0x0401D27A RID: 119418
		[Token(Token = "0x401D27A")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0401D27B RID: 119419
		[Token(Token = "0x401D27B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401D27C RID: 119420
		[Token(Token = "0x401D27C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401D27D RID: 119421
		[Token(Token = "0x401D27D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
