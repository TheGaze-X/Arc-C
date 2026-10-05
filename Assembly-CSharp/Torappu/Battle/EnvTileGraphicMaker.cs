using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022A3 RID: 8867
	[Token(Token = "0x20022A3")]
	public class EnvTileGraphicMaker : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEEA RID: 57066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEEA")]
		[Address(RVA = "0x3656B50", Offset = "0x3655750", VA = "0x183656B50", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DEEB RID: 57067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEEB")]
		[Address(RVA = "0x3656CF0", Offset = "0x36558F0", VA = "0x183656CF0")]
		public EnvTileGraphicMaker()
		{
		}

		// Token: 0x0600DEEC RID: 57068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEEC")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0400F208 RID: 61960
		[Token(Token = "0x400F208")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnvTileGraphicMaker.GraphicSetting[] _graphicSettings;

		// Token: 0x0400F209 RID: 61961
		[Token(Token = "0x400F209")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F20A RID: 61962
		[Token(Token = "0x400F20A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022A4 RID: 8868
		[Token(Token = "0x20022A4")]
		[Serializable]
		private struct GraphicSetting
		{
			// Token: 0x0400F20B RID: 61963
			[Token(Token = "0x400F20B")]
			[FieldOffset(Offset = "0x0")]
			public string statusKey;

			// Token: 0x0400F20C RID: 61964
			[Token(Token = "0x400F20C")]
			[FieldOffset(Offset = "0x8")]
			public bool useLitStateBool;

			// Token: 0x0400F20D RID: 61965
			[Token(Token = "0x400F20D")]
			[FieldOffset(Offset = "0x9")]
			public bool litState;

			// Token: 0x0400F20E RID: 61966
			[Token(Token = "0x400F20E")]
			[FieldOffset(Offset = "0xC")]
			public int graphicLevel;
		}
	}
}
