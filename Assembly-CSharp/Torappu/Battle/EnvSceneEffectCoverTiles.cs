using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002296 RID: 8854
	[Token(Token = "0x2002296")]
	public class EnvSceneEffectCoverTiles : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEC8 RID: 57032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEC8")]
		[Address(RVA = "0x3654F40", Offset = "0x3653B40", VA = "0x183654F40", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEC9")]
		[Address(RVA = "0x3655090", Offset = "0x3653C90", VA = "0x183655090", Slot = "15")]
		public override void OnEnvChanged(Tile tile, string status)
		{
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DECA")]
		[Address(RVA = "0x3655010", Offset = "0x3653C10", VA = "0x183655010")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DECB")]
		[Address(RVA = "0x36551F0", Offset = "0x3653DF0", VA = "0x1836551F0")]
		public EnvSceneEffectCoverTiles()
		{
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DECC")]
		[Address(RVA = "0x3633EF0", Offset = "0x3632AF0", VA = "0x183633EF0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DECD")]
		[Address(RVA = "0x36503E0", Offset = "0x364EFE0", VA = "0x1836503E0")]
		private void <>xLuaBaseProxy_OnEnvChanged(Tile P0, string P1)
		{
		}

		// Token: 0x0400F1D2 RID: 61906
		[Token(Token = "0x400F1D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _tileStatusMarkedAsInside;

		// Token: 0x0400F1D3 RID: 61907
		[Token(Token = "0x400F1D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _tileStatusMarkedAsOutside;

		// Token: 0x0400F1D4 RID: 61908
		[Token(Token = "0x400F1D4")]
		[FieldOffset(Offset = "0x40")]
		private SceneTileEffectHandler m_handler;

		// Token: 0x0400F1D5 RID: 61909
		[Token(Token = "0x400F1D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F1D6 RID: 61910
		[Token(Token = "0x400F1D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F1D7 RID: 61911
		[Token(Token = "0x400F1D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F1D8 RID: 61912
		[Token(Token = "0x400F1D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
