using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006810 RID: 26640
	[Token(Token = "0x2006810")]
	public class Act21sideSideStoryViewModel : SideStoryViewModel
	{
		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x060262C7 RID: 156359 RVA: 0x000CA458 File Offset: 0x000C8658
		[Token(Token = "0x17005A43")]
		public override bool customZoneClick
		{
			[Token(Token = "0x60262C7")]
			[Address(RVA = "0x2130690", Offset = "0x212F290", VA = "0x182130690", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060262C8 RID: 156360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C8")]
		[Address(RVA = "0x21304C0", Offset = "0x212F0C0", VA = "0x1821304C0", Slot = "5")]
		public override void OnZoneClick(ZoneGroupViewModel zoneGroupModel, ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060262C9 RID: 156361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C9")]
		[Address(RVA = "0x2130630", Offset = "0x212F230", VA = "0x182130630")]
		public Act21sideSideStoryViewModel()
		{
		}

		// Token: 0x060262CA RID: 156362 RVA: 0x000CA470 File Offset: 0x000C8670
		[Token(Token = "0x60262CA")]
		[Address(RVA = "0x21303A0", Offset = "0x212EFA0", VA = "0x1821303A0")]
		private bool <>xLuaBaseProxy_get_customZoneClick()
		{
			return default(bool);
		}

		// Token: 0x060262CB RID: 156363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262CB")]
		[Address(RVA = "0x2130320", Offset = "0x212EF20", VA = "0x182130320")]
		private void <>xLuaBaseProxy_OnZoneClick(ZoneGroupViewModel P0, ZoneViewModel P1)
		{
		}

		// Token: 0x04035C70 RID: 220272
		[Token(Token = "0x4035C70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_customZoneClick;

		// Token: 0x04035C71 RID: 220273
		[Token(Token = "0x4035C71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnZoneClick;

		// Token: 0x04035C72 RID: 220274
		[Token(Token = "0x4035C72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
