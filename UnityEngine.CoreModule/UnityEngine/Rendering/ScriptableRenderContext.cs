using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	[NativeHeader("Modules/UI/CanvasManager.h")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
	[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
	public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x5986CD0", Offset = "0x59858D0", VA = "0x185986CD0")]
		private void GetCameras_Internal(Type listType, object resultList)
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x925680", Offset = "0x924280", VA = "0x180925680")]
		internal ScriptableRenderContext(IntPtr ptr)
		{
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x5986D60", Offset = "0x5985960", VA = "0x185986D60")]
		internal void GetCameras(List<Camera> results)
		{
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x5986C10", Offset = "0x5985810", VA = "0x185986C10", Slot = "4")]
		public bool Equals(ScriptableRenderContext other)
		{
			return default(bool);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x5986B70", Offset = "0x5985770", VA = "0x185986B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x5986E10", Offset = "0x5985A10", VA = "0x185986E10", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000E3B RID: 3643
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x5986C70", Offset = "0x5985870", VA = "0x185986C70")]
		[MethodImpl(4096)]
		private static extern void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList);

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ShaderTagId kRenderTypeTag;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_Ptr;
	}
}
