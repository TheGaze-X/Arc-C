using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A1B RID: 31259
	[Token(Token = "0x2007A1B")]
	public class Act13sideMissionTrackViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BCF8 RID: 179448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCF8")]
		[Address(RVA = "0x27BB3D0", Offset = "0x27B9FD0", VA = "0x1827BB3D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x170066B7 RID: 26295
		// (get) Token: 0x0602BCF9 RID: 179449 RVA: 0x000DD4A8 File Offset: 0x000DB6A8
		[Token(Token = "0x170066B7")]
		public bool isShow
		{
			[Token(Token = "0x602BCF9")]
			[Address(RVA = "0x27BB520", Offset = "0x27BA120", VA = "0x1827BB520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BCFA RID: 179450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCFA")]
		[Address(RVA = "0x27BB4C0", Offset = "0x27BA0C0", VA = "0x1827BB4C0")]
		public Act13sideMissionTrackViewModel()
		{
		}

		// Token: 0x0403F638 RID: 259640
		[Token(Token = "0x403F638")]
		[FieldOffset(Offset = "0x10")]
		private bool m_showFlag;

		// Token: 0x0403F639 RID: 259641
		[Token(Token = "0x403F639")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F63A RID: 259642
		[Token(Token = "0x403F63A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F63B RID: 259643
		[Token(Token = "0x403F63B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A1C RID: 31260
		[Token(Token = "0x2007A1C")]
		public class Input
		{
			// Token: 0x0602BCFB RID: 179451 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BCFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F63C RID: 259644
			[Token(Token = "0x403F63C")]
			[FieldOffset(Offset = "0x10")]
			public bool showTrackViewModel;

			// Token: 0x0403F63D RID: 259645
			[Token(Token = "0x403F63D")]
			[FieldOffset(Offset = "0x11")]
			public bool isSelect;

			// Token: 0x0403F63E RID: 259646
			[Token(Token = "0x403F63E")]
			[FieldOffset(Offset = "0x12")]
			public bool isNew;
		}
	}
}
