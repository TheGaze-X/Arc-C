using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200349F RID: 13471
	[Token(Token = "0x200349F")]
	[ExecuteInEditMode]
	public class UIAtlasImage : MaskableGraphic, ILayoutElement, IHotfixable, ISerializationCallbackReceiver
	{
		// Token: 0x06015792 RID: 87954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015792")]
		[Address(RVA = "0xDF16B0", Offset = "0xDF02B0", VA = "0x180DF16B0")]
		private void _SetToRuntimeSprite(SpriteRenderData renderData)
		{
		}

		// Token: 0x06015793 RID: 87955 RVA: 0x0008C148 File Offset: 0x0008A348
		[Token(Token = "0x6015793")]
		[Address(RVA = "0xDF1380", Offset = "0xDEFF80", VA = "0x180DF1380")]
		private SpriteRenderData _InitRuntimeSprite()
		{
			return default(SpriteRenderData);
		}

		// Token: 0x170032B4 RID: 12980
		// (get) Token: 0x06015794 RID: 87956 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015795 RID: 87957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170032B4")]
		public override Material material
		{
			[Token(Token = "0x6015794")]
			[Address(RVA = "0xDF1C70", Offset = "0xDF0870", VA = "0x180DF1C70", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015795")]
			[Address(RVA = "0xDF2310", Offset = "0xDF0F10", VA = "0x180DF2310", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x06015796 RID: 87958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015796")]
		[Address(RVA = "0xDEF5B0", Offset = "0xDEE1B0", VA = "0x180DEF5B0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x06015797 RID: 87959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015797")]
		[Address(RVA = "0xDEFB60", Offset = "0xDEE760", VA = "0x180DEFB60", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x170032B5 RID: 12981
		// (get) Token: 0x06015798 RID: 87960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032B5")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6015798")]
			[Address(RVA = "0xDF1BF0", Offset = "0xDF07F0", VA = "0x180DF1BF0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015799 RID: 87961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015799")]
		[Address(RVA = "0xDEF6C0", Offset = "0xDEE2C0", VA = "0x180DEF6C0", Slot = "47")]
		public override void SetNativeSize()
		{
		}

		// Token: 0x170032B6 RID: 12982
		// (get) Token: 0x0601579A RID: 87962 RVA: 0x0008C160 File Offset: 0x0008A360
		[Token(Token = "0x170032B6")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x601579A")]
			[Address(RVA = "0xDF1F90", Offset = "0xDF0B90", VA = "0x180DF1F90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032B7 RID: 12983
		// (get) Token: 0x0601579B RID: 87963 RVA: 0x0008C178 File Offset: 0x0008A378
		[Token(Token = "0x170032B7")]
		public SpriteRenderData RuntimeRD
		{
			[Token(Token = "0x601579B")]
			[Address(RVA = "0xDF19D0", Offset = "0xDF05D0", VA = "0x180DF19D0")]
			get
			{
				return default(SpriteRenderData);
			}
		}

		// Token: 0x0601579C RID: 87964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601579C")]
		[Address(RVA = "0xDEF400", Offset = "0xDEE000", VA = "0x180DEF400", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0601579D RID: 87965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601579D")]
		[Address(RVA = "0xDEF900", Offset = "0xDEE500", VA = "0x180DEF900")]
		public void SetSprite(SpriteRenderData renderData)
		{
		}

		// Token: 0x0601579E RID: 87966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601579E")]
		[Address(RVA = "0xDEF1C0", Offset = "0xDEDDC0", VA = "0x180DEF1C0")]
		public void ClearSprite()
		{
		}

		// Token: 0x0601579F RID: 87967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601579F")]
		[Address(RVA = "0xDF15A0", Offset = "0xDF01A0", VA = "0x180DF15A0")]
		private void _SetToInitSprite()
		{
		}

		// Token: 0x060157A0 RID: 87968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157A0")]
		[Address(RVA = "0xDF01E0", Offset = "0xDEEDE0", VA = "0x180DF01E0")]
		private void _GenerateSimpleSprite(VertexHelper vh)
		{
		}

		// Token: 0x060157A1 RID: 87969 RVA: 0x0008C190 File Offset: 0x0008A390
		[Token(Token = "0x60157A1")]
		[Address(RVA = "0xDF0510", Offset = "0xDEF110", VA = "0x180DF0510")]
		private bool _GenerateSliceSprite(VertexHelper vh)
		{
			return default(bool);
		}

		// Token: 0x060157A2 RID: 87970 RVA: 0x0008C1A8 File Offset: 0x0008A3A8
		[Token(Token = "0x60157A2")]
		[Address(RVA = "0xDF1260", Offset = "0xDEFE60", VA = "0x180DF1260")]
		private Vector4 _GetDrawingDimensions()
		{
			return default(Vector4);
		}

		// Token: 0x060157A3 RID: 87971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157A3")]
		[Address(RVA = "0xDEFEF0", Offset = "0xDEEAF0", VA = "0x180DEFEF0")]
		private void _AddQuad(VertexHelper vh, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		// Token: 0x060157A4 RID: 87972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157A4")]
		[Address(RVA = "0xDEFC00", Offset = "0xDEE800", VA = "0x180DEFC00")]
		private void _AddQuadRotate(VertexHelper vh, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		// Token: 0x060157A5 RID: 87973 RVA: 0x0008C1C0 File Offset: 0x0008A3C0
		[Token(Token = "0x60157A5")]
		[Address(RVA = "0xDF0F50", Offset = "0xDEFB50", VA = "0x180DF0F50")]
		private Vector4 _GetAdjustedBorders(Vector4 border, Vector2 adjustedSize)
		{
			return default(Vector4);
		}

		// Token: 0x170032B8 RID: 12984
		// (get) Token: 0x060157A6 RID: 87974 RVA: 0x0008C1D8 File Offset: 0x0008A3D8
		[Token(Token = "0x170032B8")]
		public float minWidth
		{
			[Token(Token = "0x60157A6")]
			[Address(RVA = "0xDF1F20", Offset = "0xDF0B20", VA = "0x180DF1F20", Slot = "69")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032B9 RID: 12985
		// (get) Token: 0x060157A7 RID: 87975 RVA: 0x0008C1F0 File Offset: 0x0008A3F0
		[Token(Token = "0x170032B9")]
		public float preferredWidth
		{
			[Token(Token = "0x60157A7")]
			[Address(RVA = "0xDF21D0", Offset = "0xDF0DD0", VA = "0x180DF21D0", Slot = "70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x060157A8 RID: 87976 RVA: 0x0008C208 File Offset: 0x0008A408
		[Token(Token = "0x170032BA")]
		public float flexibleWidth
		{
			[Token(Token = "0x60157A8")]
			[Address(RVA = "0xDF1B00", Offset = "0xDF0700", VA = "0x180DF1B00", Slot = "71")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x060157A9 RID: 87977 RVA: 0x0008C220 File Offset: 0x0008A420
		[Token(Token = "0x170032BB")]
		public float minHeight
		{
			[Token(Token = "0x60157A9")]
			[Address(RVA = "0xDF1EB0", Offset = "0xDF0AB0", VA = "0x180DF1EB0", Slot = "72")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x060157AA RID: 87978 RVA: 0x0008C238 File Offset: 0x0008A438
		[Token(Token = "0x170032BC")]
		public float preferredHeight
		{
			[Token(Token = "0x60157AA")]
			[Address(RVA = "0xDF2090", Offset = "0xDF0C90", VA = "0x180DF2090", Slot = "73")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x060157AB RID: 87979 RVA: 0x0008C250 File Offset: 0x0008A450
		[Token(Token = "0x170032BD")]
		public float flexibleHeight
		{
			[Token(Token = "0x60157AB")]
			[Address(RVA = "0xDF1A80", Offset = "0xDF0680", VA = "0x180DF1A80", Slot = "74")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x060157AC RID: 87980 RVA: 0x0008C268 File Offset: 0x0008A468
		[Token(Token = "0x170032BE")]
		public int layoutPriority
		{
			[Token(Token = "0x60157AC")]
			[Address(RVA = "0xDF1B80", Offset = "0xDF0780", VA = "0x180DF1B80", Slot = "75")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060157AD RID: 87981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157AD")]
		[Address(RVA = "0xDEF0E0", Offset = "0xDEDCE0", VA = "0x180DEF0E0", Slot = "67")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060157AE RID: 87982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157AE")]
		[Address(RVA = "0xDEF150", Offset = "0xDEDD50", VA = "0x180DEF150", Slot = "68")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x060157AF RID: 87983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157AF")]
		[Address(RVA = "0xDEF390", Offset = "0xDEDF90", VA = "0x180DEF390", Slot = "76")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060157B0 RID: 87984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B0")]
		[Address(RVA = "0xDEF320", Offset = "0xDEDF20", VA = "0x180DEF320", Slot = "77")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060157B1 RID: 87985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B1")]
		[Address(RVA = "0xDF1910", Offset = "0xDF0510", VA = "0x180DF1910")]
		public UIAtlasImage()
		{
		}

		// Token: 0x060157B3 RID: 87987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157B3")]
		[Address(RVA = "0xDEFB40", Offset = "0xDEE740", VA = "0x180DEFB40")]
		private Material <>xLuaBaseProxy_get_material()
		{
			return null;
		}

		// Token: 0x060157B4 RID: 87988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B4")]
		[Address(RVA = "0xDEFB50", Offset = "0xDEE750", VA = "0x180DEFB50")]
		private void <>xLuaBaseProxy_set_material(Material P0)
		{
		}

		// Token: 0x060157B5 RID: 87989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B5")]
		[Address(RVA = "0xDEFAD0", Offset = "0xDEE6D0", VA = "0x180DEFAD0")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x060157B6 RID: 87990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B6")]
		[Address(RVA = "0xDEFAE0", Offset = "0xDEE6E0", VA = "0x180DEFAE0")]
		private void <>xLuaBaseProxy_UpdateMaterial()
		{
		}

		// Token: 0x060157B7 RID: 87991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60157B7")]
		[Address(RVA = "0xDEFAF0", Offset = "0xDEE6F0", VA = "0x180DEFAF0")]
		private Texture <>xLuaBaseProxy_get_mainTexture()
		{
			return null;
		}

		// Token: 0x060157B8 RID: 87992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_SetNativeSize()
		{
		}

		// Token: 0x060157B9 RID: 87993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60157B9")]
		[Address(RVA = "0xDEFAC0", Offset = "0xDEE6C0", VA = "0x180DEFAC0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x04019B5D RID: 105309
		[Token(Token = "0x4019B5D")]
		private const float FIXED_PIXELS_PER_UNIT = 100f;

		// Token: 0x04019B5E RID: 105310
		[Token(Token = "0x4019B5E")]
		private const float UV_UNIT = 1f;

		// Token: 0x04019B5F RID: 105311
		[Token(Token = "0x4019B5F")]
		private const int BORDER_PADDING = 1;

		// Token: 0x04019B60 RID: 105312
		[Token(Token = "0x4019B60")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[HideInInspector]
		private UIAtlasObject _initAtlas;

		// Token: 0x04019B61 RID: 105313
		[Token(Token = "0x4019B61")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[HideInInspector]
		private string _initSpriteId;

		// Token: 0x04019B62 RID: 105314
		[Token(Token = "0x4019B62")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[HideInInspector]
		private bool _clipBorder;

		// Token: 0x04019B63 RID: 105315
		[Token(Token = "0x4019B63")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[HideInInspector]
		private UIAtlasImage.MeshType _meshType;

		// Token: 0x04019B64 RID: 105316
		[Token(Token = "0x4019B64")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[HideInInspector]
		private Vector4 _sliceVec;

		// Token: 0x04019B65 RID: 105317
		[Token(Token = "0x4019B65")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[HideInInspector]
		private UIAtlasImage.AtlasSprite m_runtimeSprite;

		// Token: 0x04019B66 RID: 105318
		[Token(Token = "0x4019B66")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2[] s_vertScratch;

		// Token: 0x04019B67 RID: 105319
		[Token(Token = "0x4019B67")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2[] s_uvScratch;

		// Token: 0x04019B68 RID: 105320
		[Token(Token = "0x4019B68")]
		[FieldOffset(Offset = "0x10")]
		private static Material s_defaultMat;

		// Token: 0x04019B69 RID: 105321
		[Token(Token = "0x4019B69")]
		[FieldOffset(Offset = "0x18")]
		private static Material s_defaultETC1Mat;

		// Token: 0x04019B6A RID: 105322
		[Token(Token = "0x4019B6A")]
		[FieldOffset(Offset = "0x118")]
		private SpriteRenderData m_runtimeRD;

		// Token: 0x04019B6B RID: 105323
		[Token(Token = "0x4019B6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetToRuntimeSprite;

		// Token: 0x04019B6C RID: 105324
		[Token(Token = "0x4019B6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitRuntimeSprite;

		// Token: 0x04019B6D RID: 105325
		[Token(Token = "0x4019B6D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_material;

		// Token: 0x04019B6E RID: 105326
		[Token(Token = "0x4019B6E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_material;

		// Token: 0x04019B6F RID: 105327
		[Token(Token = "0x4019B6F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x04019B70 RID: 105328
		[Token(Token = "0x4019B70")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateMaterial;

		// Token: 0x04019B71 RID: 105329
		[Token(Token = "0x4019B71")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x04019B72 RID: 105330
		[Token(Token = "0x4019B72")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetNativeSize;

		// Token: 0x04019B73 RID: 105331
		[Token(Token = "0x4019B73")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_pixelsPerUnit;

		// Token: 0x04019B74 RID: 105332
		[Token(Token = "0x4019B74")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_RuntimeRD;

		// Token: 0x04019B75 RID: 105333
		[Token(Token = "0x4019B75")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04019B76 RID: 105334
		[Token(Token = "0x4019B76")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetSprite;

		// Token: 0x04019B77 RID: 105335
		[Token(Token = "0x4019B77")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ClearSprite;

		// Token: 0x04019B78 RID: 105336
		[Token(Token = "0x4019B78")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__SetToInitSprite;

		// Token: 0x04019B79 RID: 105337
		[Token(Token = "0x4019B79")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GenerateSimpleSprite;

		// Token: 0x04019B7A RID: 105338
		[Token(Token = "0x4019B7A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GenerateSliceSprite;

		// Token: 0x04019B7B RID: 105339
		[Token(Token = "0x4019B7B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetDrawingDimensions;

		// Token: 0x04019B7C RID: 105340
		[Token(Token = "0x4019B7C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AddQuad;

		// Token: 0x04019B7D RID: 105341
		[Token(Token = "0x4019B7D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__AddQuadRotate;

		// Token: 0x04019B7E RID: 105342
		[Token(Token = "0x4019B7E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetAdjustedBorders;

		// Token: 0x04019B7F RID: 105343
		[Token(Token = "0x4019B7F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x04019B80 RID: 105344
		[Token(Token = "0x4019B80")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x04019B81 RID: 105345
		[Token(Token = "0x4019B81")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x04019B82 RID: 105346
		[Token(Token = "0x4019B82")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x04019B83 RID: 105347
		[Token(Token = "0x4019B83")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x04019B84 RID: 105348
		[Token(Token = "0x4019B84")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x04019B85 RID: 105349
		[Token(Token = "0x4019B85")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x04019B86 RID: 105350
		[Token(Token = "0x4019B86")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x04019B87 RID: 105351
		[Token(Token = "0x4019B87")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x04019B88 RID: 105352
		[Token(Token = "0x4019B88")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnBeforeSerialize;

		// Token: 0x04019B89 RID: 105353
		[Token(Token = "0x4019B89")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_OnAfterDeserialize;

		// Token: 0x04019B8A RID: 105354
		[Token(Token = "0x4019B8A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020034A0 RID: 13472
		[Token(Token = "0x20034A0")]
		public enum MeshType
		{
			// Token: 0x04019B8C RID: 105356
			[Token(Token = "0x4019B8C")]
			SIMPLE,
			// Token: 0x04019B8D RID: 105357
			[Token(Token = "0x4019B8D")]
			SLICE
		}

		// Token: 0x020034A1 RID: 13473
		[Token(Token = "0x20034A1")]
		[Serializable]
		private struct Slice
		{
			// Token: 0x060157BA RID: 87994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60157BA")]
			[Address(RVA = "0xE06470", Offset = "0xE05070", VA = "0x180E06470")]
			public Slice(float x1, float y1, float x2, float y2)
			{
			}

			// Token: 0x060157BB RID: 87995 RVA: 0x0008C280 File Offset: 0x0008A480
			[Token(Token = "0x60157BB")]
			[Address(RVA = "0xE05FC0", Offset = "0xE04BC0", VA = "0x180E05FC0")]
			public bool CheckHasBorder()
			{
				return default(bool);
			}

			// Token: 0x060157BC RID: 87996 RVA: 0x0008C298 File Offset: 0x0008A498
			[Token(Token = "0x60157BC")]
			[Address(RVA = "0xE06100", Offset = "0xE04D00", VA = "0x180E06100")]
			public Vector4 ConvertToInner(Vector4 outer)
			{
				return default(Vector4);
			}

			// Token: 0x060157BD RID: 87997 RVA: 0x0008C2B0 File Offset: 0x0008A4B0
			[Token(Token = "0x60157BD")]
			[Address(RVA = "0xE06280", Offset = "0xE04E80", VA = "0x180E06280")]
			public Vector4 GetPaddingWithSize(Vector2 size)
			{
				return default(Vector4);
			}

			// Token: 0x060157BE RID: 87998 RVA: 0x0008C2C8 File Offset: 0x0008A4C8
			[Token(Token = "0x60157BE")]
			[Address(RVA = "0xE063D0", Offset = "0xE04FD0", VA = "0x180E063D0")]
			public UIAtlasImage.Slice Rotate()
			{
				return default(UIAtlasImage.Slice);
			}

			// Token: 0x04019B8E RID: 105358
			[Token(Token = "0x4019B8E")]
			[FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public static readonly Vector4 FULLRECT_VEC;

			// Token: 0x04019B8F RID: 105359
			[Token(Token = "0x4019B8F")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 min;

			// Token: 0x04019B90 RID: 105360
			[Token(Token = "0x4019B90")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 max;
		}

		// Token: 0x020034A2 RID: 13474
		[Token(Token = "0x20034A2")]
		[Serializable]
		private class AtlasSprite
		{
			// Token: 0x060157C0 RID: 88000 RVA: 0x0008C2E0 File Offset: 0x0008A4E0
			[Token(Token = "0x60157C0")]
			[Address(RVA = "0xDF89C0", Offset = "0xDF75C0", VA = "0x180DF89C0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x060157C1 RID: 88001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60157C1")]
			[Address(RVA = "0xDF8A10", Offset = "0xDF7610", VA = "0x180DF8A10")]
			public void Set(SpriteRenderData data)
			{
			}

			// Token: 0x060157C2 RID: 88002 RVA: 0x0008C2F8 File Offset: 0x0008A4F8
			[Token(Token = "0x60157C2")]
			[Address(RVA = "0xDF88A0", Offset = "0xDF74A0", VA = "0x180DF88A0")]
			public SpriteRenderData Get()
			{
				return default(SpriteRenderData);
			}

			// Token: 0x060157C3 RID: 88003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60157C3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AtlasSprite()
			{
			}

			// Token: 0x04019B91 RID: 105361
			[Token(Token = "0x4019B91")]
			[FieldOffset(Offset = "0x10")]
			public Texture2D mainTex;

			// Token: 0x04019B92 RID: 105362
			[Token(Token = "0x4019B92")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D alphaTex;

			// Token: 0x04019B93 RID: 105363
			[Token(Token = "0x4019B93")]
			[FieldOffset(Offset = "0x20")]
			public AtlasCoord rect;

			// Token: 0x04019B94 RID: 105364
			[Token(Token = "0x4019B94")]
			[FieldOffset(Offset = "0x30")]
			public int atlasSize;

			// Token: 0x04019B95 RID: 105365
			[Token(Token = "0x4019B95")]
			[FieldOffset(Offset = "0x34")]
			public bool rotate;

			// Token: 0x04019B96 RID: 105366
			[Token(Token = "0x4019B96")]
			[FieldOffset(Offset = "0x35")]
			public bool overrideUVs;

			// Token: 0x04019B97 RID: 105367
			[Token(Token = "0x4019B97")]
			[FieldOffset(Offset = "0x38")]
			public Vector4 fixedUVs;
		}
	}
}
