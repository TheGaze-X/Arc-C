using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeConditional("ENABLE_XR")]
	[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
	[UsedByNativeCode]
	public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x591B740", Offset = "0x591A340", VA = "0x18591B740")]
		[RequiredByNativeCode]
		private void InvokeDisplayFocusChanged(bool focus)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5BA3240", Offset = "0x5BA1E40", VA = "0x185BA3240")]
		public XRDisplaySubsystem()
		{
		}

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<bool> displayFocusChanged;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
		public struct XRRenderPass
		{
			// Token: 0x0400005A RID: 90
			[Token(Token = "0x400005A")]
			[FieldOffset(Offset = "0x0")]
			private IntPtr displaySubsystemInstance;

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			[FieldOffset(Offset = "0x8")]
			public int renderPassIndex;

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[FieldOffset(Offset = "0x10")]
			public RenderTargetIdentifier renderTarget;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[FieldOffset(Offset = "0x38")]
			public RenderTextureDescriptor renderTargetDesc;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[FieldOffset(Offset = "0x6C")]
			public bool hasMotionVectorPass;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[FieldOffset(Offset = "0x70")]
			public RenderTargetIdentifier motionVectorRenderTarget;

			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			[FieldOffset(Offset = "0x98")]
			public RenderTextureDescriptor motionVectorRenderTargetDesc;

			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			[FieldOffset(Offset = "0xCC")]
			public bool shouldFillOutDepth;

			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			[FieldOffset(Offset = "0xD0")]
			public int cullingPassIndex;
		}

		// Token: 0x02000015 RID: 21
		[Token(Token = "0x2000015")]
		[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
		public struct XRMirrorViewBlitDesc
		{
			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			[FieldOffset(Offset = "0x0")]
			private IntPtr displaySubsystemInstance;

			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			[FieldOffset(Offset = "0x8")]
			public bool nativeBlitAvailable;

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x9")]
			public bool nativeBlitInvalidStates;

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0xC")]
			public int blitParamsCount;
		}
	}
}
