using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004565 RID: 17765
	[Token(Token = "0x2004565")]
	public class RoguelikeBpRewardAvailTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x0601B11D RID: 110877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B11D")]
		[Address(RVA = "0x1431430", Offset = "0x1430030", VA = "0x181431430", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x17004083 RID: 16515
		// (get) Token: 0x0601B11E RID: 110878 RVA: 0x000A4298 File Offset: 0x000A2498
		[Token(Token = "0x17004083")]
		public bool isShow
		{
			[Token(Token = "0x601B11E")]
			[Address(RVA = "0x14317C0", Offset = "0x14303C0", VA = "0x1814317C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B11F RID: 110879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B11F")]
		[Address(RVA = "0x1431760", Offset = "0x1430360", VA = "0x181431760")]
		public RoguelikeBpRewardAvailTrackPointViewModel()
		{
		}

		// Token: 0x04022CAB RID: 142507
		[Token(Token = "0x4022CAB")]
		[FieldOffset(Offset = "0x10")]
		private string m_cacheTopicId;

		// Token: 0x04022CAC RID: 142508
		[Token(Token = "0x4022CAC")]
		[FieldOffset(Offset = "0x18")]
		private bool m_isAble;

		// Token: 0x04022CAD RID: 142509
		[Token(Token = "0x4022CAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04022CAE RID: 142510
		[Token(Token = "0x4022CAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04022CAF RID: 142511
		[Token(Token = "0x4022CAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004566 RID: 17766
		[Token(Token = "0x2004566")]
		public class Input
		{
			// Token: 0x0601B120 RID: 110880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B120")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04022CB0 RID: 142512
			[Token(Token = "0x4022CB0")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
