using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[Serializable]
	public sealed class Vector4Parameter : ParameterOverride<Vector4>
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x582E610", Offset = "0x582D210", VA = "0x18582E610", Slot = "9")]
		public override void Interp(Vector4 from, Vector4 to, float t)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x584B180", Offset = "0x5849D80", VA = "0x18584B180")]
		public static implicit operator Vector2(Vector4Parameter prop)
		{
			return default(Vector2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000025C4 File Offset: 0x000007C4
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x584B1B0", Offset = "0x5849DB0", VA = "0x18584B1B0")]
		public static implicit operator Vector3(Vector4Parameter prop)
		{
			return default(Vector3);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x584B140", Offset = "0x5849D40", VA = "0x18584B140")]
		public Vector4Parameter()
		{
		}
	}
}
