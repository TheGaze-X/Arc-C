using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	public class Gyroscope
	{
		// Token: 0x06000012 RID: 18 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal Gyroscope(int index)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021A0 File Offset: 0x000003A0
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59B7E10", Offset = "0x59B6A10", VA = "0x1859B7E10")]
		[FreeFunction("GetGyroRotationRateUnbiased")]
		private static Vector3 rotationRateUnbiased_Internal(int idx)
		{
			return default(Vector3);
		}

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x59B7E60", Offset = "0x59B6A60", VA = "0x1859B7E60")]
		[FreeFunction("SetGyroEnabled")]
		[MethodImpl(4096)]
		private static extern void setEnabled_Internal(int idx, bool enabled);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x59B7EA0", Offset = "0x59B6AA0", VA = "0x1859B7EA0")]
		[FreeFunction("SetGyroUpdateInterval")]
		[MethodImpl(4096)]
		private static extern void setUpdateInterval_Internal(int idx, float interval);

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x1700000F")]
		public Vector3 rotationRateUnbiased
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x59B7D60", Offset = "0x59B6960", VA = "0x1859B7D60")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000010")]
		public bool enabled
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x59B7EF0", Offset = "0x59B6AF0", VA = "0x1859B7EF0")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000011")]
		public float updateInterval
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x59B7F40", Offset = "0x59B6B40", VA = "0x1859B7F40")]
			set
			{
			}
		}

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x59B7DD0", Offset = "0x59B69D0", VA = "0x1859B7DD0")]
		[MethodImpl(4096)]
		private static extern void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret);

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		private int m_GyroIndex;
	}
}
