using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026AD RID: 9901
	[Token(Token = "0x20026AD")]
	[OperaInfo(Category = "Effect")]
	public class FinishHoldEffectIfExist : OperaNode
	{
		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x0601029B RID: 66203 RVA: 0x00062928 File Offset: 0x00060B28
		[Token(Token = "0x17002335")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x601029B")]
			[Address(RVA = "0x7E8CF0", Offset = "0x7E78F0", VA = "0x1807E8CF0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x0601029C RID: 66204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601029C")]
		[Address(RVA = "0x7E8BD0", Offset = "0x7E77D0", VA = "0x1807E8BD0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x0601029D RID: 66205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601029D")]
		[Address(RVA = "0x7E8C50", Offset = "0x7E7850", VA = "0x1807E8C50")]
		public FinishHoldEffectIfExist()
		{
		}

		// Token: 0x04012031 RID: 73777
		[Token(Token = "0x4012031")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012032 RID: 73778
		[Token(Token = "0x4012032")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012033 RID: 73779
		[Token(Token = "0x4012033")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
