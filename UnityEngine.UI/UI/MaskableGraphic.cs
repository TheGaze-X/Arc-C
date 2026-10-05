using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E7")]
		public MaskableGraphic.CullStateChangedEvent onCullStateChanged
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xF0A890", Offset = "0xF09490", VA = "0x180F0A890")]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000035B8 File Offset: 0x000017B8
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E8")]
		public bool maskable
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x5B6A300", Offset = "0x5B68F00", VA = "0x185B6A300")]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000035D0 File Offset: 0x000017D0
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E9")]
		public bool isMaskingGraphic
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x371A300", Offset = "0x3718F00", VA = "0x18371A300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x5B6A2F0", Offset = "0x5B68EF0", VA = "0x185B6A2F0")]
			set
			{
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x5B69790", Offset = "0x5B68390", VA = "0x185B69790", Slot = "60")]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x5B69720", Offset = "0x5B68320", VA = "0x185B69720", Slot = "61")]
		public virtual void Cull(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x5B69E20", Offset = "0x5B68A20", VA = "0x185B69E20")]
		private void UpdateCull(bool cull)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x5B69BA0", Offset = "0x5B687A0", VA = "0x185B69BA0", Slot = "62")]
		public virtual void SetClipRect(Rect clipRect, bool validRect)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x5B69C00", Offset = "0x5B68800", VA = "0x185B69C00", Slot = "63")]
		public virtual void SetClipSoftness(Vector2 clipSoftness)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x5B69A10", Offset = "0x5B68610", VA = "0x185B69A10", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x5B69940", Offset = "0x5B68540", VA = "0x185B69940", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x5B69A80", Offset = "0x5B68680", VA = "0x185B69A80", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "64")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Not used anymore.", true)]
		public virtual void ParentMaskStateChanged()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x5B698E0", Offset = "0x5B684E0", VA = "0x185B698E0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x170000EA")]
		private Rect rootCanvasRect
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x5B6A000", Offset = "0x5B68C00", VA = "0x185B6A000")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x5B69C50", Offset = "0x5B68850", VA = "0x185B69C50")]
		private void UpdateClipParent()
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x5B69AE0", Offset = "0x5B686E0", VA = "0x185B69AE0", Slot = "65")]
		public virtual void RecalculateClipping()
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x5B69AF0", Offset = "0x5B686F0", VA = "0x185B69AF0", Slot = "66")]
		public virtual void RecalculateMasking()
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x5B69F00", Offset = "0x5B68B00", VA = "0x185B69F00")]
		protected MaskableGraphic()
		{
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x5B69C40", Offset = "0x5B68840", VA = "0x185B69C40", Slot = "52")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		protected bool m_ShouldRecalculateStencil;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xB8")]
		[NonSerialized]
		protected Material m_MaskMaterial;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		private RectMask2D m_ParentMask;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Maskable;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_IsMaskingGraphic;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xCA")]
		[Obsolete("Not used anymore.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NonSerialized]
		protected bool m_IncludeForMasking;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xD8")]
		[Obsolete("Not used anymore", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[NonSerialized]
		protected bool m_ShouldRecalculate;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0xDC")]
		[NonSerialized]
		protected int m_StencilValue;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Vector3[] m_Corners;

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		[Serializable]
		public class CullStateChangedEvent : UnityEvent<bool>
		{
			// Token: 0x06000378 RID: 888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x5B567F0", Offset = "0x5B553F0", VA = "0x185B567F0")]
			public CullStateChangedEvent()
			{
			}
		}
	}
}
