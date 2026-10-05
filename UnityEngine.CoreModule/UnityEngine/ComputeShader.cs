using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200012F RID: 303
	[Token(Token = "0x200012F")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public sealed class ComputeShader : Object
	{
		// Token: 0x06000A7B RID: 2683
		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x5959A10", Offset = "0x5958610", VA = "0x185959A10")]
		[RequiredByNativeCode]
		[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern int FindKernel(string name);

		// Token: 0x06000A7C RID: 2684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x5959D20", Offset = "0x5958920", VA = "0x185959D20")]
		[FreeFunction(Name = "ComputeShaderScripting::SetValue<Vector4f>", HasExplicitThis = true)]
		public void SetVector(int nameID, Vector4 val)
		{
		}

		// Token: 0x06000A7D RID: 2685
		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x5959B90", Offset = "0x5958790", VA = "0x185959B90")]
		[NativeMethod(Name = "ComputeShaderScripting::SetTexture", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void SetTexture(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] Texture texture, int mipLevel);

		// Token: 0x06000A7E RID: 2686
		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x5959AC0", Offset = "0x59586C0", VA = "0x185959AC0")]
		[FreeFunction(Name = "ComputeShaderScripting::SetBuffer", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Internal_SetBuffer(int kernelIndex, int nameID, [NotNull("ArgumentNullException")] ComputeBuffer buffer);

		// Token: 0x06000A7F RID: 2687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x5959AC0", Offset = "0x59586C0", VA = "0x185959AC0")]
		public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
		{
		}

		// Token: 0x06000A80 RID: 2688
		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x5959A60", Offset = "0x5958660", VA = "0x185959A60")]
		[NativeMethod(Name = "ComputeShaderScripting::GetKernelThreadGroupSizes", HasExplicitThis = true, IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z);

		// Token: 0x06000A81 RID: 2689
		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x59599B0", Offset = "0x59585B0", VA = "0x1859599B0")]
		[NativeName("DispatchComputeShader")]
		[MethodImpl(4096)]
		public extern void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x06000A82 RID: 2690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x5959CC0", Offset = "0x59588C0", VA = "0x185959CC0")]
		public void SetVector(string name, Vector4 val)
		{
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x5959BF0", Offset = "0x59587F0", VA = "0x185959BF0")]
		public void SetTexture(int kernelIndex, string name, Texture texture)
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x5959B20", Offset = "0x5958720", VA = "0x185959B20")]
		public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
		{
		}

		// Token: 0x06000A85 RID: 2693
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x5959C70", Offset = "0x5958870", VA = "0x185959C70")]
		[MethodImpl(4096)]
		private extern void SetVector_Injected(int nameID, ref Vector4 val);
	}
}
