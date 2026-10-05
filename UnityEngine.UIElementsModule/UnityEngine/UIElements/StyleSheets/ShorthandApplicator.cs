using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	internal static class ShorthandApplicator
	{
		// Token: 0x06001465 RID: 5221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x5A7BEF0", Offset = "0x5A7AAF0", VA = "0x185A7BEF0")]
		public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x5A7C100", Offset = "0x5A7AD00", VA = "0x185A7C100")]
		public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x5A7C2F0", Offset = "0x5A7AEF0", VA = "0x185A7C2F0")]
		public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x5A7C520", Offset = "0x5A7B120", VA = "0x185A7C520")]
		public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x5A7C610", Offset = "0x5A7B210", VA = "0x185A7C610")]
		public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x5A7C7F0", Offset = "0x5A7B3F0", VA = "0x185A7C7F0")]
		public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x5A7C9E0", Offset = "0x5A7B5E0", VA = "0x185A7C9E0")]
		public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x5A7CB30", Offset = "0x5A7B730", VA = "0x185A7CB30")]
		public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x5A7D2E0", Offset = "0x5A7BEE0", VA = "0x185A7D2E0")]
		private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis)
		{
			return default(bool);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x5A7CCB0", Offset = "0x5A7B8B0", VA = "0x185A7CCB0")]
		private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
		{
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x5A7D170", Offset = "0x5A7BD70", VA = "0x185A7D170")]
		private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x5A7CFA0", Offset = "0x5A7BBA0", VA = "0x185A7CFA0")]
		private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left)
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x5A7CE00", Offset = "0x5A7BA00", VA = "0x185A7CE00")]
		private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left)
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x5A7D530", Offset = "0x5A7C130", VA = "0x185A7D530")]
		private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth)
		{
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x5A7D640", Offset = "0x5A7C240", VA = "0x185A7D640")]
		private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction)
		{
		}

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		[FieldOffset(Offset = "0x0")]
		private static List<TimeValue> s_TransitionDelayList;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		[FieldOffset(Offset = "0x8")]
		private static List<TimeValue> s_TransitionDurationList;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x10")]
		private static List<StylePropertyName> s_TransitionPropertyList;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x18")]
		private static List<EasingFunction> s_TransitionTimingFunctionList;
	}
}
