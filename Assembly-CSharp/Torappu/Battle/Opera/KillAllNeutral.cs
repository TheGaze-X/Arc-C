using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B4 RID: 9908
	[Token(Token = "0x20026B4")]
	[OperaInfo(Category = "Common")]
	public class KillAllNeutral : OperaNode
	{
		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x060102B3 RID: 66227 RVA: 0x00062A00 File Offset: 0x00060C00
		[Token(Token = "0x1700233C")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102B3")]
			[Address(RVA = "0x7ED1B0", Offset = "0x7EBDB0", VA = "0x1807ED1B0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102B4 RID: 66228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102B4")]
		[Address(RVA = "0x7ECE50", Offset = "0x7EBA50", VA = "0x1807ECE50", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102B5 RID: 66229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102B5")]
		[Address(RVA = "0x7ED110", Offset = "0x7EBD10", VA = "0x1807ED110")]
		public KillAllNeutral()
		{
		}

		// Token: 0x04012057 RID: 73815
		[Token(Token = "0x4012057")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012058 RID: 73816
		[Token(Token = "0x4012058")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012059 RID: 73817
		[Token(Token = "0x4012059")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
