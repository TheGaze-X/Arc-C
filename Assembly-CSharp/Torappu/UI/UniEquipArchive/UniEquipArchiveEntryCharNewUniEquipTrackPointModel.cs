using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003C0C RID: 15372
	[Token(Token = "0x2003C0C")]
	public class UniEquipArchiveEntryCharNewUniEquipTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x060180A3 RID: 98467 RVA: 0x000991B0 File Offset: 0x000973B0
		[Token(Token = "0x1700396B")]
		public bool isShow
		{
			[Token(Token = "0x60180A3")]
			[Address(RVA = "0x107A770", Offset = "0x1079370", VA = "0x18107A770", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060180A4 RID: 98468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180A4")]
		[Address(RVA = "0x107A4A0", Offset = "0x10790A0", VA = "0x18107A4A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060180A5 RID: 98469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60180A5")]
		[Address(RVA = "0x107A710", Offset = "0x1079310", VA = "0x18107A710")]
		public UniEquipArchiveEntryCharNewUniEquipTrackPointModel()
		{
		}

		// Token: 0x0401D27E RID: 119422
		[Token(Token = "0x401D27E")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0401D27F RID: 119423
		[Token(Token = "0x401D27F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401D280 RID: 119424
		[Token(Token = "0x401D280")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401D281 RID: 119425
		[Token(Token = "0x401D281")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
