using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[Serializable]
	public sealed class TextureParameter : ParameterOverride<Texture>
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x584A1A0", Offset = "0x5848DA0", VA = "0x18584A1A0", Slot = "9")]
		public override void Interp(Texture from, Texture to, float t)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x584A610", Offset = "0x5849210", VA = "0x18584A610")]
		public TextureParameter()
		{
		}

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x20")]
		public TextureParameterDefault defaultState;
	}
}
