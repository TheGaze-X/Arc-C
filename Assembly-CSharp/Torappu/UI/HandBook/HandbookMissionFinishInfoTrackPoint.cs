using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066C1 RID: 26305
	[Token(Token = "0x20066C1")]
	public class HandbookMissionFinishInfoTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x06025C62 RID: 154722 RVA: 0x000C9060 File Offset: 0x000C7260
		[Token(Token = "0x1700597F")]
		public bool isShow
		{
			[Token(Token = "0x6025C62")]
			[Address(RVA = "0x20CBE00", Offset = "0x20CAA00", VA = "0x1820CBE00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C63 RID: 154723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C63")]
		[Address(RVA = "0x20CB7D0", Offset = "0x20CA3D0", VA = "0x1820CB7D0")]
		private Dictionary<string, HandBookCommonStateBean.HandBookTeamViewModel> _GetViewModelParam()
		{
			return null;
		}

		// Token: 0x06025C64 RID: 154724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C64")]
		[Address(RVA = "0x20CB4B0", Offset = "0x20CA0B0", VA = "0x1820CB4B0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C65 RID: 154725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C65")]
		[Address(RVA = "0x20CBDA0", Offset = "0x20CA9A0", VA = "0x1820CBDA0")]
		public HandbookMissionFinishInfoTrackPoint()
		{
		}

		// Token: 0x040351A8 RID: 217512
		[Token(Token = "0x40351A8")]
		[FieldOffset(Offset = "0x10")]
		private bool m_availFlag;

		// Token: 0x040351A9 RID: 217513
		[Token(Token = "0x40351A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040351AA RID: 217514
		[Token(Token = "0x40351AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetViewModelParam;

		// Token: 0x040351AB RID: 217515
		[Token(Token = "0x40351AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040351AC RID: 217516
		[Token(Token = "0x40351AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
