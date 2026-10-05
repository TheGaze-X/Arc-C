using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007879 RID: 30841
	[Token(Token = "0x2007879")]
	public class Act1LockResHolder : ActivityResHolder
	{
		// Token: 0x17006522 RID: 25890
		// (get) Token: 0x0602B3A0 RID: 177056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006522")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602B3A0")]
			[Address(RVA = "0x270EBF0", Offset = "0x270D7F0", VA = "0x18270EBF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006523 RID: 25891
		// (get) Token: 0x0602B3A1 RID: 177057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006523")]
		public override Sprite homeSpriteMultiMode
		{
			[Token(Token = "0x602B3A1")]
			[Address(RVA = "0x270EB50", Offset = "0x270D750", VA = "0x18270EB50", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006524 RID: 25892
		// (get) Token: 0x0602B3A2 RID: 177058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006524")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602B3A2")]
			[Address(RVA = "0x270EC50", Offset = "0x270D850", VA = "0x18270EC50", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006525 RID: 25893
		// (get) Token: 0x0602B3A3 RID: 177059 RVA: 0x000DB360 File Offset: 0x000D9560
		[Token(Token = "0x17006525")]
		public override ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x602B3A3")]
			[Address(RVA = "0x270ECB0", Offset = "0x270D8B0", VA = "0x18270ECB0", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x0602B3A4 RID: 177060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B3A4")]
		[Address(RVA = "0x270EAA0", Offset = "0x270D6A0", VA = "0x18270EAA0")]
		public Act1LockResHolder()
		{
		}

		// Token: 0x0602B3A5 RID: 177061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B3A5")]
		[Address(RVA = "0x24A65F0", Offset = "0x24A51F0", VA = "0x1824A65F0")]
		private Sprite <>xLuaBaseProxy_get_homeSpriteMultiMode()
		{
			return null;
		}

		// Token: 0x0602B3A6 RID: 177062 RVA: 0x000DB378 File Offset: 0x000D9578
		[Token(Token = "0x602B3A6")]
		[Address(RVA = "0x24A6600", Offset = "0x24A5200", VA = "0x1824A6600")]
		private ActivityResHolder.ZoneHomeRes <>xLuaBaseProxy_get_zoneHomeRes()
		{
			return default(ActivityResHolder.ZoneHomeRes);
		}

		// Token: 0x0403E7D0 RID: 255952
		[Token(Token = "0x403E7D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403E7D1 RID: 255953
		[Token(Token = "0x403E7D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeMultiSprite;

		// Token: 0x0403E7D2 RID: 255954
		[Token(Token = "0x403E7D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityResHolder.ZoneHomeRes _zoneHome;

		// Token: 0x0403E7D3 RID: 255955
		[Token(Token = "0x403E7D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403E7D4 RID: 255956
		[Token(Token = "0x403E7D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSpriteMultiMode;

		// Token: 0x0403E7D5 RID: 255957
		[Token(Token = "0x403E7D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403E7D6 RID: 255958
		[Token(Token = "0x403E7D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x0403E7D7 RID: 255959
		[Token(Token = "0x403E7D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
