using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022E0 RID: 8928
	[Token(Token = "0x20022E0")]
	public class Act48SideManager : GlobalEnvSystem.EnvManager, IEffectSource
	{
		// Token: 0x0600E129 RID: 57641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E129")]
		[Address(RVA = "0x3687D00", Offset = "0x3686900", VA = "0x183687D00")]
		public GameObject GetTileWater(GridPosition pos)
		{
			return null;
		}

		// Token: 0x0600E12A RID: 57642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E12A")]
		[Address(RVA = "0x3687C30", Offset = "0x3686830", VA = "0x183687C30")]
		public GameObject GetTileFlower(GridPosition pos)
		{
			return null;
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E12B")]
		[Address(RVA = "0x3687F00", Offset = "0x3686B00", VA = "0x183687F00", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E12C RID: 57644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E12C")]
		[Address(RVA = "0x3688070", Offset = "0x3686C70", VA = "0x183688070", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E12D RID: 57645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E12D")]
		[Address(RVA = "0x3689610", Offset = "0x3688210", VA = "0x183689610")]
		private void _CollectWaterTraps()
		{
		}

		// Token: 0x0600E12E RID: 57646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E12E")]
		[Address(RVA = "0x3689880", Offset = "0x3688480", VA = "0x183689880")]
		private void _FindNeighborsDFS(LevelData.PredefinedData.PredefinedCharacter data)
		{
		}

		// Token: 0x0600E12F RID: 57647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E12F")]
		[Address(RVA = "0x3689BB0", Offset = "0x36887B0", VA = "0x183689BB0")]
		private void _GetNeighbors(GridPosition pos, List<GridPosition> group)
		{
		}

		// Token: 0x0600E130 RID: 57648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E130")]
		[Address(RVA = "0x3688F80", Offset = "0x3687B80", VA = "0x183688F80")]
		private void _CollectTrapsTile()
		{
		}

		// Token: 0x0600E131 RID: 57649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E131")]
		[Address(RVA = "0x3688B00", Offset = "0x3687700", VA = "0x183688B00")]
		private void _CollectMapObjects()
		{
		}

		// Token: 0x0600E132 RID: 57650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E132")]
		[Address(RVA = "0x36885C0", Offset = "0x36871C0", VA = "0x1836885C0")]
		private void _CheckTrapGroupMax(int groupIndex)
		{
		}

		// Token: 0x0600E133 RID: 57651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E133")]
		[Address(RVA = "0x3689F30", Offset = "0x3688B30", VA = "0x183689F30")]
		private void _SetGroupAreaOn(int groupIndex)
		{
		}

		// Token: 0x0600E134 RID: 57652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E134")]
		[Address(RVA = "0x3689D70", Offset = "0x3688970", VA = "0x183689D70")]
		private void _SetGroupAreaOff(int groupIndex)
		{
		}

		// Token: 0x0600E135 RID: 57653 RVA: 0x00051B28 File Offset: 0x0004FD28
		[Token(Token = "0x600E135")]
		[Address(RVA = "0x3688970", Offset = "0x3687570", VA = "0x183688970")]
		private bool _CheckTrapOnTile(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E136 RID: 57654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E136")]
		[Address(RVA = "0x3687DD0", Offset = "0x36869D0", VA = "0x183687DD0")]
		public List<GridPosition> GetTrapGroupPos(GridPosition pos)
		{
			return null;
		}

		// Token: 0x0600E137 RID: 57655 RVA: 0x00051B40 File Offset: 0x0004FD40
		[Token(Token = "0x600E137")]
		[Address(RVA = "0x36883D0", Offset = "0x3686FD0", VA = "0x1836883D0")]
		public bool RegistFunctionTrap(Trap trap)
		{
			return default(bool);
		}

		// Token: 0x0600E138 RID: 57656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E138")]
		[Address(RVA = "0x3687BA0", Offset = "0x36867A0", VA = "0x183687BA0", Slot = "5")]
		public new void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600E139 RID: 57657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E139")]
		[Address(RVA = "0x368A0F0", Offset = "0x3688CF0", VA = "0x18368A0F0")]
		public Act48SideManager()
		{
		}

		// Token: 0x0600E13A RID: 57658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E13A")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E13B RID: 57659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E13B")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F5ED RID: 62957
		[Token(Token = "0x400F5ED")]
		private const string TRAP_FULL_TRIGGER = "trap_full";

		// Token: 0x0400F5EE RID: 62958
		[Token(Token = "0x400F5EE")]
		private const string TRAP_NOT_FULL_TRIGGER = "trap_not_full";

		// Token: 0x0400F5EF RID: 62959
		[Token(Token = "0x400F5EF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _trapId;

		// Token: 0x0400F5F0 RID: 62960
		[Token(Token = "0x400F5F0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _effectId;

		// Token: 0x0400F5F1 RID: 62961
		[Token(Token = "0x400F5F1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuffData _buffToTrap;

		// Token: 0x0400F5F2 RID: 62962
		[Token(Token = "0x400F5F2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _poolParentName;

		// Token: 0x0400F5F3 RID: 62963
		[Token(Token = "0x400F5F3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _poolName;

		// Token: 0x0400F5F4 RID: 62964
		[Token(Token = "0x400F5F4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _poolFlowerName;

		// Token: 0x0400F5F5 RID: 62965
		[Token(Token = "0x400F5F5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _poolStartPos;

		// Token: 0x0400F5F6 RID: 62966
		[Token(Token = "0x400F5F6")]
		[FieldOffset(Offset = "0x60")]
		private List<List<GridPosition>> m_trapPostions;

		// Token: 0x0400F5F7 RID: 62967
		[Token(Token = "0x400F5F7")]
		[FieldOffset(Offset = "0x68")]
		private List<List<ObjectPtr<Effect>>> m_trapEffects;

		// Token: 0x0400F5F8 RID: 62968
		[Token(Token = "0x400F5F8")]
		[FieldOffset(Offset = "0x70")]
		private List<List<GridPosition>> m_trapEffectsPos;

		// Token: 0x0400F5F9 RID: 62969
		[Token(Token = "0x400F5F9")]
		[FieldOffset(Offset = "0x78")]
		private List<int> m_trapFullCnt;

		// Token: 0x0400F5FA RID: 62970
		[Token(Token = "0x400F5FA")]
		[FieldOffset(Offset = "0x80")]
		private List<bool> m_trapIsMax;

		// Token: 0x0400F5FB RID: 62971
		[Token(Token = "0x400F5FB")]
		[FieldOffset(Offset = "0x88")]
		private List<ObjectPtr<Trap>> m_trapSkill;

		// Token: 0x0400F5FC RID: 62972
		[Token(Token = "0x400F5FC")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<GridPosition, LevelData.PredefinedData.PredefinedCharacter> m_predefinedData;

		// Token: 0x0400F5FD RID: 62973
		[Token(Token = "0x400F5FD")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<GridPosition, GameObject> m_sceneWaters;

		// Token: 0x0400F5FE RID: 62974
		[Token(Token = "0x400F5FE")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<GridPosition, GameObject> m_sceneFlowers;

		// Token: 0x0400F5FF RID: 62975
		[Token(Token = "0x400F5FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTileWater;

		// Token: 0x0400F600 RID: 62976
		[Token(Token = "0x400F600")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTileFlower;

		// Token: 0x0400F601 RID: 62977
		[Token(Token = "0x400F601")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F602 RID: 62978
		[Token(Token = "0x400F602")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F603 RID: 62979
		[Token(Token = "0x400F603")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CollectWaterTraps;

		// Token: 0x0400F604 RID: 62980
		[Token(Token = "0x400F604")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindNeighborsDFS;

		// Token: 0x0400F605 RID: 62981
		[Token(Token = "0x400F605")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetNeighbors;

		// Token: 0x0400F606 RID: 62982
		[Token(Token = "0x400F606")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CollectTrapsTile;

		// Token: 0x0400F607 RID: 62983
		[Token(Token = "0x400F607")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CollectMapObjects;

		// Token: 0x0400F608 RID: 62984
		[Token(Token = "0x400F608")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckTrapGroupMax;

		// Token: 0x0400F609 RID: 62985
		[Token(Token = "0x400F609")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetGroupAreaOn;

		// Token: 0x0400F60A RID: 62986
		[Token(Token = "0x400F60A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SetGroupAreaOff;

		// Token: 0x0400F60B RID: 62987
		[Token(Token = "0x400F60B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckTrapOnTile;

		// Token: 0x0400F60C RID: 62988
		[Token(Token = "0x400F60C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTrapGroupPos;

		// Token: 0x0400F60D RID: 62989
		[Token(Token = "0x400F60D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RegistFunctionTrap;

		// Token: 0x0400F60E RID: 62990
		[Token(Token = "0x400F60E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0400F60F RID: 62991
		[Token(Token = "0x400F60F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
