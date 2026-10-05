using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements
{
	// Token: 0x0200025C RID: 604
	[Token(Token = "0x200025C")]
	internal class StyleVariableResolver
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001119 RID: 4377 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000455")]
		private StyleSheet currentSheet
		{
			[Token(Token = "0x6001119")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000456")]
		private StyleValueHandle[] currentHandles
		{
			[Token(Token = "0x600111A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000457")]
		public List<StylePropertyValue> resolvedValues
		{
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000458")]
		public StyleVariableContext variableContext
		{
			[Token(Token = "0x600111C")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111D")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111E")]
		[Address(RVA = "0x5B256E0", Offset = "0x5B242E0", VA = "0x185B256E0")]
		public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles)
		{
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111F")]
		[Address(RVA = "0x5B259E0", Offset = "0x5B245E0", VA = "0x185B259E0")]
		private void PushContext(StyleSheet sheet, StyleValueHandle[] handles)
		{
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x5B25950", Offset = "0x5B24550", VA = "0x185B25950")]
		private void PopContext()
		{
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x5B255F0", Offset = "0x5B241F0", VA = "0x185B255F0")]
		public void AddValue(StyleValueHandle handle)
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x5B25E60", Offset = "0x5B24A60", VA = "0x185B25E60")]
		public bool ResolveVarFunction(ref int index)
		{
			return default(bool);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x5B25D20", Offset = "0x5B24920", VA = "0x185B25D20")]
		private StyleVariableResolver.Result ResolveVarFunction(ref int index, int argc, string varName)
		{
			return StyleVariableResolver.Result.Valid;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x5B26260", Offset = "0x5B24E60", VA = "0x185B26260")]
		public bool ValidateResolvedValues()
		{
			return default(bool);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x5B25F40", Offset = "0x5B24B40", VA = "0x185B25F40")]
		private StyleVariableResolver.Result ResolveVariable(string variableName)
		{
			return StyleVariableResolver.Result.Valid;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x5B25A90", Offset = "0x5B24690", VA = "0x185B25A90")]
		private StyleVariableResolver.Result ResolveFallback(ref int index)
		{
			return StyleVariableResolver.Result.Valid;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x5B257B0", Offset = "0x5B243B0", VA = "0x185B257B0")]
		private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName)
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x5B26460", Offset = "0x5B25060", VA = "0x185B26460")]
		public StyleVariableResolver()
		{
		}

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		internal const int kMaxResolves = 100;

		// Token: 0x040008EA RID: 2282
		[Token(Token = "0x40008EA")]
		[FieldOffset(Offset = "0x0")]
		private static StyleSyntaxParser s_SyntaxParser;

		// Token: 0x040008EB RID: 2283
		[Token(Token = "0x40008EB")]
		[FieldOffset(Offset = "0x10")]
		private StylePropertyValueMatcher m_Matcher;

		// Token: 0x040008EC RID: 2284
		[Token(Token = "0x40008EC")]
		[FieldOffset(Offset = "0x18")]
		private List<StylePropertyValue> m_ResolvedValues;

		// Token: 0x040008ED RID: 2285
		[Token(Token = "0x40008ED")]
		[FieldOffset(Offset = "0x20")]
		private Stack<string> m_ResolvedVarStack;

		// Token: 0x040008EE RID: 2286
		[Token(Token = "0x40008EE")]
		[FieldOffset(Offset = "0x28")]
		private StyleProperty m_Property;

		// Token: 0x040008EF RID: 2287
		[Token(Token = "0x40008EF")]
		[FieldOffset(Offset = "0x30")]
		private Stack<StyleVariableResolver.ResolveContext> m_ContextStack;

		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x40008F0")]
		[FieldOffset(Offset = "0x38")]
		private StyleVariableResolver.ResolveContext m_CurrentContext;

		// Token: 0x0200025D RID: 605
		[Token(Token = "0x200025D")]
		private enum Result
		{
			// Token: 0x040008F3 RID: 2291
			[Token(Token = "0x40008F3")]
			Valid,
			// Token: 0x040008F4 RID: 2292
			[Token(Token = "0x40008F4")]
			Invalid,
			// Token: 0x040008F5 RID: 2293
			[Token(Token = "0x40008F5")]
			NotFound
		}

		// Token: 0x0200025E RID: 606
		[Token(Token = "0x200025E")]
		private struct ResolveContext
		{
			// Token: 0x040008F6 RID: 2294
			[Token(Token = "0x40008F6")]
			[FieldOffset(Offset = "0x0")]
			public StyleSheet sheet;

			// Token: 0x040008F7 RID: 2295
			[Token(Token = "0x40008F7")]
			[FieldOffset(Offset = "0x8")]
			public StyleValueHandle[] handles;
		}
	}
}
