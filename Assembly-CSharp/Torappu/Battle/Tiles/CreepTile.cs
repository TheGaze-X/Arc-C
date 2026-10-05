using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Tiles
{
	// Token: 0x020029F8 RID: 10744
	[Token(Token = "0x20029F8")]
	public class CreepTile : DynamicBuffTile
	{
		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06011D26 RID: 72998 RVA: 0x0006D1B8 File Offset: 0x0006B3B8
		[Token(Token = "0x1700274A")]
		protected override int maxTriggerCnt
		{
			[Token(Token = "0x6011D26")]
			[Address(RVA = "0x9AADB0", Offset = "0x9A99B0", VA = "0x1809AADB0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011D27 RID: 72999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D27")]
		[Address(RVA = "0x9A9AD0", Offset = "0x9A86D0", VA = "0x1809A9AD0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x06011D28 RID: 73000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D28")]
		[Address(RVA = "0x9AA2F0", Offset = "0x9A8EF0", VA = "0x1809AA2F0", Slot = "23")]
		protected override void PreloadAssets()
		{
		}

		// Token: 0x06011D29 RID: 73001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D29")]
		[Address(RVA = "0x9A9E20", Offset = "0x9A8A20", VA = "0x1809A9E20", Slot = "50")]
		protected override void OnSwitchMode(int mode)
		{
		}

		// Token: 0x06011D2A RID: 73002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D2A")]
		[Address(RVA = "0x9AA980", Offset = "0x9A9580", VA = "0x1809AA980")]
		private void _UpdateCreepEffects(int mode)
		{
		}

		// Token: 0x06011D2B RID: 73003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D2B")]
		[Address(RVA = "0x9A9EE0", Offset = "0x9A8AE0", VA = "0x1809A9EE0", Slot = "40")]
		protected override void OnTrigger()
		{
		}

		// Token: 0x06011D2C RID: 73004 RVA: 0x0006D1D0 File Offset: 0x0006B3D0
		[Token(Token = "0x6011D2C")]
		[Address(RVA = "0x9AA560", Offset = "0x9A9160", VA = "0x1809AA560")]
		private bool _CheckTriggerable()
		{
			return default(bool);
		}

		// Token: 0x06011D2D RID: 73005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D2D")]
		[Address(RVA = "0x9AA7F0", Offset = "0x9A93F0", VA = "0x1809AA7F0")]
		private void _TryCastOnTile(CreepTile creepTile)
		{
		}

		// Token: 0x06011D2E RID: 73006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D2E")]
		[Address(RVA = "0x9AA740", Offset = "0x9A9340", VA = "0x1809AA740")]
		private void _SwitchModeFromDirection(int mode, SharedConsts.Direction direction)
		{
		}

		// Token: 0x06011D2F RID: 73007 RVA: 0x0006D1E8 File Offset: 0x0006B3E8
		[Token(Token = "0x6011D2F")]
		[Address(RVA = "0x9AAB80", Offset = "0x9A9780", VA = "0x1809AAB80")]
		private bool _ValidateTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x06011D30 RID: 73008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D30")]
		[Address(RVA = "0x9AACE0", Offset = "0x9A98E0", VA = "0x1809AACE0")]
		public CreepTile()
		{
		}

		// Token: 0x06011D31 RID: 73009 RVA: 0x0006D200 File Offset: 0x0006B400
		[Token(Token = "0x6011D31")]
		[Address(RVA = "0x5B9600", Offset = "0x5B8200", VA = "0x1805B9600")]
		private int <>xLuaBaseProxy_get_maxTriggerCnt()
		{
			return 0;
		}

		// Token: 0x06011D32 RID: 73010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D32")]
		[Address(RVA = "0x50CDC0", Offset = "0x50B9C0", VA = "0x18050CDC0")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x06011D33 RID: 73011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D33")]
		[Address(RVA = "0x5B95F0", Offset = "0x5B81F0", VA = "0x1805B95F0")]
		private void <>xLuaBaseProxy_PreloadAssets()
		{
		}

		// Token: 0x06011D34 RID: 73012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D34")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnSwitchMode(int P0)
		{
		}

		// Token: 0x06011D35 RID: 73013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D35")]
		[Address(RVA = "0x5B95E0", Offset = "0x5B81E0", VA = "0x1805B95E0")]
		private void <>xLuaBaseProxy_OnTrigger()
		{
		}

		// Token: 0x04014049 RID: 81993
		[Token(Token = "0x4014049")]
		private const int PRELOAD_EFFECT_SIZE = 30;

		// Token: 0x0401404A RID: 81994
		[Token(Token = "0x401404A")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private TargetOptions _stopCreepCharacterOption;

		// Token: 0x0401404B RID: 81995
		[Token(Token = "0x401404B")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		private Range _creepRange;

		// Token: 0x0401404C RID: 81996
		[Token(Token = "0x401404C")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		private int _defaultMode;

		// Token: 0x0401404D RID: 81997
		[Token(Token = "0x401404D")]
		[FieldOffset(Offset = "0x254")]
		[SerializeField]
		private int _creepMode;

		// Token: 0x0401404E RID: 81998
		[Token(Token = "0x401404E")]
		[FieldOffset(Offset = "0x258")]
		[SerializeField]
		private float _creepProtectTime;

		// Token: 0x0401404F RID: 81999
		[Token(Token = "0x401404F")]
		[FieldOffset(Offset = "0x260")]
		[SerializeField]
		private List<CreepTile.DirectionEffectGroup> _creepDirectionEffects;

		// Token: 0x04014050 RID: 82000
		[Token(Token = "0x4014050")]
		[FieldOffset(Offset = "0x268")]
		private int m_originMode;

		// Token: 0x04014051 RID: 82001
		[Token(Token = "0x4014051")]
		[FieldOffset(Offset = "0x270")]
		private FP m_creepModeStartTime;

		// Token: 0x04014052 RID: 82002
		[Token(Token = "0x4014052")]
		[FieldOffset(Offset = "0x278")]
		private FP m_creepProtectTime;

		// Token: 0x04014053 RID: 82003
		[Token(Token = "0x4014053")]
		[FieldOffset(Offset = "0x280")]
		private SharedConsts.Direction m_switchDirection;

		// Token: 0x04014054 RID: 82004
		[Token(Token = "0x4014054")]
		[FieldOffset(Offset = "0x284")]
		private bool m_runeExtraCheck;

		// Token: 0x04014055 RID: 82005
		[Token(Token = "0x4014055")]
		[FieldOffset(Offset = "0x288")]
		private int m_runeCheckBlockCnt;

		// Token: 0x04014056 RID: 82006
		[Token(Token = "0x4014056")]
		[FieldOffset(Offset = "0x290")]
		private Effect m_currentCreepEffect;

		// Token: 0x04014057 RID: 82007
		[Token(Token = "0x4014057")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTriggerCnt;

		// Token: 0x04014058 RID: 82008
		[Token(Token = "0x4014058")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014059 RID: 82009
		[Token(Token = "0x4014059")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreloadAssets;

		// Token: 0x0401405A RID: 82010
		[Token(Token = "0x401405A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSwitchMode;

		// Token: 0x0401405B RID: 82011
		[Token(Token = "0x401405B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateCreepEffects;

		// Token: 0x0401405C RID: 82012
		[Token(Token = "0x401405C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0401405D RID: 82013
		[Token(Token = "0x401405D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckTriggerable;

		// Token: 0x0401405E RID: 82014
		[Token(Token = "0x401405E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryCastOnTile;

		// Token: 0x0401405F RID: 82015
		[Token(Token = "0x401405F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SwitchModeFromDirection;

		// Token: 0x04014060 RID: 82016
		[Token(Token = "0x4014060")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ValidateTile;

		// Token: 0x04014061 RID: 82017
		[Token(Token = "0x4014061")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029F9 RID: 10745
		[Token(Token = "0x20029F9")]
		[Serializable]
		private struct EffectWeightPair : IItemWithWeight
		{
			// Token: 0x1700274B RID: 10059
			// (get) Token: 0x06011D36 RID: 73014 RVA: 0x0006D218 File Offset: 0x0006B418
			[Token(Token = "0x1700274B")]
			public float weightValue
			{
				[Token(Token = "0x6011D36")]
				[Address(RVA = "0x5DE4D0", Offset = "0x5DD0D0", VA = "0x1805DE4D0", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x04014062 RID: 82018
			[Token(Token = "0x4014062")]
			[FieldOffset(Offset = "0x0")]
			public string effect;

			// Token: 0x04014063 RID: 82019
			[Token(Token = "0x4014063")]
			[FieldOffset(Offset = "0x8")]
			public float weight;
		}

		// Token: 0x020029FA RID: 10746
		[Token(Token = "0x20029FA")]
		[Serializable]
		private class DirectionEffectGroup
		{
			// Token: 0x06011D37 RID: 73015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011D37")]
			[Address(RVA = "0x9AAE10", Offset = "0x9A9A10", VA = "0x1809AAE10")]
			public DirectionEffectGroup()
			{
			}

			// Token: 0x04014064 RID: 82020
			[Token(Token = "0x4014064")]
			[FieldOffset(Offset = "0x10")]
			public SharedConsts.Direction direction;

			// Token: 0x04014065 RID: 82021
			[Token(Token = "0x4014065")]
			[FieldOffset(Offset = "0x18")]
			public List<CreepTile.EffectWeightPair> effects;
		}
	}
}
