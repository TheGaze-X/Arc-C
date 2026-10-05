using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066BC RID: 26300
	[Token(Token = "0x20066BC")]
	public class HandBookUpdatedTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700597C RID: 22908
		// (get) Token: 0x06025C51 RID: 154705 RVA: 0x000C8FD0 File Offset: 0x000C71D0
		[Token(Token = "0x1700597C")]
		public bool isShow
		{
			[Token(Token = "0x6025C51")]
			[Address(RVA = "0x20BE8F0", Offset = "0x20BD4F0", VA = "0x1820BE8F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C52 RID: 154706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C52")]
		[Address(RVA = "0x20BE7D0", Offset = "0x20BD3D0", VA = "0x1820BE7D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C53 RID: 154707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C53")]
		[Address(RVA = "0x20BE890", Offset = "0x20BD490", VA = "0x1820BE890")]
		public HandBookUpdatedTrackPointModel()
		{
		}

		// Token: 0x04035193 RID: 217491
		[Token(Token = "0x4035193")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04035194 RID: 217492
		[Token(Token = "0x4035194")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035195 RID: 217493
		[Token(Token = "0x4035195")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04035196 RID: 217494
		[Token(Token = "0x4035196")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
