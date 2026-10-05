using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079E7 RID: 31207
	[Token(Token = "0x20079E7")]
	public class Act13sideMissionTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BBF9 RID: 179193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF9")]
		[Address(RVA = "0x279C6A0", Offset = "0x279B2A0", VA = "0x18279C6A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700668F RID: 26255
		// (get) Token: 0x0602BBFA RID: 179194 RVA: 0x000DD280 File Offset: 0x000DB480
		[Token(Token = "0x1700668F")]
		public bool isShow
		{
			[Token(Token = "0x602BBFA")]
			[Address(RVA = "0x279CA70", Offset = "0x279B670", VA = "0x18279CA70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BBFB RID: 179195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBFB")]
		[Address(RVA = "0x279CA10", Offset = "0x279B610", VA = "0x18279CA10")]
		public Act13sideMissionTrackPointModel()
		{
		}

		// Token: 0x0403F4B2 RID: 259250
		[Token(Token = "0x403F4B2")]
		[FieldOffset(Offset = "0x10")]
		private bool hasTrackPoint;

		// Token: 0x0403F4B3 RID: 259251
		[Token(Token = "0x403F4B3")]
		[FieldOffset(Offset = "0x11")]
		private bool isNew;

		// Token: 0x0403F4B4 RID: 259252
		[Token(Token = "0x403F4B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F4B5 RID: 259253
		[Token(Token = "0x403F4B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F4B6 RID: 259254
		[Token(Token = "0x403F4B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079E8 RID: 31208
		[Token(Token = "0x20079E8")]
		public class Input
		{
			// Token: 0x0602BBFC RID: 179196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BBFC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F4B7 RID: 259255
			[Token(Token = "0x403F4B7")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403F4B8 RID: 259256
			[Token(Token = "0x403F4B8")]
			[FieldOffset(Offset = "0x18")]
			public bool haveAbleToGetMission;

			// Token: 0x0403F4B9 RID: 259257
			[Token(Token = "0x403F4B9")]
			[FieldOffset(Offset = "0x19")]
			public bool isInTime;
		}
	}
}
