using System;
using AdvancedInspector;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Gyro
{
	// Token: 0x020016F1 RID: 5873
	[Token(Token = "0x20016F1")]
	public class GyroControllerTest2 : MonoBehaviour
	{
		// Token: 0x060094AE RID: 38062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AE")]
		[Address(RVA = "0x31050A0", Offset = "0x3103CA0", VA = "0x1831050A0")]
		private void Start()
		{
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AF")]
		[Address(RVA = "0x3105100", Offset = "0x3103D00", VA = "0x183105100")]
		private void Update()
		{
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x00039ED0 File Offset: 0x000380D0
		[Token(Token = "0x60094B0")]
		[Address(RVA = "0x31056E0", Offset = "0x31042E0", VA = "0x1831056E0")]
		private float _GetOffset(float maxOffset, float v, Interpolator.EaseType easeType)
		{
			return 0f;
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B1")]
		[Address(RVA = "0x3105710", Offset = "0x3104310", VA = "0x183105710")]
		public GyroControllerTest2()
		{
		}

		// Token: 0x04008AAF RID: 35503
		[Token(Token = "0x4008AAF")]
		[FieldOffset(Offset = "0x18")]
		public Transform targetCamera;

		// Token: 0x04008AB0 RID: 35504
		[Token(Token = "0x4008AB0")]
		[FieldOffset(Offset = "0x20")]
		public Transform cameraAim;

		// Token: 0x04008AB1 RID: 35505
		[Token(Token = "0x4008AB1")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 cameraOffset;

		// Token: 0x04008AB2 RID: 35506
		[Token(Token = "0x4008AB2")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 aimOffset;

		// Token: 0x04008AB3 RID: 35507
		[Token(Token = "0x4008AB3")]
		[FieldOffset(Offset = "0x38")]
		public float maxSpeedFactor;

		// Token: 0x04008AB4 RID: 35508
		[Token(Token = "0x4008AB4")]
		[FieldOffset(Offset = "0x3C")]
		public float minSpeedFactor;

		// Token: 0x04008AB5 RID: 35509
		[Token(Token = "0x4008AB5")]
		[FieldOffset(Offset = "0x40")]
		public float maxSpeedDistance;

		// Token: 0x04008AB6 RID: 35510
		[Token(Token = "0x4008AB6")]
		[FieldOffset(Offset = "0x44")]
		public float minSpeedDistance;

		// Token: 0x04008AB7 RID: 35511
		[Token(Token = "0x4008AB7")]
		[FieldOffset(Offset = "0x48")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private Vector3 m_oriCameraPosition;

		// Token: 0x04008AB8 RID: 35512
		[Token(Token = "0x4008AB8")]
		[FieldOffset(Offset = "0x54")]
		[Inspect(Level = 2)]
		private Vector3 m_oriAimPosition;
	}
}
