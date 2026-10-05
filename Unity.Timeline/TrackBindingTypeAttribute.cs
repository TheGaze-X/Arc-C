using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[AttributeUsage(AttributeTargets.Class)]
	public class TrackBindingTypeAttribute : Attribute
	{
		// Token: 0x0600030C RID: 780 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x5903E30", Offset = "0x5902A30", VA = "0x185903E30")]
		public TrackBindingTypeAttribute(Type type)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x37442C0", Offset = "0x3742EC0", VA = "0x1837442C0")]
		public TrackBindingTypeAttribute(Type type, TrackBindingFlags flags)
		{
		}

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type type;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x18")]
		public readonly TrackBindingFlags flags;
	}
}
