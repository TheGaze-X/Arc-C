using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022B2 RID: 8882
	[Token(Token = "0x20022B2")]
	public class Act25SideExtraManager : GlobalEnvSystem.EnvManager, IEffectSource
	{
		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x0600DF42 RID: 57154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C03")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600DF42")]
			[Address(RVA = "0x36438F0", Offset = "0x36424F0", VA = "0x1836438F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DF43 RID: 57155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF43")]
		[Address(RVA = "0x3642AB0", Offset = "0x36416B0", VA = "0x183642AB0", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600DF44 RID: 57156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF44")]
		[Address(RVA = "0x36431C0", Offset = "0x3641DC0", VA = "0x1836431C0")]
		private void _OnTileClicked(object arg)
		{
		}

		// Token: 0x0600DF45 RID: 57157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF45")]
		[Address(RVA = "0x3643700", Offset = "0x3642300", VA = "0x183643700")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600DF46 RID: 57158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF46")]
		[Address(RVA = "0x3642BD0", Offset = "0x36417D0", VA = "0x183642BD0", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600DF47 RID: 57159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF47")]
		[Address(RVA = "0x3642DE0", Offset = "0x36419E0", VA = "0x183642DE0")]
		private void _CreateEffectIfNot(Tile tile)
		{
		}

		// Token: 0x0600DF48 RID: 57160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF48")]
		[Address(RVA = "0x36430E0", Offset = "0x3641CE0", VA = "0x1836430E0")]
		private void _FinishEffectIfNot()
		{
		}

		// Token: 0x0600DF49 RID: 57161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF49")]
		[Address(RVA = "0x3642940", Offset = "0x3641540", VA = "0x183642940", Slot = "5")]
		public new void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600DF4A RID: 57162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF4A")]
		[Address(RVA = "0x3643890", Offset = "0x3642490", VA = "0x183643890")]
		public Act25SideExtraManager()
		{
		}

		// Token: 0x0600DF4B RID: 57163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF4B")]
		[Address(RVA = "0x3642D70", Offset = "0x3641970", VA = "0x183642D70")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600DF4C RID: 57164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF4C")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DF4D RID: 57165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF4D")]
		[Address(RVA = "0x3642D10", Offset = "0x3641910", VA = "0x183642D10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F27A RID: 62074
		[Token(Token = "0x400F27A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _ristarMove;

		// Token: 0x0400F27B RID: 62075
		[Token(Token = "0x400F27B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _movingCursorIndex;

		// Token: 0x0400F27C RID: 62076
		[Token(Token = "0x400F27C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] _cantMoveMark;

		// Token: 0x0400F27D RID: 62077
		[Token(Token = "0x400F27D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _tileKeyList;

		// Token: 0x0400F27E RID: 62078
		[Token(Token = "0x400F27E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<MapEffectData> _effects;

		// Token: 0x0400F27F RID: 62079
		[Token(Token = "0x400F27F")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<MapEffect> m_effect;

		// Token: 0x0400F280 RID: 62080
		[Token(Token = "0x400F280")]
		[FieldOffset(Offset = "0x60")]
		private EnemyRistar m_ristar;

		// Token: 0x0400F281 RID: 62081
		[Token(Token = "0x400F281")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F282 RID: 62082
		[Token(Token = "0x400F282")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F283 RID: 62083
		[Token(Token = "0x400F283")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTileClicked;

		// Token: 0x0400F284 RID: 62084
		[Token(Token = "0x400F284")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F285 RID: 62085
		[Token(Token = "0x400F285")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F286 RID: 62086
		[Token(Token = "0x400F286")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateEffectIfNot;

		// Token: 0x0400F287 RID: 62087
		[Token(Token = "0x400F287")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FinishEffectIfNot;

		// Token: 0x0400F288 RID: 62088
		[Token(Token = "0x400F288")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F289 RID: 62089
		[Token(Token = "0x400F289")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
