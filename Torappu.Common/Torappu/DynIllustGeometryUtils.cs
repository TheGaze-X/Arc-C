using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	public class DynIllustGeometryUtils : IHotfixable
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x00005B94 File Offset: 0x00003D94
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x5513EA0", Offset = "0x5512AA0", VA = "0x185513EA0")]
		public static DynIllustGeometryUtils.Output CalculateAdaptiveParam(DynIllustGeometryUtils.Input input)
		{
			return default(DynIllustGeometryUtils.Output);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00005BAC File Offset: 0x00003DAC
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x5515270", Offset = "0x5513E70", VA = "0x185515270")]
		private static DynIllustGeometryUtils.Output _CalculateOutputWithScreenSpaceCamera(DynIllustGeometryUtils.Input input)
		{
			return default(DynIllustGeometryUtils.Output);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00005BC4 File Offset: 0x00003DC4
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x55157B0", Offset = "0x55143B0", VA = "0x1855157B0")]
		private static DynIllustGeometryUtils.Output _CalculateOutputWithWorldSpaceCamera(DynIllustGeometryUtils.Input input)
		{
			return default(DynIllustGeometryUtils.Output);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00005BDC File Offset: 0x00003DDC
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x5514380", Offset = "0x5512F80", VA = "0x185514380")]
		private static DynIllustGeometryUtils.Output _CalculateMeshAndUV(DynIllustGeometryUtils.Input param, Bounds screenBound, float screenWidthInRawImageSpace, float screenWidthInWorldSpace, float currentDistanceZ = 0f)
		{
			return default(DynIllustGeometryUtils.Output);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x5516200", Offset = "0x5514E00", VA = "0x185516200")]
		private static void _ClampWithLinkedScale(ref float main, ref float linked, float min, float max)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x5516380", Offset = "0x5514F80", VA = "0x185516380")]
		public DynIllustGeometryUtils()
		{
		}

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] s_corners;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate87 __Hotfix0_CalculateAdaptiveParam;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate87 __Hotfix0__CalculateOutputWithScreenSpaceCamera;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate87 __Hotfix0__CalculateOutputWithWorldSpaceCamera;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate88 __Hotfix0__CalculateMeshAndUV;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate89 __Hotfix0__ClampWithLinkedScale;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x020000E0 RID: 224
		[Token(Token = "0x20000E0")]
		public enum OutputKind
		{
			// Token: 0x0400050D RID: 1293
			[Token(Token = "0x400050D")]
			INVALID,
			// Token: 0x0400050E RID: 1294
			[Token(Token = "0x400050E")]
			LEGACY,
			// Token: 0x0400050F RID: 1295
			[Token(Token = "0x400050F")]
			VALID
		}

		// Token: 0x020000E1 RID: 225
		[Token(Token = "0x20000E1")]
		public struct Input
		{
			// Token: 0x04000510 RID: 1296
			[Token(Token = "0x4000510")]
			[FieldOffset(Offset = "0x0")]
			public bool isLegacy;

			// Token: 0x04000511 RID: 1297
			[Token(Token = "0x4000511")]
			[FieldOffset(Offset = "0x8")]
			public Camera uiCamera;

			// Token: 0x04000512 RID: 1298
			[Token(Token = "0x4000512")]
			[FieldOffset(Offset = "0x10")]
			public Canvas rootCanvas;

			// Token: 0x04000513 RID: 1299
			[Token(Token = "0x4000513")]
			[FieldOffset(Offset = "0x18")]
			public RawImage imgIllust;

			// Token: 0x04000514 RID: 1300
			[Token(Token = "0x4000514")]
			[FieldOffset(Offset = "0x20")]
			public RectTransform illustTrans;

			// Token: 0x04000515 RID: 1301
			[Token(Token = "0x4000515")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 referenceCenter;

			// Token: 0x04000516 RID: 1302
			[Token(Token = "0x4000516")]
			[FieldOffset(Offset = "0x34")]
			public float referenceOrthographicSize;

			// Token: 0x04000517 RID: 1303
			[Token(Token = "0x4000517")]
			[FieldOffset(Offset = "0x38")]
			public float overflowSize;

			// Token: 0x04000518 RID: 1304
			[Token(Token = "0x4000518")]
			[FieldOffset(Offset = "0x3C")]
			public float minOrthographicSize;

			// Token: 0x04000519 RID: 1305
			[Token(Token = "0x4000519")]
			[FieldOffset(Offset = "0x40")]
			public float rtCameraZValue;

			// Token: 0x0400051A RID: 1306
			[Token(Token = "0x400051A")]
			[FieldOffset(Offset = "0x48")]
			public Vector3[] rawImageWorldCorners;

			// Token: 0x0400051B RID: 1307
			[Token(Token = "0x400051B")]
			[FieldOffset(Offset = "0x50")]
			public float zoomMaxRatio;
		}

		// Token: 0x020000E2 RID: 226
		[Token(Token = "0x20000E2")]
		public struct Output
		{
			// Token: 0x0400051C RID: 1308
			[Token(Token = "0x400051C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DynIllustGeometryUtils.Output INVALID;

			// Token: 0x0400051D RID: 1309
			[Token(Token = "0x400051D")]
			[FieldOffset(Offset = "0x3C")]
			public static readonly DynIllustGeometryUtils.Output LEGACY;

			// Token: 0x0400051E RID: 1310
			[Token(Token = "0x400051E")]
			[FieldOffset(Offset = "0x0")]
			public DynIllustGeometryUtils.OutputKind kind;

			// Token: 0x0400051F RID: 1311
			[Token(Token = "0x400051F")]
			[FieldOffset(Offset = "0x4")]
			public Vector3 localBL;

			// Token: 0x04000520 RID: 1312
			[Token(Token = "0x4000520")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 localTR;

			// Token: 0x04000521 RID: 1313
			[Token(Token = "0x4000521")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 uvBL;

			// Token: 0x04000522 RID: 1314
			[Token(Token = "0x4000522")]
			[FieldOffset(Offset = "0x24")]
			public Vector2 uvTR;

			// Token: 0x04000523 RID: 1315
			[Token(Token = "0x4000523")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 rtCameraPosition;

			// Token: 0x04000524 RID: 1316
			[Token(Token = "0x4000524")]
			[FieldOffset(Offset = "0x38")]
			public float rtCameraOrthographicSize;
		}
	}
}
