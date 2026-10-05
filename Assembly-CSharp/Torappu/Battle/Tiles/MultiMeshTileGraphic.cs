using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Tiles
{
	// Token: 0x020029FD RID: 10749
	[Token(Token = "0x20029FD")]
	public class MultiMeshTileGraphic : TileGraphic
	{
		// Token: 0x06011D4A RID: 73034 RVA: 0x0006D290 File Offset: 0x0006B490
		[Token(Token = "0x6011D4A")]
		[Address(RVA = "0x9B2400", Offset = "0x9B1000", VA = "0x1809B2400", Slot = "8")]
		protected override bool SetHighlight(TileGraphic.HighlightType value, bool force)
		{
			return default(bool);
		}

		// Token: 0x06011D4B RID: 73035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D4B")]
		[Address(RVA = "0x9B2360", Offset = "0x9B0F60", VA = "0x1809B2360", Slot = "7")]
		public override void ResetTile()
		{
		}

		// Token: 0x06011D4C RID: 73036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D4C")]
		[Address(RVA = "0x9B2240", Offset = "0x9B0E40", VA = "0x1809B2240", Slot = "6")]
		public override void RefreshThemeConfig()
		{
		}

		// Token: 0x06011D4D RID: 73037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D4D")]
		[Address(RVA = "0x9B1D70", Offset = "0x9B0970", VA = "0x1809B1D70")]
		private void Awake()
		{
		}

		// Token: 0x06011D4E RID: 73038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D4E")]
		[Address(RVA = "0x9B3030", Offset = "0x9B1C30", VA = "0x1809B3030")]
		private void _InitCustomColorIfNot()
		{
		}

		// Token: 0x06011D4F RID: 73039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D4F")]
		[Address(RVA = "0x9B3300", Offset = "0x9B1F00", VA = "0x1809B3300")]
		public MultiMeshTileGraphic()
		{
		}

		// Token: 0x06011D55 RID: 73045 RVA: 0x0006D2A8 File Offset: 0x0006B4A8
		[Token(Token = "0x6011D55")]
		[Address(RVA = "0x9B1A00", Offset = "0x9B0600", VA = "0x1809B1A00")]
		private bool <>xLuaBaseProxy_SetHighlight(TileGraphic.HighlightType P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06011D56 RID: 73046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D56")]
		[Address(RVA = "0x9B19F0", Offset = "0x9B05F0", VA = "0x1809B19F0")]
		private void <>xLuaBaseProxy_ResetTile()
		{
		}

		// Token: 0x06011D57 RID: 73047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D57")]
		[Address(RVA = "0x9B19E0", Offset = "0x9B05E0", VA = "0x1809B19E0")]
		private void <>xLuaBaseProxy_RefreshThemeConfig()
		{
		}

		// Token: 0x0401407F RID: 82047
		[Token(Token = "0x401407F")]
		private const string BUILDABLE_MATERIAL_KEY = "buildable";

		// Token: 0x04014080 RID: 82048
		[Token(Token = "0x4014080")]
		private const string FOCUSED_MATERIAL_KEY = "focused";

		// Token: 0x04014081 RID: 82049
		[Token(Token = "0x4014081")]
		private const string REPLACEABLE_MATERIAL_KEY = "replaceable";

		// Token: 0x04014082 RID: 82050
		[Token(Token = "0x4014082")]
		private const string CUSTOM_MATERIAL_KEY = "custom";

		// Token: 0x04014083 RID: 82051
		[Token(Token = "0x4014083")]
		private const float TWEEN_LOOP_TIME = 1.5f;

		// Token: 0x04014084 RID: 82052
		[Token(Token = "0x4014084")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color FOCUSED_COLOR;

		// Token: 0x04014085 RID: 82053
		[Token(Token = "0x4014085")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color EMISSION_COLOR;

		// Token: 0x04014086 RID: 82054
		[Token(Token = "0x4014086")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color EMISSION_CLEAR_COLOR;

		// Token: 0x04014087 RID: 82055
		[Token(Token = "0x4014087")]
		[FieldOffset(Offset = "0x40")]
		private List<Renderer> m_renderers;

		// Token: 0x04014088 RID: 82056
		[Token(Token = "0x4014088")]
		[FieldOffset(Offset = "0x48")]
		private Material m_replaceableMaterial;

		// Token: 0x04014089 RID: 82057
		[Token(Token = "0x4014089")]
		[FieldOffset(Offset = "0x50")]
		private Material m_buildableMaterial;

		// Token: 0x0401408A RID: 82058
		[Token(Token = "0x401408A")]
		[FieldOffset(Offset = "0x58")]
		private Material m_focusedMaterial;

		// Token: 0x0401408B RID: 82059
		[Token(Token = "0x401408B")]
		[FieldOffset(Offset = "0x60")]
		private Material m_originMaterial;

		// Token: 0x0401408C RID: 82060
		[Token(Token = "0x401408C")]
		[FieldOffset(Offset = "0x68")]
		private Material m_customMaterial;

		// Token: 0x0401408D RID: 82061
		[Token(Token = "0x401408D")]
		[FieldOffset(Offset = "0x70")]
		private Color m_customColor;

		// Token: 0x0401408E RID: 82062
		[Token(Token = "0x401408E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isCustomColorInitialized;

		// Token: 0x0401408F RID: 82063
		[Token(Token = "0x401408F")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tween;

		// Token: 0x04014090 RID: 82064
		[Token(Token = "0x4014090")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetHighlight;

		// Token: 0x04014091 RID: 82065
		[Token(Token = "0x4014091")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetTile;

		// Token: 0x04014092 RID: 82066
		[Token(Token = "0x4014092")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RefreshThemeConfig;

		// Token: 0x04014093 RID: 82067
		[Token(Token = "0x4014093")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04014094 RID: 82068
		[Token(Token = "0x4014094")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitCustomColorIfNot;

		// Token: 0x04014095 RID: 82069
		[Token(Token = "0x4014095")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
