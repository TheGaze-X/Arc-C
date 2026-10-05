using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[NativeHeader("Runtime/Camera/CameraUtil.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
	public sealed class GL
	{
		// Token: 0x06000304 RID: 772
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x59295B0", Offset = "0x59281B0", VA = "0x1859295B0")]
		[NativeName("ImmediateVertex")]
		[MethodImpl(4096)]
		public static extern void Vertex3(float x, float y, float z);

		// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x5929610", Offset = "0x5928210", VA = "0x185929610")]
		public static void Vertex(Vector3 v)
		{
		}

		// Token: 0x06000306 RID: 774
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x5929550", Offset = "0x5928150", VA = "0x185929550")]
		[NativeName("ImmediateTexCoordAll")]
		[MethodImpl(4096)]
		public static extern void TexCoord3(float x, float y, float z);

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x5929500", Offset = "0x5928100", VA = "0x185929500")]
		public static void TexCoord2(float x, float y)
		{
		}

		// Token: 0x06000308 RID: 776
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x59293B0", Offset = "0x5927FB0", VA = "0x1859293B0")]
		[NativeName("ImmediateTexCoord")]
		[MethodImpl(4096)]
		public static extern void MultiTexCoord3(int unit, float x, float y, float z);

		// Token: 0x06000309 RID: 777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x5929350", Offset = "0x5927F50", VA = "0x185929350")]
		public static void MultiTexCoord2(int unit, float x, float y)
		{
		}

		// Token: 0x0600030A RID: 778
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x5929110", Offset = "0x5927D10", VA = "0x185929110")]
		[NativeName("ImmediateColor")]
		[MethodImpl(4096)]
		private static extern void ImmediateColor(float r, float g, float b, float a);

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5928E20", Offset = "0x5927A20", VA = "0x185928E20")]
		public static void Color(Color c)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600030C RID: 780
		// (set) Token: 0x0600030D RID: 781
		[Token(Token = "0x170000B8")]
		[NativeProperty("UserBackfaceMode")]
		public static extern bool invertCulling { [Token(Token = "0x600030C")] [Address(RVA = "0x59296D0", Offset = "0x59282D0", VA = "0x1859296D0")] [MethodImpl(4096)] get; [Token(Token = "0x600030D")] [Address(RVA = "0x5929700", Offset = "0x5928300", VA = "0x185929700")] [MethodImpl(4096)] set; }

		// Token: 0x0600030E RID: 782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x59294C0", Offset = "0x59280C0", VA = "0x1859294C0")]
		private static void SetViewMatrix(Matrix4x4 m)
		{
		}

		// Token: 0x170000B9 RID: 185
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B9")]
		public static Matrix4x4 modelview
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x5929740", Offset = "0x5928340", VA = "0x185929740")]
			set
			{
			}
		}

		// Token: 0x06000310 RID: 784
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x5929450", Offset = "0x5928050", VA = "0x185929450")]
		[FreeFunction("GLPushMatrixScript")]
		[MethodImpl(4096)]
		public static extern void PushMatrix();

		// Token: 0x06000311 RID: 785
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5929420", Offset = "0x5928020", VA = "0x185929420")]
		[FreeFunction("GLPopMatrixScript")]
		[MethodImpl(4096)]
		public static extern void PopMatrix();

		// Token: 0x06000312 RID: 786
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x5929270", Offset = "0x5927E70", VA = "0x185929270")]
		[FreeFunction("GLLoadIdentityScript")]
		[MethodImpl(4096)]
		public static extern void LoadIdentity();

		// Token: 0x06000313 RID: 787
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x59292A0", Offset = "0x5927EA0", VA = "0x1859292A0")]
		[FreeFunction("GLLoadOrthoScript")]
		[MethodImpl(4096)]
		public static extern void LoadOrtho();

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5929310", Offset = "0x5927F10", VA = "0x185929310")]
		[FreeFunction("GLLoadProjectionMatrixScript")]
		public static void LoadProjectionMatrix(Matrix4x4 mat)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x59290A0", Offset = "0x5927CA0", VA = "0x1859290A0")]
		[FreeFunction("GLGetGPUProjectionMatrix")]
		public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000316 RID: 790
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5928FC0", Offset = "0x5927BC0", VA = "0x185928FC0")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern void GLLoadPixelMatrixScript(float left, float right, float bottom, float top);

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x5928FC0", Offset = "0x5927BC0", VA = "0x185928FC0")]
		public static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
		}

		// Token: 0x06000318 RID: 792
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5928F80", Offset = "0x5927B80", VA = "0x185928F80")]
		[FreeFunction]
		[MethodImpl(4096)]
		private static extern void GLIssuePluginEvent(IntPtr callback, int eventID);

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x5929190", Offset = "0x5927D90", VA = "0x185929190")]
		public static void IssuePluginEvent(IntPtr callback, int eventID)
		{
		}

		// Token: 0x0600031A RID: 794
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x5928CC0", Offset = "0x59278C0", VA = "0x185928CC0")]
		[FreeFunction("GLBegin", ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern void Begin(int mode);

		// Token: 0x0600031B RID: 795
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x5928E70", Offset = "0x5927A70", VA = "0x185928E70")]
		[FreeFunction("GLEnd")]
		[MethodImpl(4096)]
		public static extern void End();

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x5928F10", Offset = "0x5927B10", VA = "0x185928F10")]
		[FreeFunction]
		private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x5928D50", Offset = "0x5927950", VA = "0x185928D50")]
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5928DC0", Offset = "0x59279C0", VA = "0x185928DC0")]
		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x5929690", Offset = "0x5928290", VA = "0x185929690")]
		[FreeFunction("SetGLViewport")]
		public static void Viewport(Rect pixelRect)
		{
		}

		// Token: 0x06000320 RID: 800
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5928D00", Offset = "0x5927900", VA = "0x185928D00")]
		[FreeFunction("ClearWithSkybox")]
		[MethodImpl(4096)]
		public static extern void ClearWithSkybox(bool clearDepth, Camera camera);

		// Token: 0x06000321 RID: 801
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x5929480", Offset = "0x5928080", VA = "0x185929480")]
		[MethodImpl(4096)]
		private static extern void SetViewMatrix_Injected(ref Matrix4x4 m);

		// Token: 0x06000322 RID: 802
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x59292D0", Offset = "0x5927ED0", VA = "0x1859292D0")]
		[MethodImpl(4096)]
		private static extern void LoadProjectionMatrix_Injected(ref Matrix4x4 mat);

		// Token: 0x06000323 RID: 803
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5929040", Offset = "0x5927C40", VA = "0x185929040")]
		[MethodImpl(4096)]
		private static extern void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret);

		// Token: 0x06000324 RID: 804
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x5928EA0", Offset = "0x5927AA0", VA = "0x185928EA0")]
		[MethodImpl(4096)]
		private static extern void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);

		// Token: 0x06000325 RID: 805
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x5929650", Offset = "0x5928250", VA = "0x185929650")]
		[MethodImpl(4096)]
		private static extern void Viewport_Injected(ref Rect pixelRect);
	}
}
