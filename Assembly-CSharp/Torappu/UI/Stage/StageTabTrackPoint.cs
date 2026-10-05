using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069C2 RID: 27074
	[Token(Token = "0x20069C2")]
	public class StageTabTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x17005B71 RID: 23409
		// (get) Token: 0x06026BDC RID: 158684 RVA: 0x000CC240 File Offset: 0x000CA440
		[Token(Token = "0x17005B71")]
		public bool isShow
		{
			[Token(Token = "0x6026BDC")]
			[Address(RVA = "0x21D7EF0", Offset = "0x21D6AF0", VA = "0x1821D7EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026BDD RID: 158685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BDD")]
		[Address(RVA = "0x21D7320", Offset = "0x21D5F20", VA = "0x1821D7320", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06026BDE RID: 158686 RVA: 0x000CC258 File Offset: 0x000CA458
		[Token(Token = "0x6026BDE")]
		[Address(RVA = "0x21D7C50", Offset = "0x21D6850", VA = "0x1821D7C50")]
		private bool _TryFindRetroAvailFlag()
		{
			return default(bool);
		}

		// Token: 0x06026BDF RID: 158687 RVA: 0x000CC270 File Offset: 0x000CA470
		[Token(Token = "0x6026BDF")]
		[Address(RVA = "0x21D7700", Offset = "0x21D6300", VA = "0x1821D7700")]
		private bool _TryFindMiniAvailFlag()
		{
			return default(bool);
		}

		// Token: 0x06026BE0 RID: 158688 RVA: 0x000CC288 File Offset: 0x000CA488
		[Token(Token = "0x6026BE0")]
		[Address(RVA = "0x21D7AB0", Offset = "0x21D66B0", VA = "0x1821D7AB0")]
		private bool _TryFindRecalRuneFlag()
		{
			return default(bool);
		}

		// Token: 0x06026BE1 RID: 158689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026BE1")]
		[Address(RVA = "0x21D7E90", Offset = "0x21D6A90", VA = "0x1821D7E90")]
		public StageTabTrackPoint()
		{
		}

		// Token: 0x04036B51 RID: 224081
		[Token(Token = "0x4036B51")]
		[FieldOffset(Offset = "0x10")]
		private bool m_haveRewardFlag;

		// Token: 0x04036B52 RID: 224082
		[Token(Token = "0x4036B52")]
		[FieldOffset(Offset = "0x11")]
		private bool m_isSelect;

		// Token: 0x04036B53 RID: 224083
		[Token(Token = "0x4036B53")]
		[FieldOffset(Offset = "0x12")]
		private bool m_isHasCheckTrack;

		// Token: 0x04036B54 RID: 224084
		[Token(Token = "0x4036B54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04036B55 RID: 224085
		[Token(Token = "0x4036B55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04036B56 RID: 224086
		[Token(Token = "0x4036B56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryFindRetroAvailFlag;

		// Token: 0x04036B57 RID: 224087
		[Token(Token = "0x4036B57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryFindMiniAvailFlag;

		// Token: 0x04036B58 RID: 224088
		[Token(Token = "0x4036B58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryFindRecalRuneFlag;

		// Token: 0x04036B59 RID: 224089
		[Token(Token = "0x4036B59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020069C3 RID: 27075
		[Token(Token = "0x20069C3")]
		public class Param
		{
			// Token: 0x06026BE2 RID: 158690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026BE2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04036B5A RID: 224090
			[Token(Token = "0x4036B5A")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelect;

			// Token: 0x04036B5B RID: 224091
			[Token(Token = "0x4036B5B")]
			[FieldOffset(Offset = "0x14")]
			public ZoneViewType zoneViewType;
		}
	}
}
