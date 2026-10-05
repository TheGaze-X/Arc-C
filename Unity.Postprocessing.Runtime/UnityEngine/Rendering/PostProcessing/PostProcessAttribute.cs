using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public sealed class PostProcessAttribute : Attribute
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x58292E0", Offset = "0x5827EE0", VA = "0x1858292E0")]
		public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5829270", Offset = "0x5827E70", VA = "0x185829270")]
		internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
		{
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x10")]
		public readonly Type renderer;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x18")]
		public readonly PostProcessEvent eventType;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public readonly string menuItem;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		public readonly bool allowInSceneView;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x29")]
		internal readonly bool builtinEffect;
	}
}
