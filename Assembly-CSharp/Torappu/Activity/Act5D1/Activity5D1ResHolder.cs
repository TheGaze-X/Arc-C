using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007221 RID: 29217
	[Token(Token = "0x2007221")]
	public class Activity5D1ResHolder : ActivityResHolder
	{
		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x0602969C RID: 169628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006217")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602969C")]
			[Address(RVA = "0x24D2F90", Offset = "0x24D1B90", VA = "0x1824D2F90", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x0602969D RID: 169629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006218")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602969D")]
			[Address(RVA = "0x24D2F30", Offset = "0x24D1B30", VA = "0x1824D2F30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x0602969E RID: 169630 RVA: 0x000D59D8 File Offset: 0x000D3BD8
		[Token(Token = "0x17006219")]
		public override ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x602969E")]
			[Address(RVA = "0x24D2FF0", Offset = "0x24D1BF0", VA = "0x1824D2FF0", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x0602969F RID: 169631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602969F")]
		[Address(RVA = "0x24D2ED0", Offset = "0x24D1AD0", VA = "0x1824D2ED0")]
		public Activity5D1ResHolder()
		{
		}

		// Token: 0x060296A0 RID: 169632 RVA: 0x000D59F0 File Offset: 0x000D3BF0
		[Token(Token = "0x60296A0")]
		[Address(RVA = "0x24A6600", Offset = "0x24A5200", VA = "0x1824A6600")]
		private ActivityResHolder.ZoneHomeRes <>xLuaBaseProxy_get_zoneHomeRes()
		{
			return default(ActivityResHolder.ZoneHomeRes);
		}

		// Token: 0x0403B24A RID: 242250
		[Token(Token = "0x403B24A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403B24B RID: 242251
		[Token(Token = "0x403B24B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _zoneTabSprite;

		// Token: 0x0403B24C RID: 242252
		[Token(Token = "0x403B24C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityResHolder.ZoneHomeRes _zoneHomeRes;

		// Token: 0x0403B24D RID: 242253
		[Token(Token = "0x403B24D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403B24E RID: 242254
		[Token(Token = "0x403B24E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403B24F RID: 242255
		[Token(Token = "0x403B24F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x0403B250 RID: 242256
		[Token(Token = "0x403B250")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
