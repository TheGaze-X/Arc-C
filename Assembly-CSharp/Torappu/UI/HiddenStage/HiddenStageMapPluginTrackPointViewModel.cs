using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA4 RID: 19620
	[Token(Token = "0x2004CA4")]
	public class HiddenStageMapPluginTrackPointViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004500 RID: 17664
		// (get) Token: 0x0601D697 RID: 120471 RVA: 0x000AB648 File Offset: 0x000A9848
		[Token(Token = "0x17004500")]
		public bool isShow
		{
			[Token(Token = "0x601D697")]
			[Address(RVA = "0x1709E70", Offset = "0x1708A70", VA = "0x181709E70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D698 RID: 120472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D698")]
		[Address(RVA = "0x1709D70", Offset = "0x1708970", VA = "0x181709D70", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D699 RID: 120473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D699")]
		[Address(RVA = "0x1709E10", Offset = "0x1708A10", VA = "0x181709E10")]
		public HiddenStageMapPluginTrackPointViewModel()
		{
		}

		// Token: 0x04026BA5 RID: 158629
		[Token(Token = "0x4026BA5")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasTrackPoint;

		// Token: 0x04026BA6 RID: 158630
		[Token(Token = "0x4026BA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026BA7 RID: 158631
		[Token(Token = "0x4026BA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026BA8 RID: 158632
		[Token(Token = "0x4026BA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
