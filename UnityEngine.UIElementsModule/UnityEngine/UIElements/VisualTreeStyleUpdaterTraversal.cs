using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00004950 File Offset: 0x00002B50
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		private float currentPixelsPerPoint
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
		public void PrepareTraversal(float pixelsPerPoint)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x5AA35D0", Offset = "0x5AA21D0", VA = "0x185AA35D0")]
		public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x5AA38C0", Offset = "0x5AA24C0", VA = "0x185AA38C0")]
		public void Clear()
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x5AA4980", Offset = "0x5AA3580", VA = "0x185AA4980")]
		private void PropagateToChildren(VisualElement ve)
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x5AA4A60", Offset = "0x5AA3660", VA = "0x185AA4A60")]
		private void PropagateToParents(VisualElement ve)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x5AA3BB0", Offset = "0x5AA27B0", VA = "0x185AA3BB0")]
		private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info)
		{
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x5AA4BA0", Offset = "0x5AA37A0", VA = "0x185AA4BA0", Slot = "5")]
		public override void TraverseRecursive(VisualElement element, int depth)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x5AA4870", Offset = "0x5AA3470", VA = "0x185AA4870")]
		private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x5AA3960", Offset = "0x5AA2560", VA = "0x185AA3960")]
		private void ForceUpdateTransitions(VisualElement element)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x5AA36E0", Offset = "0x5AA22E0", VA = "0x185AA36E0")]
		internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x5AA4B10", Offset = "0x5AA3710", VA = "0x185AA4B10")]
		protected bool ShouldSkipElement(VisualElement element)
		{
			return default(bool);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x5AA3BE0", Offset = "0x5AA27E0", VA = "0x185AA3BE0")]
		private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors)
		{
			return default(ComputedStyle);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x5AA4750", Offset = "0x5AA3350", VA = "0x185AA4750")]
		private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule)
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x5AA53B0", Offset = "0x5AA3FB0", VA = "0x185AA53B0")]
		public VisualTreeStyleUpdaterTraversal()
		{
		}

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x10")]
		private StyleVariableContext m_ProcessVarContext;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x18")]
		private HashSet<VisualElement> m_UpdateList;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<VisualElement> m_ParentList;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x28")]
		private List<SelectorMatchRecord> m_TempMatchResults;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x38")]
		private StyleMatchingContext m_StyleMatchingContext;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x40")]
		private StylePropertyReader m_StylePropertyReader;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<StylePropertyId> m_AnimatedProperties;
	}
}
