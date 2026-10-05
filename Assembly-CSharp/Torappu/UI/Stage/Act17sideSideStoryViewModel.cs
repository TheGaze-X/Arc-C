using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200680F RID: 26639
	[Token(Token = "0x200680F")]
	public class Act17sideSideStoryViewModel : SideStoryViewModel
	{
		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x060262C2 RID: 156354 RVA: 0x000CA428 File Offset: 0x000C8628
		[Token(Token = "0x17005A42")]
		public override bool customZoneClick
		{
			[Token(Token = "0x60262C2")]
			[Address(RVA = "0x2130460", Offset = "0x212F060", VA = "0x182130460", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060262C3 RID: 156355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C3")]
		[Address(RVA = "0x2130150", Offset = "0x212ED50", VA = "0x182130150", Slot = "5")]
		public override void OnZoneClick(ZoneGroupViewModel zoneGroupModel, ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060262C4 RID: 156356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C4")]
		[Address(RVA = "0x2130400", Offset = "0x212F000", VA = "0x182130400")]
		public Act17sideSideStoryViewModel()
		{
		}

		// Token: 0x060262C5 RID: 156357 RVA: 0x000CA440 File Offset: 0x000C8640
		[Token(Token = "0x60262C5")]
		[Address(RVA = "0x21303A0", Offset = "0x212EFA0", VA = "0x1821303A0")]
		private bool <>xLuaBaseProxy_get_customZoneClick()
		{
			return default(bool);
		}

		// Token: 0x060262C6 RID: 156358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262C6")]
		[Address(RVA = "0x2130320", Offset = "0x212EF20", VA = "0x182130320")]
		private void <>xLuaBaseProxy_OnZoneClick(ZoneGroupViewModel P0, ZoneViewModel P1)
		{
		}

		// Token: 0x04035C6D RID: 220269
		[Token(Token = "0x4035C6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_customZoneClick;

		// Token: 0x04035C6E RID: 220270
		[Token(Token = "0x4035C6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnZoneClick;

		// Token: 0x04035C6F RID: 220271
		[Token(Token = "0x4035C6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
