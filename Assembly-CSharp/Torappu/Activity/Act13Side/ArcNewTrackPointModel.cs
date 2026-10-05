using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079E3 RID: 31203
	[Token(Token = "0x20079E3")]
	public class ArcNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BBEE RID: 179182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBEE")]
		[Address(RVA = "0x27A88A0", Offset = "0x27A74A0", VA = "0x1827A88A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700668E RID: 26254
		// (get) Token: 0x0602BBEF RID: 179183 RVA: 0x000DD268 File Offset: 0x000DB468
		[Token(Token = "0x1700668E")]
		public bool isShow
		{
			[Token(Token = "0x602BBEF")]
			[Address(RVA = "0x27A89F0", Offset = "0x27A75F0", VA = "0x1827A89F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BBF0 RID: 179184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBF0")]
		[Address(RVA = "0x27A8990", Offset = "0x27A7590", VA = "0x1827A8990")]
		public ArcNewTrackPointModel()
		{
		}

		// Token: 0x0403F497 RID: 259223
		[Token(Token = "0x403F497")]
		[FieldOffset(Offset = "0x10")]
		private bool isNew;

		// Token: 0x0403F498 RID: 259224
		[Token(Token = "0x403F498")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F499 RID: 259225
		[Token(Token = "0x403F499")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F49A RID: 259226
		[Token(Token = "0x403F49A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079E4 RID: 31204
		[Token(Token = "0x20079E4")]
		public class Input
		{
			// Token: 0x0602BBF1 RID: 179185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BBF1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F49B RID: 259227
			[Token(Token = "0x403F49B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
