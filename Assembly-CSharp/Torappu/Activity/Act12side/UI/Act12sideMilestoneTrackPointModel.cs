using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A9D RID: 31389
	[Token(Token = "0x2007A9D")]
	public class Act12sideMilestoneTrackPointModel : IHotfixable, ITrackPointModel
	{
		// Token: 0x1700670F RID: 26383
		// (get) Token: 0x0602BF96 RID: 180118 RVA: 0x000DDC88 File Offset: 0x000DBE88
		[Token(Token = "0x1700670F")]
		public bool isShow
		{
			[Token(Token = "0x602BF96")]
			[Address(RVA = "0x27DE460", Offset = "0x27DD060", VA = "0x1827DE460", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BF97 RID: 180119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF97")]
		[Address(RVA = "0x27DE340", Offset = "0x27DCF40", VA = "0x1827DE340", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602BF98 RID: 180120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF98")]
		[Address(RVA = "0x27DE400", Offset = "0x27DD000", VA = "0x1827DE400")]
		public Act12sideMilestoneTrackPointModel()
		{
		}

		// Token: 0x0403FB1F RID: 260895
		[Token(Token = "0x403FB1F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403FB20 RID: 260896
		[Token(Token = "0x403FB20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403FB21 RID: 260897
		[Token(Token = "0x403FB21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403FB22 RID: 260898
		[Token(Token = "0x403FB22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
