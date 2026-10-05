using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public class TrackClipTypeAttribute : Attribute
	{
		// Token: 0x06000309 RID: 777 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x4E17BF0", Offset = "0x4E167F0", VA = "0x184E17BF0")]
		public TrackClipTypeAttribute(Type clipClass)
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public TrackClipTypeAttribute(Type clipClass, bool allowAutoCreate)
		{
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type inspectedType;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool allowAutoCreate;
	}
}
