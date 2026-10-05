using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	internal static class UIEventRegistration
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x5A98C60", Offset = "0x5A97860", VA = "0x185A98C60")]
		internal static void RegisterUIElementSystem(IUIElementsUtility utility)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x5A98E40", Offset = "0x5A97A40", VA = "0x185A98E40")]
		private static void TakeCapture()
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x5A98CE0", Offset = "0x5A978E0", VA = "0x185A98CE0")]
		private static void ReleaseCapture()
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x5A98690", Offset = "0x5A97290", VA = "0x185A98690")]
		private static bool EndContainerGUIFromException(Exception exception)
		{
			return default(bool);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x5A98A20", Offset = "0x5A97620", VA = "0x185A98A20")]
		private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr)
		{
			return default(bool);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x5A98530", Offset = "0x5A97130", VA = "0x185A98530")]
		private static void CleanupRoots()
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x5A988C0", Offset = "0x5A974C0", VA = "0x185A988C0")]
		internal static void MakeCurrentIMGUIContainerDirty()
		{
		}

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x0")]
		private static List<IUIElementsUtility> s_Utilities;
	}
}
