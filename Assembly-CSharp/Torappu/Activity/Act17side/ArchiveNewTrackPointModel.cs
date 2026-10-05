using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act17side
{
	// Token: 0x020079A9 RID: 31145
	[Token(Token = "0x20079A9")]
	public class ArchiveNewTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602BB0D RID: 178957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB0D")]
		[Address(RVA = "0x27A8A50", Offset = "0x27A7650", VA = "0x1827A8A50", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17006675 RID: 26229
		// (get) Token: 0x0602BB0E RID: 178958 RVA: 0x000DCE18 File Offset: 0x000DB018
		[Token(Token = "0x17006675")]
		public bool isShow
		{
			[Token(Token = "0x602BB0E")]
			[Address(RVA = "0x27A8BA0", Offset = "0x27A77A0", VA = "0x1827A8BA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BB0F RID: 178959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BB0F")]
		[Address(RVA = "0x27A8B40", Offset = "0x27A7740", VA = "0x1827A8B40")]
		public ArchiveNewTrackPointModel()
		{
		}

		// Token: 0x0403F35B RID: 258907
		[Token(Token = "0x403F35B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isNew;

		// Token: 0x0403F35C RID: 258908
		[Token(Token = "0x403F35C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403F35D RID: 258909
		[Token(Token = "0x403F35D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403F35E RID: 258910
		[Token(Token = "0x403F35E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020079AA RID: 31146
		[Token(Token = "0x20079AA")]
		public class Input
		{
			// Token: 0x0602BB10 RID: 178960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BB10")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F35F RID: 258911
			[Token(Token = "0x403F35F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
