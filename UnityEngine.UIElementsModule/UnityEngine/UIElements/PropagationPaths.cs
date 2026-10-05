using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	internal class PropagationPaths
	{
		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x5B0F870", Offset = "0x5B0E470", VA = "0x185B0F870")]
		public PropagationPaths()
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x5B0F5D0", Offset = "0x5B0E1D0", VA = "0x185B0F5D0")]
		internal static PropagationPaths Copy(PropagationPaths paths)
		{
			return null;
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x5B0F410", Offset = "0x5B0E010", VA = "0x185B0F410")]
		public static PropagationPaths Build(VisualElement elem, EventBase evt, PropagationPaths.Type pathTypesRequested)
		{
			return null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x5B0F6C0", Offset = "0x5B0E2C0", VA = "0x185B0F6C0")]
		public void Release()
		{
		}

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<PropagationPaths> s_Pool;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<VisualElement> trickleDownPath;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x18")]
		public readonly List<VisualElement> targetElements;

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x20")]
		public readonly List<VisualElement> bubbleUpPath;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		private const int k_DefaultPropagationDepth = 16;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		private const int k_DefaultTargetCount = 4;

		// Token: 0x020001E7 RID: 487
		[Token(Token = "0x20001E7")]
		[Flags]
		public enum Type
		{
			// Token: 0x040006AE RID: 1710
			[Token(Token = "0x40006AE")]
			None = 0,
			// Token: 0x040006AF RID: 1711
			[Token(Token = "0x40006AF")]
			TrickleDown = 1,
			// Token: 0x040006B0 RID: 1712
			[Token(Token = "0x40006B0")]
			BubbleUp = 2
		}
	}
}
