using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A2 RID: 9890
	[Token(Token = "0x20026A2")]
	[OperaInfo(Category = "Camera")]
	public class CameraShake : OperaNode
	{
		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x0601026F RID: 66159 RVA: 0x00062808 File Offset: 0x00060A08
		[Token(Token = "0x1700232C")]
		public override CameraController.PostprocessMask postProcessType
		{
			[Token(Token = "0x601026F")]
			[Address(RVA = "0x7E2070", Offset = "0x7E0C70", VA = "0x1807E2070", Slot = "4")]
			get
			{
				return CameraController.PostprocessMask.NONE;
			}
		}

		// Token: 0x06010270 RID: 66160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010270")]
		[Address(RVA = "0x7E1F10", Offset = "0x7E0B10", VA = "0x1807E1F10", Slot = "6")]
		protected override void DoExecute()
		{
		}

		// Token: 0x06010271 RID: 66161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010271")]
		[Address(RVA = "0x7E1FD0", Offset = "0x7E0BD0", VA = "0x1807E1FD0")]
		public CameraShake()
		{
		}

		// Token: 0x04011FF0 RID: 73712
		[Token(Token = "0x4011FF0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _duration;

		// Token: 0x04011FF1 RID: 73713
		[Token(Token = "0x4011FF1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 _strength;

		// Token: 0x04011FF2 RID: 73714
		[Token(Token = "0x4011FF2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _vibrato;

		// Token: 0x04011FF3 RID: 73715
		[Token(Token = "0x4011FF3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _randomness;

		// Token: 0x04011FF4 RID: 73716
		[Token(Token = "0x4011FF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_postProcessType;

		// Token: 0x04011FF5 RID: 73717
		[Token(Token = "0x4011FF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoExecute;

		// Token: 0x04011FF6 RID: 73718
		[Token(Token = "0x4011FF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
