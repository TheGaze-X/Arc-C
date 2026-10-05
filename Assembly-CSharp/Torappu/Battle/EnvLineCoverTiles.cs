using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200228F RID: 8847
	[Token(Token = "0x200228F")]
	public class EnvLineCoverTiles : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEA2 RID: 56994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA2")]
		[Address(RVA = "0x3653030", Offset = "0x3651C30", VA = "0x183653030", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DEA3 RID: 56995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA3")]
		[Address(RVA = "0x3653330", Offset = "0x3651F30", VA = "0x183653330", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA4")]
		[Address(RVA = "0x3653490", Offset = "0x3652090", VA = "0x183653490", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA5")]
		[Address(RVA = "0x36532C0", Offset = "0x3651EC0", VA = "0x1836532C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x00051090 File Offset: 0x0004F290
		[Token(Token = "0x600DEA6")]
		[Address(RVA = "0x3653550", Offset = "0x3652150", VA = "0x183653550")]
		private float _GetLineHeightByLineFirstTileHeight(List<GridPosition> lines)
		{
			return 0f;
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA7")]
		[Address(RVA = "0x36536B0", Offset = "0x36522B0", VA = "0x1836536B0")]
		public EnvLineCoverTiles()
		{
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA8")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEA9")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEAA")]
		[Address(RVA = "0x36480E0", Offset = "0x3646CE0", VA = "0x1836480E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F196 RID: 61846
		[Token(Token = "0x400F196")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _tileStatusMarkedAsInside;

		// Token: 0x0400F197 RID: 61847
		[Token(Token = "0x400F197")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _tileStatusMarkedAsOutside;

		// Token: 0x0400F198 RID: 61848
		[Token(Token = "0x400F198")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _edgeLineRendererEffectKey;

		// Token: 0x0400F199 RID: 61849
		[Token(Token = "0x400F199")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _disableBlackboardKey;

		// Token: 0x0400F19A RID: 61850
		[Token(Token = "0x400F19A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x0400F19B RID: 61851
		[Token(Token = "0x400F19B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _lineOffsetToMapCenter;

		// Token: 0x0400F19C RID: 61852
		[Token(Token = "0x400F19C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EnvLineCoverTiles.HeightConfig _heightConfig;

		// Token: 0x0400F19D RID: 61853
		[Token(Token = "0x400F19D")]
		[FieldOffset(Offset = "0x68")]
		private RangeLineEffectHandler m_handler;

		// Token: 0x0400F19E RID: 61854
		[Token(Token = "0x400F19E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F19F RID: 61855
		[Token(Token = "0x400F19F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F1A0 RID: 61856
		[Token(Token = "0x400F1A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F1A1 RID: 61857
		[Token(Token = "0x400F1A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F1A2 RID: 61858
		[Token(Token = "0x400F1A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetLineHeightByLineFirstTileHeight;

		// Token: 0x0400F1A3 RID: 61859
		[Token(Token = "0x400F1A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002290 RID: 8848
		[Token(Token = "0x2002290")]
		[Serializable]
		public class HeightConfig
		{
			// Token: 0x0600DEAB RID: 57003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DEAB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HeightConfig()
			{
			}

			// Token: 0x0400F1A4 RID: 61860
			[Token(Token = "0x400F1A4")]
			[FieldOffset(Offset = "0x10")]
			public bool followTileDynamicHeight;
		}
	}
}
