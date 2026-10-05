using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act21side
{
	// Token: 0x02007625 RID: 30245
	[Token(Token = "0x2007625")]
	public class Act21sideMapOperaEntryLikeTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602A93C RID: 174396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A93C")]
		[Address(RVA = "0x265CB50", Offset = "0x265B750", VA = "0x18265CB50", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700642B RID: 25643
		// (get) Token: 0x0602A93D RID: 174397 RVA: 0x000D91E8 File Offset: 0x000D73E8
		[Token(Token = "0x1700642B")]
		public bool isShow
		{
			[Token(Token = "0x602A93D")]
			[Address(RVA = "0x265CD60", Offset = "0x265B960", VA = "0x18265CD60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A93E RID: 174398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A93E")]
		[Address(RVA = "0x265CD00", Offset = "0x265B900", VA = "0x18265CD00")]
		public Act21sideMapOperaEntryLikeTrackPoint()
		{
		}

		// Token: 0x0403D4D4 RID: 251092
		[Token(Token = "0x403D4D4")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D4D5 RID: 251093
		[Token(Token = "0x403D4D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D4D6 RID: 251094
		[Token(Token = "0x403D4D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D4D7 RID: 251095
		[Token(Token = "0x403D4D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007626 RID: 30246
		[Token(Token = "0x2007626")]
		public class Input
		{
			// Token: 0x0602A93F RID: 174399 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A93F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403D4D8 RID: 251096
			[Token(Token = "0x403D4D8")]
			[FieldOffset(Offset = "0x10")]
			public bool isAllTimeout;
		}
	}
}
