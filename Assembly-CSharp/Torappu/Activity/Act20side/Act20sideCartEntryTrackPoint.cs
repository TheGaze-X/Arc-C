using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x020076A3 RID: 30371
	[Token(Token = "0x20076A3")]
	public class Act20sideCartEntryTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602AB45 RID: 174917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB45")]
		[Address(RVA = "0x266FD70", Offset = "0x266E970", VA = "0x18266FD70", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006456 RID: 25686
		// (get) Token: 0x0602AB46 RID: 174918 RVA: 0x000D9788 File Offset: 0x000D7988
		[Token(Token = "0x17006456")]
		public bool isShow
		{
			[Token(Token = "0x602AB46")]
			[Address(RVA = "0x266FEF0", Offset = "0x266EAF0", VA = "0x18266FEF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB47 RID: 174919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB47")]
		[Address(RVA = "0x266FE90", Offset = "0x266EA90", VA = "0x18266FE90")]
		public Act20sideCartEntryTrackPoint()
		{
		}

		// Token: 0x0403D8A3 RID: 252067
		[Token(Token = "0x403D8A3")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D8A4 RID: 252068
		[Token(Token = "0x403D8A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D8A5 RID: 252069
		[Token(Token = "0x403D8A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D8A6 RID: 252070
		[Token(Token = "0x403D8A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020076A4 RID: 30372
		[Token(Token = "0x20076A4")]
		public class Param
		{
			// Token: 0x0602AB48 RID: 174920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AB48")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403D8A7 RID: 252071
			[Token(Token = "0x403D8A7")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403D8A8 RID: 252072
			[Token(Token = "0x403D8A8")]
			[FieldOffset(Offset = "0x18")]
			public bool isAccessible;

			// Token: 0x0403D8A9 RID: 252073
			[Token(Token = "0x403D8A9")]
			[FieldOffset(Offset = "0x19")]
			public bool isNewUnlocked;
		}
	}
}
