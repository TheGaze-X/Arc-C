using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022A5 RID: 8869
	[Token(Token = "0x20022A5")]
	public class EnvTileInfoMaker : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEED RID: 57069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEED")]
		[Address(RVA = "0x3656D50", Offset = "0x3655950", VA = "0x183656D50", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DEEE RID: 57070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEEE")]
		[Address(RVA = "0x3656F30", Offset = "0x3655B30", VA = "0x183656F30")]
		public EnvTileInfoMaker()
		{
		}

		// Token: 0x0600DEEF RID: 57071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEEF")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0400F20F RID: 61967
		[Token(Token = "0x400F20F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnvTileInfoMaker.TileInfoMaskSetting[] _maskSettings;

		// Token: 0x0400F210 RID: 61968
		[Token(Token = "0x400F210")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F211 RID: 61969
		[Token(Token = "0x400F211")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022A6 RID: 8870
		[Token(Token = "0x20022A6")]
		[Serializable]
		private struct TileInfoMaskSetting
		{
			// Token: 0x0400F212 RID: 61970
			[Token(Token = "0x400F212")]
			[FieldOffset(Offset = "0x0")]
			public string statusKey;

			// Token: 0x0400F213 RID: 61971
			[Token(Token = "0x400F213")]
			[FieldOffset(Offset = "0x8")]
			public TileInfoMask[] tileInfoMask;

			// Token: 0x0400F214 RID: 61972
			[Token(Token = "0x400F214")]
			[FieldOffset(Offset = "0x10")]
			public bool isEnable;
		}
	}
}
