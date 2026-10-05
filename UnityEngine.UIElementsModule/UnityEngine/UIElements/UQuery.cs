using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public static class UQuery
	{
		// Token: 0x020000AC RID: 172
		[Token(Token = "0x20000AC")]
		internal interface IVisualPredicateWrapper
		{
			// Token: 0x0600051B RID: 1307
			[Token(Token = "0x600051B")]
			bool Predicate(object e);
		}

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		internal class IsOfType<T> : UQuery.IVisualPredicateWrapper where T : VisualElement
		{
			// Token: 0x0600051C RID: 1308 RVA: 0x00004518 File Offset: 0x00002718
			[Token(Token = "0x600051C")]
			public bool Predicate(object e)
			{
				return default(bool);
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600051D")]
			public IsOfType()
			{
			}

			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			[FieldOffset(Offset = "0x0")]
			public static UQuery.IsOfType<T> s_Instance;
		}

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		internal abstract class UQueryMatcher : HierarchyTraversal
		{
			// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			protected UQueryMatcher()
			{
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x5A9A5B0", Offset = "0x5A991B0", VA = "0x185A9A5B0", Slot = "4")]
			public override void Traverse(VisualElement element)
			{
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00004530 File Offset: 0x00002730
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x591F3A0", Offset = "0x591DFA0", VA = "0x18591F3A0", Slot = "6")]
			protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				return default(bool);
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			private static void NoProcessResult(VisualElement e, MatchResultInfo i)
			{
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x5A9A380", Offset = "0x5A98F80", VA = "0x185A9A380", Slot = "5")]
			public override void TraverseRecursive(VisualElement element, int depth)
			{
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x5A9A320", Offset = "0x5A98F20", VA = "0x185A9A320", Slot = "7")]
			public virtual void Run(VisualElement root, List<RuleMatcher> matchers)
			{
			}

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[FieldOffset(Offset = "0x10")]
			internal List<RuleMatcher> m_Matchers;
		}

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		internal abstract class SingleQueryMatcher : UQuery.UQueryMatcher
		{
			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x06000529 RID: 1321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000131")]
			public VisualElement match
			{
				[Token(Token = "0x6000528")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000529")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x5A8F190", Offset = "0x5A8DD90", VA = "0x185A8F190", Slot = "7")]
			public override void Run(VisualElement root, List<RuleMatcher> matchers)
			{
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x00004548 File Offset: 0x00002748
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x5A8F180", Offset = "0x5A8DD80", VA = "0x185A8F180")]
			public bool IsInUse()
			{
				return default(bool);
			}

			// Token: 0x0600052C RID: 1324
			[Token(Token = "0x600052C")]
			public abstract UQuery.SingleQueryMatcher CreateNew();

			// Token: 0x0600052D RID: 1325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			protected SingleQueryMatcher()
			{
			}
		}

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		internal class FirstQueryMatcher : UQuery.SingleQueryMatcher
		{
			// Token: 0x0600052E RID: 1326 RVA: 0x00004560 File Offset: 0x00002760
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x5A8D160", Offset = "0x5A8BD60", VA = "0x185A8D160", Slot = "6")]
			protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
			{
				return default(bool);
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x5A8D110", Offset = "0x5A8BD10", VA = "0x185A8D110", Slot = "8")]
			public override UQuery.SingleQueryMatcher CreateNew()
			{
				return null;
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public FirstQueryMatcher()
			{
			}

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UQuery.FirstQueryMatcher Instance;
		}
	}
}
