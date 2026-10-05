using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class GUILayout
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x59946C0", Offset = "0x59932C0", VA = "0x1859946C0")]
		public static void Label(string text, params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x59947B0", Offset = "0x59933B0", VA = "0x1859947B0")]
		public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x59931B0", Offset = "0x5991DB0", VA = "0x1859931B0")]
		private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x5992A10", Offset = "0x5991610", VA = "0x185992A10")]
		public static void Box(Texture image, params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5992E10", Offset = "0x5991A10", VA = "0x185992E10")]
		private static void DoBox(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x5992C60", Offset = "0x5991860", VA = "0x185992C60")]
		public static bool Button(string text, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x5992F00", Offset = "0x5991B00", VA = "0x185992F00")]
		private static bool DoButton(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return default(bool);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5995320", Offset = "0x5993F20", VA = "0x185995320")]
		public static string TextField(string text, params GUILayoutOption[] options)
		{
			return null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x59932E0", Offset = "0x5991EE0", VA = "0x1859932E0")]
		private static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, GUILayoutOption[] options)
		{
			return null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x59953F0", Offset = "0x5993FF0", VA = "0x1859953F0")]
		public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
		{
			return default(bool);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x59934D0", Offset = "0x59920D0", VA = "0x1859934D0")]
		private static bool DoToggle(bool value, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return default(bool);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x5994C00", Offset = "0x5993800", VA = "0x185994C00")]
		public static int SelectionGrid(int selected, string[] texts, int xCount, params GUILayoutOption[] options)
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x5994AF0", Offset = "0x59936F0", VA = "0x185994AF0")]
		public static int SelectionGrid(int selected, Texture[] images, int xCount, params GUILayoutOption[] options)
		{
			return 0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x5994EF0", Offset = "0x5993AF0", VA = "0x185994EF0")]
		public static int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
		{
			return 0;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x59943F0", Offset = "0x5992FF0", VA = "0x1859943F0")]
		public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
		{
			return 0f;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x5992FF0", Offset = "0x5991BF0", VA = "0x185992FF0")]
		private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options)
		{
			return 0f;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x5995050", Offset = "0x5993C50", VA = "0x185995050")]
		public static void Space(float pixels)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x5993FB0", Offset = "0x5992BB0", VA = "0x185993FB0")]
		public static void FlexibleSpace()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x5991DC0", Offset = "0x59909C0", VA = "0x185991DC0")]
		public static void BeginHorizontal(params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x5991FB0", Offset = "0x5990BB0", VA = "0x185991FB0")]
		public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x5993D00", Offset = "0x5992900", VA = "0x185993D00")]
		public static void EndHorizontal()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5992900", Offset = "0x5991500", VA = "0x185992900")]
		public static void BeginVertical(params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x59929A0", Offset = "0x59915A0", VA = "0x1859929A0")]
		public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5992780", Offset = "0x5991380", VA = "0x185992780")]
		public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5993E30", Offset = "0x5992A30", VA = "0x185993E30")]
		public static void EndVertical()
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x59919D0", Offset = "0x59905D0", VA = "0x1859919D0")]
		public static void BeginArea(Rect screenRect)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5991D20", Offset = "0x5990920", VA = "0x185991D20")]
		public static void BeginArea(Rect screenRect, string text)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5991A80", Offset = "0x5990680", VA = "0x185991A80")]
		public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5993A50", Offset = "0x5992650", VA = "0x185993A50")]
		public static void EndArea()
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5992130", Offset = "0x5990D30", VA = "0x185992130")]
		public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x59922E0", Offset = "0x5990EE0", VA = "0x1859922E0")]
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x59924B0", Offset = "0x59910B0", VA = "0x1859924B0")]
		public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
		{
			return default(Vector2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5993D40", Offset = "0x5992940", VA = "0x185993D40")]
		public static void EndScrollView()
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5993DB0", Offset = "0x59929B0", VA = "0x185993DB0")]
		internal static void EndScrollView(bool handleScrollWheel)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x59955A0", Offset = "0x59941A0", VA = "0x1859955A0")]
		public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5993710", Offset = "0x5992310", VA = "0x185993710")]
		private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x59954F0", Offset = "0x59940F0", VA = "0x1859954F0")]
		public static GUILayoutOption Width(float width)
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5994A40", Offset = "0x5993640", VA = "0x185994A40")]
		public static GUILayoutOption MinWidth(float minWidth)
		{
			return null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x59948E0", Offset = "0x59934E0", VA = "0x1859948E0")]
		public static GUILayoutOption MaxWidth(float maxWidth)
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x5994340", Offset = "0x5992F40", VA = "0x185994340")]
		public static GUILayoutOption Height(float height)
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5994990", Offset = "0x5993590", VA = "0x185994990")]
		public static GUILayoutOption MinHeight(float minHeight)
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x5994830", Offset = "0x5993430", VA = "0x185994830")]
		public static GUILayoutOption MaxHeight(float maxHeight)
		{
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5993F10", Offset = "0x5992B10", VA = "0x185993F10")]
		public static GUILayoutOption ExpandWidth(bool expand)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5993E70", Offset = "0x5992A70", VA = "0x185993E70")]
		public static GUILayoutOption ExpandHeight(bool expand)
		{
			return null;
		}

		// Token: 0x02000012 RID: 18
		[Token(Token = "0x2000012")]
		private sealed class LayoutedWindow
		{
			// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x59A78C0", Offset = "0x59A64C0", VA = "0x1859A78C0")]
			internal LayoutedWindow(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style)
			{
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x59A7750", Offset = "0x59A6350", VA = "0x1859A7750")]
			public void DoWindow(int windowID)
			{
			}

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x10")]
			private readonly GUI.WindowFunction m_Func;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x18")]
			private readonly Rect m_ScreenRect;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x28")]
			private readonly GUILayoutOption[] m_Options;

			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			[FieldOffset(Offset = "0x30")]
			private readonly GUIStyle m_Style;
		}
	}
}
