using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	internal class SendMouseEvents
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x59BA010", Offset = "0x59B8C10", VA = "0x1859BA010")]
		private static void UpdateMouse()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59B9FC0", Offset = "0x59B8BC0", VA = "0x1859B9FC0")]
		[RequiredByNativeCode]
		private static void SetMouseMoved()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x59B8AE0", Offset = "0x59B76E0", VA = "0x1859B8AE0")]
		[RequiredByNativeCode]
		private static void DoSendMouseEvents(int skipRTCameras)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x59B9690", Offset = "0x59B8290", VA = "0x1859B9690")]
		private static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_MouseUsed;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x8")]
		private static readonly SendMouseEvents.HitInfo[] m_LastHit;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly SendMouseEvents.HitInfo[] m_CurrentHit;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		private static Camera[] m_Cameras;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x28")]
		public static Func<KeyValuePair<int, Vector2>> s_GetMouseState;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x30")]
		private static Vector2 s_MousePosition;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x38")]
		private static bool s_MouseButtonPressedThisFrame;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x39")]
		private static bool s_MouseButtonIsPressed;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		private struct HitInfo
		{
			// Token: 0x0600004D RID: 77 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x59B8020", Offset = "0x59B6C20", VA = "0x1859B8020")]
			public void SendMessage(string name)
			{
			}

			// Token: 0x0600004E RID: 78 RVA: 0x000022C4 File Offset: 0x000004C4
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x59B8050", Offset = "0x59B6C50", VA = "0x1859B8050")]
			public static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				return default(bool);
			}

			// Token: 0x0600004F RID: 79 RVA: 0x000022DC File Offset: 0x000004DC
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x59B7F90", Offset = "0x59B6B90", VA = "0x1859B7F90")]
			public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				return default(bool);
			}

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			[FieldOffset(Offset = "0x0")]
			public GameObject target;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			[FieldOffset(Offset = "0x8")]
			public Camera camera;
		}
	}
}
