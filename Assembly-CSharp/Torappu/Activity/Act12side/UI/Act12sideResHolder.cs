using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A69 RID: 31337
	[Token(Token = "0x2007A69")]
	public class Act12sideResHolder : ActivityResHolder
	{
		// Token: 0x170066E3 RID: 26339
		// (get) Token: 0x0602BE33 RID: 179763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E3")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602BE33")]
			[Address(RVA = "0x27C31A0", Offset = "0x27C1DA0", VA = "0x1827C31A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066E4 RID: 26340
		// (get) Token: 0x0602BE34 RID: 179764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E4")]
		public override Sprite homeSpriteMultiMode
		{
			[Token(Token = "0x602BE34")]
			[Address(RVA = "0x27C3100", Offset = "0x27C1D00", VA = "0x1827C3100", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170066E5 RID: 26341
		// (get) Token: 0x0602BE35 RID: 179765 RVA: 0x000DD958 File Offset: 0x000DBB58
		[Token(Token = "0x170066E5")]
		public override ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x602BE35")]
			[Address(RVA = "0x27C3260", Offset = "0x27C1E60", VA = "0x1827C3260", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x170066E6 RID: 26342
		// (get) Token: 0x0602BE36 RID: 179766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170066E6")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602BE36")]
			[Address(RVA = "0x27C3200", Offset = "0x27C1E00", VA = "0x1827C3200", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BE37 RID: 179767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE37")]
		[Address(RVA = "0x27C3050", Offset = "0x27C1C50", VA = "0x1827C3050")]
		public Act12sideResHolder()
		{
		}

		// Token: 0x0602BE38 RID: 179768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BE38")]
		[Address(RVA = "0x24A65F0", Offset = "0x24A51F0", VA = "0x1824A65F0")]
		private Sprite <>xLuaBaseProxy_get_homeSpriteMultiMode()
		{
			return null;
		}

		// Token: 0x0602BE39 RID: 179769 RVA: 0x000DD970 File Offset: 0x000DBB70
		[Token(Token = "0x602BE39")]
		[Address(RVA = "0x24A6600", Offset = "0x24A5200", VA = "0x1824A6600")]
		private ActivityResHolder.ZoneHomeRes <>xLuaBaseProxy_get_zoneHomeRes()
		{
			return default(ActivityResHolder.ZoneHomeRes);
		}

		// Token: 0x0403F8FB RID: 260347
		[Token(Token = "0x403F8FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403F8FC RID: 260348
		[Token(Token = "0x403F8FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeMultiSprite;

		// Token: 0x0403F8FD RID: 260349
		[Token(Token = "0x403F8FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityResHolder.ZoneHomeRes _zoneHome;

		// Token: 0x0403F8FE RID: 260350
		[Token(Token = "0x403F8FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403F8FF RID: 260351
		[Token(Token = "0x403F8FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSpriteMultiMode;

		// Token: 0x0403F900 RID: 260352
		[Token(Token = "0x403F900")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x0403F901 RID: 260353
		[Token(Token = "0x403F901")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403F902 RID: 260354
		[Token(Token = "0x403F902")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
