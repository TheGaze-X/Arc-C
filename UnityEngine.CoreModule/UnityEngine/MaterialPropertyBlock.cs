using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
	[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	public sealed class MaterialPropertyBlock
	{
		// Token: 0x0600036D RID: 877 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x592F090", Offset = "0x592DC90", VA = "0x18592F090")]
		[NativeName("GetColorFromScript")]
		[ThreadSafe]
		private Color GetColorImpl(int name)
		{
			return default(Color);
		}

		// Token: 0x0600036E RID: 878
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x592F3D0", Offset = "0x592DFD0", VA = "0x18592F3D0")]
		[NativeName("SetFloatFromScript")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private extern void SetFloatImpl(int name, float value);

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x592F9D0", Offset = "0x592E5D0", VA = "0x18592F9D0")]
		[ThreadSafe]
		[NativeName("SetVectorFromScript")]
		private void SetVectorImpl(int name, Vector4 value)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x592F2A0", Offset = "0x592DEA0", VA = "0x18592F2A0")]
		[ThreadSafe]
		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x592F570", Offset = "0x592E170", VA = "0x18592F570")]
		[ThreadSafe]
		[NativeName("SetMatrixFromScript")]
		private void SetMatrixImpl(int name, Matrix4x4 value)
		{
		}

		// Token: 0x06000372 RID: 882
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x592F630", Offset = "0x592E230", VA = "0x18592F630")]
		[ThreadSafe]
		[NativeName("SetTextureFromScript")]
		[MethodImpl(4096)]
		private extern void SetTextureImpl(int name, [NotNull("ArgumentNullException")] Texture value);

		// Token: 0x06000373 RID: 883
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x592F200", Offset = "0x592DE00", VA = "0x18592F200")]
		[NativeName("SetBufferFromScript")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private extern void SetBufferImpl(int name, ComputeBuffer value);

		// Token: 0x06000374 RID: 884
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x592F700", Offset = "0x592E300", VA = "0x18592F700")]
		[ThreadSafe]
		[NativeName("SetVectorArrayFromScript")]
		[MethodImpl(4096)]
		private extern void SetVectorArrayImpl(int name, Vector4[] values, int count);

		// Token: 0x06000375 RID: 885
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x592EE00", Offset = "0x592DA00", VA = "0x18592EE00")]
		[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = true)]
		[MethodImpl(4096)]
		private static extern IntPtr CreateImpl();

		// Token: 0x06000376 RID: 886
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x592EE30", Offset = "0x592DA30", VA = "0x18592EE30")]
		[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void DestroyImpl(IntPtr mpb);

		// Token: 0x06000377 RID: 887
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x592ED70", Offset = "0x592D970", VA = "0x18592ED70")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private extern void Clear(bool keepMemory);

		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x592EDC0", Offset = "0x592D9C0", VA = "0x18592EDC0")]
		public void Clear()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x592F790", Offset = "0x592E390", VA = "0x18592F790")]
		private void SetVectorArray(int name, Vector4[] values, int count)
		{
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x592FB00", Offset = "0x592E700", VA = "0x18592FB00")]
		public MaterialPropertyBlock()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x592EF30", Offset = "0x592DB30", VA = "0x18592EF30", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x592EE70", Offset = "0x592DA70", VA = "0x18592EE70")]
		private void Dispose()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x592F4A0", Offset = "0x592E0A0", VA = "0x18592F4A0")]
		public void SetInt(string name, int value)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x592F420", Offset = "0x592E020", VA = "0x18592F420")]
		public void SetFloat(string name, float value)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x592F3D0", Offset = "0x592DFD0", VA = "0x18592F3D0")]
		public void SetFloat(int nameID, float value)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x592FA70", Offset = "0x592E670", VA = "0x18592FA70")]
		public void SetVector(string name, Vector4 value)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x592FA20", Offset = "0x592E620", VA = "0x18592FA20")]
		public void SetVector(int nameID, Vector4 value)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x592F340", Offset = "0x592DF40", VA = "0x18592F340")]
		public void SetColor(string name, Color value)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x592F2F0", Offset = "0x592DEF0", VA = "0x18592F2F0")]
		public void SetColor(int nameID, Color value)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x592F5C0", Offset = "0x592E1C0", VA = "0x18592F5C0")]
		public void SetMatrix(int nameID, Matrix4x4 value)
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x592F200", Offset = "0x592DE00", VA = "0x18592F200")]
		public void SetBuffer(int nameID, ComputeBuffer value)
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x592F680", Offset = "0x592E280", VA = "0x18592F680")]
		public void SetTexture(string name, Texture value)
		{
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x592F630", Offset = "0x592E230", VA = "0x18592F630")]
		public void SetTexture(int nameID, Texture value)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x592F900", Offset = "0x592E500", VA = "0x18592F900")]
		public void SetVectorArray(string name, Vector4[] values)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x592F760", Offset = "0x592E360", VA = "0x18592F760")]
		public void SetVectorArray(int nameID, Vector4[] values)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x592F160", Offset = "0x592DD60", VA = "0x18592F160")]
		public Color GetColor(string name)
		{
			return default(Color);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x592F0F0", Offset = "0x592DCF0", VA = "0x18592F0F0")]
		public Color GetColor(int nameID)
		{
			return default(Color);
		}

		// Token: 0x0600038C RID: 908
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x592F040", Offset = "0x592DC40", VA = "0x18592F040")]
		[MethodImpl(4096)]
		private extern void GetColorImpl_Injected(int name, out Color ret);

		// Token: 0x0600038D RID: 909
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x592F980", Offset = "0x592E580", VA = "0x18592F980")]
		[MethodImpl(4096)]
		private extern void SetVectorImpl_Injected(int name, ref Vector4 value);

		// Token: 0x0600038E RID: 910
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x592F250", Offset = "0x592DE50", VA = "0x18592F250")]
		[MethodImpl(4096)]
		private extern void SetColorImpl_Injected(int name, ref Color value);

		// Token: 0x0600038F RID: 911
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x592F520", Offset = "0x592E120", VA = "0x18592F520")]
		[MethodImpl(4096)]
		private extern void SetMatrixImpl_Injected(int name, ref Matrix4x4 value);

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
