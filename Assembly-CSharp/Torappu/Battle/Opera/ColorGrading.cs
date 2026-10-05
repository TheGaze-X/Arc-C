using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A4 RID: 9892
	[Token(Token = "0x20026A4")]
	[OperaInfo(Category = "Screen")]
	public class ColorGrading : OperaNode
	{
		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x06010275 RID: 66165 RVA: 0x00062838 File Offset: 0x00060A38
		[Token(Token = "0x1700232E")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x6010275")]
			[Address(RVA = "0x7E41D0", Offset = "0x7E2DD0", VA = "0x1807E41D0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010276 RID: 66166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010276")]
		[Address(RVA = "0x7E3A20", Offset = "0x7E2620", VA = "0x1807E3A20", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010277 RID: 66167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010277")]
		[Address(RVA = "0x7E4040", Offset = "0x7E2C40", VA = "0x1807E4040", Slot = "5")]
		public override void OnCompleted()
		{
		}

		// Token: 0x06010278 RID: 66168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010278")]
		[Address(RVA = "0x7E4130", Offset = "0x7E2D30", VA = "0x1807E4130")]
		public ColorGrading()
		{
		}

		// Token: 0x06010279 RID: 66169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010279")]
		[Address(RVA = "0x7E40D0", Offset = "0x7E2CD0", VA = "0x1807E40D0")]
		private void <>xLuaBaseProxy_OnCompleted()
		{
		}

		// Token: 0x04011FFB RID: 73723
		[Token(Token = "0x4011FFB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fadeInTime;

		// Token: 0x04011FFC RID: 73724
		[Token(Token = "0x4011FFC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _keepTime;

		// Token: 0x04011FFD RID: 73725
		[Token(Token = "0x4011FFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeOutTime;

		// Token: 0x04011FFE RID: 73726
		[Token(Token = "0x4011FFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04011FFF RID: 73727
		[Token(Token = "0x4011FFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012000 RID: 73728
		[Token(Token = "0x4012000")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCompleted;

		// Token: 0x04012001 RID: 73729
		[Token(Token = "0x4012001")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
