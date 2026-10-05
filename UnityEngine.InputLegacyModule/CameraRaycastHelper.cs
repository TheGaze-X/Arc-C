using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	internal class CameraRaycastHelper
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x59B7CF0", Offset = "0x59B68F0", VA = "0x1859B7CF0")]
		[FreeFunction("CameraScripting::RaycastTry")]
		internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x59B7C10", Offset = "0x59B6810", VA = "0x1859B7C10")]
		[FreeFunction("CameraScripting::RaycastTry2D")]
		internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			return null;
		}

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x59B7C80", Offset = "0x59B6880", VA = "0x1859B7C80")]
		[MethodImpl(4096)]
		private static extern GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask);

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x59B7BA0", Offset = "0x59B67A0", VA = "0x1859B7BA0")]
		[MethodImpl(4096)]
		private static extern GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask);
	}
}
