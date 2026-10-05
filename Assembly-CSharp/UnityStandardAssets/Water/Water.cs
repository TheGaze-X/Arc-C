using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x3216A90", Offset = "0x3215690", VA = "0x183216A90")]
		public void OnWillRenderObject()
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x3216740", Offset = "0x3215340", VA = "0x183216740")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x3218310", Offset = "0x3216F10", VA = "0x183218310")]
		private void Update()
		{
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x32180C0", Offset = "0x3216CC0", VA = "0x1832180C0")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x3215C10", Offset = "0x3214810", VA = "0x183215C10")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x3216730", Offset = "0x3215330", VA = "0x183216730")]
		private Water.WaterMode GetWaterMode()
		{
			return Water.WaterMode.Simple;
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x32165D0", Offset = "0x32151D0", VA = "0x1832165D0")]
		private Water.WaterMode FindHardwareWaterSupport()
		{
			return Water.WaterMode.Simple;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x3215970", Offset = "0x3214570", VA = "0x183215970")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x509F80", Offset = "0x508B80", VA = "0x180509F80")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x3218650", Offset = "0x3217250", VA = "0x183218650")]
		public Water()
		{
		}

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x18")]
		public Water.WaterMode waterMode;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x20")]
		public int textureSize;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x50")]
		private Water.WaterMode m_HardwareWaterSupport;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		// Token: 0x0200024D RID: 589
		[Token(Token = "0x200024D")]
		public enum WaterMode
		{
			// Token: 0x04000C70 RID: 3184
			[Token(Token = "0x4000C70")]
			Simple,
			// Token: 0x04000C71 RID: 3185
			[Token(Token = "0x4000C71")]
			Reflective,
			// Token: 0x04000C72 RID: 3186
			[Token(Token = "0x4000C72")]
			Refractive
		}
	}
}
