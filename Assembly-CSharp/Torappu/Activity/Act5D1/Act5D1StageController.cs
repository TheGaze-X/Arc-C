using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007212 RID: 29202
	[Token(Token = "0x2007212")]
	public class Act5D1StageController : ActivityStageController
	{
		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x0602967D RID: 169597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006213")]
		public static string staticActivityId
		{
			[Token(Token = "0x602967D")]
			[Address(RVA = "0x24D1E70", Offset = "0x24D0A70", VA = "0x1824D1E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x0602967E RID: 169598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006214")]
		public Act5D1InitMeta initMetaObj
		{
			[Token(Token = "0x602967E")]
			[Address(RVA = "0x24D1DC0", Offset = "0x24D09C0", VA = "0x1824D1DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602967F RID: 169599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602967F")]
		[Address(RVA = "0x24D1C90", Offset = "0x24D0890", VA = "0x1824D1C90", Slot = "13")]
		protected override void OnStageTimeout()
		{
		}

		// Token: 0x06029680 RID: 169600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029680")]
		[Address(RVA = "0x24D1A90", Offset = "0x24D0690", VA = "0x1824D1A90", Slot = "14")]
		protected override void OnRewardTimeout()
		{
		}

		// Token: 0x06029681 RID: 169601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029681")]
		[Address(RVA = "0x24D19F0", Offset = "0x24D05F0", VA = "0x1824D19F0", Slot = "5")]
		protected override ActivityStageBridge CreateBridge()
		{
			return null;
		}

		// Token: 0x06029682 RID: 169602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029682")]
		[Address(RVA = "0x24D1D60", Offset = "0x24D0960", VA = "0x1824D1D60")]
		public Act5D1StageController()
		{
		}

		// Token: 0x06029683 RID: 169603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029683")]
		[Address(RVA = "0x22DB6C0", Offset = "0x22DA2C0", VA = "0x1822DB6C0")]
		private void <>xLuaBaseProxy_OnStageTimeout()
		{
		}

		// Token: 0x06029684 RID: 169604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029684")]
		[Address(RVA = "0x247CFA0", Offset = "0x247BBA0", VA = "0x18247CFA0")]
		private void <>xLuaBaseProxy_OnRewardTimeout()
		{
		}

		// Token: 0x0403B21D RID: 242205
		[Token(Token = "0x403B21D")]
		[FieldOffset(Offset = "0x60")]
		private Act5D1InitMeta m_initMetaObj;

		// Token: 0x0403B21E RID: 242206
		[Token(Token = "0x403B21E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_staticActivityId;

		// Token: 0x0403B21F RID: 242207
		[Token(Token = "0x403B21F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_initMetaObj;

		// Token: 0x0403B220 RID: 242208
		[Token(Token = "0x403B220")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStageTimeout;

		// Token: 0x0403B221 RID: 242209
		[Token(Token = "0x403B221")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRewardTimeout;

		// Token: 0x0403B222 RID: 242210
		[Token(Token = "0x403B222")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateBridge;

		// Token: 0x0403B223 RID: 242211
		[Token(Token = "0x403B223")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007213 RID: 29203
		[Token(Token = "0x2007213")]
		private class Bridge : ActivityStageBridge
		{
			// Token: 0x06029685 RID: 169605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029685")]
			[Address(RVA = "0x24BE8D0", Offset = "0x24BD4D0", VA = "0x1824BE8D0")]
			public Bridge(Act5D1StageController controller)
			{
			}

			// Token: 0x0403B224 RID: 242212
			[Token(Token = "0x403B224")]
			[FieldOffset(Offset = "0x18")]
			private Act5D1StageController m_controller;
		}
	}
}
