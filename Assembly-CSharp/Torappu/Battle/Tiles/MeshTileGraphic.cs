using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Tiles
{
	// Token: 0x020029FB RID: 10747
	[Token(Token = "0x20029FB")]
	[RequireComponent(typeof(Renderer))]
	public class MeshTileGraphic : TileGraphic
	{
		// Token: 0x06011D38 RID: 73016 RVA: 0x0006D230 File Offset: 0x0006B430
		[Token(Token = "0x6011D38")]
		[Address(RVA = "0x9B1060", Offset = "0x9AFC60", VA = "0x1809B1060", Slot = "8")]
		protected override bool SetHighlight(TileGraphic.HighlightType value, bool force)
		{
			return default(bool);
		}

		// Token: 0x06011D39 RID: 73017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D39")]
		[Address(RVA = "0x9B0FC0", Offset = "0x9AFBC0", VA = "0x1809B0FC0", Slot = "7")]
		public override void ResetTile()
		{
		}

		// Token: 0x06011D3A RID: 73018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D3A")]
		[Address(RVA = "0x9B0EA0", Offset = "0x9AFAA0", VA = "0x1809B0EA0", Slot = "6")]
		public override void RefreshThemeConfig()
		{
		}

		// Token: 0x06011D3B RID: 73019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D3B")]
		[Address(RVA = "0x9B0AA0", Offset = "0x9AF6A0", VA = "0x1809B0AA0")]
		private void Awake()
		{
		}

		// Token: 0x06011D3C RID: 73020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D3C")]
		[Address(RVA = "0x9B1A10", Offset = "0x9B0610", VA = "0x1809B1A10")]
		private void _InitCustomColorIfNot()
		{
		}

		// Token: 0x06011D3D RID: 73021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D3D")]
		[Address(RVA = "0x9B1CD0", Offset = "0x9B08D0", VA = "0x1809B1CD0")]
		public MeshTileGraphic()
		{
		}

		// Token: 0x06011D43 RID: 73027 RVA: 0x0006D248 File Offset: 0x0006B448
		[Token(Token = "0x6011D43")]
		[Address(RVA = "0x9B1A00", Offset = "0x9B0600", VA = "0x1809B1A00")]
		private bool <>xLuaBaseProxy_SetHighlight(TileGraphic.HighlightType P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06011D44 RID: 73028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D44")]
		[Address(RVA = "0x9B19F0", Offset = "0x9B05F0", VA = "0x1809B19F0")]
		private void <>xLuaBaseProxy_ResetTile()
		{
		}

		// Token: 0x06011D45 RID: 73029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D45")]
		[Address(RVA = "0x9B19E0", Offset = "0x9B05E0", VA = "0x1809B19E0")]
		private void <>xLuaBaseProxy_RefreshThemeConfig()
		{
		}

		// Token: 0x04014066 RID: 82022
		[Token(Token = "0x4014066")]
		private const string BUILDABLE_MATERIAL_KEY = "buildable";

		// Token: 0x04014067 RID: 82023
		[Token(Token = "0x4014067")]
		private const string FOCUSED_MATERIAL_KEY = "focused";

		// Token: 0x04014068 RID: 82024
		[Token(Token = "0x4014068")]
		private const string REPLACEABLE_MATERIAL_KEY = "replaceable";

		// Token: 0x04014069 RID: 82025
		[Token(Token = "0x4014069")]
		private const string CUSTOM_MATERIAL_KEY = "custom";

		// Token: 0x0401406A RID: 82026
		[Token(Token = "0x401406A")]
		private const float TWEEN_LOOP_TIME = 1.5f;

		// Token: 0x0401406B RID: 82027
		[Token(Token = "0x401406B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color FOCUSED_COLOR;

		// Token: 0x0401406C RID: 82028
		[Token(Token = "0x401406C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color EMISSION_CLEAR_COLOR;

		// Token: 0x0401406D RID: 82029
		[Token(Token = "0x401406D")]
		[FieldOffset(Offset = "0x40")]
		private Renderer m_renderer;

		// Token: 0x0401406E RID: 82030
		[Token(Token = "0x401406E")]
		[FieldOffset(Offset = "0x48")]
		private Material m_replaceableMaterial;

		// Token: 0x0401406F RID: 82031
		[Token(Token = "0x401406F")]
		[FieldOffset(Offset = "0x50")]
		private Material m_buildableMaterial;

		// Token: 0x04014070 RID: 82032
		[Token(Token = "0x4014070")]
		[FieldOffset(Offset = "0x58")]
		private Material m_focusedMaterial;

		// Token: 0x04014071 RID: 82033
		[Token(Token = "0x4014071")]
		[FieldOffset(Offset = "0x60")]
		private Material m_originMaterial;

		// Token: 0x04014072 RID: 82034
		[Token(Token = "0x4014072")]
		[FieldOffset(Offset = "0x68")]
		private Material m_customMaterial;

		// Token: 0x04014073 RID: 82035
		[Token(Token = "0x4014073")]
		[FieldOffset(Offset = "0x70")]
		private Color m_customColor;

		// Token: 0x04014074 RID: 82036
		[Token(Token = "0x4014074")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isCustomColorInitialized;

		// Token: 0x04014075 RID: 82037
		[Token(Token = "0x4014075")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tween;

		// Token: 0x04014076 RID: 82038
		[Token(Token = "0x4014076")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetHighlight;

		// Token: 0x04014077 RID: 82039
		[Token(Token = "0x4014077")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ResetTile;

		// Token: 0x04014078 RID: 82040
		[Token(Token = "0x4014078")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshThemeConfig;

		// Token: 0x04014079 RID: 82041
		[Token(Token = "0x4014079")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401407A RID: 82042
		[Token(Token = "0x401407A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitCustomColorIfNot;

		// Token: 0x0401407B RID: 82043
		[Token(Token = "0x401407B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
