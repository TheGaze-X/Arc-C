using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
public class MirrorReflection : MonoBehaviour
{
	// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x50ACD0", Offset = "0x5098D0", VA = "0x18050ACD0")]
	public void OnWillRenderObject()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x50A910", Offset = "0x509510", VA = "0x18050A910")]
	private void OnDisable()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x50B940", Offset = "0x50A540", VA = "0x18050B940")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x50A340", Offset = "0x508F40", VA = "0x18050A340")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x50BCB0", Offset = "0x50A8B0", VA = "0x18050BCB0")]
	private static float sgn(float a)
	{
		return 0f;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x50A0A0", Offset = "0x508CA0", VA = "0x18050A0A0")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x509F80", Offset = "0x508B80", VA = "0x180509F80")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x50BC20", Offset = "0x50A820", VA = "0x18050BC20")]
	public MirrorReflection()
	{
	}

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x18")]
	public bool m_DisablePixelLights;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x1C")]
	public int m_TextureSize;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	public float m_ClipPlaneOffset;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask m_ReflectLayers;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x28")]
	private Hashtable m_ReflectionCameras;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_ReflectionTexture;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x38")]
	private int m_OldReflectionTextureSize;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_InsideRendering;
}
