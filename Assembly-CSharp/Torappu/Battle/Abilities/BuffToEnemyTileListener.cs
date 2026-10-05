using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C3C RID: 11324
	[Token(Token = "0x2002C3C")]
	public class BuffToEnemyTileListener : AttachListenerToTileAbility.AttachableTileListener
	{
		// Token: 0x060131F0 RID: 78320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F0")]
		[Address(RVA = "0xB166D0", Offset = "0xB152D0", VA = "0x180B166D0", Slot = "7")]
		public override void DoSetData(Ability.Options options)
		{
		}

		// Token: 0x060131F1 RID: 78321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F1")]
		[Address(RVA = "0xB16AD0", Offset = "0xB156D0", VA = "0x180B16AD0", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x060131F2 RID: 78322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F2")]
		[Address(RVA = "0xB16870", Offset = "0xB15470", VA = "0x180B16870", Slot = "9")]
		public override void OnCasted(Tile tile, int times)
		{
		}

		// Token: 0x060131F3 RID: 78323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F3")]
		[Address(RVA = "0xB16DF0", Offset = "0xB159F0", VA = "0x180B16DF0", Slot = "10")]
		public override void OnRefresh(Tile tile)
		{
		}

		// Token: 0x060131F4 RID: 78324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F4")]
		[Address(RVA = "0xB16C30", Offset = "0xB15830", VA = "0x180B16C30", Slot = "12")]
		public override void OnEntityEnter(Entity entity)
		{
		}

		// Token: 0x060131F5 RID: 78325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F5")]
		[Address(RVA = "0xB16D10", Offset = "0xB15910", VA = "0x180B16D10", Slot = "13")]
		public override void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x060131F6 RID: 78326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F6")]
		[Address(RVA = "0xB17070", Offset = "0xB15C70", VA = "0x180B17070")]
		private void _BuffToEnemy(BuffData[] buffs, Enemy enemy)
		{
		}

		// Token: 0x060131F7 RID: 78327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F7")]
		[Address(RVA = "0xB17700", Offset = "0xB16300", VA = "0x180B17700")]
		private void _RemoveAttachedBuffs()
		{
		}

		// Token: 0x060131F8 RID: 78328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F8")]
		[Address(RVA = "0xB173E0", Offset = "0xB15FE0", VA = "0x180B173E0")]
		private void _OnTileListenerRemoved(object arg)
		{
		}

		// Token: 0x060131F9 RID: 78329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131F9")]
		[Address(RVA = "0xB17890", Offset = "0xB16490", VA = "0x180B17890")]
		public BuffToEnemyTileListener()
		{
		}

		// Token: 0x060131FA RID: 78330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131FA")]
		[Address(RVA = "0xB15AF0", Offset = "0xB146F0", VA = "0x180B15AF0")]
		private void <>xLuaBaseProxy_DoSetData(Ability.Options P0)
		{
		}

		// Token: 0x060131FB RID: 78331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131FB")]
		[Address(RVA = "0xB15B30", Offset = "0xB14730", VA = "0x180B15B30")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060131FC RID: 78332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131FC")]
		[Address(RVA = "0xB15B20", Offset = "0xB14720", VA = "0x180B15B20")]
		private void <>xLuaBaseProxy_OnCasted(Tile P0, int P1)
		{
		}

		// Token: 0x060131FD RID: 78333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131FD")]
		[Address(RVA = "0xB15B50", Offset = "0xB14750", VA = "0x180B15B50")]
		private void <>xLuaBaseProxy_OnRefresh(Tile P0)
		{
		}

		// Token: 0x060131FE RID: 78334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131FE")]
		[Address(RVA = "0xB17050", Offset = "0xB15C50", VA = "0x180B17050")]
		private void <>xLuaBaseProxy_OnEntityEnter(Entity P0)
		{
		}

		// Token: 0x060131FF RID: 78335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131FF")]
		[Address(RVA = "0xB17060", Offset = "0xB15C60", VA = "0x180B17060")]
		private void <>xLuaBaseProxy_OnEntityLeave(Entity P0)
		{
		}

		// Token: 0x0401598A RID: 88458
		[Token(Token = "0x401598A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetValidator _targetValidator;

		// Token: 0x0401598B RID: 88459
		[Token(Token = "0x401598B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData[] _buffsWhenCasted;

		// Token: 0x0401598C RID: 88460
		[Token(Token = "0x401598C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuffData[] _buffsWhenEnemyEnter;

		// Token: 0x0401598D RID: 88461
		[Token(Token = "0x401598D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuffData[] _buffsWhenEnemyLeave;

		// Token: 0x0401598E RID: 88462
		[Token(Token = "0x401598E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _clearBuffWhenAbilityDetached;

		// Token: 0x0401598F RID: 88463
		[Token(Token = "0x401598F")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool _clearBuffWhenTileListenerRemoved;

		// Token: 0x04015990 RID: 88464
		[Token(Token = "0x4015990")]
		private const string CASTED_TIMES = "casted_times";

		// Token: 0x04015991 RID: 88465
		[Token(Token = "0x4015991")]
		[FieldOffset(Offset = "0x48")]
		private Blackboard m_blackboard;

		// Token: 0x04015992 RID: 88466
		[Token(Token = "0x4015992")]
		[FieldOffset(Offset = "0x50")]
		private List<ObjectPtr<Buff>> m_buffs;

		// Token: 0x04015993 RID: 88467
		[Token(Token = "0x4015993")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015994 RID: 88468
		[Token(Token = "0x4015994")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015995 RID: 88469
		[Token(Token = "0x4015995")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCasted;

		// Token: 0x04015996 RID: 88470
		[Token(Token = "0x4015996")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x04015997 RID: 88471
		[Token(Token = "0x4015997")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEntityEnter;

		// Token: 0x04015998 RID: 88472
		[Token(Token = "0x4015998")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEntityLeave;

		// Token: 0x04015999 RID: 88473
		[Token(Token = "0x4015999")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BuffToEnemy;

		// Token: 0x0401599A RID: 88474
		[Token(Token = "0x401599A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RemoveAttachedBuffs;

		// Token: 0x0401599B RID: 88475
		[Token(Token = "0x401599B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnTileListenerRemoved;

		// Token: 0x0401599C RID: 88476
		[Token(Token = "0x401599C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
