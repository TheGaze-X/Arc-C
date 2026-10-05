using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[Serializable]
	public class VectorImage : ScriptableObject
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x5A9DFE0", Offset = "0x5A9CBE0", VA = "0x185A9DFE0")]
		public VectorImage()
		{
		}

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal Texture2D atlas;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal VectorImageVertex[] vertices;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal ushort[] indices;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal GradientSettings[] settings;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal Vector2 size;
	}
}
