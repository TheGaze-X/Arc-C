using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[NativeHeader("IMGUIScriptingClasses.h")]
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyle
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000163 RID: 355
		// (set) Token: 0x06000164 RID: 356
		[Token(Token = "0x17000051")]
		[NativeProperty("Name", false, TargetType.Function)]
		internal extern string rawName { [Token(Token = "0x6000163")] [Address(RVA = "0x599B660", Offset = "0x599A260", VA = "0x18599B660")] [MethodImpl(4096)] get; [Token(Token = "0x6000164")] [Address(RVA = "0x599C0B0", Offset = "0x599ACB0", VA = "0x18599C0B0")] [MethodImpl(4096)] set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000165 RID: 357
		// (set) Token: 0x06000166 RID: 358
		[Token(Token = "0x17000052")]
		[NativeProperty("Font", false, TargetType.Function)]
		public extern Font font { [Token(Token = "0x6000165")] [Address(RVA = "0x599AED0", Offset = "0x5999AD0", VA = "0x18599AED0")] [MethodImpl(4096)] get; [Token(Token = "0x6000166")] [Address(RVA = "0x599BC70", Offset = "0x599A870", VA = "0x18599BC70")] [MethodImpl(4096)] set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000167 RID: 359
		// (set) Token: 0x06000168 RID: 360
		[Token(Token = "0x17000053")]
		[NativeProperty("m_ImagePosition", false, TargetType.Field)]
		public extern ImagePosition imagePosition { [Token(Token = "0x6000167")] [Address(RVA = "0x599AF80", Offset = "0x5999B80", VA = "0x18599AF80")] [MethodImpl(4096)] get; [Token(Token = "0x6000168")] [Address(RVA = "0x599BD20", Offset = "0x599A920", VA = "0x18599BD20")] [MethodImpl(4096)] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000169 RID: 361
		// (set) Token: 0x0600016A RID: 362
		[Token(Token = "0x17000054")]
		[NativeProperty("m_Alignment", false, TargetType.Field)]
		public extern TextAnchor alignment { [Token(Token = "0x6000169")] [Address(RVA = "0x599AB80", Offset = "0x5999780", VA = "0x18599AB80")] [MethodImpl(4096)] get; [Token(Token = "0x600016A")] [Address(RVA = "0x599B980", Offset = "0x599A580", VA = "0x18599B980")] [MethodImpl(4096)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600016B RID: 363
		// (set) Token: 0x0600016C RID: 364
		[Token(Token = "0x17000055")]
		[NativeProperty("m_WordWrap", false, TargetType.Field)]
		public extern bool wordWrap { [Token(Token = "0x600016B")] [Address(RVA = "0x599B760", Offset = "0x599A360", VA = "0x18599B760")] [MethodImpl(4096)] get; [Token(Token = "0x600016C")] [Address(RVA = "0x599C1F0", Offset = "0x599ADF0", VA = "0x18599C1F0")] [MethodImpl(4096)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600016D RID: 365
		// (set) Token: 0x0600016E RID: 366
		[Token(Token = "0x17000056")]
		[NativeProperty("m_Clipping", false, TargetType.Field)]
		public extern TextClipping clipping { [Token(Token = "0x600016D")] [Address(RVA = "0x599AC80", Offset = "0x5999880", VA = "0x18599AC80")] [MethodImpl(4096)] get; [Token(Token = "0x600016E")] [Address(RVA = "0x599BA20", Offset = "0x599A620", VA = "0x18599BA20")] [MethodImpl(4096)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002778 File Offset: 0x00000978
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		[NativeProperty("m_ContentOffset", false, TargetType.Field)]
		public Vector2 contentOffset
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x599AD10", Offset = "0x5999910", VA = "0x18599AD10")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x599BAB0", Offset = "0x599A6B0", VA = "0x18599BAB0")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000171 RID: 369
		// (set) Token: 0x06000172 RID: 370
		[Token(Token = "0x17000058")]
		[NativeProperty("m_FixedWidth", false, TargetType.Field)]
		public extern float fixedWidth { [Token(Token = "0x6000171")] [Address(RVA = "0x599ADA0", Offset = "0x59999A0", VA = "0x18599ADA0")] [MethodImpl(4096)] get; [Token(Token = "0x6000172")] [Address(RVA = "0x599BB40", Offset = "0x599A740", VA = "0x18599BB40")] [MethodImpl(4096)] set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000173 RID: 371
		// (set) Token: 0x06000174 RID: 372
		[Token(Token = "0x17000059")]
		[NativeProperty("m_FixedHeight", false, TargetType.Field)]
		public extern float fixedHeight { [Token(Token = "0x6000173")] [Address(RVA = "0x599AD60", Offset = "0x5999960", VA = "0x18599AD60")] [MethodImpl(4096)] get; [Token(Token = "0x6000174")] [Address(RVA = "0x599BAF0", Offset = "0x599A6F0", VA = "0x18599BAF0")] [MethodImpl(4096)] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000175 RID: 373
		// (set) Token: 0x06000176 RID: 374
		[Token(Token = "0x1700005A")]
		[NativeProperty("m_StretchWidth", false, TargetType.Field)]
		public extern bool stretchWidth { [Token(Token = "0x6000175")] [Address(RVA = "0x599B720", Offset = "0x599A320", VA = "0x18599B720")] [MethodImpl(4096)] get; [Token(Token = "0x6000176")] [Address(RVA = "0x599C1A0", Offset = "0x599ADA0", VA = "0x18599C1A0")] [MethodImpl(4096)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000177 RID: 375
		// (set) Token: 0x06000178 RID: 376
		[Token(Token = "0x1700005B")]
		[NativeProperty("m_StretchHeight", false, TargetType.Field)]
		public extern bool stretchHeight { [Token(Token = "0x6000177")] [Address(RVA = "0x599B6E0", Offset = "0x599A2E0", VA = "0x18599B6E0")] [MethodImpl(4096)] get; [Token(Token = "0x6000178")] [Address(RVA = "0x599C150", Offset = "0x599AD50", VA = "0x18599C150")] [MethodImpl(4096)] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000179 RID: 377
		// (set) Token: 0x0600017A RID: 378
		[Token(Token = "0x1700005C")]
		[NativeProperty("m_FontSize", false, TargetType.Field)]
		public extern int fontSize { [Token(Token = "0x6000179")] [Address(RVA = "0x599AE50", Offset = "0x5999A50", VA = "0x18599AE50")] [MethodImpl(4096)] get; [Token(Token = "0x600017A")] [Address(RVA = "0x599BBF0", Offset = "0x599A7F0", VA = "0x18599BBF0")] [MethodImpl(4096)] set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017B RID: 379
		// (set) Token: 0x0600017C RID: 380
		[Token(Token = "0x1700005D")]
		[NativeProperty("m_FontStyle", false, TargetType.Field)]
		public extern FontStyle fontStyle { [Token(Token = "0x600017B")] [Address(RVA = "0x599AE90", Offset = "0x5999A90", VA = "0x18599AE90")] [MethodImpl(4096)] get; [Token(Token = "0x600017C")] [Address(RVA = "0x599BC30", Offset = "0x599A830", VA = "0x18599BC30")] [MethodImpl(4096)] set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600017D RID: 381
		// (set) Token: 0x0600017E RID: 382
		[Token(Token = "0x1700005E")]
		[NativeProperty("m_RichText", false, TargetType.Field)]
		public extern bool richText { [Token(Token = "0x600017D")] [Address(RVA = "0x599B6A0", Offset = "0x599A2A0", VA = "0x18599B6A0")] [MethodImpl(4096)] get; [Token(Token = "0x600017E")] [Address(RVA = "0x599C100", Offset = "0x599AD00", VA = "0x18599C100")] [MethodImpl(4096)] set; }

		// Token: 0x1700005F RID: 95
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005F")]
		[NativeProperty("m_ClipOffset", false, TargetType.Field)]
		internal Vector2 Internal_clipOffset
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x599B8E0", Offset = "0x599A4E0", VA = "0x18599B8E0")]
			set
			{
			}
		}

		// Token: 0x06000180 RID: 384
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5999F30", Offset = "0x5998B30", VA = "0x185999F30")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Create(GUIStyle self);

		// Token: 0x06000181 RID: 385
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5999EE0", Offset = "0x5998AE0", VA = "0x185999EE0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern IntPtr Internal_Copy(GUIStyle self, GUIStyle other);

		// Token: 0x06000182 RID: 386
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5999F70", Offset = "0x5998B70", VA = "0x185999F70")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr self);

		// Token: 0x06000183 RID: 387
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5999D10", Offset = "0x5998910", VA = "0x185999D10")]
		[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern IntPtr GetStyleStatePtr(int idx);

		// Token: 0x06000184 RID: 388
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5998A90", Offset = "0x5997690", VA = "0x185998A90")]
		[FreeFunction(Name = "GUIStyle_Bindings::AssignStyleState", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void AssignStyleState(int idx, IntPtr srcStyleState);

		// Token: 0x06000185 RID: 389
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5999CD0", Offset = "0x59988D0", VA = "0x185999CD0")]
		[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern IntPtr GetRectOffsetPtr(int idx);

		// Token: 0x06000186 RID: 390
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5998A40", Offset = "0x5997640", VA = "0x185998A40")]
		[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void AssignRectOffset(int idx, IntPtr srcRectOffset);

		// Token: 0x06000187 RID: 391
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x599A600", Offset = "0x5999200", VA = "0x18599A600")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetLineHeight")]
		[MethodImpl(4096)]
		private static extern float Internal_GetLineHeight(IntPtr target);

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x599A380", Offset = "0x5998F80", VA = "0x18599A380")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
		private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x599A020", Offset = "0x5998C20", VA = "0x18599A020")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
		private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x599A100", Offset = "0x5998D00", VA = "0x18599A100")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawCursor", HasExplicitThis = true)]
		private void Internal_DrawCursor(Rect position, GUIContent content, int pos, Color cursorColor)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x599A220", Offset = "0x5998E20", VA = "0x18599A220")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_DrawWithTextSelection", HasExplicitThis = true)]
		private void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, Color cursorColor, Color selectionColor)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x599A4B0", Offset = "0x59990B0", VA = "0x18599A4B0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorPixelPosition", HasExplicitThis = true)]
		internal Vector2 Internal_GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return default(Vector2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x599A5A0", Offset = "0x59991A0", VA = "0x18599A5A0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorStringIndex", HasExplicitThis = true)]
		internal int Internal_GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return 0;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x599A6B0", Offset = "0x59992B0", VA = "0x18599A6B0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetSelectedRenderedText", HasExplicitThis = true)]
		internal string Internal_GetSelectedRenderedText(Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex)
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x5998C20", Offset = "0x5997820", VA = "0x185998C20")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSize(GUIContent content)
		{
			return default(Vector2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x5998BC0", Offset = "0x59977C0", VA = "0x185998BC0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
		internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
		{
			return default(Vector2);
		}

		// Token: 0x06000191 RID: 401
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x5998AE0", Offset = "0x59976E0", VA = "0x185998AE0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern float Internal_CalcHeight(GUIContent content, float width);

		// Token: 0x06000192 RID: 402 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5999DB0", Offset = "0x59989B0", VA = "0x185999DB0")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
		private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
		{
			return default(Vector2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x599A7F0", Offset = "0x59993F0", VA = "0x18599A7F0")]
		[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
		internal static void SetMouseTooltip(string tooltip, Rect screenRect)
		{
		}

		// Token: 0x06000194 RID: 404
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x599A720", Offset = "0x5999320", VA = "0x18599A720")]
		[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
		[MethodImpl(4096)]
		internal static extern bool IsTooltipActive(string tooltip);

		// Token: 0x06000195 RID: 405
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x599A410", Offset = "0x5999010", VA = "0x18599A410")]
		[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetCursorFlashOffset")]
		[MethodImpl(4096)]
		private static extern float Internal_GetCursorFlashOffset();

		// Token: 0x06000196 RID: 406
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x599A760", Offset = "0x5999360", VA = "0x18599A760")]
		[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
		[MethodImpl(4096)]
		internal static extern void SetDefaultFont(Font font);

		// Token: 0x06000197 RID: 407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x599AA90", Offset = "0x5999690", VA = "0x18599AA90")]
		public GUIStyle()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x599A9C0", Offset = "0x59995C0", VA = "0x18599A9C0")]
		public GUIStyle(GUIStyle other)
		{
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x5999AF0", Offset = "0x59986F0", VA = "0x185999AF0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600019A RID: 410 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public string name
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x599B190", Offset = "0x5999D90", VA = "0x18599B190")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x599BDC0", Offset = "0x599A9C0", VA = "0x18599BDC0")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		public GUIStyleState normal
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x599B2B0", Offset = "0x5999EB0", VA = "0x18599B2B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x599BE10", Offset = "0x599AA10", VA = "0x18599BE10")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public GUIStyleState hover
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x599AF10", Offset = "0x5999B10", VA = "0x18599AF10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x599BCC0", Offset = "0x599A8C0", VA = "0x18599BCC0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public GUIStyleState active
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x599AB10", Offset = "0x5999710", VA = "0x18599AB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x599B920", Offset = "0x599A520", VA = "0x18599B920")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public GUIStyleState onNormal
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x599B470", Offset = "0x599A070", VA = "0x18599B470")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x599BF90", Offset = "0x599AB90", VA = "0x18599BF90")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public GUIStyleState onHover
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x599B400", Offset = "0x599A000", VA = "0x18599B400")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x599BF30", Offset = "0x599AB30", VA = "0x18599BF30")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public GUIStyleState onActive
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x599B320", Offset = "0x5999F20", VA = "0x18599B320")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x599BE70", Offset = "0x599AA70", VA = "0x18599BE70")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public GUIStyleState focused
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x599ADE0", Offset = "0x59999E0", VA = "0x18599ADE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x599BB90", Offset = "0x599A790", VA = "0x18599BB90")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000068")]
		public GUIStyleState onFocused
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x599B390", Offset = "0x5999F90", VA = "0x18599B390")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x599BED0", Offset = "0x599AAD0", VA = "0x18599BED0")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public RectOffset border
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x599ABC0", Offset = "0x59997C0", VA = "0x18599ABC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x599B9C0", Offset = "0x599A5C0", VA = "0x18599B9C0")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001AE RID: 430 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public RectOffset margin
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x599B0D0", Offset = "0x5999CD0", VA = "0x18599B0D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x599BD60", Offset = "0x599A960", VA = "0x18599BD60")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		public RectOffset padding
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x599B5A0", Offset = "0x599A1A0", VA = "0x18599B5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x599C050", Offset = "0x599AC50", VA = "0x18599C050")]
			set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public RectOffset overflow
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x599B4E0", Offset = "0x599A0E0", VA = "0x18599B4E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x599BFF0", Offset = "0x599ABF0", VA = "0x18599BFF0")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x1700006D")]
		public float lineHeight
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x599B060", Offset = "0x5999C60", VA = "0x18599B060")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x59998B0", Offset = "0x59984B0", VA = "0x1859998B0")]
		public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x5999820", Offset = "0x5998420", VA = "0x185999820")]
		public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x5999990", Offset = "0x5998590", VA = "0x185999990")]
		public void Draw(Rect position, GUIContent content, int controlID)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x5999670", Offset = "0x5998270", VA = "0x185999670")]
		public void Draw(Rect position, GUIContent content, int controlID, bool on)
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x5999A50", Offset = "0x5998650", VA = "0x185999A50")]
		public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x5999740", Offset = "0x5998340", VA = "0x185999740")]
		private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x5998C80", Offset = "0x5997880", VA = "0x185998C80")]
		public void DrawCursor(Rect position, GUIContent content, int controlID, int character)
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x5998F70", Offset = "0x5997B70", VA = "0x185998F70")]
		internal void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x59994D0", Offset = "0x59980D0", VA = "0x1859994D0")]
		internal void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x5999340", Offset = "0x5997F40", VA = "0x185999340")]
		public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x599B7A0", Offset = "0x599A3A0", VA = "0x18599B7A0")]
		public static implicit operator GUIStyle(string str)
		{
			return null;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700006E")]
		public static GUIStyle none
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x599B1F0", Offset = "0x5999DF0", VA = "0x18599B1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x5999BF0", Offset = "0x59987F0", VA = "0x185999BF0")]
		public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
		{
			return default(Vector2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x5999C70", Offset = "0x5998870", VA = "0x185999C70")]
		public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
		{
			return 0;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x5998C20", Offset = "0x5997820", VA = "0x185998C20")]
		public Vector2 CalcSize(GUIContent content)
		{
			return default(Vector2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x5998BC0", Offset = "0x59977C0", VA = "0x185998BC0")]
		internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
		{
			return default(Vector2);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5998AE0", Offset = "0x59976E0", VA = "0x185998AE0")]
		public float CalcHeight(GUIContent content, float width)
		{
			return 0f;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x1700006F")]
		public bool isHeightDependantOnWidth
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x599AFC0", Offset = "0x5999BC0", VA = "0x18599AFC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x5998B40", Offset = "0x5997740", VA = "0x185998B40")]
		public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x599A870", Offset = "0x5999470", VA = "0x18599A870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001CA RID: 458
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x599ACC0", Offset = "0x59998C0", VA = "0x18599ACC0")]
		[MethodImpl(4096)]
		private extern void get_contentOffset_Injected(out Vector2 ret);

		// Token: 0x060001CB RID: 459
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x599BA60", Offset = "0x599A660", VA = "0x18599BA60")]
		[MethodImpl(4096)]
		private extern void set_contentOffset_Injected(ref Vector2 value);

		// Token: 0x060001CC RID: 460
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x599B890", Offset = "0x599A490", VA = "0x18599B890")]
		[MethodImpl(4096)]
		private extern void set_Internal_clipOffset_Injected(ref Vector2 value);

		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x599A2F0", Offset = "0x5998EF0", VA = "0x18599A2F0")]
		[MethodImpl(4096)]
		private extern void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x5999FB0", Offset = "0x5998BB0", VA = "0x185999FB0")]
		[MethodImpl(4096)]
		private extern void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on);

		// Token: 0x060001CF RID: 463
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x599A090", Offset = "0x5998C90", VA = "0x18599A090")]
		[MethodImpl(4096)]
		private extern void Internal_DrawCursor_Injected(ref Rect position, GUIContent content, int pos, ref Color cursorColor);

		// Token: 0x060001D0 RID: 464
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x599A170", Offset = "0x5998D70", VA = "0x18599A170")]
		[MethodImpl(4096)]
		private extern void Internal_DrawWithTextSelection_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref Color cursorColor, ref Color selectionColor);

		// Token: 0x060001D1 RID: 465
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x599A440", Offset = "0x5999040", VA = "0x18599A440")]
		[MethodImpl(4096)]
		private extern void Internal_GetCursorPixelPosition_Injected(ref Rect position, GUIContent content, int cursorStringIndex, out Vector2 ret);

		// Token: 0x060001D2 RID: 466
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x599A530", Offset = "0x5999130", VA = "0x18599A530")]
		[MethodImpl(4096)]
		private extern int Internal_GetCursorStringIndex_Injected(ref Rect position, GUIContent content, ref Vector2 cursorPixelPosition);

		// Token: 0x060001D3 RID: 467
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x599A640", Offset = "0x5999240", VA = "0x18599A640")]
		[MethodImpl(4096)]
		private extern string Internal_GetSelectedRenderedText_Injected(ref Rect localPosition, GUIContent mContent, int selectIndex, int cursorIndex);

		// Token: 0x060001D4 RID: 468
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x5999E80", Offset = "0x5998A80", VA = "0x185999E80")]
		[MethodImpl(4096)]
		private extern void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret);

		// Token: 0x060001D5 RID: 469
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5999E10", Offset = "0x5998A10", VA = "0x185999E10")]
		[MethodImpl(4096)]
		private extern void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret);

		// Token: 0x060001D6 RID: 470
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x5999D50", Offset = "0x5998950", VA = "0x185999D50")]
		[MethodImpl(4096)]
		private extern void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret);

		// Token: 0x060001D7 RID: 471
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x599A7A0", Offset = "0x59993A0", VA = "0x18599A7A0")]
		[MethodImpl(4096)]
		private static extern void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect);

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private GUIStyleState m_Normal;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private GUIStyleState m_Hover;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private GUIStyleState m_Active;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private GUIStyleState m_Focused;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private GUIStyleState m_OnNormal;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private GUIStyleState m_OnHover;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private GUIStyleState m_OnActive;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private GUIStyleState m_OnFocused;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private RectOffset m_Border;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private RectOffset m_Padding;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private RectOffset m_Margin;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private RectOffset m_Overflow;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private string m_Name;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showKeyboardFocus;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static GUIStyle s_None;
	}
}
