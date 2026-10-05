using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200238E RID: 9102
	[Token(Token = "0x200238E")]
	public class CastTile : Tile, IActionNodeSource
	{
		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x0600E6EC RID: 59116 RVA: 0x000541F8 File Offset: 0x000523F8
		[Token(Token = "0x17001CFF")]
		protected override int maxTriggerCnt
		{
			[Token(Token = "0x600E6EC")]
			[Address(RVA = "0x5BA0B0", Offset = "0x5B8CB0", VA = "0x1805BA0B0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600E6ED RID: 59117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6ED")]
		[Address(RVA = "0x5B8DE0", Offset = "0x5B79E0", VA = "0x1805B8DE0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E6EE RID: 59118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6EE")]
		[Address(RVA = "0x5B8D30", Offset = "0x5B7930", VA = "0x1805B8D30", Slot = "41")]
		public void GatherActionNodes(List<ActionNode> results)
		{
		}

		// Token: 0x0600E6EF RID: 59119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6EF")]
		[Address(RVA = "0x5B9080", Offset = "0x5B7C80", VA = "0x1805B9080", Slot = "40")]
		protected override void OnTrigger()
		{
		}

		// Token: 0x0600E6F0 RID: 59120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F0")]
		[Address(RVA = "0x5B99E0", Offset = "0x5B85E0", VA = "0x1805B99E0")]
		private void _TryCastOnTarget(Entity target, bool isBuildSlot = false)
		{
		}

		// Token: 0x0600E6F1 RID: 59121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F1")]
		[Address(RVA = "0x5B9D60", Offset = "0x5B8960", VA = "0x1805B9D60")]
		private void _TryFindExtraTargets()
		{
		}

		// Token: 0x0600E6F2 RID: 59122 RVA: 0x00054210 File Offset: 0x00052410
		[Token(Token = "0x600E6F2")]
		[Address(RVA = "0x5B9610", Offset = "0x5B8210", VA = "0x1805B9610")]
		private bool _CheckExtraTarget(Entity candidate)
		{
			return default(bool);
		}

		// Token: 0x0600E6F3 RID: 59123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F3")]
		[Address(RVA = "0x5B9550", Offset = "0x5B8150", VA = "0x1805B9550", Slot = "23")]
		protected override void PreloadAssets()
		{
		}

		// Token: 0x0600E6F4 RID: 59124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F4")]
		[Address(RVA = "0x5B9F80", Offset = "0x5B8B80", VA = "0x1805B9F80")]
		public CastTile()
		{
		}

		// Token: 0x0600E6F5 RID: 59125 RVA: 0x00054228 File Offset: 0x00052428
		[Token(Token = "0x600E6F5")]
		[Address(RVA = "0x5B9600", Offset = "0x5B8200", VA = "0x1805B9600")]
		private int <>xLuaBaseProxy_get_maxTriggerCnt()
		{
			return 0;
		}

		// Token: 0x0600E6F6 RID: 59126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F6")]
		[Address(RVA = "0x5B8930", Offset = "0x5B7530", VA = "0x1805B8930")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0600E6F7 RID: 59127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F7")]
		[Address(RVA = "0x5B95E0", Offset = "0x5B81E0", VA = "0x1805B95E0")]
		private void <>xLuaBaseProxy_OnTrigger()
		{
		}

		// Token: 0x0600E6F8 RID: 59128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6F8")]
		[Address(RVA = "0x5B95F0", Offset = "0x5B81F0", VA = "0x1805B95F0")]
		private void <>xLuaBaseProxy_PreloadAssets()
		{
		}

		// Token: 0x0400FE45 RID: 65093
		[Token(Token = "0x400FE45")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x0400FE46 RID: 65094
		[Token(Token = "0x400FE46")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private SideType _sourceSide;

		// Token: 0x0400FE47 RID: 65095
		[Token(Token = "0x400FE47")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private ActionArray _actions;

		// Token: 0x0400FE48 RID: 65096
		[Token(Token = "0x400FE48")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private ActionArray _actionsOnTrigger;

		// Token: 0x0400FE49 RID: 65097
		[Token(Token = "0x400FE49")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private ActionArray _actionsToSlot;

		// Token: 0x0400FE4A RID: 65098
		[Token(Token = "0x400FE4A")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private string _castEffect;

		// Token: 0x0400FE4B RID: 65099
		[Token(Token = "0x400FE4B")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private string _hitEffect;

		// Token: 0x0400FE4C RID: 65100
		[Token(Token = "0x400FE4C")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private int _castMaxCnt;

		// Token: 0x0400FE4D RID: 65101
		[Token(Token = "0x400FE4D")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private Range _extraTargetRange;

		// Token: 0x0400FE4E RID: 65102
		[Token(Token = "0x400FE4E")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private bool _onlyCombatEnemyInExtraRange;

		// Token: 0x0400FE4F RID: 65103
		[Token(Token = "0x400FE4F")]
		[FieldOffset(Offset = "0x1CC")]
		private int m_maxTriggerCnt;

		// Token: 0x0400FE50 RID: 65104
		[Token(Token = "0x400FE50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTriggerCnt;

		// Token: 0x0400FE51 RID: 65105
		[Token(Token = "0x400FE51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FE52 RID: 65106
		[Token(Token = "0x400FE52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherActionNodes;

		// Token: 0x0400FE53 RID: 65107
		[Token(Token = "0x400FE53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400FE54 RID: 65108
		[Token(Token = "0x400FE54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryCastOnTarget;

		// Token: 0x0400FE55 RID: 65109
		[Token(Token = "0x400FE55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryFindExtraTargets;

		// Token: 0x0400FE56 RID: 65110
		[Token(Token = "0x400FE56")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckExtraTarget;

		// Token: 0x0400FE57 RID: 65111
		[Token(Token = "0x400FE57")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PreloadAssets;

		// Token: 0x0400FE58 RID: 65112
		[Token(Token = "0x400FE58")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
