using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079E9 RID: 31209
	[Token(Token = "0x20079E9")]
	public class Act13sideMissionNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BBFD RID: 179197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBFD")]
		[Address(RVA = "0x279C500", Offset = "0x279B100", VA = "0x18279C500", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006690 RID: 26256
		// (get) Token: 0x0602BBFE RID: 179198 RVA: 0x000DD298 File Offset: 0x000DB498
		[Token(Token = "0x17006690")]
		public bool isShow
		{
			[Token(Token = "0x602BBFE")]
			[Address(RVA = "0x279C640", Offset = "0x279B240", VA = "0x18279C640", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BBFF RID: 179199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBFF")]
		[Address(RVA = "0x279C5E0", Offset = "0x279B1E0", VA = "0x18279C5E0")]
		public Act13sideMissionNewTrackPointModel()
		{
		}

		// Token: 0x0403F4BA RID: 259258
		[Token(Token = "0x403F4BA")]
		[FieldOffset(Offset = "0x10")]
		private bool isNew;

		// Token: 0x0403F4BB RID: 259259
		[Token(Token = "0x403F4BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F4BC RID: 259260
		[Token(Token = "0x403F4BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F4BD RID: 259261
		[Token(Token = "0x403F4BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079EA RID: 31210
		[Token(Token = "0x20079EA")]
		public class Input
		{
			// Token: 0x0602BC00 RID: 179200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BC00")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F4BE RID: 259262
			[Token(Token = "0x403F4BE")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403F4BF RID: 259263
			[Token(Token = "0x403F4BF")]
			[FieldOffset(Offset = "0x18")]
			public bool isInTime;
		}
	}
}
