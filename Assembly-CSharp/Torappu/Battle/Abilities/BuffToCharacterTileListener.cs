using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C3B RID: 11323
	[Token(Token = "0x2002C3B")]
	public class BuffToCharacterTileListener : AttachListenerToTileAbility.AttachableTileListener
	{
		// Token: 0x060131E1 RID: 78305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E1")]
		[Address(RVA = "0xB15620", Offset = "0xB14220", VA = "0x180B15620", Slot = "7")]
		public override void DoSetData(Ability.Options options)
		{
		}

		// Token: 0x060131E2 RID: 78306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E2")]
		[Address(RVA = "0xB15870", Offset = "0xB14470", VA = "0x180B15870", Slot = "8")]
		public override void OnDetached()
		{
		}

		// Token: 0x060131E3 RID: 78307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E3")]
		[Address(RVA = "0xB157C0", Offset = "0xB143C0", VA = "0x180B157C0", Slot = "9")]
		public override void OnCasted(Tile tile, int times)
		{
		}

		// Token: 0x060131E4 RID: 78308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E4")]
		[Address(RVA = "0xB159D0", Offset = "0xB145D0", VA = "0x180B159D0", Slot = "11")]
		public override void OnLocatedCharacterUpdate(Character character)
		{
		}

		// Token: 0x060131E5 RID: 78309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E5")]
		[Address(RVA = "0xB15A50", Offset = "0xB14650", VA = "0x180B15A50", Slot = "10")]
		public override void OnRefresh(Tile tile)
		{
		}

		// Token: 0x060131E6 RID: 78310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E6")]
		[Address(RVA = "0xB15B60", Offset = "0xB14760", VA = "0x180B15B60")]
		private void _BuffToCharacter(BuffData[] buffs, Character character)
		{
		}

		// Token: 0x060131E7 RID: 78311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E7")]
		[Address(RVA = "0xB16400", Offset = "0xB15000", VA = "0x180B16400")]
		private void _RemoveAttachedBuffs()
		{
		}

		// Token: 0x060131E8 RID: 78312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131E8")]
		[Address(RVA = "0xB160B0", Offset = "0xB14CB0", VA = "0x180B160B0")]
		private void _OnTileListenerRemoved(object arg)
		{
		}

		// Token: 0x060131E9 RID: 78313 RVA: 0x00074A18 File Offset: 0x00072C18
		[Token(Token = "0x60131E9")]
		[Address(RVA = "0xB15EE0", Offset = "0xB14AE0", VA = "0x180B15EE0")]
		private bool _CheckTargetInBlackList(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060131EA RID: 78314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131EA")]
		[Address(RVA = "0xB16590", Offset = "0xB15190", VA = "0x180B16590")]
		public BuffToCharacterTileListener()
		{
		}

		// Token: 0x060131EB RID: 78315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131EB")]
		[Address(RVA = "0xB15AF0", Offset = "0xB146F0", VA = "0x180B15AF0")]
		private void <>xLuaBaseProxy_DoSetData(Ability.Options P0)
		{
		}

		// Token: 0x060131EC RID: 78316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131EC")]
		[Address(RVA = "0xB15B30", Offset = "0xB14730", VA = "0x180B15B30")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060131ED RID: 78317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131ED")]
		[Address(RVA = "0xB15B20", Offset = "0xB14720", VA = "0x180B15B20")]
		private void <>xLuaBaseProxy_OnCasted(Tile P0, int P1)
		{
		}

		// Token: 0x060131EE RID: 78318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131EE")]
		[Address(RVA = "0xB15B40", Offset = "0xB14740", VA = "0x180B15B40")]
		private void <>xLuaBaseProxy_OnLocatedCharacterUpdate(Character P0)
		{
		}

		// Token: 0x060131EF RID: 78319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131EF")]
		[Address(RVA = "0xB15B50", Offset = "0xB14750", VA = "0x180B15B50")]
		private void <>xLuaBaseProxy_OnRefresh(Tile P0)
		{
		}

		// Token: 0x04015977 RID: 88439
		[Token(Token = "0x4015977")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TargetValidator _targetValidator;

		// Token: 0x04015978 RID: 88440
		[Token(Token = "0x4015978")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04015979 RID: 88441
		[Token(Token = "0x4015979")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuffData[] _buffsWhenCasted;

		// Token: 0x0401597A RID: 88442
		[Token(Token = "0x401597A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _clearBuffWhenAbilityDetached;

		// Token: 0x0401597B RID: 88443
		[Token(Token = "0x401597B")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _clearBuffWhenTileListenerRemoved;

		// Token: 0x0401597C RID: 88444
		[Token(Token = "0x401597C")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _useBlackList;

		// Token: 0x0401597D RID: 88445
		[Token(Token = "0x401597D")]
		private const string CASTED_TIMES = "casted_times";

		// Token: 0x0401597E RID: 88446
		[Token(Token = "0x401597E")]
		[FieldOffset(Offset = "0x40")]
		private Blackboard m_blackboard;

		// Token: 0x0401597F RID: 88447
		[Token(Token = "0x401597F")]
		[FieldOffset(Offset = "0x48")]
		private List<ObjectPtr<Buff>> m_buffs;

		// Token: 0x04015980 RID: 88448
		[Token(Token = "0x4015980")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04015981 RID: 88449
		[Token(Token = "0x4015981")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015982 RID: 88450
		[Token(Token = "0x4015982")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCasted;

		// Token: 0x04015983 RID: 88451
		[Token(Token = "0x4015983")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnLocatedCharacterUpdate;

		// Token: 0x04015984 RID: 88452
		[Token(Token = "0x4015984")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x04015985 RID: 88453
		[Token(Token = "0x4015985")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BuffToCharacter;

		// Token: 0x04015986 RID: 88454
		[Token(Token = "0x4015986")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RemoveAttachedBuffs;

		// Token: 0x04015987 RID: 88455
		[Token(Token = "0x4015987")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnTileListenerRemoved;

		// Token: 0x04015988 RID: 88456
		[Token(Token = "0x4015988")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckTargetInBlackList;

		// Token: 0x04015989 RID: 88457
		[Token(Token = "0x4015989")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
