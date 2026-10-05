using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class TrackballAttribute : Attribute
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public TrackballAttribute(TrackballAttribute.Mode mode)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		public readonly TrackballAttribute.Mode mode;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		public enum Mode
		{
			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			None,
			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			Lift,
			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			Gamma,
			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			Gain
		}
	}
}
