using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007527 RID: 29991
	[Token(Token = "0x2007527")]
	public class Act25sideResearchMissionTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602A41F RID: 173087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A41F")]
		[Address(RVA = "0x25E45E0", Offset = "0x25E31E0", VA = "0x1825E45E0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006370 RID: 25456
		// (get) Token: 0x0602A420 RID: 173088 RVA: 0x000D7CE8 File Offset: 0x000D5EE8
		[Token(Token = "0x17006370")]
		public bool isShow
		{
			[Token(Token = "0x602A420")]
			[Address(RVA = "0x25E47A0", Offset = "0x25E33A0", VA = "0x1825E47A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A421 RID: 173089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A421")]
		[Address(RVA = "0x25E4740", Offset = "0x25E3340", VA = "0x1825E4740")]
		public Act25sideResearchMissionTrackPoint()
		{
		}

		// Token: 0x0403CC0B RID: 248843
		[Token(Token = "0x403CC0B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403CC0C RID: 248844
		[Token(Token = "0x403CC0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403CC0D RID: 248845
		[Token(Token = "0x403CC0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403CC0E RID: 248846
		[Token(Token = "0x403CC0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007528 RID: 29992
		[Token(Token = "0x2007528")]
		public class Param
		{
			// Token: 0x0602A422 RID: 173090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A422")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403CC0F RID: 248847
			[Token(Token = "0x403CC0F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403CC10 RID: 248848
			[Token(Token = "0x403CC10")]
			[FieldOffset(Offset = "0x18")]
			public string areaId;
		}
	}
}
