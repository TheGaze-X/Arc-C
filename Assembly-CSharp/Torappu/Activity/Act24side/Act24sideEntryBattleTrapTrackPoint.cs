using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200758A RID: 30090
	[Token(Token = "0x200758A")]
	public class Act24sideEntryBattleTrapTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x170063B0 RID: 25520
		// (get) Token: 0x0602A5C9 RID: 173513 RVA: 0x000D8270 File Offset: 0x000D6470
		[Token(Token = "0x170063B0")]
		public bool isShow
		{
			[Token(Token = "0x602A5C9")]
			[Address(RVA = "0x2600AA0", Offset = "0x25FF6A0", VA = "0x182600AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A5CA RID: 173514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5CA")]
		[Address(RVA = "0x2600940", Offset = "0x25FF540", VA = "0x182600940", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0602A5CB RID: 173515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5CB")]
		[Address(RVA = "0x2600A40", Offset = "0x25FF640", VA = "0x182600A40")]
		public Act24sideEntryBattleTrapTrackPoint()
		{
		}

		// Token: 0x0403CF09 RID: 249609
		[Token(Token = "0x403CF09")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403CF0A RID: 249610
		[Token(Token = "0x403CF0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403CF0B RID: 249611
		[Token(Token = "0x403CF0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403CF0C RID: 249612
		[Token(Token = "0x403CF0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200758B RID: 30091
		[Token(Token = "0x200758B")]
		public class Param
		{
			// Token: 0x0602A5CC RID: 173516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5CC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403CF0D RID: 249613
			[Token(Token = "0x403CF0D")]
			[FieldOffset(Offset = "0x10")]
			public Act24sideEntryBattleTrapViewModel model;
		}
	}
}
