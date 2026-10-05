using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026AB RID: 9899
	[Token(Token = "0x20026AB")]
	[OperaInfo(Category = "Effect")]
	public class PlayCameraEffect : OperaNode
	{
		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06010294 RID: 66196 RVA: 0x000628F8 File Offset: 0x00060AF8
		[Token(Token = "0x17002333")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x6010294")]
			[Address(RVA = "0x7EDD00", Offset = "0x7EC900", VA = "0x1807EDD00", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010295 RID: 66197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010295")]
		[Address(RVA = "0x7EDBD0", Offset = "0x7EC7D0", VA = "0x1807EDBD0", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010296 RID: 66198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010296")]
		[Address(RVA = "0x7EDC60", Offset = "0x7EC860", VA = "0x1807EDC60")]
		public PlayCameraEffect()
		{
		}

		// Token: 0x04012027 RID: 73767
		[Token(Token = "0x4012027")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _effectKey;

		// Token: 0x04012028 RID: 73768
		[Token(Token = "0x4012028")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04012029 RID: 73769
		[Token(Token = "0x4012029")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x0401202A RID: 73770
		[Token(Token = "0x401202A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
