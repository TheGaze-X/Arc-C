using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006811 RID: 26641
	[Token(Token = "0x2006811")]
	public class SideStoryHaveTrailRewardTrackModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x060262CC RID: 156364 RVA: 0x000CA488 File Offset: 0x000C8688
		[Token(Token = "0x17005A44")]
		public bool isShow
		{
			[Token(Token = "0x60262CC")]
			[Address(RVA = "0x2134440", Offset = "0x2133040", VA = "0x182134440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060262CD RID: 156365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262CD")]
		[Address(RVA = "0x2134120", Offset = "0x2132D20", VA = "0x182134120", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060262CE RID: 156366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262CE")]
		[Address(RVA = "0x21343E0", Offset = "0x2132FE0", VA = "0x1821343E0")]
		public SideStoryHaveTrailRewardTrackModel()
		{
		}

		// Token: 0x04035C73 RID: 220275
		[Token(Token = "0x4035C73")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04035C74 RID: 220276
		[Token(Token = "0x4035C74")]
		[FieldOffset(Offset = "0x11")]
		private bool m_isSelect;

		// Token: 0x04035C75 RID: 220277
		[Token(Token = "0x4035C75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035C76 RID: 220278
		[Token(Token = "0x4035C76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04035C77 RID: 220279
		[Token(Token = "0x4035C77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006812 RID: 26642
		[Token(Token = "0x2006812")]
		public class Param
		{
			// Token: 0x060262CF RID: 156367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60262CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04035C78 RID: 220280
			[Token(Token = "0x4035C78")]
			[FieldOffset(Offset = "0x10")]
			public int currentCount;

			// Token: 0x04035C79 RID: 220281
			[Token(Token = "0x4035C79")]
			[FieldOffset(Offset = "0x14")]
			public bool isSelect;

			// Token: 0x04035C7A RID: 220282
			[Token(Token = "0x4035C7A")]
			[FieldOffset(Offset = "0x18")]
			public RetroTrailData trailData;
		}
	}
}
