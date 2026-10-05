using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026B5 RID: 9909
	[Token(Token = "0x20026B5")]
	[OperaInfo(Category = "Common")]
	public class KillAllCharacter : OperaNode
	{
		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x060102B6 RID: 66230 RVA: 0x00062A18 File Offset: 0x00060C18
		[Token(Token = "0x1700233D")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x60102B6")]
			[Address(RVA = "0x7EC960", Offset = "0x7EB560", VA = "0x1807EC960", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x060102B7 RID: 66231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102B7")]
		[Address(RVA = "0x7EC420", Offset = "0x7EB020", VA = "0x1807EC420", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x060102B8 RID: 66232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102B8")]
		[Address(RVA = "0x7EC8B0", Offset = "0x7EB4B0", VA = "0x1807EC8B0")]
		public KillAllCharacter()
		{
		}

		// Token: 0x0401205A RID: 73818
		[Token(Token = "0x401205A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _killCharacter;

		// Token: 0x0401205B RID: 73819
		[Token(Token = "0x401205B")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _respawnTimeDecByRatio;

		// Token: 0x0401205C RID: 73820
		[Token(Token = "0x401205C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _respawnTimeDecRatio;

		// Token: 0x0401205D RID: 73821
		[Token(Token = "0x401205D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _killTrap;

		// Token: 0x0401205E RID: 73822
		[Token(Token = "0x401205E")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _killToken;

		// Token: 0x0401205F RID: 73823
		[Token(Token = "0x401205F")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _forceWithdraw;

		// Token: 0x04012060 RID: 73824
		[Token(Token = "0x4012060")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012061 RID: 73825
		[Token(Token = "0x4012061")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04012062 RID: 73826
		[Token(Token = "0x4012062")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
