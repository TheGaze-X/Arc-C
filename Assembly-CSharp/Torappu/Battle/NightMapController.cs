using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002262 RID: 8802
	[Token(Token = "0x2002262")]
	public class NightMapController : MapController
	{
		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x00050C88 File Offset: 0x0004EE88
		[Token(Token = "0x17001BE1")]
		public override MapTags tag
		{
			[Token(Token = "0x600DD4D")]
			[Address(RVA = "0x363CB90", Offset = "0x363B790", VA = "0x18363CB90", Slot = "4")]
			get
			{
				return MapTags.DEFAULT;
			}
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD4E")]
		[Address(RVA = "0x363C290", Offset = "0x363AE90", VA = "0x18363C290", Slot = "5")]
		public override void Init(Map battleMap)
		{
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD4F")]
		[Address(RVA = "0x363C5A0", Offset = "0x363B1A0", VA = "0x18363C5A0")]
		public void RewriteTileOptions(Tile tile, AdvancedBuildableMask mask)
		{
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD50")]
		[Address(RVA = "0x363C8A0", Offset = "0x363B4A0", VA = "0x18363C8A0")]
		private void _UpdateBrightTiles(Tile tile)
		{
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD51")]
		[Address(RVA = "0x363C4B0", Offset = "0x363B0B0", VA = "0x18363C4B0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x0600DD52 RID: 56658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD52")]
		[Address(RVA = "0x363CA80", Offset = "0x363B680", VA = "0x18363CA80")]
		public NightMapController()
		{
		}

		// Token: 0x0600DD54 RID: 56660 RVA: 0x00050CA0 File Offset: 0x0004EEA0
		[Token(Token = "0x600DD54")]
		[Address(RVA = "0x363C230", Offset = "0x363AE30", VA = "0x18363C230")]
		private MapTags <>xLuaBaseProxy_get_tag()
		{
			return MapTags.DEFAULT;
		}

		// Token: 0x0600DD55 RID: 56661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD55")]
		[Address(RVA = "0x3627C90", Offset = "0x3626890", VA = "0x183627C90")]
		private void <>xLuaBaseProxy_Init(Map P0)
		{
		}

		// Token: 0x0600DD56 RID: 56662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD56")]
		[Address(RVA = "0x363C110", Offset = "0x363AD10", VA = "0x18363C110")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x0400EFBF RID: 61375
		[Token(Token = "0x400EFBF")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<Tile, int> m_buildableMarkTilesDict;

		// Token: 0x0400EFC0 RID: 61376
		[Token(Token = "0x400EFC0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string BRIGHT_TILE_KEYWORD;

		// Token: 0x0400EFC1 RID: 61377
		[Token(Token = "0x400EFC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tag;

		// Token: 0x0400EFC2 RID: 61378
		[Token(Token = "0x400EFC2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EFC3 RID: 61379
		[Token(Token = "0x400EFC3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RewriteTileOptions;

		// Token: 0x0400EFC4 RID: 61380
		[Token(Token = "0x400EFC4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateBrightTiles;

		// Token: 0x0400EFC5 RID: 61381
		[Token(Token = "0x400EFC5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400EFC6 RID: 61382
		[Token(Token = "0x400EFC6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
