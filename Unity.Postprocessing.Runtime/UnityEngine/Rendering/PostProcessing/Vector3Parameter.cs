using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Serializable]
	public sealed class Vector3Parameter : ParameterOverride<Vector3>
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x584B020", Offset = "0x5849C20", VA = "0x18584B020", Slot = "9")]
		public override void Interp(Vector3 from, Vector3 to, float t)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x584B110", Offset = "0x5849D10", VA = "0x18584B110")]
		public static implicit operator Vector2(Vector3Parameter prop)
		{
			return default(Vector2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x584B0B0", Offset = "0x5849CB0", VA = "0x18584B0B0")]
		public static implicit operator Vector4(Vector3Parameter prop)
		{
			return default(Vector4);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x584B070", Offset = "0x5849C70", VA = "0x18584B070")]
		public Vector3Parameter()
		{
		}
	}
}
