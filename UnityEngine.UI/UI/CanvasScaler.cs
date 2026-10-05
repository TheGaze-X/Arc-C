using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[ExecuteAlways]
	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Canvas))]
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A8")]
		public CanvasScaler.ScaleMode uiScaleMode
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return CanvasScaler.ScaleMode.ConstantPixelSize;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002E80 File Offset: 0x00001080
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A9")]
		public float referencePixelsPerUnit
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00002E98 File Offset: 0x00001098
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AA")]
		public float scaleFactor
		{
			[Token(Token = "0x6000275")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000276")]
			[Address(RVA = "0x5B56290", Offset = "0x5B54E90", VA = "0x185B56290")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002EB0 File Offset: 0x000010B0
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AB")]
		public Vector2 referenceResolution
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5B561E0", Offset = "0x5B54DE0", VA = "0x185B561E0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5B56220", Offset = "0x5B54E20", VA = "0x185B56220")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x170000AC")]
		public Vector2 referenceResolutionAfterScaler
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x5B560D0", Offset = "0x5B54CD0", VA = "0x185B560D0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AD")]
		public CanvasScaler.ScreenMatchMode screenMatchMode
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AE")]
		public float matchWidthOrHeight
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AF")]
		public CanvasScaler.Unit physicalUnit
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return CanvasScaler.Unit.Centimeters;
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B0")]
		public float fallbackScreenDPI
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xFB13C0", Offset = "0xFAFFC0", VA = "0x180FB13C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1692890", Offset = "0x1691490", VA = "0x181692890")]
			set
			{
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B1")]
		public float defaultSpriteDPI
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x5B56200", Offset = "0x5B54E00", VA = "0x185B56200")]
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x06000285 RID: 645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B2")]
		public float dynamicPixelsPerUnit
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x42B1310", Offset = "0x42AFF10", VA = "0x1842B1310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x4469FE0", Offset = "0x4468BE0", VA = "0x184469FE0")]
			set
			{
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B3")]
		public Canvas canvas
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x5B55CC0", Offset = "0x5B548C0", VA = "0x185B55CC0")]
		public bool IsScreenSizeMatch()
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x5B56000", Offset = "0x5B54C00", VA = "0x185B56000")]
		public void Torappu_HandleConstantPhysicalSize()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x5626A30", Offset = "0x5625630", VA = "0x185626A30")]
		public void Torappu_HandleConstantPixelSize()
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x5B56040", Offset = "0x5B54C40", VA = "0x185B56040")]
		public void Torappu_HandleScaleWithScreenSize()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5B55FC0", Offset = "0x5B54BC0", VA = "0x185B55FC0")]
		public void Torappu_SetScaleFactor(float scaleFactor)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x5B55F80", Offset = "0x5B54B80", VA = "0x185B55F80")]
		public void Torappu_SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x5B56080", Offset = "0x5B54C80", VA = "0x185B56080")]
		protected CanvasScaler()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x5B55EB0", Offset = "0x5B54AB0", VA = "0x185B55EB0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x5B556E0", Offset = "0x5B542E0", VA = "0x185B556E0")]
		private void Canvas_preWillRenderCanvases()
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x5B55DD0", Offset = "0x5B549D0", VA = "0x185B55DD0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x5B55B70", Offset = "0x5B54770", VA = "0x185B55B70", Slot = "17")]
		protected virtual void Handle()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5B55B00", Offset = "0x5B54700", VA = "0x185B55B00", Slot = "18")]
		protected virtual void HandleWorldCanvas()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5B55800", Offset = "0x5B54400", VA = "0x185B55800", Slot = "19")]
		protected virtual void HandleConstantPixelSize()
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5B55870", Offset = "0x5B54470", VA = "0x185B55870", Slot = "20")]
		protected virtual void HandleScaleWithScreenSize()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5B55720", Offset = "0x5B54320", VA = "0x185B55720", Slot = "21")]
		protected virtual void HandleConstantPhysicalSize()
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5B55FC0", Offset = "0x5B54BC0", VA = "0x185B55FC0")]
		protected void SetScaleFactor(float scaleFactor)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5B55F80", Offset = "0x5B54B80", VA = "0x185B55F80")]
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
		}

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		[SerializeField]
		private CanvasScaler.ScaleMode m_UiScaleMode;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
		[SerializeField]
		protected float m_ReferencePixelsPerUnit;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		[SerializeField]
		protected float m_ScaleFactor;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		[SerializeField]
		protected Vector2 m_ReferenceResolution;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
		protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		[SerializeField]
		protected float m_MatchWidthOrHeight;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		private const float kLogBase = 2f;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("The physical unit to specify positions and sizes in.")]
		protected CanvasScaler.Unit m_PhysicalUnit;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		protected float m_FallbackScreenDPI;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
		protected float m_DefaultSpriteDPI;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		protected float m_DynamicPixelsPerUnit;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x48")]
		private Canvas m_Canvas;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private float m_PrevScaleFactor;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x54")]
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected bool m_PresetInfoIsWorld;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 cacheLocalScale;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x68")]
		public bool isInited;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x0")]
		public static CanvasScalerAspects s_aspects;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x69")]
		public bool isSizeCached;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2 cacheScreenSize;

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public enum ScaleMode
		{
			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			ConstantPixelSize,
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			ScaleWithScreenSize,
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			ConstantPhysicalSize
		}

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		public enum ScreenMatchMode
		{
			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			MatchWidthOrHeight,
			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			Expand,
			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			Shrink
		}

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		public enum Unit
		{
			// Token: 0x04000156 RID: 342
			[Token(Token = "0x4000156")]
			Centimeters,
			// Token: 0x04000157 RID: 343
			[Token(Token = "0x4000157")]
			Millimeters,
			// Token: 0x04000158 RID: 344
			[Token(Token = "0x4000158")]
			Inches,
			// Token: 0x04000159 RID: 345
			[Token(Token = "0x4000159")]
			Points,
			// Token: 0x0400015A RID: 346
			[Token(Token = "0x400015A")]
			Picas
		}
	}
}
