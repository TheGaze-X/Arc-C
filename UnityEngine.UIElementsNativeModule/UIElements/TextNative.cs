using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[NativeHeader("Modules/UIElementsNative/TextNative.bindings.h")]
	internal static class TextNative
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x5B4D0F0", Offset = "0x5B4BCF0", VA = "0x185B4D0F0")]
		public static Vector2 GetCursorPosition(TextNativeSettings settings, Rect rect, int cursorIndex)
		{
			return default(Vector2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x5B4CD20", Offset = "0x5B4B920", VA = "0x185B4CD20")]
		public static float ComputeTextWidth(TextNativeSettings settings)
		{
			return 0f;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x5B4CBF0", Offset = "0x5B4B7F0", VA = "0x185B4CBF0")]
		public static float ComputeTextHeight(TextNativeSettings settings)
		{
			return 0f;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x5B4D510", Offset = "0x5B4C110", VA = "0x185B4D510")]
		public static NativeArray<TextVertex> GetVertices(TextNativeSettings settings)
		{
			return default(NativeArray<TextVertex>);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x5B4D290", Offset = "0x5B4BE90", VA = "0x185B4D290")]
		public static Vector2 GetOffset(TextNativeSettings settings, Rect screenRect)
		{
			return default(Vector2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5B281C0", Offset = "0x5B26DC0", VA = "0x185B281C0")]
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			return 0f;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x5B4CF10", Offset = "0x5B4BB10", VA = "0x185B4CF10")]
		[FreeFunction(Name = "TextNative::ComputeTextWidth")]
		private static float DoComputeTextWidth(TextNativeSettings settings)
		{
			return 0f;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x5B4CE90", Offset = "0x5B4BA90", VA = "0x185B4CE90")]
		[FreeFunction(Name = "TextNative::ComputeTextHeight")]
		private static float DoComputeTextHeight(TextNativeSettings settings)
		{
			return 0f;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5B4CFC0", Offset = "0x5B4BBC0", VA = "0x185B4CFC0")]
		[FreeFunction(Name = "TextNative::GetCursorPosition")]
		private static Vector2 DoGetCursorPosition(TextNativeSettings settings, Rect rect, int cursorPosition)
		{
			return default(Vector2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x5B4D4A0", Offset = "0x5B4C0A0", VA = "0x185B4D4A0")]
		[FreeFunction(Name = "TextNative::GetVertices")]
		private static void GetVertices(TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x5B4D090", Offset = "0x5B4BC90", VA = "0x185B4D090")]
		[FreeFunction(Name = "TextNative::GetOffset")]
		private static Vector2 DoGetOffset(TextNativeSettings settings, Rect rect)
		{
			return default(Vector2);
		}

		// Token: 0x060000B8 RID: 184
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5B4CED0", Offset = "0x5B4BAD0", VA = "0x185B4CED0")]
		[MethodImpl(4096)]
		private static extern float DoComputeTextWidth_Injected(ref TextNativeSettings settings);

		// Token: 0x060000B9 RID: 185
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5B4CE50", Offset = "0x5B4BA50", VA = "0x185B4CE50")]
		[MethodImpl(4096)]
		private static extern float DoComputeTextHeight_Injected(ref TextNativeSettings settings);

		// Token: 0x060000BA RID: 186
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x5B4CF50", Offset = "0x5B4BB50", VA = "0x185B4CF50")]
		[MethodImpl(4096)]
		private static extern void DoGetCursorPosition_Injected(ref TextNativeSettings settings, ref Rect rect, int cursorPosition, out Vector2 ret);

		// Token: 0x060000BB RID: 187
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5B4D430", Offset = "0x5B4C030", VA = "0x185B4D430")]
		[MethodImpl(4096)]
		private static extern void GetVertices_Injected(ref TextNativeSettings settings, IntPtr buffer, int vertexSize, ref int vertexCount);

		// Token: 0x060000BC RID: 188
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5B4D030", Offset = "0x5B4BC30", VA = "0x185B4D030")]
		[MethodImpl(4096)]
		private static extern void DoGetOffset_Injected(ref TextNativeSettings settings, ref Rect rect, out Vector2 ret);
	}
}
