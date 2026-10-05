using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public class GraphicUtil : IHotfixable
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x551C4D0", Offset = "0x551B0D0", VA = "0x18551C4D0")]
		public static void Blur(RenderTexture source, RenderTexture destination, int downsample, int blurSize, int blurIterations, Material blurMaterial)
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x551F440", Offset = "0x551E040", VA = "0x18551F440")]
		public static Sprite ShotBlurredCamera(Camera camera, Shader blurShader)
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x551C310", Offset = "0x551AF10", VA = "0x18551C310")]
		public static void AdjustSizeToMaxSize(int maxWidth, int maxHeight, ref int basicWidth, ref int basicHeight, RoundingMode roundingMode = RoundingMode.ROUND)
		{
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x551F570", Offset = "0x551E170", VA = "0x18551F570")]
		public static Sprite ShotBlurredCamera(List<Camera> cameras, Shader blurShader, int overrideWidth = 0, int overrideHeight = 0)
		{
			return null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x551E4B0", Offset = "0x551D0B0", VA = "0x18551E4B0")]
		public static RenderTexture CreateCameraRT(Camera camera, RenderTextureFormat textureFormat = RenderTextureFormat.ARGB32, int overrideWidth = 0, int overrideHeight = 0, int depthBuffer = 0)
		{
			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00005E34 File Offset: 0x00004034
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x551C8C0", Offset = "0x551B4C0", VA = "0x18551C8C0")]
		public static int CalcBlurSize(int width, int height)
		{
			return 0;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00005E4C File Offset: 0x0000404C
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x551C9F0", Offset = "0x551B5F0", VA = "0x18551C9F0")]
		public static Bounds CalcBoundOfRectTransform(RectTransform transform, RectTransform local)
		{
			return default(Bounds);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x551D8C0", Offset = "0x551C4C0", VA = "0x18551D8C0")]
		public static Vector3 CalcWorldCenter(RectTransform transform)
		{
			return default(Vector3);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00005E7C File Offset: 0x0000407C
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x551DF40", Offset = "0x551CB40", VA = "0x18551DF40")]
		public static Vector2 ConvertAnchoredPosToOtherRectTrans(Vector2 anchoredPos, RectTransform fromTrans, RectTransform toTrans)
		{
			return default(Vector2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00005E94 File Offset: 0x00004094
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x551FE50", Offset = "0x551EA50", VA = "0x18551FE50")]
		public static Vector2 StartFromLeftBottom(Vector2 position, RectTransform local)
		{
			return default(Vector2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00005EAC File Offset: 0x000040AC
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x551D540", Offset = "0x551C140", VA = "0x18551D540")]
		public static Bounds CalcWorldBoundOfRectTransform(RectTransform transform)
		{
			return default(Bounds);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x551DBC0", Offset = "0x551C7C0", VA = "0x18551DBC0")]
		public static Texture2D CaptureTextureThumbFromCamera(Camera camera, int width, int height)
		{
			return null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x551DA90", Offset = "0x551C690", VA = "0x18551DA90")]
		public static Sprite CaptureSpriteThumbFromCamera(Camera camera, int width, int height)
		{
			return null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00005EC4 File Offset: 0x000040C4
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x551E620", Offset = "0x551D220", VA = "0x18551E620")]
		public static Bounds Encapsulate2DBounds(Bounds target, Bounds container)
		{
			return default(Bounds);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x551DDF0", Offset = "0x551C9F0", VA = "0x18551DDF0")]
		public static void ClearRTSprite(Sprite sprite)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00005EDC File Offset: 0x000040DC
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x55207F0", Offset = "0x551F3F0", VA = "0x1855207F0")]
		public static Vector2 WorldToRectLocalPoint(Camera camera, Vector3 point, RectTransform rectTrans)
		{
			return default(Vector2);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00005EF4 File Offset: 0x000040F4
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x551E1C0", Offset = "0x551CDC0", VA = "0x18551E1C0")]
		public static Vector2 ConvertScreenToCanvasLogic(in Vector2 valInScreen, CanvasScaler scaler)
		{
			return default(Vector2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00005F0C File Offset: 0x0000410C
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x551E360", Offset = "0x551CF60", VA = "0x18551E360")]
		public static Vector2 ConvertScreenToCanvasLogic(in Vector2 valInScreen, in Vector2 referenceResolution, float matchWidthOrHeight)
		{
			return default(Vector2);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00005F24 File Offset: 0x00004124
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x551EBA0", Offset = "0x551D7A0", VA = "0x18551EBA0")]
		public static RenderTextureDescriptor GetRTDescFromBase(RenderTextureDescriptor baseDesc, int width, int height)
		{
			return default(RenderTextureDescriptor);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00005F3C File Offset: 0x0000413C
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x551F110", Offset = "0x551DD10", VA = "0x18551F110")]
		public static Vector2Int Scale2DByMaxValue(Vector2Int size, Vector2Int max)
		{
			return default(Vector2Int);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00005F54 File Offset: 0x00004154
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x551F220", Offset = "0x551DE20", VA = "0x18551F220")]
		public static Vector2Int Scale2DByMinValue(Vector2Int size, Vector2Int max)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00005F6C File Offset: 0x0000416C
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x551D180", Offset = "0x551BD80", VA = "0x18551D180")]
		public static Vector2 CalcCameraHalfScreenSizeAtDistance(Camera cam, float distance)
		{
			return default(Vector2);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00005F84 File Offset: 0x00004184
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x551FFB0", Offset = "0x551EBB0", VA = "0x18551FFB0")]
		public static bool TryCalcCameraFrustumQuadAtDistance(Camera cam, float distance, Vector3[] outWorldCorners)
		{
			return default(bool);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00005F9C File Offset: 0x0000419C
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x551CE20", Offset = "0x551BA20", VA = "0x18551CE20")]
		public static Bounds CalcBoundOfWorldQuadInLocal(Vector3[] worldCorners, Matrix4x4 toLocalMatrix)
		{
			return default(Bounds);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00005FB4 File Offset: 0x000041B4
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x5520320", Offset = "0x551EF20", VA = "0x185520320")]
		public static bool TryGetPlaneNormal(Vector3 a, Vector3 b, Vector3 c, out Vector3 normal)
		{
			return default(bool);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00005FCC File Offset: 0x000041CC
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x551EFD0", Offset = "0x551DBD0", VA = "0x18551EFD0")]
		public static bool IsDirectionParallelToPlaneNormal(Vector3 planeNormal, Vector3 dir, float eps = 1E-05f)
		{
			return default(bool);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00005FE4 File Offset: 0x000041E4
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x551E990", Offset = "0x551D590", VA = "0x18551E990")]
		public static Bounds ExpandBoundsByScreenOverflow(Bounds src, int pixelWidth, int pixelHeight, float overflowPx)
		{
			return default(Bounds);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00005FFC File Offset: 0x000041FC
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x551D380", Offset = "0x551BF80", VA = "0x18551D380")]
		public static float CalcReferenceDistanceByFovAndScreenWidth(Camera cam, float worldScreenWidth)
		{
			return 0f;
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00006014 File Offset: 0x00004214
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x551EE40", Offset = "0x551DA40", VA = "0x18551EE40")]
		public static bool IsBoundsOverlap2D(Bounds a, Bounds b)
		{
			return default(bool);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000602C File Offset: 0x0000422C
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x55205C0", Offset = "0x551F1C0", VA = "0x1855205C0")]
		public static float UICalcInheritAlpha(Graphic graphic)
		{
			return 0f;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00006044 File Offset: 0x00004244
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x551ED90", Offset = "0x551D990", VA = "0x18551ED90")]
		public static float GetScreenScaleMatchValue()
		{
			return 0f;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x551F330", Offset = "0x551DF30", VA = "0x18551F330")]
		public static void SetPropertyBlockToRenderer(Renderer renderer, MaterialPropertyBlock propertyBlock, int materialIndex = -1)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x5520980", Offset = "0x551F580", VA = "0x185520980")]
		public GraphicUtil()
		{
		}

		// Token: 0x04000562 RID: 1378
		[Token(Token = "0x4000562")]
		public const string MAT_UI_ANIM_KEYWORD = "_HG_UI_ANM_ON";

		// Token: 0x04000563 RID: 1379
		[Token(Token = "0x4000563")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] s_corners;

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate90 __Hotfix0_Blur;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate91 __Hotfix0_ShotBlurredCamera;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate92 __Hotfix0_AdjustSizeToMaxSize;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate93 __Hotfix1_ShotBlurredCamera;

		// Token: 0x04000568 RID: 1384
		[Token(Token = "0x4000568")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate94 __Hotfix0_CreateCameraRT;

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate95 __Hotfix0_CalcBlurSize;

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate96 __Hotfix0_CalcBoundOfRectTransform;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate97 __Hotfix0_CalcWorldCenter;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate98 __Hotfix0_ConvertAnchoredPosToOtherRectTrans;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate99 __Hotfix0_StartFromLeftBottom;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate100 __Hotfix0_CalcWorldBoundOfRectTransform;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate101 __Hotfix0_CaptureTextureThumbFromCamera;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate102 __Hotfix0_CaptureSpriteThumbFromCamera;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate103 __Hotfix0_Encapsulate2DBounds;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearRTSprite;

		// Token: 0x04000573 RID: 1395
		[Token(Token = "0x4000573")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate104 __Hotfix0_WorldToRectLocalPoint;

		// Token: 0x04000574 RID: 1396
		[Token(Token = "0x4000574")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate105 __Hotfix0_ConvertScreenToCanvasLogic;

		// Token: 0x04000575 RID: 1397
		[Token(Token = "0x4000575")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate106 __Hotfix1_ConvertScreenToCanvasLogic;

		// Token: 0x04000576 RID: 1398
		[Token(Token = "0x4000576")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate107 __Hotfix0_GetRTDescFromBase;

		// Token: 0x04000577 RID: 1399
		[Token(Token = "0x4000577")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate108 __Hotfix0_Scale2DByMaxValue;

		// Token: 0x04000578 RID: 1400
		[Token(Token = "0x4000578")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate108 __Hotfix0_Scale2DByMinValue;

		// Token: 0x04000579 RID: 1401
		[Token(Token = "0x4000579")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate109 __Hotfix0_CalcCameraHalfScreenSizeAtDistance;

		// Token: 0x0400057A RID: 1402
		[Token(Token = "0x400057A")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate110 __Hotfix0_TryCalcCameraFrustumQuadAtDistance;

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate111 __Hotfix0_CalcBoundOfWorldQuadInLocal;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate112 __Hotfix0_TryGetPlaneNormal;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate113 __Hotfix0_IsDirectionParallelToPlaneNormal;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate114 __Hotfix0_ExpandBoundsByScreenOverflow;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate115 __Hotfix0_CalcReferenceDistanceByFovAndScreenWidth;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate116 __Hotfix0_IsBoundsOverlap2D;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate23 __Hotfix0_UICalcInheritAlpha;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate11 __Hotfix0_GetScreenScaleMatchValue;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate117 __Hotfix0_SetPropertyBlockToRenderer;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x108")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
