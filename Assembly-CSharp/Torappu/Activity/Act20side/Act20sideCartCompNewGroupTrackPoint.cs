using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007651 RID: 30289
	[Token(Token = "0x2007651")]
	public class Act20sideCartCompNewGroupTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006435 RID: 25653
		// (get) Token: 0x0602A9BE RID: 174526 RVA: 0x000D9410 File Offset: 0x000D7610
		[Token(Token = "0x17006435")]
		public bool isShow
		{
			[Token(Token = "0x602A9BE")]
			[Address(RVA = "0x26537E0", Offset = "0x26523E0", VA = "0x1826537E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A9BF RID: 174527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9BF")]
		[Address(RVA = "0x26535C0", Offset = "0x26521C0", VA = "0x1826535C0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602A9C0 RID: 174528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9C0")]
		[Address(RVA = "0x2653780", Offset = "0x2652380", VA = "0x182653780")]
		public Act20sideCartCompNewGroupTrackPoint()
		{
		}

		// Token: 0x0403D59C RID: 251292
		[Token(Token = "0x403D59C")]
		[FieldOffset(Offset = "0x10")]
		private bool m_haveNewFlag;

		// Token: 0x0403D59D RID: 251293
		[Token(Token = "0x403D59D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D59E RID: 251294
		[Token(Token = "0x403D59E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D59F RID: 251295
		[Token(Token = "0x403D59F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
