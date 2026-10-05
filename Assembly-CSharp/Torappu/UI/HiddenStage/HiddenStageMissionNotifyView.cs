using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CAB RID: 19627
	[Token(Token = "0x2004CAB")]
	public abstract class HiddenStageMissionNotifyView : UINotifyView<HiddenStageMissionNotifyView.Param>
	{
		// Token: 0x0601D6B6 RID: 120502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B6")]
		[Address(RVA = "0x1709ED0", Offset = "0x1708AD0", VA = "0x181709ED0", Slot = "9")]
		protected override void Render(HiddenStageMissionNotifyView.Param param)
		{
		}

		// Token: 0x0601D6B7 RID: 120503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6B7")]
		[Address(RVA = "0x1709F60", Offset = "0x1708B60", VA = "0x181709F60")]
		protected HiddenStageMissionNotifyView()
		{
		}

		// Token: 0x04026BFC RID: 158716
		[Token(Token = "0x4026BFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026BFD RID: 158717
		[Token(Token = "0x4026BFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CAC RID: 19628
		[Token(Token = "0x2004CAC")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0601D6B8 RID: 120504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D6B8")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04026BFE RID: 158718
			[Token(Token = "0x4026BFE")]
			[FieldOffset(Offset = "0x10")]
			public HiddenStageMissionPushMsg payLoad;

			// Token: 0x04026BFF RID: 158719
			[Token(Token = "0x4026BFF")]
			[FieldOffset(Offset = "0x20")]
			public string funcId;
		}
	}
}
