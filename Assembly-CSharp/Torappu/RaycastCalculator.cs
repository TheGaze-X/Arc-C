using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	public class RaycastCalculator : MonoBehaviour
	{
		// Token: 0x06004EEF RID: 20207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0x188F250", Offset = "0x188DE50", VA = "0x18188F250")]
		private void Start()
		{
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0x188F380", Offset = "0x188DF80", VA = "0x18188F380")]
		public RaycastCalculator()
		{
		}

		// Token: 0x04001316 RID: 4886
		[Token(Token = "0x4001316")]
		[FieldOffset(Offset = "0x18")]
		public Transform planePoint;

		// Token: 0x04001317 RID: 4887
		[Token(Token = "0x4001317")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 planeNormal;

		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x4001318")]
		[FieldOffset(Offset = "0x30")]
		public Transform source;
	}
}
