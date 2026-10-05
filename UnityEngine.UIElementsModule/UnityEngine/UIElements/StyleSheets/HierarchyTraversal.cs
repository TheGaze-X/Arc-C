using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	internal abstract class HierarchyTraversal
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140D")]
		[Address(RVA = "0x5A67590", Offset = "0x5A66190", VA = "0x185A67590", Slot = "4")]
		public virtual void Traverse(VisualElement element)
		{
		}

		// Token: 0x0600140E RID: 5134
		[Token(Token = "0x600140E")]
		public abstract void TraverseRecursive(VisualElement element, int depth);

		// Token: 0x0600140F RID: 5135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x5A674B0", Offset = "0x5A660B0", VA = "0x185A674B0")]
		protected void Recurse(VisualElement element, int depth)
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected HierarchyTraversal()
		{
		}
	}
}
