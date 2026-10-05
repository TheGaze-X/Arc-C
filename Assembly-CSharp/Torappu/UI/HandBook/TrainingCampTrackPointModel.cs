using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066BE RID: 26302
	[Token(Token = "0x20066BE")]
	public class TrainingCampTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700597E RID: 22910
		// (get) Token: 0x06025C57 RID: 154711 RVA: 0x000C9000 File Offset: 0x000C7200
		[Token(Token = "0x1700597E")]
		public bool isShow
		{
			[Token(Token = "0x6025C57")]
			[Address(RVA = "0x20CC170", Offset = "0x20CAD70", VA = "0x1820CC170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025C58 RID: 154712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C58")]
		[Address(RVA = "0x20CBFF0", Offset = "0x20CABF0", VA = "0x1820CBFF0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x06025C59 RID: 154713 RVA: 0x000C9018 File Offset: 0x000C7218
		[Token(Token = "0x6025C59")]
		[Address(RVA = "0x20CBF50", Offset = "0x20CAB50", VA = "0x1820CBF50")]
		public static bool GetShowFlag()
		{
			return default(bool);
		}

		// Token: 0x06025C5A RID: 154714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C5A")]
		[Address(RVA = "0x20CC110", Offset = "0x20CAD10", VA = "0x1820CC110")]
		public TrainingCampTrackPointModel()
		{
		}

		// Token: 0x0403519B RID: 217499
		[Token(Token = "0x403519B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403519C RID: 217500
		[Token(Token = "0x403519C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403519D RID: 217501
		[Token(Token = "0x403519D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403519E RID: 217502
		[Token(Token = "0x403519E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShowFlag;

		// Token: 0x0403519F RID: 217503
		[Token(Token = "0x403519F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
