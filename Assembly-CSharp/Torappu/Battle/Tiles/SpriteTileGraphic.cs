using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Tiles
{
	// Token: 0x020029FF RID: 10751
	[Token(Token = "0x20029FF")]
	public class SpriteTileGraphic : TileGraphic
	{
		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x06011D5C RID: 73052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700274C")]
		protected SpriteRenderer sprite
		{
			[Token(Token = "0x6011D5C")]
			[Address(RVA = "0x9B7790", Offset = "0x9B6390", VA = "0x1809B7790")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011D5D RID: 73053 RVA: 0x0006D2F0 File Offset: 0x0006B4F0
		[Token(Token = "0x6011D5D")]
		[Address(RVA = "0x9B6F90", Offset = "0x9B5B90", VA = "0x1809B6F90", Slot = "8")]
		protected override bool SetHighlight(TileGraphic.HighlightType value, bool force)
		{
			return default(bool);
		}

		// Token: 0x06011D5E RID: 73054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D5E")]
		[Address(RVA = "0x9B7250", Offset = "0x9B5E50", VA = "0x1809B7250", Slot = "9")]
		public override void SetLitState(bool state)
		{
		}

		// Token: 0x06011D5F RID: 73055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D5F")]
		[Address(RVA = "0x9B7140", Offset = "0x9B5D40", VA = "0x1809B7140", Slot = "10")]
		public override void SetLitState(int litLevel)
		{
		}

		// Token: 0x06011D60 RID: 73056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D60")]
		[Address(RVA = "0x9B7300", Offset = "0x9B5F00", VA = "0x1809B7300", Slot = "11")]
		public override void SetLitStrength(float strength)
		{
		}

		// Token: 0x06011D61 RID: 73057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D61")]
		[Address(RVA = "0x9B74F0", Offset = "0x9B60F0", VA = "0x1809B74F0")]
		private void _InitCustomColorIfNot()
		{
		}

		// Token: 0x06011D62 RID: 73058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D62")]
		[Address(RVA = "0x9B6F10", Offset = "0x9B5B10", VA = "0x1809B6F10")]
		private void Awake()
		{
		}

		// Token: 0x06011D63 RID: 73059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D63")]
		[Address(RVA = "0x9B76A0", Offset = "0x9B62A0", VA = "0x1809B76A0")]
		public SpriteTileGraphic()
		{
		}

		// Token: 0x06011D64 RID: 73060 RVA: 0x0006D308 File Offset: 0x0006B508
		[Token(Token = "0x6011D64")]
		[Address(RVA = "0x9B1A00", Offset = "0x9B0600", VA = "0x1809B1A00")]
		private bool <>xLuaBaseProxy_SetHighlight(TileGraphic.HighlightType P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x06011D65 RID: 73061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D65")]
		[Address(RVA = "0x9B74C0", Offset = "0x9B60C0", VA = "0x1809B74C0")]
		private void <>xLuaBaseProxy_SetLitState(bool P0)
		{
		}

		// Token: 0x06011D66 RID: 73062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D66")]
		[Address(RVA = "0x9B74D0", Offset = "0x9B60D0", VA = "0x1809B74D0")]
		private void <>xLuaBaseProxy_SetLitState(int P0)
		{
		}

		// Token: 0x06011D67 RID: 73063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D67")]
		[Address(RVA = "0x9B74E0", Offset = "0x9B60E0", VA = "0x1809B74E0")]
		private void <>xLuaBaseProxy_SetLitStrength(float P0)
		{
		}

		// Token: 0x04014099 RID: 82073
		[Token(Token = "0x4014099")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SpriteRenderer _sprite;

		// Token: 0x0401409A RID: 82074
		[Token(Token = "0x401409A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _buildableColor;

		// Token: 0x0401409B RID: 82075
		[Token(Token = "0x401409B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _focusColor;

		// Token: 0x0401409C RID: 82076
		[Token(Token = "0x401409C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _brightColor;

		// Token: 0x0401409D RID: 82077
		[Token(Token = "0x401409D")]
		[FieldOffset(Offset = "0x78")]
		private Color m_originColor;

		// Token: 0x0401409E RID: 82078
		[Token(Token = "0x401409E")]
		[FieldOffset(Offset = "0x88")]
		private Color m_customColor;

		// Token: 0x0401409F RID: 82079
		[Token(Token = "0x401409F")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isCustomColorInitialized;

		// Token: 0x040140A0 RID: 82080
		[Token(Token = "0x40140A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sprite;

		// Token: 0x040140A1 RID: 82081
		[Token(Token = "0x40140A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetHighlight;

		// Token: 0x040140A2 RID: 82082
		[Token(Token = "0x40140A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetLitState;

		// Token: 0x040140A3 RID: 82083
		[Token(Token = "0x40140A3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_SetLitState;

		// Token: 0x040140A4 RID: 82084
		[Token(Token = "0x40140A4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetLitStrength;

		// Token: 0x040140A5 RID: 82085
		[Token(Token = "0x40140A5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitCustomColorIfNot;

		// Token: 0x040140A6 RID: 82086
		[Token(Token = "0x40140A6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040140A7 RID: 82087
		[Token(Token = "0x40140A7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
