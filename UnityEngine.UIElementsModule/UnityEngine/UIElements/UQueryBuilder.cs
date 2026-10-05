using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B6 RID: 182
	[Token(Token = "0x20000B6")]
	public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> where T : VisualElement
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000136")]
		private List<StyleSelector> styleSelectors
		{
			[Token(Token = "0x600054C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000137")]
		private List<StyleSelectorPart> parts
		{
			[Token(Token = "0x600054D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		public UQueryBuilder(VisualElement visualElement)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x600054F")]
		public UQueryBuilder<T> Class(string classname)
		{
			return default(UQueryBuilder<T>);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x6000550")]
		public UQueryBuilder<T> Name(string id)
		{
			return default(UQueryBuilder<T>);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x6000551")]
		public UQueryBuilder<T2> OfType<T2>([Optional] string name, [Optional] string className) where T2 : VisualElement
		{
			return default(UQueryBuilder<T2>);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x6000552")]
		internal UQueryBuilder<T> SingleBaseType()
		{
			return default(UQueryBuilder<T>);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000553")]
		private void AddClass(string c)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000554")]
		private void AddName(string id)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000555")]
		private void AddType<T2>() where T2 : VisualElement
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x6000556")]
		private UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship) where T2 : VisualElement
		{
			return default(UQueryBuilder<T2>);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000557")]
		private void AddPseudoStatesRuleIfNecessasy()
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000558")]
		private void FinishSelector()
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000559")]
		private bool CurrentSelectorEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055A")]
		private void FinishCurrentSelector()
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x600055B")]
		public UQueryState<T> Build()
		{
			return default(UQueryState<T>);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		public void ToList(List<T> results)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x600055D")]
		public bool Equals(UQueryBuilder<T> other)
		{
			return default(bool);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x600055E")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x600055F")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<StyleSelector> m_StyleSelectors;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<StyleSelectorPart> m_Parts;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private VisualElement m_Element;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<RuleMatcher> m_Matchers;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private StyleSelectorRelationship m_Relationship;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int pseudoStatesMask;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int negatedPseudoStatesMask;
	}
}
