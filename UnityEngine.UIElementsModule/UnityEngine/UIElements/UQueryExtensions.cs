using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public static class UQueryExtensions
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000560")]
		public static T Q<T>(this VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x5A996A0", Offset = "0x5A982A0", VA = "0x185A996A0")]
		public static VisualElement Q(this VisualElement e, [Optional] string name, [Optional] string className)
		{
			return null;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x6000562")]
		public static UQueryBuilder<T> Query<T>(this VisualElement e, [Optional] string name, [Optional] string className) where T : VisualElement
		{
			return default(UQueryBuilder<T>);
		}

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UQueryState<VisualElement> SingleElementEmptyQuery;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static UQueryState<VisualElement> SingleElementNameQuery;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static UQueryState<VisualElement> SingleElementClassQuery;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static UQueryState<VisualElement> SingleElementNameAndClassQuery;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static UQueryState<VisualElement> SingleElementTypeQuery;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static UQueryState<VisualElement> SingleElementTypeAndNameQuery;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static UQueryState<VisualElement> SingleElementTypeAndClassQuery;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static UQueryState<VisualElement> SingleElementTypeAndNameAndClassQuery;
	}
}
