using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B3 RID: 9907
	[Token(Token = "0x20026B3")]
	[OperaInfo(Category = "Common")]
	public class KillAllEnemy : OperaNode
	{
		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x060102B0 RID: 66224 RVA: 0x000629E8 File Offset: 0x00060BE8
		[Token(Token = "0x1700233B")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102B0")]
			[Address(RVA = "0x7ECDF0", Offset = "0x7EB9F0", VA = "0x1807ECDF0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102B1 RID: 66225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102B1")]
		[Address(RVA = "0x7EC9C0", Offset = "0x7EB5C0", VA = "0x1807EC9C0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102B2 RID: 66226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102B2")]
		[Address(RVA = "0x7ECD40", Offset = "0x7EB940", VA = "0x1807ECD40")]
		public KillAllEnemy()
		{
		}

		// Token: 0x04012051 RID: 73809
		[Token(Token = "0x4012051")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _finishCurrentWave;

		// Token: 0x04012052 RID: 73810
		[Token(Token = "0x4012052")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _checkEnemyLevelMask;

		// Token: 0x04012053 RID: 73811
		[Token(Token = "0x4012053")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private EnemyLevelMask _enemyLevelMask;

		// Token: 0x04012054 RID: 73812
		[Token(Token = "0x4012054")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012055 RID: 73813
		[Token(Token = "0x4012055")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012056 RID: 73814
		[Token(Token = "0x4012056")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
