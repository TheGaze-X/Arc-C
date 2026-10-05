using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[StaticAccessor("GeometryUtilityScripting", StaticAccessorType.DoubleColon)]
	public sealed class GeometryUtility
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x59297B0", Offset = "0x59283B0", VA = "0x1859297B0")]
		public static void CalculateFrustumPlanes(Camera camera, Plane[] planes)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x59299D0", Offset = "0x59285D0", VA = "0x1859299D0")]
		public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x5929B50", Offset = "0x5928750", VA = "0x185929B50")]
		[NativeName("ExtractPlanes")]
		private static void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix)
		{
		}

		// Token: 0x0600022D RID: 557
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x5929B00", Offset = "0x5928700", VA = "0x185929B00")]
		[MethodImpl(4096)]
		private static extern void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix);
	}
}
