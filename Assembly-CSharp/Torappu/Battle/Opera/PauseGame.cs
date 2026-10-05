using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B1 RID: 9905
	[Token(Token = "0x20026B1")]
	[OperaInfo(Category = "Common")]
	public class PauseGame : OperaNode
	{
		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x060102AA RID: 66218 RVA: 0x000629B8 File Offset: 0x00060BB8
		[Token(Token = "0x17002339")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102AA")]
			[Address(RVA = "0x7ED7B0", Offset = "0x7EC3B0", VA = "0x1807ED7B0", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102AB RID: 66219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102AB")]
		[Address(RVA = "0x7ED670", Offset = "0x7EC270", VA = "0x1807ED670", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102AC RID: 66220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102AC")]
		[Address(RVA = "0x7ED700", Offset = "0x7EC300", VA = "0x1807ED700")]
		public PauseGame()
		{
		}

		// Token: 0x04012048 RID: 73800
		[Token(Token = "0x4012048")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Consts.BattlePauseKey _pauseKey;

		// Token: 0x04012049 RID: 73801
		[Token(Token = "0x4012049")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _isPause;

		// Token: 0x0401204A RID: 73802
		[Token(Token = "0x401204A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x0401204B RID: 73803
		[Token(Token = "0x401204B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x0401204C RID: 73804
		[Token(Token = "0x401204C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
