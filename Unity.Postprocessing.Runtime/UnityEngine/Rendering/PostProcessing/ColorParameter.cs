using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Serializable]
	public sealed class ColorParameter : ParameterOverride<Color>
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x582E610", Offset = "0x582D210", VA = "0x18582E610", Slot = "9")]
		public override void Interp(Color from, Color to, float t)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x582E6C0", Offset = "0x582D2C0", VA = "0x18582E6C0")]
		public static implicit operator Vector4(ColorParameter prop)
		{
			return default(Vector4);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x582E680", Offset = "0x582D280", VA = "0x18582E680")]
		public ColorParameter()
		{
		}
	}
}
