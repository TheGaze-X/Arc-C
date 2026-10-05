using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeHeader("Modules/IMGUI/GUIClip.h")]
	[NativeHeader("Modules/IMGUI/GUIState.h")]
	internal sealed class GUIClip
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x17000028")]
		internal static Rect visibleRect
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x598D470", Offset = "0x598C070", VA = "0x18598D470")]
			[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x598D200", Offset = "0x598BE00", VA = "0x18598D200")]
		internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
		}

		// Token: 0x0600009D RID: 157
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x598D010", Offset = "0x598BC10", VA = "0x18598D010")]
		[MethodImpl(4096)]
		internal static extern void Internal_Pop();

		// Token: 0x0600009E RID: 158
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x598CFB0", Offset = "0x598BBB0", VA = "0x18598CFB0")]
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
		[MethodImpl(4096)]
		internal static extern int Internal_GetCount();

		// Token: 0x0600009F RID: 159 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x598D390", Offset = "0x598BF90", VA = "0x18598D390")]
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.UnclipToWindow")]
		private static Vector2 UnclipToWindow_Vector2(Vector2 pos)
		{
			return default(Vector2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x598CF60", Offset = "0x598BB60", VA = "0x18598CF60")]
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
		internal static Matrix4x4 GetMatrix()
		{
			return default(Matrix4x4);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x598D300", Offset = "0x598BF00", VA = "0x18598D300")]
		internal static void SetMatrix(Matrix4x4 m)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x598D0A0", Offset = "0x598BCA0", VA = "0x18598D0A0")]
		internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x598D130", Offset = "0x598BD30", VA = "0x18598D130")]
		internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect)
		{
		}

		// Token: 0x060000A4 RID: 164
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x598CFE0", Offset = "0x598BBE0", VA = "0x18598CFE0")]
		[MethodImpl(4096)]
		internal static extern void Internal_PopParentClip();

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x598D260", Offset = "0x598BE60", VA = "0x18598D260")]
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x598D010", Offset = "0x598BC10", VA = "0x18598D010")]
		internal static void Pop()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x598D3E0", Offset = "0x598BFE0", VA = "0x18598D3E0")]
		public static Vector2 UnclipToWindow(Vector2 pos)
		{
			return default(Vector2);
		}

		// Token: 0x060000A8 RID: 168
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x598D430", Offset = "0x598C030", VA = "0x18598D430")]
		[MethodImpl(4096)]
		private static extern void get_visibleRect_Injected(out Rect ret);

		// Token: 0x060000A9 RID: 169
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x598D190", Offset = "0x598BD90", VA = "0x18598D190")]
		[MethodImpl(4096)]
		private static extern void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

		// Token: 0x060000AA RID: 170
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x598D340", Offset = "0x598BF40", VA = "0x18598D340")]
		[MethodImpl(4096)]
		private static extern void UnclipToWindow_Vector2_Injected(ref Vector2 pos, out Vector2 ret);

		// Token: 0x060000AB RID: 171
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x598CF20", Offset = "0x598BB20", VA = "0x18598CF20")]
		[MethodImpl(4096)]
		private static extern void GetMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x060000AC RID: 172
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x598D2C0", Offset = "0x598BEC0", VA = "0x18598D2C0")]
		[MethodImpl(4096)]
		private static extern void SetMatrix_Injected(ref Matrix4x4 m);

		// Token: 0x060000AD RID: 173
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x598D040", Offset = "0x598BC40", VA = "0x18598D040")]
		[MethodImpl(4096)]
		private static extern void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect);

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		internal struct ParentClipScope : IDisposable
		{
			// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x59A7970", Offset = "0x59A6570", VA = "0x1859A7970")]
			public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
			{
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x59A7930", Offset = "0x59A6530", VA = "0x1859A7930", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x0")]
			private bool m_Disposed;
		}
	}
}
