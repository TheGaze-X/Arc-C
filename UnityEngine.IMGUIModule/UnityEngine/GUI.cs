using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
	[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
	public class GUI
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public static Color color
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x59A69A0", Offset = "0x59A55A0", VA = "0x1859A69A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x59A6E90", Offset = "0x59A5A90", VA = "0x1859A6E90")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000021F0 File Offset: 0x000003F0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public static Color backgroundColor
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x59A6860", Offset = "0x59A5460", VA = "0x1859A6860")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x59A6DA0", Offset = "0x59A59A0", VA = "0x1859A6DA0")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002208 File Offset: 0x00000408
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public static Color contentColor
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x59A6A50", Offset = "0x59A5650", VA = "0x1859A6A50")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x59A6F40", Offset = "0x59A5B40", VA = "0x1859A6F40")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000044 RID: 68
		// (set) Token: 0x06000045 RID: 69
		[Token(Token = "0x1700001C")]
		public static extern bool changed { [Token(Token = "0x6000044")] [Address(RVA = "0x59A6930", Offset = "0x59A5530", VA = "0x1859A6930")] [MethodImpl(4096)] get; [Token(Token = "0x6000045")] [Address(RVA = "0x59A6E10", Offset = "0x59A5A10", VA = "0x1859A6E10")] [MethodImpl(4096)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000046 RID: 70
		// (set) Token: 0x06000047 RID: 71
		[Token(Token = "0x1700001D")]
		public static extern bool enabled { [Token(Token = "0x6000046")] [Address(RVA = "0x59A6AC0", Offset = "0x59A56C0", VA = "0x1859A6AC0")] [MethodImpl(4096)] get; [Token(Token = "0x6000047")] [Address(RVA = "0x59A6FB0", Offset = "0x59A5BB0", VA = "0x1859A6FB0")] [MethodImpl(4096)] set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000048 RID: 72
		[Token(Token = "0x1700001E")]
		internal static extern bool usePageScrollbars { [Token(Token = "0x6000048")] [Address(RVA = "0x59A6D30", Offset = "0x59A5930", VA = "0x1859A6D30")] [MethodImpl(4096)] get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000049 RID: 73
		[Token(Token = "0x1700001F")]
		internal static extern Material blendMaterial { [Token(Token = "0x6000049")] [Address(RVA = "0x59A68D0", Offset = "0x59A54D0", VA = "0x1859A68D0")] [FreeFunction("GetGUIBlendMaterial")] [MethodImpl(4096)] get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004A RID: 74
		[Token(Token = "0x17000020")]
		internal static extern Material blitMaterial { [Token(Token = "0x600004A")] [Address(RVA = "0x59A6900", Offset = "0x59A5500", VA = "0x1859A6900")] [FreeFunction("GetGUIBlitMaterial")] [MethodImpl(4096)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004B RID: 75
		[Token(Token = "0x17000021")]
		internal static extern Material roundedRectMaterial { [Token(Token = "0x600004B")] [Address(RVA = "0x59A6BD0", Offset = "0x59A57D0", VA = "0x1859A6BD0")] [FreeFunction("GetGUIRoundedRectMaterial")] [MethodImpl(4096)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004C RID: 76
		[Token(Token = "0x17000022")]
		internal static extern Material roundedRectWithColorPerBorderMaterial { [Token(Token = "0x600004C")] [Address(RVA = "0x59A6C00", Offset = "0x59A5800", VA = "0x1859A6C00")] [FreeFunction("GetGUIRoundedRectWithColorPerBorderMaterial")] [MethodImpl(4096)] get; }

		// Token: 0x0600004D RID: 77
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x59A3610", Offset = "0x59A2210", VA = "0x1859A3610")]
		[MethodImpl(4096)]
		internal static extern void GrabMouseControl(int id);

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x59A45C0", Offset = "0x59A31C0", VA = "0x1859A45C0")]
		[MethodImpl(4096)]
		internal static extern bool HasMouseControl(int id);

		// Token: 0x0600004F RID: 79
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x59A4E70", Offset = "0x59A3A70", VA = "0x1859A4E70")]
		[MethodImpl(4096)]
		internal static extern void ReleaseMouseControl();

		// Token: 0x06000050 RID: 80
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x59A5A80", Offset = "0x59A4680", VA = "0x1859A5A80")]
		[FreeFunction("GetGUIState().SetNameOfNextControl")]
		[MethodImpl(4096)]
		public static extern void SetNextControlName(string name);

		// Token: 0x06000051 RID: 81
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x59A4A40", Offset = "0x59A3640", VA = "0x1859A4A40")]
		[MethodImpl(4096)]
		internal static extern void InternalRepaintEditorWindow();

		// Token: 0x06000052 RID: 82 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59A4AE0", Offset = "0x59A36E0", VA = "0x1859A4AE0")]
		private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout)
		{
			return default(Rect);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		internal static int scrollTroughSide
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x59A6C30", Offset = "0x59A5830", VA = "0x1859A6C30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x59A70B0", Offset = "0x59A5CB0", VA = "0x1859A70B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		internal static DateTime nextScrollStepTime
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x59A6B80", Offset = "0x59A5780", VA = "0x1859A6B80")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x59A7050", Offset = "0x59A5C50", VA = "0x1859A7050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public static GUISkin skin
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x59A6CD0", Offset = "0x59A58D0", VA = "0x1859A6CD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x59A7110", Offset = "0x59A5D10", VA = "0x1859A7110")]
			set
			{
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59A0280", Offset = "0x599EE80", VA = "0x1859A0280")]
		internal static void DoSetSkin(GUISkin newSkin)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public static Matrix4x4 matrix
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x59A6AF0", Offset = "0x59A56F0", VA = "0x1859A6AF0")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x59A6FF0", Offset = "0x59A5BF0", VA = "0x1859A6FF0")]
			set
			{
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x59A4BC0", Offset = "0x59A37C0", VA = "0x1859A4BC0")]
		public static void Label(Rect position, string text)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59A4CC0", Offset = "0x59A38C0", VA = "0x1859A4CC0")]
		public static void Label(Rect position, GUIContent content, GUIStyle style)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x59A2410", Offset = "0x59A1010", VA = "0x1859A2410")]
		public static void DrawTexture(Rect position, Texture image)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59A22A0", Offset = "0x59A0EA0", VA = "0x1859A22A0")]
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x59A11C0", Offset = "0x599FDC0", VA = "0x1859A11C0")]
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59A1EB0", Offset = "0x59A0AB0", VA = "0x1859A1EB0")]
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59A1FD0", Offset = "0x59A0BD0", VA = "0x1859A1FD0")]
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x59A1310", Offset = "0x599FF10", VA = "0x1859A1310")]
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59A1D30", Offset = "0x59A0930", VA = "0x1859A1D30")]
		public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x59A1BE0", Offset = "0x59A07E0", VA = "0x1859A1BE0")]
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x59A1530", Offset = "0x59A0130", VA = "0x1859A1530")]
		internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x599E380", Offset = "0x599CF80", VA = "0x18599E380")]
		internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect)
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x599D910", Offset = "0x599C510", VA = "0x18599D910")]
		public static void Box(Rect position, string text)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x599D6E0", Offset = "0x599C2E0", VA = "0x18599D6E0")]
		public static void Box(Rect position, GUIContent content, GUIStyle style)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x599D9D0", Offset = "0x599C5D0", VA = "0x18599D9D0")]
		public static bool Button(Rect position, string text)
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x599DC50", Offset = "0x599C850", VA = "0x18599DC50")]
		public static bool Button(Rect position, GUIContent content)
		{
			return default(bool);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x599DA90", Offset = "0x599C690", VA = "0x18599DA90")]
		public static bool Button(Rect position, GUIContent content, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x599DCE0", Offset = "0x599C8E0", VA = "0x18599DCE0")]
		internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x599FE40", Offset = "0x599EA40", VA = "0x18599FE40")]
		private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType)
		{
			return default(bool);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x59A5C50", Offset = "0x59A4850", VA = "0x1859A5C50")]
		public static string TextField(Rect position, string text)
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x59A4D40", Offset = "0x59A3940", VA = "0x1859A4D40")]
		internal static string PasswordFieldGetStrToShow(string password, char maskChar)
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x59A03F0", Offset = "0x599EFF0", VA = "0x1859A03F0")]
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x59A0E70", Offset = "0x599FA70", VA = "0x1859A0E70")]
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x59A04D0", Offset = "0x599F0D0", VA = "0x1859A04D0")]
		internal static void DoTextField(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x59A4090", Offset = "0x59A2C90", VA = "0x1859A4090")]
		private static void HandleTextFieldEventForTouchscreen(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, char maskChar, TextEditor editor)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x59A39C0", Offset = "0x59A25C0", VA = "0x1859A39C0")]
		private static void HandleTextFieldEventForDesktop(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, TextEditor editor)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x59A3650", Offset = "0x59A2250", VA = "0x1859A3650")]
		private static void HandleTextFieldEventForDesktopWithForcedKeyboard(Rect position, int id, GUIContent content, bool multiline, int maxLength, GUIStyle style, string secureText, TextEditor editor)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x59A5D90", Offset = "0x59A4990", VA = "0x1859A5D90")]
		public static bool Toggle(Rect position, bool value, GUIContent content, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x59A5990", Offset = "0x59A4590", VA = "0x1859A5990")]
		public static int SelectionGrid(Rect position, int selected, GUIContent[] contents, int xCount, GUIStyle style)
		{
			return 0;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x599E1E0", Offset = "0x599CDE0", VA = "0x18599E1E0")]
		internal static int CalcTotalHorizSpacing(int xCount, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle)
		{
			return 0;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x599F6B0", Offset = "0x599E2B0", VA = "0x18599F6B0")]
		internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x599FAA0", Offset = "0x599E6A0", VA = "0x18599FAA0")]
		private static void DoLabel(Rect position, GUIContent content, GUIStyle style)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x59A0F30", Offset = "0x599FB30", VA = "0x1859A0F30")]
		internal static bool DoToggle(Rect position, int id, bool value, GUIContent content, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x599F580", Offset = "0x599E180", VA = "0x18599F580")]
		internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x599EA30", Offset = "0x599D630", VA = "0x18599EA30")]
		private static int DoButtonGrid(Rect position, int selected, GUIContent[] contents, string[] controlNames, int itemsPerRow, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, [Optional] bool[] contentsEnabled)
		{
			return 0;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x599DE40", Offset = "0x599CA40", VA = "0x18599DE40")]
		private static Rect[] CalcGridRects(Rect position, GUIContent[] contents, int xCount, float elemWidth, float elemHeight, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize)
		{
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x59A4970", Offset = "0x59A3570", VA = "0x1859A4970")]
		public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb)
		{
			return 0f;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x59A5AC0", Offset = "0x59A46C0", VA = "0x1859A5AC0")]
		public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, [Optional] GUIStyle thumbExtent)
		{
			return 0f;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x59A4600", Offset = "0x59A3200", VA = "0x1859A4600")]
		public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style)
		{
			return 0f;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x59A4EA0", Offset = "0x59A3AA0", VA = "0x1859A4EA0")]
		internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style)
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x59A5F30", Offset = "0x59A4B30", VA = "0x1859A5F30")]
		public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style)
		{
			return 0f;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x59A51C0", Offset = "0x59A3DC0", VA = "0x1859A51C0")]
		internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz)
		{
			return 0f;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x599C570", Offset = "0x599B170", VA = "0x18599C570")]
		public static void BeginGroup(Rect position, GUIContent content, GUIStyle style)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x599C240", Offset = "0x599AE40", VA = "0x18599C240")]
		internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x59A25A0", Offset = "0x59A11A0", VA = "0x1859A25A0")]
		public static void EndGroup()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000027")]
		internal static GenericStack scrollViewStates
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x59A6C80", Offset = "0x59A5880", VA = "0x1859A6C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x599D4E0", Offset = "0x599C0E0", VA = "0x18599D4E0")]
		public static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical)
		{
			return default(Vector2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x599C630", Offset = "0x599B230", VA = "0x18599C630")]
		internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background)
		{
			return default(Vector2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x59A25E0", Offset = "0x59A11E0", VA = "0x1859A25E0")]
		public static void EndScrollView()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x59A2630", Offset = "0x59A1230", VA = "0x1859A2630")]
		public static void EndScrollView(bool handleScrollWheel)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x59A62A0", Offset = "0x59A4EA0", VA = "0x1859A62A0")]
		public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style)
		{
			return default(Rect);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x59A1070", Offset = "0x599FC70", VA = "0x1859A1070")]
		private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout)
		{
			return default(Rect);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x599E6B0", Offset = "0x599D2B0", VA = "0x18599E6B0")]
		[RequiredByNativeCode]
		internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style)
		{
		}

		// Token: 0x06000092 RID: 146
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x59A6960", Offset = "0x59A5560", VA = "0x1859A6960")]
		[MethodImpl(4096)]
		private static extern void get_color_Injected(out Color ret);

		// Token: 0x06000093 RID: 147
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x59A6E50", Offset = "0x59A5A50", VA = "0x1859A6E50")]
		[MethodImpl(4096)]
		private static extern void set_color_Injected(ref Color value);

		// Token: 0x06000094 RID: 148
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x59A6820", Offset = "0x59A5420", VA = "0x1859A6820")]
		[MethodImpl(4096)]
		private static extern void get_backgroundColor_Injected(out Color ret);

		// Token: 0x06000095 RID: 149
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x59A6D60", Offset = "0x59A5960", VA = "0x1859A6D60")]
		[MethodImpl(4096)]
		private static extern void set_backgroundColor_Injected(ref Color value);

		// Token: 0x06000096 RID: 150
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x59A6A10", Offset = "0x59A5610", VA = "0x1859A6A10")]
		[MethodImpl(4096)]
		private static extern void get_contentColor_Injected(out Color ret);

		// Token: 0x06000097 RID: 151
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x59A6F00", Offset = "0x59A5B00", VA = "0x1859A6F00")]
		[MethodImpl(4096)]
		private static extern void set_contentColor_Injected(ref Color value);

		// Token: 0x06000098 RID: 152
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x59A4A70", Offset = "0x59A3670", VA = "0x1859A4A70")]
		[MethodImpl(4096)]
		private static extern void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret);

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int s_ScrollControlId;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int s_HotTextField;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int s_BoxHash;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int s_ButonHash;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int s_RepeatButtonHash;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int s_ToggleHash;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int s_ButtonGridHash;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int s_SliderHash;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int s_BeginGroupHash;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int s_ScrollviewHash;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static GUISkin s_Skin;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static Rect s_ToolTipRect;

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public enum ToolbarButtonSize
		{
			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			Fixed,
			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			FitToContents
		}

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600009A RID: 154
		[Token(Token = "0x200000B")]
		public delegate void WindowFunction(int id);
	}
}
