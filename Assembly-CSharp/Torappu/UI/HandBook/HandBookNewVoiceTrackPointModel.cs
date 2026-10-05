using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066BB RID: 26299
	[Token(Token = "0x20066BB")]
	public class HandBookNewVoiceTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700597B RID: 22907
		// (get) Token: 0x06025C4E RID: 154702 RVA: 0x000C8FB8 File Offset: 0x000C71B8
		[Token(Token = "0x1700597B")]
		public bool isShow
		{
			[Token(Token = "0x6025C4E")]
			[Address(RVA = "0x20BDD40", Offset = "0x20BC940", VA = "0x1820BDD40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C4F RID: 154703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C4F")]
		[Address(RVA = "0x20BDC10", Offset = "0x20BC810", VA = "0x1820BDC10", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C50 RID: 154704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C50")]
		[Address(RVA = "0x20BDCE0", Offset = "0x20BC8E0", VA = "0x1820BDCE0")]
		public HandBookNewVoiceTrackPointModel()
		{
		}

		// Token: 0x0403518F RID: 217487
		[Token(Token = "0x403518F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x04035190 RID: 217488
		[Token(Token = "0x4035190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04035191 RID: 217489
		[Token(Token = "0x4035191")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04035192 RID: 217490
		[Token(Token = "0x4035192")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
