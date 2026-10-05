using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[Serializable]
	public sealed class Vector2Parameter : ParameterOverride<Vector2>
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x584AF00", Offset = "0x5849B00", VA = "0x18584AF00", Slot = "9")]
		public override void Interp(Vector2 from, Vector2 to, float t)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x584AF90", Offset = "0x5849B90", VA = "0x18584AF90")]
		public static implicit operator Vector3(Vector2Parameter prop)
		{
			return default(Vector3);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x584AFD0", Offset = "0x5849BD0", VA = "0x18584AFD0")]
		public static implicit operator Vector4(Vector2Parameter prop)
		{
			return default(Vector4);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x584AF50", Offset = "0x5849B50", VA = "0x18584AF50")]
		public Vector2Parameter()
		{
		}
	}
}
