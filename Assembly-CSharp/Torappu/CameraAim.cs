using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	public class CameraAim : MonoBehaviour
	{
		// Token: 0x06004EEB RID: 20203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x187EEC0", Offset = "0x187DAC0", VA = "0x18187EEC0")]
		private void Awake()
		{
		}

		// Token: 0x06004EEC RID: 20204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x187EF80", Offset = "0x187DB80", VA = "0x18187EF80")]
		private void Update()
		{
		}

		// Token: 0x06004EED RID: 20205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x187EF80", Offset = "0x187DB80", VA = "0x18187EF80")]
		private void _UpdateRotationTowardAim()
		{
		}

		// Token: 0x06004EEE RID: 20206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CameraAim()
		{
		}

		// Token: 0x04001313 RID: 4883
		[Token(Token = "0x4001313")]
		[FieldOffset(Offset = "0x18")]
		public Transform aimTarget;

		// Token: 0x04001314 RID: 4884
		[Token(Token = "0x4001314")]
		[FieldOffset(Offset = "0x20")]
		public Transform source;

		// Token: 0x04001315 RID: 4885
		[Token(Token = "0x4001315")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 m_oriSourceUp;
	}
}
