using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200758C RID: 30092
	[Token(Token = "0x200758C")]
	public class Act24sideEntryMissionTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170063B1 RID: 25521
		// (get) Token: 0x0602A5CD RID: 173517 RVA: 0x000D8288 File Offset: 0x000D6488
		[Token(Token = "0x170063B1")]
		public bool isShow
		{
			[Token(Token = "0x602A5CD")]
			[Address(RVA = "0x2600DF0", Offset = "0x25FF9F0", VA = "0x182600DF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A5CE RID: 173518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5CE")]
		[Address(RVA = "0x2600CA0", Offset = "0x25FF8A0", VA = "0x182600CA0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602A5CF RID: 173519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5CF")]
		[Address(RVA = "0x2600D90", Offset = "0x25FF990", VA = "0x182600D90")]
		public Act24sideEntryMissionTrackPoint()
		{
		}

		// Token: 0x0403CF0E RID: 249614
		[Token(Token = "0x403CF0E")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403CF0F RID: 249615
		[Token(Token = "0x403CF0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403CF10 RID: 249616
		[Token(Token = "0x403CF10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403CF11 RID: 249617
		[Token(Token = "0x403CF11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200758D RID: 30093
		[Token(Token = "0x200758D")]
		public class Param
		{
			// Token: 0x0602A5D0 RID: 173520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403CF12 RID: 249618
			[Token(Token = "0x403CF12")]
			[FieldOffset(Offset = "0x10")]
			public Act24sideEntryMissionViewModel model;
		}
	}
}
