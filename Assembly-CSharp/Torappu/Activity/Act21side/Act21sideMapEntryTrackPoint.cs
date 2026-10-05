using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act21side
{
	// Token: 0x02007621 RID: 30241
	[Token(Token = "0x2007621")]
	public class Act21sideMapEntryTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602A934 RID: 174388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A934")]
		[Address(RVA = "0x265C9A0", Offset = "0x265B5A0", VA = "0x18265C9A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006429 RID: 25641
		// (get) Token: 0x0602A935 RID: 174389 RVA: 0x000D91B8 File Offset: 0x000D73B8
		[Token(Token = "0x17006429")]
		public bool isShow
		{
			[Token(Token = "0x602A935")]
			[Address(RVA = "0x265CAF0", Offset = "0x265B6F0", VA = "0x18265CAF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A936 RID: 174390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A936")]
		[Address(RVA = "0x265CA90", Offset = "0x265B690", VA = "0x18265CA90")]
		public Act21sideMapEntryTrackPoint()
		{
		}

		// Token: 0x0403D4C9 RID: 251081
		[Token(Token = "0x403D4C9")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D4CA RID: 251082
		[Token(Token = "0x403D4CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D4CB RID: 251083
		[Token(Token = "0x403D4CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D4CC RID: 251084
		[Token(Token = "0x403D4CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007622 RID: 30242
		[Token(Token = "0x2007622")]
		public class Input
		{
			// Token: 0x0602A937 RID: 174391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A937")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403D4CD RID: 251085
			[Token(Token = "0x403D4CD")]
			[FieldOffset(Offset = "0x10")]
			public bool isAllTimeout;

			// Token: 0x0403D4CE RID: 251086
			[Token(Token = "0x403D4CE")]
			[FieldOffset(Offset = "0x11")]
			public bool hasNewSign;
		}
	}
}
