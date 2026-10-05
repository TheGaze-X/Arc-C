using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
	public class GUILayoutUtility
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5990170", Offset = "0x598ED70", VA = "0x185990170")]
		private static Rect Internal_GetWindowRect(int windowID)
		{
			return default(Rect);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5990230", Offset = "0x598EE30", VA = "0x185990230")]
		private static void Internal_MoveWindow(int windowID, Rect r)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		internal static int unbalancedgroupscount
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x5991920", Offset = "0x5990520", VA = "0x185991920")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x5991970", Offset = "0x5990570", VA = "0x185991970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x598FD90", Offset = "0x598E990", VA = "0x18598FD90")]
		internal static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow)
		{
			return null;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x5991400", Offset = "0x5990000", VA = "0x185991400")]
		internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			return null;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x5991320", Offset = "0x598FF20", VA = "0x185991320")]
		internal static void RemoveSelectedIdList(int instanceID, bool isWindow)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x598EE70", Offset = "0x598DA70", VA = "0x18598EE70")]
		internal static void Begin(int instanceID)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x598E160", Offset = "0x598CD60", VA = "0x18598E160")]
		internal static void BeginContainer(GUILayoutUtility.LayoutCache cache)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x598EA90", Offset = "0x598D690", VA = "0x18598EA90")]
		internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5991060", Offset = "0x598FC60", VA = "0x185991060")]
		internal static void Layout()
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x5990A70", Offset = "0x598F670", VA = "0x185990A70")]
		internal static void LayoutFromEditorWindow()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x5990830", Offset = "0x598F430", VA = "0x185990830")]
		internal static void LayoutFromContainer(float w, float h)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x59902B0", Offset = "0x598EEB0", VA = "0x1859902B0")]
		internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x5990CE0", Offset = "0x598F8E0", VA = "0x185990CE0")]
		private static void LayoutSingleGroup(GUILayoutGroup i)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x598F150", Offset = "0x598DD50", VA = "0x18598F150")]
		private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x598E690", Offset = "0x598D290", VA = "0x18598E690")]
		internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType)
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x598F980", Offset = "0x598E580", VA = "0x18598F980")]
		internal static void EndLayoutGroup()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x598E380", Offset = "0x598CF80", VA = "0x18598E380")]
		internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x5990090", Offset = "0x598EC90", VA = "0x185990090")]
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x598F520", Offset = "0x598E120", VA = "0x18598F520")]
		private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x598FE50", Offset = "0x598EA50", VA = "0x18598FE50")]
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x598F2F0", Offset = "0x598DEF0", VA = "0x18598F2F0")]
		private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options)
		{
			return default(Rect);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700002D")]
		internal static GUIStyle spaceStyle
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x59917E0", Offset = "0x59903E0", VA = "0x1859917E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600010A RID: 266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x5990130", Offset = "0x598ED30", VA = "0x185990130")]
		[MethodImpl(4096)]
		private static extern void Internal_GetWindowRect_Injected(int windowID, out Rect ret);

		// Token: 0x0600010B RID: 267
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x59901F0", Offset = "0x598EDF0", VA = "0x1859901F0")]
		[MethodImpl(4096)]
		private static extern void Internal_MoveWindow_Injected(int windowID, ref Rect r);

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x10")]
		internal static GUILayoutUtility.LayoutCache current;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly Rect kDummyRect;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x30")]
		private static GUIStyle s_SpaceStyle;

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
		internal sealed class LayoutCache
		{
			// Token: 0x1700002E RID: 46
			// (set) Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700002E")]
			private int id
			{
				[Token(Token = "0x600010C")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x59A7610", Offset = "0x59A6210", VA = "0x1859A7610")]
			internal LayoutCache(int instanceID = -1)
			{
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x59A72C0", Offset = "0x59A5EC0", VA = "0x1859A72C0")]
			public void ResetCursor()
			{
			}

			// Token: 0x04000079 RID: 121
			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x18")]
			internal GUILayoutGroup topLevel;

			// Token: 0x0400007A RID: 122
			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x20")]
			internal GenericStack layoutGroups;

			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			[FieldOffset(Offset = "0x28")]
			internal GUILayoutGroup windows;
		}
	}
}
