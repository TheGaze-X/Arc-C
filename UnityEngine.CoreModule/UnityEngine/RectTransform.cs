using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	[NativeHeader("Runtime/Transform/RectTransform.h")]
	[NativeClass("UI::RectTransform")]
	public sealed class RectTransform : Transform
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		public static event RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x5968F90", Offset = "0x5967B90", VA = "0x185968F90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x5969750", Offset = "0x5968350", VA = "0x185969750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x17000254")]
		public Rect rect
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x5969660", Offset = "0x5968260", VA = "0x185969660")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00006318 File Offset: 0x00004518
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000255")]
		public Vector2 anchorMin
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x5969140", Offset = "0x5967D40", VA = "0x185969140")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x59698F0", Offset = "0x59684F0", VA = "0x1859698F0")]
			set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00006330 File Offset: 0x00004530
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000256")]
		public Vector2 anchorMax
		{
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x59690A0", Offset = "0x5967CA0", VA = "0x1859690A0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x5969860", Offset = "0x5968460", VA = "0x185969860")]
			set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x00006348 File Offset: 0x00004548
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000257")]
		public Vector2 anchoredPosition
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x5969290", Offset = "0x5967E90", VA = "0x185969290")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x5969A60", Offset = "0x5968660", VA = "0x185969A60")]
			set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x00006360 File Offset: 0x00004560
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000258")]
		public Vector2 sizeDelta
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x5969700", Offset = "0x5968300", VA = "0x185969700")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x596A0E0", Offset = "0x5968CE0", VA = "0x18596A0E0")]
			set
			{
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000259")]
		public Vector2 pivot
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x59695C0", Offset = "0x59681C0", VA = "0x1859695C0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x596A050", Offset = "0x5968C50", VA = "0x18596A050")]
			set
			{
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00006390 File Offset: 0x00004590
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025A")]
		public Vector3 anchoredPosition3D
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x5969190", Offset = "0x5967D90", VA = "0x185969190")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x5969930", Offset = "0x5968530", VA = "0x185969930")]
			set
			{
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025B")]
		public Vector2 offsetMin
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x5969490", Offset = "0x5968090", VA = "0x185969490")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x5969D90", Offset = "0x5968990", VA = "0x185969D90")]
			set
			{
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		public Vector2 offsetMax
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x5969360", Offset = "0x5967F60", VA = "0x185969360")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x5969B30", Offset = "0x5968730", VA = "0x185969B30")]
			set
			{
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000B35 RID: 2869
		// (set) Token: 0x06000B36 RID: 2870
		[Token(Token = "0x1700025D")]
		public extern Object drivenByObject { [Token(Token = "0x6000B35")] [Address(RVA = "0x59692E0", Offset = "0x5967EE0", VA = "0x1859692E0")] [MethodImpl(4096)] get; [Token(Token = "0x6000B36")] [Address(RVA = "0x5969AA0", Offset = "0x59686A0", VA = "0x185969AA0")] [MethodImpl(4096)] internal set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000B37 RID: 2871
		// (set) Token: 0x06000B38 RID: 2872
		[Token(Token = "0x1700025E")]
		internal extern DrivenTransformProperties drivenProperties { [Token(Token = "0x6000B37")] [Address(RVA = "0x5969320", Offset = "0x5967F20", VA = "0x185969320")] [MethodImpl(4096)] get; [Token(Token = "0x6000B38")] [Address(RVA = "0x5969AF0", Offset = "0x59686F0", VA = "0x185969AF0")] [MethodImpl(4096)] set; }

		// Token: 0x06000B39 RID: 2873
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5967B30", Offset = "0x5966730", VA = "0x185967B30")]
		[NativeMethod("UpdateIfTransformDispatchIsDirty")]
		[MethodImpl(4096)]
		public extern void ForceUpdateRectTransforms();

		// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x5967B70", Offset = "0x5966770", VA = "0x185967B70")]
		public void GetLocalCorners(Vector3[] fourCornersArray)
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x59682B0", Offset = "0x5966EB0", VA = "0x1859682B0")]
		public void GetWorldCorners(Vector3[] fourCornersArray)
		{
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x5968640", Offset = "0x5967240", VA = "0x185968640")]
		public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size)
		{
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x5968B30", Offset = "0x5967730", VA = "0x185968B30")]
		public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x59685E0", Offset = "0x59671E0", VA = "0x1859685E0")]
		[RequiredByNativeCode]
		internal static void SendReapplyDrivenProperties(RectTransform driven)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x5967F10", Offset = "0x5966B10", VA = "0x185967F10")]
		internal Rect GetRectInParentSpace()
		{
			return default(Rect);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5967D50", Offset = "0x5966950", VA = "0x185967D50")]
		private Vector2 GetParentSize()
		{
			return default(Vector2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public RectTransform()
		{
		}

		// Token: 0x06000B42 RID: 2882
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x5969610", Offset = "0x5968210", VA = "0x185969610")]
		[MethodImpl(4096)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x06000B43 RID: 2883
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x59690F0", Offset = "0x5967CF0", VA = "0x1859690F0")]
		[MethodImpl(4096)]
		private extern void get_anchorMin_Injected(out Vector2 ret);

		// Token: 0x06000B44 RID: 2884
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x59698A0", Offset = "0x59684A0", VA = "0x1859698A0")]
		[MethodImpl(4096)]
		private extern void set_anchorMin_Injected(ref Vector2 value);

		// Token: 0x06000B45 RID: 2885
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x5969050", Offset = "0x5967C50", VA = "0x185969050")]
		[MethodImpl(4096)]
		private extern void get_anchorMax_Injected(out Vector2 ret);

		// Token: 0x06000B46 RID: 2886
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x5969810", Offset = "0x5968410", VA = "0x185969810")]
		[MethodImpl(4096)]
		private extern void set_anchorMax_Injected(ref Vector2 value);

		// Token: 0x06000B47 RID: 2887
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x5969240", Offset = "0x5967E40", VA = "0x185969240")]
		[MethodImpl(4096)]
		private extern void get_anchoredPosition_Injected(out Vector2 ret);

		// Token: 0x06000B48 RID: 2888
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x5969A10", Offset = "0x5968610", VA = "0x185969A10")]
		[MethodImpl(4096)]
		private extern void set_anchoredPosition_Injected(ref Vector2 value);

		// Token: 0x06000B49 RID: 2889
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x59696B0", Offset = "0x59682B0", VA = "0x1859696B0")]
		[MethodImpl(4096)]
		private extern void get_sizeDelta_Injected(out Vector2 ret);

		// Token: 0x06000B4A RID: 2890
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x596A090", Offset = "0x5968C90", VA = "0x18596A090")]
		[MethodImpl(4096)]
		private extern void set_sizeDelta_Injected(ref Vector2 value);

		// Token: 0x06000B4B RID: 2891
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x5969570", Offset = "0x5968170", VA = "0x185969570")]
		[MethodImpl(4096)]
		private extern void get_pivot_Injected(out Vector2 ret);

		// Token: 0x06000B4C RID: 2892
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x596A000", Offset = "0x5968C00", VA = "0x18596A000")]
		[MethodImpl(4096)]
		private extern void set_pivot_Injected(ref Vector2 value);

		// Token: 0x02000148 RID: 328
		[Token(Token = "0x2000148")]
		public enum Edge
		{
			// Token: 0x04000537 RID: 1335
			[Token(Token = "0x4000537")]
			Left,
			// Token: 0x04000538 RID: 1336
			[Token(Token = "0x4000538")]
			Right,
			// Token: 0x04000539 RID: 1337
			[Token(Token = "0x4000539")]
			Top,
			// Token: 0x0400053A RID: 1338
			[Token(Token = "0x400053A")]
			Bottom
		}

		// Token: 0x02000149 RID: 329
		[Token(Token = "0x2000149")]
		public enum Axis
		{
			// Token: 0x0400053C RID: 1340
			[Token(Token = "0x400053C")]
			Horizontal,
			// Token: 0x0400053D RID: 1341
			[Token(Token = "0x400053D")]
			Vertical
		}

		// Token: 0x0200014A RID: 330
		// (Invoke) Token: 0x06000B4E RID: 2894
		[Token(Token = "0x200014A")]
		public delegate void ReapplyDrivenProperties(RectTransform driven);
	}
}
