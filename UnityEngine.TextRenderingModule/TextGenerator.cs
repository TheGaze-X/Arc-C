using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[NativeHeader("Modules/TextRendering/TextGenerator.h")]
	[UsedByNativeCode]
	[StructLayout(0)]
	public sealed class TextGenerator : IDisposable
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5A04A80", Offset = "0x5A03680", VA = "0x185A04A80")]
		public TextGenerator()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5A04910", Offset = "0x5A03510", VA = "0x185A04910")]
		public TextGenerator(int initialCapacity)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5A033A0", Offset = "0x5A01FA0", VA = "0x185A033A0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5A04500", Offset = "0x5A03100", VA = "0x185A04500", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x17000001")]
		public int characterCountVisible
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5A04BE0", Offset = "0x5A037E0", VA = "0x185A04BE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5A045A0", Offset = "0x5A031A0", VA = "0x185A045A0")]
		private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings)
		{
			return default(TextGenerationSettings);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5A03780", Offset = "0x5A02380", VA = "0x185A03780")]
		public void Invalidate()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5A034B0", Offset = "0x5A020B0", VA = "0x185A034B0")]
		public void GetCharacters(List<UICharInfo> characters)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5A03500", Offset = "0x5A02100", VA = "0x185A03500")]
		public void GetLines(List<UILineInfo> lines)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5A036C0", Offset = "0x5A022C0", VA = "0x185A036C0")]
		public void GetVertices(List<UIVertex> vertices)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5A03600", Offset = "0x5A02200", VA = "0x185A03600")]
		public float GetPreferredWidth(string str, TextGenerationSettings settings)
		{
			return 0f;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5A03550", Offset = "0x5A02150", VA = "0x185A03550")]
		public float GetPreferredHeight(string str, TextGenerationSettings settings)
		{
			return 0f;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020F8 File Offset: 0x000002F8
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x5A03E30", Offset = "0x5A02A30", VA = "0x185A03E30")]
		public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context)
		{
			return default(bool);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x5A044A0", Offset = "0x5A030A0", VA = "0x185A044A0")]
		public bool Populate(string str, TextGenerationSettings settings)
		{
			return default(bool);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5A03AB0", Offset = "0x5A026B0", VA = "0x185A03AB0")]
		private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings)
		{
			return TextGenerationError.None;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5A03790", Offset = "0x5A02390", VA = "0x185A03790")]
		private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings)
		{
			return TextGenerationError.None;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000002")]
		public IList<UIVertex> verts
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x5A04E20", Offset = "0x5A03A20", VA = "0x185A04E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000003")]
		public IList<UICharInfo> characters
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x5A04C60", Offset = "0x5A03860", VA = "0x185A04C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x17000004")]
		public IList<UILineInfo> lines
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x5A04D10", Offset = "0x5A03910", VA = "0x185A04D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x17000005")]
		public Rect rectExtents
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x5A04DD0", Offset = "0x5A039D0", VA = "0x185A04DD0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24
		[Token(Token = "0x17000006")]
		public extern int characterCount { [Token(Token = "0x6000018")] [Address(RVA = "0x5A04C20", Offset = "0x5A03820", VA = "0x185A04C20")] [MethodImpl(4096)] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25
		[Token(Token = "0x17000007")]
		public extern int lineCount { [Token(Token = "0x6000019")] [Address(RVA = "0x5A04CD0", Offset = "0x5A038D0", VA = "0x185A04CD0")] [MethodImpl(4096)] get; }

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5A03710", Offset = "0x5A02310", VA = "0x185A03710")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create();

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5A03740", Offset = "0x5A02340", VA = "0x185A03740")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		// Token: 0x0600001C RID: 28 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5A04320", Offset = "0x5A02F20", VA = "0x185A04320")]
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5A04120", Offset = "0x5A02D20", VA = "0x185A04120")]
		internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error)
		{
			return default(bool);
		}

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5A036C0", Offset = "0x5A022C0", VA = "0x185A036C0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private extern void GetVerticesInternal(object vertices);

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5A034B0", Offset = "0x5A020B0", VA = "0x185A034B0")]
		[NativeThrows]
		[MethodImpl(4096)]
		private extern void GetCharactersInternal(object characters);

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5A03500", Offset = "0x5A02100", VA = "0x185A03500")]
		[NativeThrows]
		[MethodImpl(4096)]
		private extern void GetLinesInternal(object lines);

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5A04D80", Offset = "0x5A03980", VA = "0x185A04D80")]
		[MethodImpl(4096)]
		private extern void get_rectExtents_Injected(out Rect ret);

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5A04060", Offset = "0x5A02C60", VA = "0x185A04060")]
		[MethodImpl(4096)]
		private extern bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error);

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_LastString;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextGenerationSettings m_LastSettings;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_HasGenerated;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private TextGenerationError m_LastValid;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<UIVertex> m_Verts;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly List<UICharInfo> m_Characters;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly List<UILineInfo> m_Lines;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool m_CachedVerts;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool m_CachedCharacters;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool m_CachedLines;
	}
}
