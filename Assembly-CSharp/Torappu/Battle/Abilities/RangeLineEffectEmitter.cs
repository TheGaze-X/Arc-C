using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BF8 RID: 11256
	[Token(Token = "0x2002BF8")]
	public class RangeLineEffectEmitter : AbstractEffectEmitter, BattleAttackRangeController.IRangeListener
	{
		// Token: 0x0601302C RID: 77868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601302C")]
		[Address(RVA = "0xAE9310", Offset = "0xAE7F10", VA = "0x180AE9310", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0601302D RID: 77869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601302D")]
		[Address(RVA = "0xAE9A10", Offset = "0xAE8610", VA = "0x180AE9A10", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601302E RID: 77870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601302E")]
		[Address(RVA = "0xAE9840", Offset = "0xAE8440", VA = "0x180AE9840", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x0601302F RID: 77871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601302F")]
		[Address(RVA = "0xAE9980", Offset = "0xAE8580", VA = "0x180AE9980", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06013030 RID: 77872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013030")]
		[Address(RVA = "0xAE93B0", Offset = "0xAE7FB0", VA = "0x180AE93B0", Slot = "18")]
		public void OnCharacterAttackRangeUpdate(Character character, Dictionary<Character, List<Tile>> allRangeTiles)
		{
		}

		// Token: 0x06013031 RID: 77873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013031")]
		[Address(RVA = "0xAE9CC0", Offset = "0xAE88C0", VA = "0x180AE9CC0")]
		private void _OnAttached()
		{
		}

		// Token: 0x06013032 RID: 77874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013032")]
		[Address(RVA = "0xAE9D30", Offset = "0xAE8930", VA = "0x180AE9D30")]
		private void _OnDetached()
		{
		}

		// Token: 0x06013033 RID: 77875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013033")]
		[Address(RVA = "0xAE97D0", Offset = "0xAE83D0", VA = "0x180AE97D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06013034 RID: 77876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013034")]
		[Address(RVA = "0xAE9DB0", Offset = "0xAE89B0", VA = "0x180AE9DB0")]
		public RangeLineEffectEmitter()
		{
		}

		// Token: 0x06013035 RID: 77877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013035")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013036 RID: 77878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013036")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x06013037 RID: 77879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013037")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04015785 RID: 87941
		[Token(Token = "0x4015785")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _edgeLineRendererEffectKey;

		// Token: 0x04015786 RID: 87942
		[Token(Token = "0x4015786")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _disableBlackboardKey;

		// Token: 0x04015787 RID: 87943
		[Token(Token = "0x4015787")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x04015788 RID: 87944
		[Token(Token = "0x4015788")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _lineOffsetToMapCenter;

		// Token: 0x04015789 RID: 87945
		[Token(Token = "0x4015789")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<GridPosition> m_curAttackRange;

		// Token: 0x0401578A RID: 87946
		[Token(Token = "0x401578A")]
		[FieldOffset(Offset = "0x48")]
		private RangeLineEffectHandler m_handler;

		// Token: 0x0401578B RID: 87947
		[Token(Token = "0x401578B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401578C RID: 87948
		[Token(Token = "0x401578C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401578D RID: 87949
		[Token(Token = "0x401578D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401578E RID: 87950
		[Token(Token = "0x401578E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401578F RID: 87951
		[Token(Token = "0x401578F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCharacterAttackRangeUpdate;

		// Token: 0x04015790 RID: 87952
		[Token(Token = "0x4015790")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnAttached;

		// Token: 0x04015791 RID: 87953
		[Token(Token = "0x4015791")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDetached;

		// Token: 0x04015792 RID: 87954
		[Token(Token = "0x4015792")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04015793 RID: 87955
		[Token(Token = "0x4015793")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
