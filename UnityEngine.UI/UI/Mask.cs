using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[AddComponentMenu("UI/Mask", 13)]
	[ExecuteAlways]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E4")]
		public RectTransform rectTransform
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x5B695B0", Offset = "0x5B681B0", VA = "0x185B695B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E5")]
		public bool showMaskGraphic
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x5B69620", Offset = "0x5B68220", VA = "0x185B69620")]
			set
			{
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E6")]
		public Graphic graphic
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x5B69540", Offset = "0x5B68140", VA = "0x185B69540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x5B69530", Offset = "0x5B68130", VA = "0x185B69530")]
		protected Mask()
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x5B68D20", Offset = "0x5B67920", VA = "0x185B68D20", Slot = "19")]
		public virtual bool MaskEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		[Obsolete("Not used anymore.")]
		public virtual void OnSiblingGraphicEnabledDisabled()
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x5B69200", Offset = "0x5B67E00", VA = "0x185B69200", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x5B68E00", Offset = "0x5B67A00", VA = "0x185B68E00", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x5B68C30", Offset = "0x5B67830", VA = "0x185B68C30", Slot = "21")]
		public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x5B68910", Offset = "0x5B67510", VA = "0x185B68910", Slot = "22")]
		public virtual Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private RectTransform m_RectTransform;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_ShowMaskGraphic;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private Graphic m_Graphic;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private Material m_MaskMaterial;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		private Material m_UnmaskMaterial;
	}
}
