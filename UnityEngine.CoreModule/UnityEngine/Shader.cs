using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
	[NativeHeader("Runtime/Misc/ResourceManager.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
	public sealed class Shader : Object
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x59403A0", Offset = "0x593EFA0", VA = "0x1859403A0")]
		public static Shader Find(string name)
		{
			return null;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000409 RID: 1033
		[Token(Token = "0x17000101")]
		public extern bool isSupported { [Token(Token = "0x6000409")] [Address(RVA = "0x5941230", Offset = "0x593FE30", VA = "0x185941230")] [NativeMethod("IsSupported")] [MethodImpl(4096)] get; }

		// Token: 0x0600040A RID: 1034
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x5940360", Offset = "0x593EF60", VA = "0x185940360")]
		[FreeFunction("ShaderScripting::EnableKeyword")]
		[MethodImpl(4096)]
		public static extern void EnableKeyword(string keyword);

		// Token: 0x0600040B RID: 1035
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5940320", Offset = "0x593EF20", VA = "0x185940320")]
		[FreeFunction("ShaderScripting::DisableKeyword")]
		[MethodImpl(4096)]
		public static extern void DisableKeyword(string keyword);

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600040C RID: 1036
		[Token(Token = "0x17000102")]
		internal extern DisableBatchingType disableBatching { [Token(Token = "0x600040C")] [Address(RVA = "0x59411F0", Offset = "0x593FDF0", VA = "0x1859411F0")] [FreeFunction("ShaderScripting::GetDisableBatchingType", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x0600040D RID: 1037
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x5941160", Offset = "0x593FD60", VA = "0x185941160")]
		[FreeFunction("ShaderScripting::TagToID")]
		[MethodImpl(4096)]
		internal static extern int TagToID(string name);

		// Token: 0x0600040E RID: 1038
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x5940470", Offset = "0x593F070", VA = "0x185940470")]
		[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
		[MethodImpl(4096)]
		public static extern int PropertyToID(string name);

		// Token: 0x0600040F RID: 1039
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x59407C0", Offset = "0x593F3C0", VA = "0x1859407C0")]
		[FreeFunction("ShaderScripting::SetGlobalFloat")]
		[MethodImpl(4096)]
		private static extern void SetGlobalFloatImpl(int name, float value);

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x5941060", Offset = "0x593FC60", VA = "0x185941060")]
		[FreeFunction("ShaderScripting::SetGlobalVector")]
		private static void SetGlobalVectorImpl(int name, Vector4 value)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x5940BE0", Offset = "0x593F7E0", VA = "0x185940BE0")]
		[FreeFunction("ShaderScripting::SetGlobalMatrix")]
		private static void SetGlobalMatrixImpl(int name, Matrix4x4 value)
		{
		}

		// Token: 0x06000412 RID: 1042
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x5940D10", Offset = "0x593F910", VA = "0x185940D10")]
		[FreeFunction("ShaderScripting::SetGlobalTexture")]
		[MethodImpl(4096)]
		private static extern void SetGlobalTextureImpl(int name, Texture value);

		// Token: 0x06000413 RID: 1043
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x5940430", Offset = "0x593F030", VA = "0x185940430")]
		[FreeFunction("ShaderScripting::GetGlobalFloat")]
		[MethodImpl(4096)]
		private static extern float GetGlobalFloatImpl(int name);

		// Token: 0x06000414 RID: 1044
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x5940560", Offset = "0x593F160", VA = "0x185940560")]
		[FreeFunction("ShaderScripting::SetGlobalFloatArray")]
		[MethodImpl(4096)]
		private static extern void SetGlobalFloatArrayImpl(int name, float[] values, int count);

		// Token: 0x06000415 RID: 1045
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x5940DC0", Offset = "0x593F9C0", VA = "0x185940DC0")]
		[FreeFunction("ShaderScripting::SetGlobalVectorArray")]
		[MethodImpl(4096)]
		private static extern void SetGlobalVectorArrayImpl(int name, Vector4[] values, int count);

		// Token: 0x06000416 RID: 1046
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x5940940", Offset = "0x593F540", VA = "0x185940940")]
		[FreeFunction("ShaderScripting::SetGlobalMatrixArray")]
		[MethodImpl(4096)]
		private static extern void SetGlobalMatrixArrayImpl(int name, Matrix4x4[] values, int count);

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x5940660", Offset = "0x593F260", VA = "0x185940660")]
		private static void SetGlobalFloatArray(int name, float[] values, int count)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x5940E10", Offset = "0x593FA10", VA = "0x185940E10")]
		private static void SetGlobalVectorArray(int name, Vector4[] values, int count)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x5940A40", Offset = "0x593F640", VA = "0x185940A40")]
		private static void SetGlobalMatrixArray(int name, Matrix4x4[] values, int count)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x5940880", Offset = "0x593F480", VA = "0x185940880")]
		public static void SetGlobalInt(string name, int value)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x59408F0", Offset = "0x593F4F0", VA = "0x1859408F0")]
		public static void SetGlobalInt(int nameID, int value)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x5940810", Offset = "0x593F410", VA = "0x185940810")]
		public static void SetGlobalFloat(string name, float value)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x59407C0", Offset = "0x593F3C0", VA = "0x1859407C0")]
		public static void SetGlobalFloat(int nameID, float value)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x59410A0", Offset = "0x593FCA0", VA = "0x1859410A0")]
		public static void SetGlobalVector(string name, Vector4 value)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x5941120", Offset = "0x593FD20", VA = "0x185941120")]
		public static void SetGlobalVector(int nameID, Vector4 value)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x59404B0", Offset = "0x593F0B0", VA = "0x1859404B0")]
		public static void SetGlobalColor(string name, Color value)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x5940C20", Offset = "0x593F820", VA = "0x185940C20")]
		public static void SetGlobalMatrix(string name, Matrix4x4 value)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x5940CB0", Offset = "0x593F8B0", VA = "0x185940CB0")]
		public static void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x5940D50", Offset = "0x593F950", VA = "0x185940D50")]
		public static void SetGlobalTexture(string name, Texture value)
		{
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5940D10", Offset = "0x593F910", VA = "0x185940D10")]
		public static void SetGlobalTexture(int nameID, Texture value)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x59405B0", Offset = "0x593F1B0", VA = "0x1859405B0")]
		public static void SetGlobalFloatArray(int nameID, float[] values)
		{
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x5940F70", Offset = "0x593FB70", VA = "0x185940F70")]
		public static void SetGlobalVectorArray(int nameID, Vector4[] values)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5940990", Offset = "0x593F590", VA = "0x185940990")]
		public static void SetGlobalMatrixArray(int nameID, Matrix4x4[] values)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5940430", Offset = "0x593F030", VA = "0x185940430")]
		public static float GetGlobalFloat(int nameID)
		{
			return 0f;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x59411A0", Offset = "0x593FDA0", VA = "0x1859411A0")]
		private Shader()
		{
		}

		// Token: 0x0600042A RID: 1066
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5941020", Offset = "0x593FC20", VA = "0x185941020")]
		[MethodImpl(4096)]
		private static extern void SetGlobalVectorImpl_Injected(int name, ref Vector4 value);

		// Token: 0x0600042B RID: 1067
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x5940BA0", Offset = "0x593F7A0", VA = "0x185940BA0")]
		[MethodImpl(4096)]
		private static extern void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value);
	}
}
