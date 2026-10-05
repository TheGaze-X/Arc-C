using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200764F RID: 30287
	[Token(Token = "0x200764F")]
	public class Act20sideCartCompNewTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17006434 RID: 25652
		// (get) Token: 0x0602A9BA RID: 174522 RVA: 0x000D93F8 File Offset: 0x000D75F8
		[Token(Token = "0x17006434")]
		public bool isShow
		{
			[Token(Token = "0x602A9BA")]
			[Address(RVA = "0x2653A30", Offset = "0x2652630", VA = "0x182653A30", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A9BB RID: 174523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9BB")]
		[Address(RVA = "0x2653840", Offset = "0x2652440", VA = "0x182653840", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602A9BC RID: 174524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9BC")]
		[Address(RVA = "0x26539D0", Offset = "0x26525D0", VA = "0x1826539D0")]
		public Act20sideCartCompNewTrackPoint()
		{
		}

		// Token: 0x0403D596 RID: 251286
		[Token(Token = "0x403D596")]
		[FieldOffset(Offset = "0x10")]
		private string m_compId;

		// Token: 0x0403D597 RID: 251287
		[Token(Token = "0x403D597")]
		[FieldOffset(Offset = "0x18")]
		private bool m_haveNewFlag;

		// Token: 0x0403D598 RID: 251288
		[Token(Token = "0x403D598")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D599 RID: 251289
		[Token(Token = "0x403D599")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D59A RID: 251290
		[Token(Token = "0x403D59A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007650 RID: 30288
		[Token(Token = "0x2007650")]
		public class Param
		{
			// Token: 0x0602A9BD RID: 174525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A9BD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403D59B RID: 251291
			[Token(Token = "0x403D59B")]
			[FieldOffset(Offset = "0x10")]
			public string compId;
		}
	}
}
