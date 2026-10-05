using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.XR
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("Modules/VR/VRModule.h")]
	[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
	[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeConditional("ENABLE_VR")]
	public static class XRSettings
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1
		[Token(Token = "0x17000001")]
		public static extern bool enabled { [Token(Token = "0x6000001")] [Address(RVA = "0x5BA1BE0", Offset = "0x5BA07E0", VA = "0x185BA1BE0")] [StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)] [MethodImpl(4096)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2
		[Token(Token = "0x17000002")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static extern int eyeTextureWidth { [Token(Token = "0x6000002")] [Address(RVA = "0x5BA1CD0", Offset = "0x5BA08D0", VA = "0x185BA1CD0")] [MethodImpl(4096)] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3
		[Token(Token = "0x17000003")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static extern int eyeTextureHeight { [Token(Token = "0x6000003")] [Address(RVA = "0x5BA1CA0", Offset = "0x5BA08A0", VA = "0x185BA1CA0")] [MethodImpl(4096)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
		[NativeName("IntermediateEyeTextureDesc")]
		public static RenderTextureDescriptor eyeTextureDesc
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x5BA1C50", Offset = "0x5BA0850", VA = "0x185BA1C50")]
			get
			{
				return default(RenderTextureDescriptor);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000005")]
		public static float renderViewportScale
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x5BA1D00", Offset = "0x5BA0900", VA = "0x185BA1D00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6
		[Token(Token = "0x17000006")]
		[NativeName("RenderViewportScale")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		internal static extern float renderViewportScaleInternal { [Token(Token = "0x6000006")] [Address(RVA = "0x5BA1D00", Offset = "0x5BA0900", VA = "0x185BA1D00")] [MethodImpl(4096)] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7
		[Token(Token = "0x17000007")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static extern XRSettings.StereoRenderingMode stereoRenderingMode { [Token(Token = "0x6000007")] [Address(RVA = "0x5BA1D30", Offset = "0x5BA0930", VA = "0x185BA1D30")] [MethodImpl(4096)] get; }

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5BA1C10", Offset = "0x5BA0810", VA = "0x185BA1C10")]
		[MethodImpl(4096)]
		private static extern void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret);

		// Token: 0x02000003 RID: 3
		[Token(Token = "0x2000003")]
		public enum StereoRenderingMode
		{
			// Token: 0x04000002 RID: 2
			[Token(Token = "0x4000002")]
			MultiPass,
			// Token: 0x04000003 RID: 3
			[Token(Token = "0x4000003")]
			SinglePass,
			// Token: 0x04000004 RID: 4
			[Token(Token = "0x4000004")]
			SinglePassInstanced,
			// Token: 0x04000005 RID: 5
			[Token(Token = "0x4000005")]
			SinglePassMultiview
		}
	}
}
