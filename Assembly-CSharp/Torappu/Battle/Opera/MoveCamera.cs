using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A3 RID: 9891
	[Token(Token = "0x20026A3")]
	[OperaInfo(Category = "Camera")]
	public class MoveCamera : OperaNode
	{
		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x06010272 RID: 66162 RVA: 0x00062820 File Offset: 0x00060A20
		[Token(Token = "0x1700232D")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x6010272")]
			[Address(RVA = "0x7ED350", Offset = "0x7EBF50", VA = "0x1807ED350", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010273 RID: 66163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010273")]
		[Address(RVA = "0x7ED210", Offset = "0x7EBE10", VA = "0x1807ED210", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010274 RID: 66164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010274")]
		[Address(RVA = "0x7ED2B0", Offset = "0x7EBEB0", VA = "0x1807ED2B0")]
		public MoveCamera()
		{
		}

		// Token: 0x04011FF7 RID: 73719
		[Token(Token = "0x4011FF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 _offset;

		// Token: 0x04011FF8 RID: 73720
		[Token(Token = "0x4011FF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04011FF9 RID: 73721
		[Token(Token = "0x4011FF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04011FFA RID: 73722
		[Token(Token = "0x4011FFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
