using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[NativeHeader("Modules/UIElementsNative/UIElementsRuntimeUtilityNative.h")]
	[VisibleToOtherModules(new string[]
	{
		"Unity.UIElements"
	})]
	internal static class UIElementsRuntimeUtilityNative
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5B4D780", Offset = "0x5B4C380", VA = "0x185B4D780")]
		[RequiredByNativeCode]
		public static void RepaintOverlayPanels()
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5B4D800", Offset = "0x5B4C400", VA = "0x185B4D800")]
		[RequiredByNativeCode]
		public static void UpdateRuntimePanels()
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5B4D730", Offset = "0x5B4C330", VA = "0x185B4D730")]
		[RequiredByNativeCode]
		public static void RepaintOffscreenPanels()
		{
		}

		// Token: 0x060000C0 RID: 192
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x5B4D700", Offset = "0x5B4C300", VA = "0x185B4D700")]
		[MethodImpl(4096)]
		public static extern void RegisterPlayerloopCallback();

		// Token: 0x060000C1 RID: 193
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5B4D7D0", Offset = "0x5B4C3D0", VA = "0x185B4D7D0")]
		[MethodImpl(4096)]
		public static extern void UnregisterPlayerloopCallback();

		// Token: 0x060000C2 RID: 194
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x5B4D850", Offset = "0x5B4C450", VA = "0x185B4D850")]
		[MethodImpl(4096)]
		public static extern void VisualElementCreation();

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		internal static Action RepaintOverlayPanelsCallback;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x8")]
		internal static Action UpdateRuntimePanelsCallback;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		internal static Action RepaintOffscreenPanelsCallback;
	}
}
