using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[NativeConditional("ENABLE_XR")]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5BA34E0", Offset = "0x5BA20E0", VA = "0x185BA34E0")]
		[RequiredByNativeCode]
		private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5BA3540", Offset = "0x5BA2140", VA = "0x185BA3540")]
		public XRMeshSubsystem()
		{
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		[NativeConditional("ENABLE_XR")]
		private readonly struct MeshTransformList : IDisposable
		{
			// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x5BA3180", Offset = "0x5BA1D80", VA = "0x185BA3180", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000042 RID: 66
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x5BA31C0", Offset = "0x5BA1DC0", VA = "0x185BA31C0")]
			[FreeFunction("UnityXRMeshTransformList_Dispose")]
			[MethodImpl(4096)]
			private static extern void Dispose(IntPtr self);

			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			[FieldOffset(Offset = "0x0")]
			private readonly IntPtr m_Self;
		}
	}
}
