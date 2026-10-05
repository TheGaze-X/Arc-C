using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A19 RID: 31257
	[Token(Token = "0x2007A19")]
	public class Act13sideLongTermMissionTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BCF4 RID: 179444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCF4")]
		[Address(RVA = "0x27B6B30", Offset = "0x27B5730", VA = "0x1827B6B30", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x170066B6 RID: 26294
		// (get) Token: 0x0602BCF5 RID: 179445 RVA: 0x000DD490 File Offset: 0x000DB690
		[Token(Token = "0x170066B6")]
		public bool isShow
		{
			[Token(Token = "0x602BCF5")]
			[Address(RVA = "0x27B6C60", Offset = "0x27B5860", VA = "0x1827B6C60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BCF6 RID: 179446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCF6")]
		[Address(RVA = "0x27B6C00", Offset = "0x27B5800", VA = "0x1827B6C00")]
		public Act13sideLongTermMissionTrackPoint()
		{
		}

		// Token: 0x0403F632 RID: 259634
		[Token(Token = "0x403F632")]
		[FieldOffset(Offset = "0x10")]
		private bool hasTrackPoint;

		// Token: 0x0403F633 RID: 259635
		[Token(Token = "0x403F633")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F634 RID: 259636
		[Token(Token = "0x403F634")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F635 RID: 259637
		[Token(Token = "0x403F635")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A1A RID: 31258
		[Token(Token = "0x2007A1A")]
		public class Input
		{
			// Token: 0x0602BCF7 RID: 179447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BCF7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F636 RID: 259638
			[Token(Token = "0x403F636")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403F637 RID: 259639
			[Token(Token = "0x403F637")]
			[FieldOffset(Offset = "0x18")]
			public bool haveAbleToGetMission;
		}
	}
}
