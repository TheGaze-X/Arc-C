using System;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x02003328 RID: 13096
	[Token(Token = "0x2003328")]
	public class TileInfoController
	{
		// Token: 0x06014D6E RID: 85358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D6E")]
		[Address(RVA = "0xD34A50", Offset = "0xD33650", VA = "0x180D34A50")]
		public void Reset()
		{
		}

		// Token: 0x06014D6F RID: 85359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D6F")]
		[Address(RVA = "0xD348C0", Offset = "0xD334C0", VA = "0x180D348C0")]
		public void OnBottomMaskDown()
		{
		}

		// Token: 0x06014D70 RID: 85360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D70")]
		[Address(RVA = "0xD34A40", Offset = "0xD33640", VA = "0x180D34A40")]
		public void OnBottomMaskUp()
		{
		}

		// Token: 0x06014D71 RID: 85361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D71")]
		[Address(RVA = "0xD34D40", Offset = "0xD33940", VA = "0x180D34D40")]
		private void _SelectTile(Tile tile)
		{
		}

		// Token: 0x06014D72 RID: 85362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D72")]
		[Address(RVA = "0xD34A40", Offset = "0xD33640", VA = "0x180D34A40")]
		private void _UnselectTile()
		{
		}

		// Token: 0x06014D73 RID: 85363 RVA: 0x00088D70 File Offset: 0x00086F70
		[Token(Token = "0x6014D73")]
		[Address(RVA = "0xD34B30", Offset = "0xD33730", VA = "0x180D34B30")]
		private bool _CheckStateValid(UIStateEnum state)
		{
			return default(bool);
		}

		// Token: 0x06014D74 RID: 85364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D74")]
		[Address(RVA = "0xD34B90", Offset = "0xD33790", VA = "0x180D34B90")]
		private void _ClearSelectedTile()
		{
		}

		// Token: 0x06014D75 RID: 85365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D75")]
		[Address(RVA = "0xD34C80", Offset = "0xD33880", VA = "0x180D34C80")]
		private void _OnUIStateChanged(object arg)
		{
		}

		// Token: 0x06014D76 RID: 85366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D76")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TileInfoController()
		{
		}

		// Token: 0x04018C6F RID: 101487
		[Token(Token = "0x4018C6F")]
		[FieldOffset(Offset = "0x10")]
		private Tile m_selectedTile;

		// Token: 0x04018C70 RID: 101488
		[Token(Token = "0x4018C70")]
		[FieldOffset(Offset = "0x18")]
		private int m_popupId;
	}
}
