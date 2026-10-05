using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act21side
{
	// Token: 0x02007623 RID: 30243
	[Token(Token = "0x2007623")]
	public class Act21sideMapOperaEntryTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602A938 RID: 174392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A938")]
		[Address(RVA = "0x265CDC0", Offset = "0x265B9C0", VA = "0x18265CDC0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700642A RID: 25642
		// (get) Token: 0x0602A939 RID: 174393 RVA: 0x000D91D0 File Offset: 0x000D73D0
		[Token(Token = "0x1700642A")]
		public bool isShow
		{
			[Token(Token = "0x602A939")]
			[Address(RVA = "0x265CF80", Offset = "0x265BB80", VA = "0x18265CF80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A93A RID: 174394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A93A")]
		[Address(RVA = "0x265CF20", Offset = "0x265BB20", VA = "0x18265CF20")]
		public Act21sideMapOperaEntryTrackPoint()
		{
		}

		// Token: 0x0403D4CF RID: 251087
		[Token(Token = "0x403D4CF")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D4D0 RID: 251088
		[Token(Token = "0x403D4D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D4D1 RID: 251089
		[Token(Token = "0x403D4D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D4D2 RID: 251090
		[Token(Token = "0x403D4D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007624 RID: 30244
		[Token(Token = "0x2007624")]
		public class Input
		{
			// Token: 0x0602A93B RID: 174395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A93B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403D4D3 RID: 251091
			[Token(Token = "0x403D4D3")]
			[FieldOffset(Offset = "0x10")]
			public bool isAllTimeout;
		}
	}
}
