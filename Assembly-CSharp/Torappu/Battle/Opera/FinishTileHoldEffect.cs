using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026AE RID: 9902
	[Token(Token = "0x20026AE")]
	[OperaInfo(Category = "Effect")]
	public class FinishTileHoldEffect : OperaNode
	{
		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x0601029E RID: 66206 RVA: 0x00062940 File Offset: 0x00060B40
		[Token(Token = "0x17002336")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x601029E")]
			[Address(RVA = "0x7E8FB0", Offset = "0x7E7BB0", VA = "0x1807E8FB0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x0601029F RID: 66207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601029F")]
		[Address(RVA = "0x7E8D50", Offset = "0x7E7950", VA = "0x1807E8D50", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102A0 RID: 66208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102A0")]
		[Address(RVA = "0x7E8F10", Offset = "0x7E7B10", VA = "0x1807E8F10")]
		public FinishTileHoldEffect()
		{
		}

		// Token: 0x04012034 RID: 73780
		[Token(Token = "0x4012034")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x04012035 RID: 73781
		[Token(Token = "0x4012035")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012036 RID: 73782
		[Token(Token = "0x4012036")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012037 RID: 73783
		[Token(Token = "0x4012037")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
