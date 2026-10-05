using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071E9 RID: 29161
	[Token(Token = "0x20071E9")]
	public class Activity5D0ResHolder : ActivityResHolder, IHotfixable
	{
		// Token: 0x17006202 RID: 25090
		// (get) Token: 0x060295DD RID: 169437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006202")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x60295DD")]
			[Address(RVA = "0x24BE750", Offset = "0x24BD350", VA = "0x1824BE750", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006203 RID: 25091
		// (get) Token: 0x060295DE RID: 169438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006203")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x60295DE")]
			[Address(RVA = "0x24BE6F0", Offset = "0x24BD2F0", VA = "0x1824BE6F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006204 RID: 25092
		// (get) Token: 0x060295DF RID: 169439 RVA: 0x000D57C8 File Offset: 0x000D39C8
		[Token(Token = "0x17006204")]
		public override ActivityResHolder.ZoneHomeRes zoneHomeRes
		{
			[Token(Token = "0x60295DF")]
			[Address(RVA = "0x24BE7B0", Offset = "0x24BD3B0", VA = "0x1824BE7B0", Slot = "7")]
			get
			{
				return default(ActivityResHolder.ZoneHomeRes);
			}
		}

		// Token: 0x060295E0 RID: 169440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295E0")]
		[Address(RVA = "0x24BE690", Offset = "0x24BD290", VA = "0x1824BE690")]
		public Activity5D0ResHolder()
		{
		}

		// Token: 0x060295E1 RID: 169441 RVA: 0x000D57E0 File Offset: 0x000D39E0
		[Token(Token = "0x60295E1")]
		[Address(RVA = "0x24A6600", Offset = "0x24A5200", VA = "0x1824A6600")]
		private ActivityResHolder.ZoneHomeRes <>xLuaBaseProxy_get_zoneHomeRes()
		{
			return default(ActivityResHolder.ZoneHomeRes);
		}

		// Token: 0x0403B13A RID: 241978
		[Token(Token = "0x403B13A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403B13B RID: 241979
		[Token(Token = "0x403B13B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _zoneTabSprite;

		// Token: 0x0403B13C RID: 241980
		[Token(Token = "0x403B13C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActivityResHolder.ZoneHomeRes _zoneHomeRes;

		// Token: 0x0403B13D RID: 241981
		[Token(Token = "0x403B13D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403B13E RID: 241982
		[Token(Token = "0x403B13E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403B13F RID: 241983
		[Token(Token = "0x403B13F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_zoneHomeRes;

		// Token: 0x0403B140 RID: 241984
		[Token(Token = "0x403B140")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
