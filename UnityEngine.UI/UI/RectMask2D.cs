using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[AddComponentMenu("UI/Rect Mask 2D", 14)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600039D RID: 925 RVA: 0x000036D8 File Offset: 0x000018D8
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F5")]
		public Vector4 padding
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x5B6E520", Offset = "0x5B6D120", VA = "0x185B6E520")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x5B6E7B0", Offset = "0x5B6D3B0", VA = "0x185B6E7B0")]
			set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600039F RID: 927 RVA: 0x000036F0 File Offset: 0x000018F0
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F6")]
		public Vector2Int softness
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x5B6E7A0", Offset = "0x5B6D3A0", VA = "0x185B6E7A0")]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x5B6E7C0", Offset = "0x5B6D3C0", VA = "0x185B6E7C0")]
			set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		internal Canvas Canvas
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x5B6E2E0", Offset = "0x5B6CEE0", VA = "0x185B6E2E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x170000F8")]
		public Rect canvasRect
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x5B6E450", Offset = "0x5B6D050", VA = "0x185B6E450")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F9")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x5B6E530", Offset = "0x5B6D130", VA = "0x185B6E530")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x5B6E150", Offset = "0x5B6CD50", VA = "0x185B6E150")]
		protected RectMask2D()
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5B6D440", Offset = "0x5B6C040", VA = "0x185B6D440", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5B6D380", Offset = "0x5B6BF80", VA = "0x185B6D380", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x5B6D360", Offset = "0x5B6BF60", VA = "0x185B6D360", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x5B6D210", Offset = "0x5B6BE10", VA = "0x185B6D210", Slot = "19")]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x170000FA")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x5B6E5A0", Offset = "0x5B6D1A0", VA = "0x185B6E5A0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x5B6D470", Offset = "0x5B6C070", VA = "0x185B6D470", Slot = "20")]
		public virtual void PerformClipping()
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5B6DE10", Offset = "0x5B6CA10", VA = "0x185B6DE10", Slot = "21")]
		public virtual void UpdateClipSoftness()
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x5B6D0F0", Offset = "0x5B6BCF0", VA = "0x185B6D0F0")]
		public void AddClippable(IClippable clippable)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x5B6DCC0", Offset = "0x5B6C8C0", VA = "0x185B6DCC0")]
		public void RemoveClippable(IClippable clippable)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x5B6D330", Offset = "0x5B6BF30", VA = "0x185B6D330", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5B6D330", Offset = "0x5B6BF30", VA = "0x185B6D330", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private readonly RectangularVertexClipper m_VertexClipper;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private HashSet<MaskableGraphic> m_MaskableTargets;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private HashSet<IClippable> m_ClipTargets;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private bool m_ShouldRecalculateClipRects;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		private List<RectMask2D> m_Clippers;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		private Rect m_LastClipRectCanvasSpace;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		private bool m_ForceClip;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Vector4 m_Padding;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector2Int m_Softness;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Canvas m_Canvas;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] m_Corners;
	}
}
