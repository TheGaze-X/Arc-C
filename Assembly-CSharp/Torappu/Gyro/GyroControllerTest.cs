using System;
using AdvancedInspector;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Gyro
{
	// Token: 0x020016F0 RID: 5872
	[Token(Token = "0x20016F0")]
	public class GyroControllerTest : MonoBehaviour
	{
		// Token: 0x060094AA RID: 38058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AA")]
		[Address(RVA = "0x3105740", Offset = "0x3104340", VA = "0x183105740")]
		private void Start()
		{
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AB")]
		[Address(RVA = "0x31057A0", Offset = "0x31043A0", VA = "0x1831057A0")]
		private void Update()
		{
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x00039EB8 File Offset: 0x000380B8
		[Token(Token = "0x60094AC")]
		[Address(RVA = "0x31056E0", Offset = "0x31042E0", VA = "0x1831056E0")]
		private float _GetOffset(float maxOffset, float v, Interpolator.EaseType easeType)
		{
			return 0f;
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AD")]
		[Address(RVA = "0x3105B70", Offset = "0x3104770", VA = "0x183105B70")]
		public GyroControllerTest()
		{
		}

		// Token: 0x04008AA8 RID: 35496
		[Token(Token = "0x4008AA8")]
		[FieldOffset(Offset = "0x18")]
		public Transform targetCamera;

		// Token: 0x04008AA9 RID: 35497
		[Token(Token = "0x4008AA9")]
		[FieldOffset(Offset = "0x20")]
		public Transform cameraAim;

		// Token: 0x04008AAA RID: 35498
		[Token(Token = "0x4008AAA")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 cameraOffset;

		// Token: 0x04008AAB RID: 35499
		[Token(Token = "0x4008AAB")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 aimOffset;

		// Token: 0x04008AAC RID: 35500
		[Token(Token = "0x4008AAC")]
		[FieldOffset(Offset = "0x38")]
		public float speedFactor;

		// Token: 0x04008AAD RID: 35501
		[Token(Token = "0x4008AAD")]
		[FieldOffset(Offset = "0x3C")]
		[Inspect(Level = 2)]
		[ReadOnly]
		private Vector3 m_oriCameraPosition;

		// Token: 0x04008AAE RID: 35502
		[Token(Token = "0x4008AAE")]
		[FieldOffset(Offset = "0x48")]
		[Inspect(Level = 2)]
		private Vector3 m_oriAimPosition;
	}
}
