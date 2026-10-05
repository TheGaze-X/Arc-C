using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A1D RID: 31261
	[Token(Token = "0x2007A1D")]
	public class Act13sideOrgNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BCFC RID: 179452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCFC")]
		[Address(RVA = "0x27BCC70", Offset = "0x27BB870", VA = "0x1827BCC70", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x170066B8 RID: 26296
		// (get) Token: 0x0602BCFD RID: 179453 RVA: 0x000DD4C0 File Offset: 0x000DB6C0
		[Token(Token = "0x170066B8")]
		public bool isShow
		{
			[Token(Token = "0x602BCFD")]
			[Address(RVA = "0x27BCDA0", Offset = "0x27BB9A0", VA = "0x1827BCDA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BCFE RID: 179454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCFE")]
		[Address(RVA = "0x27BCD40", Offset = "0x27BB940", VA = "0x1827BCD40")]
		public Act13sideOrgNewTrackPointModel()
		{
		}

		// Token: 0x0403F63F RID: 259647
		[Token(Token = "0x403F63F")]
		[FieldOffset(Offset = "0x10")]
		private bool isNew;

		// Token: 0x0403F640 RID: 259648
		[Token(Token = "0x403F640")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F641 RID: 259649
		[Token(Token = "0x403F641")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F642 RID: 259650
		[Token(Token = "0x403F642")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A1E RID: 31262
		[Token(Token = "0x2007A1E")]
		public class Input
		{
			// Token: 0x0602BCFF RID: 179455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BCFF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F643 RID: 259651
			[Token(Token = "0x403F643")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403F644 RID: 259652
			[Token(Token = "0x403F644")]
			[FieldOffset(Offset = "0x18")]
			public bool isNew;
		}
	}
}
