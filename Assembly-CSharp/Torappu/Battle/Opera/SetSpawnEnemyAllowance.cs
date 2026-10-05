using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B2 RID: 9906
	[Token(Token = "0x20026B2")]
	[OperaInfo(Category = "Common")]
	public class SetSpawnEnemyAllowance : OperaNode
	{
		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x060102AD RID: 66221 RVA: 0x000629D0 File Offset: 0x00060BD0
		[Token(Token = "0x1700233A")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102AD")]
			[Address(RVA = "0x7EF320", Offset = "0x7EDF20", VA = "0x1807EF320", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102AE RID: 66222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102AE")]
		[Address(RVA = "0x7EF1E0", Offset = "0x7EDDE0", VA = "0x1807EF1E0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102AF RID: 66223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102AF")]
		[Address(RVA = "0x7EF280", Offset = "0x7EDE80", VA = "0x1807EF280")]
		public SetSpawnEnemyAllowance()
		{
		}

		// Token: 0x0401204D RID: 73805
		[Token(Token = "0x401204D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _isEnableSpawnEnemy;

		// Token: 0x0401204E RID: 73806
		[Token(Token = "0x401204E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x0401204F RID: 73807
		[Token(Token = "0x401204F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012050 RID: 73808
		[Token(Token = "0x4012050")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
