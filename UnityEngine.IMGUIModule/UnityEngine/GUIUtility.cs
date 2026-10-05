using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[NativeHeader("Modules/IMGUI/GUIUtility.h")]
	[NativeHeader("Runtime/Input/InputBindings.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
	[NativeHeader("Runtime/Utilities/CopyPaste.h")]
	[NativeHeader("Modules/IMGUI/GUIManager.h")]
	public class GUIUtility
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D9 RID: 473
		[Token(Token = "0x17000070")]
		[NativeProperty("GetGUIState().m_PixelsPerPoint", true, TargetType.Field)]
		internal static extern float pixelsPerPoint { [Token(Token = "0x60001D9")] [Address(RVA = "0x59ADB30", Offset = "0x59AC730", VA = "0x1859ADB30")] [MethodImpl(4096)] get; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001DA RID: 474
		[Token(Token = "0x17000071")]
		[NativeProperty("GetGUIState().m_OnGUIDepth", true, TargetType.Field)]
		internal static extern int guiDepth { [Token(Token = "0x60001DA")] [Address(RVA = "0x59ADB00", Offset = "0x59AC700", VA = "0x1859ADB00")] [MethodImpl(4096)] get; }

		// Token: 0x17000072 RID: 114
		// (set) Token: 0x060001DB RID: 475
		[Token(Token = "0x17000072")]
		[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", true, TargetType.Field)]
		internal static extern bool mouseUsed { [Token(Token = "0x60001DB")] [Address(RVA = "0x59ADCC0", Offset = "0x59AC8C0", VA = "0x1859ADCC0")] [MethodImpl(4096)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001DC RID: 476
		// (set) Token: 0x060001DD RID: 477
		[Token(Token = "0x17000073")]
		[StaticAccessor("GetInputManager()", StaticAccessorType.Dot)]
		internal static extern bool textFieldInput { [Token(Token = "0x60001DC")] [Address(RVA = "0x59ADB90", Offset = "0x59AC790", VA = "0x1859ADB90")] [MethodImpl(4096)] get; [Token(Token = "0x60001DD")] [Address(RVA = "0x59ADD40", Offset = "0x59AC940", VA = "0x1859ADD40")] [MethodImpl(4096)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001DE RID: 478
		// (set) Token: 0x060001DF RID: 479
		[Token(Token = "0x17000074")]
		public static extern string systemCopyBuffer { [Token(Token = "0x60001DE")] [Address(RVA = "0x59ADB60", Offset = "0x59AC760", VA = "0x1859ADB60")] [FreeFunction("GetCopyBuffer")] [MethodImpl(4096)] get; [Token(Token = "0x60001DF")] [Address(RVA = "0x59ADD00", Offset = "0x59AC900", VA = "0x1859ADD00")] [FreeFunction("SetCopyBuffer")] [MethodImpl(4096)] set; }

		// Token: 0x060001E0 RID: 480 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x59AD540", Offset = "0x59AC140", VA = "0x1859AD540")]
		[FreeFunction("GetGUIState().GetControlID")]
		private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
		{
			return 0;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x59ACFA0", Offset = "0x59ABBA0", VA = "0x1859ACFA0")]
		public static int GetControlID(int hint, FocusType focusType, Rect rect)
		{
			return 0;
		}

		// Token: 0x060001E2 RID: 482
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x59AC860", Offset = "0x59AB460", VA = "0x1859AC860")]
		[MethodImpl(4096)]
		internal static extern void BeginContainerFromOwner(ScriptableObject owner);

		// Token: 0x060001E3 RID: 483
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x59AC8A0", Offset = "0x59AB4A0", VA = "0x1859AC8A0")]
		[MethodImpl(4096)]
		internal static extern void BeginContainer(ObjectGUIState objectGUIState);

		// Token: 0x060001E4 RID: 484
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x59AD490", Offset = "0x59AC090", VA = "0x1859AD490")]
		[NativeMethod("EndContainer")]
		[MethodImpl(4096)]
		internal static extern void Internal_EndContainer();

		// Token: 0x060001E5 RID: 485
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x59ACA60", Offset = "0x59AB660", VA = "0x1859ACA60")]
		[MethodImpl(4096)]
		internal static extern int CheckForTabEvent(Event evt);

		// Token: 0x060001E6 RID: 486
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x59ADA20", Offset = "0x59AC620", VA = "0x1859ADA20")]
		[MethodImpl(4096)]
		internal static extern void SetKeyboardControlToFirstControlId();

		// Token: 0x060001E7 RID: 487
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x59ADA50", Offset = "0x59AC650", VA = "0x1859ADA50")]
		[MethodImpl(4096)]
		internal static extern void SetKeyboardControlToLastControlId();

		// Token: 0x060001E8 RID: 488
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x59AD1B0", Offset = "0x59ABDB0", VA = "0x1859AD1B0")]
		[MethodImpl(4096)]
		internal static extern bool HasFocusableControls();

		// Token: 0x060001E9 RID: 489
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x59AD790", Offset = "0x59AC390", VA = "0x1859AD790")]
		[MethodImpl(4096)]
		internal static extern bool OwnsId(int id);

		// Token: 0x060001EA RID: 490 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x59AC780", Offset = "0x59AB380", VA = "0x1859AC780")]
		public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels)
		{
			return default(Rect);
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001EB RID: 491
		[Token(Token = "0x17000075")]
		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static extern string compositionString { [Token(Token = "0x60001EB")] [Address(RVA = "0x59ADAD0", Offset = "0x59AC6D0", VA = "0x1859ADAD0")] [MethodImpl(4096)] get; }

		// Token: 0x17000076 RID: 118
		// (set) Token: 0x060001EC RID: 492
		[Token(Token = "0x17000076")]
		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static extern IMECompositionMode imeCompositionMode { [Token(Token = "0x60001EC")] [Address(RVA = "0x59ADC80", Offset = "0x59AC880", VA = "0x1859ADC80")] [MethodImpl(4096)] set; }

		// Token: 0x17000077 RID: 119
		// (set) Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		[StaticAccessor("InputBindings", StaticAccessorType.DoubleColon)]
		internal static Vector2 compositionCursorPos
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x59ADC00", Offset = "0x59AC800", VA = "0x1859ADC00")]
			set
			{
			}
		}

		// Token: 0x060001EE RID: 494
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x59AD5D0", Offset = "0x59AC1D0", VA = "0x1859AD5D0")]
		[MethodImpl(4096)]
		private static extern int Internal_GetHotControl();

		// Token: 0x060001EF RID: 495
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x59AD600", Offset = "0x59AC200", VA = "0x1859AD600")]
		[MethodImpl(4096)]
		private static extern int Internal_GetKeyboardControl();

		// Token: 0x060001F0 RID: 496
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x59AD630", Offset = "0x59AC230", VA = "0x1859AD630")]
		[MethodImpl(4096)]
		private static extern void Internal_SetHotControl(int value);

		// Token: 0x060001F1 RID: 497
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x59AD670", Offset = "0x59AC270", VA = "0x1859AD670")]
		[MethodImpl(4096)]
		private static extern void Internal_SetKeyboardControl(int value);

		// Token: 0x060001F2 RID: 498
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x59AD590", Offset = "0x59AC190", VA = "0x1859AD590")]
		[MethodImpl(4096)]
		private static extern object Internal_GetDefaultSkin(int skinMode);

		// Token: 0x060001F3 RID: 499
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x59AD4C0", Offset = "0x59AC0C0", VA = "0x1859AD4C0")]
		[MethodImpl(4096)]
		private static extern void Internal_ExitGUI();

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x59AD740", Offset = "0x59AC340", VA = "0x1859AD740")]
		[RequiredByNativeCode]
		private static void MarkGUIChanged()
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x59AD030", Offset = "0x59ABC30", VA = "0x1859AD030")]
		public static int GetControlID(FocusType focus)
		{
			return 0;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x59ACE90", Offset = "0x59ABA90", VA = "0x1859ACE90")]
		public static int GetControlID(FocusType focus, Rect position)
		{
			return 0;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x59ACF10", Offset = "0x59ABB10", VA = "0x1859ACF10")]
		public static int GetControlID(int hint, FocusType focus)
		{
			return 0;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x59AD150", Offset = "0x59ABD50", VA = "0x1859AD150")]
		public static object GetStateObject(Type t, int controlID)
		{
			return null;
		}

		// Token: 0x17000078 RID: 120
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		internal static bool guiIsExiting
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x59ADC40", Offset = "0x59AC840", VA = "0x1859ADC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public static int hotControl
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x59AD5D0", Offset = "0x59AC1D0", VA = "0x1859AD5D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x59AD630", Offset = "0x59AC230", VA = "0x1859AD630")]
			set
			{
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x59ADA80", Offset = "0x59AC680", VA = "0x1859ADA80")]
		[RequiredByNativeCode]
		internal static void TakeCapture()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x59AD850", Offset = "0x59AC450", VA = "0x1859AD850")]
		[RequiredByNativeCode]
		internal static void RemoveCapture()
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		public static int keyboardControl
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x59AD600", Offset = "0x59AC200", VA = "0x1859AD600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x59AD670", Offset = "0x59AC270", VA = "0x1859AD670")]
			set
			{
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x59AD1E0", Offset = "0x59ABDE0", VA = "0x1859AD1E0")]
		internal static bool HasKeyFocus(int controlID)
		{
			return default(bool);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x59ACE40", Offset = "0x59ABA40", VA = "0x1859ACE40")]
		public static void ExitGUI()
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x59AD0C0", Offset = "0x59ABCC0", VA = "0x1859AD0C0")]
		internal static GUISkin GetDefaultSkin()
		{
			return null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x59AD7D0", Offset = "0x59AC3D0", VA = "0x1859AD7D0")]
		[RequiredByNativeCode]
		internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x59ACBE0", Offset = "0x59AB7E0", VA = "0x1859ACBE0")]
		internal static void EndContainer()
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x59AC8E0", Offset = "0x59AB4E0", VA = "0x1859AC8E0")]
		[RequiredByNativeCode]
		internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x59ACB30", Offset = "0x59AB730", VA = "0x1859ACB30")]
		[RequiredByNativeCode]
		internal static void DestroyGUI(int instanceID)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x59ACCE0", Offset = "0x59AB8E0", VA = "0x1859ACCE0")]
		[RequiredByNativeCode]
		internal static void EndGUI(int layoutType)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x59ACC30", Offset = "0x59AB830", VA = "0x1859ACC30")]
		[RequiredByNativeCode]
		internal static bool EndGUIFromException(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x59ACB80", Offset = "0x59AB780", VA = "0x1859ACB80")]
		[RequiredByNativeCode]
		internal static bool EndContainerGUIFromException(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x59AD8A0", Offset = "0x59AC4A0", VA = "0x1859AD8A0")]
		internal static void ResetGlobalState()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x59AD6B0", Offset = "0x59AC2B0", VA = "0x1859AD6B0")]
		internal static bool IsExitGUIException(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x59AD6B0", Offset = "0x59AC2B0", VA = "0x1859AD6B0")]
		internal static bool ShouldRethrowException(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x59ACAA0", Offset = "0x59AB6A0", VA = "0x1859ACAA0")]
		internal static void CheckOnGUI()
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x59AD9A0", Offset = "0x59AC5A0", VA = "0x1859AD9A0")]
		internal static float RoundToPixelGrid(float v)
		{
			return 0f;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x59AC7F0", Offset = "0x59AB3F0", VA = "0x1859AC7F0")]
		public static Rect AlignRectToDevice(Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x59AD350", Offset = "0x59ABF50", VA = "0x1859AD350")]
		internal static bool HitTest(Rect rect, Vector2 point, int offset)
		{
			return default(bool);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x59AD3F0", Offset = "0x59ABFF0", VA = "0x1859AD3F0")]
		internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x59AD280", Offset = "0x59ABE80", VA = "0x1859AD280")]
		internal static bool HitTest(Rect rect, Event evt)
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x59AD4F0", Offset = "0x59AC0F0", VA = "0x1859AD4F0")]
		[MethodImpl(4096)]
		private static extern int Internal_GetControlID_Injected(int hint, FocusType focusType, ref Rect rect);

		// Token: 0x06000214 RID: 532
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x59AC710", Offset = "0x59AB310", VA = "0x1859AC710")]
		[MethodImpl(4096)]
		private static extern void AlignRectToDevice_Injected(ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret);

		// Token: 0x06000215 RID: 533
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x59ADBC0", Offset = "0x59AC7C0", VA = "0x1859ADBC0")]
		[MethodImpl(4096)]
		private static extern void set_compositionCursorPos_Injected(ref Vector2 value);

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		internal static int s_ControlCount;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x4")]
		internal static int s_SkinMode;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x8")]
		internal static int s_OriginalID;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		internal static Action takeCapture;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		internal static Action releaseCapture;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		internal static Func<int, IntPtr, bool> processEvent;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		internal static Action cleanupRoots;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x30")]
		internal static Func<Exception, bool> endContainerGUIFromException;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x38")]
		internal static Action guiChanged;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x48")]
		internal static Func<bool> s_HasCurrentWindowKeyFocusFunc;
	}
}
