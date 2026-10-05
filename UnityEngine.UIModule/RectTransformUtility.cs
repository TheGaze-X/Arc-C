using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[NativeHeader("Modules/UI/RectTransformUtil.h")]
	[NativeHeader("Modules/UI/Canvas.h")]
	public sealed class RectTransformUtility
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5B53CE0", Offset = "0x5B528E0", VA = "0x185B53CE0")]
		public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
		{
			return default(Vector2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5B53DD0", Offset = "0x5B529D0", VA = "0x185B53DD0")]
		public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
		{
			return default(Rect);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x5B53ED0", Offset = "0x5B52AD0", VA = "0x185B53ED0")]
		private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
		{
			return default(bool);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5B54040", Offset = "0x5B52C40", VA = "0x185B54040")]
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5B53F60", Offset = "0x5B52B60", VA = "0x185B53F60")]
		public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
		{
			return default(bool);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5B54430", Offset = "0x5B53030", VA = "0x185B54430")]
		public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			return default(bool);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5B54180", Offset = "0x5B52D80", VA = "0x185B54180")]
		public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
		{
			return default(bool);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x5B542A0", Offset = "0x5B52EA0", VA = "0x185B542A0")]
		public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
		{
			return default(Ray);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5B54900", Offset = "0x5B53500", VA = "0x185B54900")]
		public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
		{
			return default(Vector2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5B53120", Offset = "0x5B51D20", VA = "0x185B53120")]
		public static Bounds CalculateRelativeRectTransformBounds(Transform root, Transform child)
		{
			return default(Bounds);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x5B53820", Offset = "0x5B52420", VA = "0x185B53820")]
		public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x5B535C0", Offset = "0x5B521C0", VA = "0x185B535C0")]
		public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5522350", Offset = "0x5520F50", VA = "0x185522350")]
		private static Vector2 GetTransposed(Vector2 input)
		{
			return default(Vector2);
		}

		// Token: 0x0600003D RID: 61
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x5B53C70", Offset = "0x5B52870", VA = "0x185B53C70")]
		[MethodImpl(4096)]
		private static extern void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret);

		// Token: 0x0600003E RID: 62
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5B53D70", Offset = "0x5B52970", VA = "0x185B53D70")]
		[MethodImpl(4096)]
		private static extern void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret);

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5B53E60", Offset = "0x5B52A60", VA = "0x185B53E60")]
		[MethodImpl(4096)]
		private static extern bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset);

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3[] s_Corners;
	}
}
