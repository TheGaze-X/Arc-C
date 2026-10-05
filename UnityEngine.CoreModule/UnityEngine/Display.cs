using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/DisplayManager.h")]
	public class Display
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x5928980", Offset = "0x5927580", VA = "0x185928980")]
		internal Display()
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x485B340", Offset = "0x4859F40", VA = "0x18485B340")]
		internal Display(IntPtr nativeDisplay)
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x170000AC")]
		public int renderingWidth
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x5928A90", Offset = "0x5927690", VA = "0x185928A90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x170000AD")]
		public int renderingHeight
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x5928A10", Offset = "0x5927610", VA = "0x185928A10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x170000AE")]
		public int systemWidth
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x5928B90", Offset = "0x5927790", VA = "0x185928B90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x170000AF")]
		public int systemHeight
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x5928B10", Offset = "0x5927710", VA = "0x185928B10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x5928710", Offset = "0x5927310", VA = "0x185928710")]
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			return default(Vector3);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000B0")]
		public static Display main
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x59289C0", Offset = "0x59275C0", VA = "0x1859289C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x59284C0", Offset = "0x59270C0", VA = "0x1859284C0")]
		[RequiredByNativeCode]
		private static void RecreateDisplayList(IntPtr[] nativeDisplay)
		{
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x5928370", Offset = "0x5926F70", VA = "0x185928370")]
		[RequiredByNativeCode]
		private static void FireDisplaysUpdated()
		{
		}

		// Token: 0x060002CB RID: 715
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x5928460", Offset = "0x5927060", VA = "0x185928460")]
		[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
		[MethodImpl(4096)]
		private static extern void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x060002CC RID: 716
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x5928400", Offset = "0x5927000", VA = "0x185928400")]
		[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
		[MethodImpl(4096)]
		private static extern void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x060002CD RID: 717
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x59286B0", Offset = "0x59272B0", VA = "0x1859286B0")]
		[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
		[MethodImpl(4096)]
		private static extern int RelativeMouseAtImpl(int x, int y, out int rx, out int ry);

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr nativeDisplay;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x0")]
		public static Display[] displays;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x8")]
		private static Display _mainDisplay;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x10")]
		private static int m_ActiveEditorGameViewTarget;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x18")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Display.DisplaysUpdatedDelegate onDisplaysUpdated;

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060002D0 RID: 720
		[Token(Token = "0x2000074")]
		public delegate void DisplaysUpdatedDelegate();
	}
}
