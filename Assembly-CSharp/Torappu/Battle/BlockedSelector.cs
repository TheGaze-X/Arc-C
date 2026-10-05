using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002505 RID: 9477
	[Token(Token = "0x2002505")]
	public class BlockedSelector : TargetSelector
	{
		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x0600F40F RID: 62479 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F410 RID: 62480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001FC4")]
		private protected Character character
		{
			[Token(Token = "0x600F40F")]
			[Address(RVA = "0x6B8D20", Offset = "0x6B7920", VA = "0x1806B8D20")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F410")]
			[Address(RVA = "0x6B8F60", Offset = "0x6B7B60", VA = "0x1806B8F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x0600F411 RID: 62481 RVA: 0x0005A078 File Offset: 0x00058278
		[Token(Token = "0x17001FC5")]
		protected virtual bool ignoreTargetFree
		{
			[Token(Token = "0x600F411")]
			[Address(RVA = "0x6B8E40", Offset = "0x6B7A40", VA = "0x1806B8E40", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x0600F412 RID: 62482 RVA: 0x0005A090 File Offset: 0x00058290
		[Token(Token = "0x17001FC6")]
		protected virtual bool ignoreAllyTargetFree
		{
			[Token(Token = "0x600F412")]
			[Address(RVA = "0x6B8D80", Offset = "0x6B7980", VA = "0x1806B8D80", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x0600F413 RID: 62483 RVA: 0x0005A0A8 File Offset: 0x000582A8
		[Token(Token = "0x17001FC7")]
		protected virtual bool ignoreHealFree
		{
			[Token(Token = "0x600F413")]
			[Address(RVA = "0x6B8DE0", Offset = "0x6B79E0", VA = "0x1806B8DE0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x0600F414 RID: 62484 RVA: 0x0005A0C0 File Offset: 0x000582C0
		[Token(Token = "0x17001FC8")]
		protected virtual bool onlyIgnoreSomeOfTargetFreeCase
		{
			[Token(Token = "0x600F414")]
			[Address(RVA = "0x6B8F00", Offset = "0x6B7B00", VA = "0x1806B8F00", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600F415 RID: 62485 RVA: 0x0005A0D8 File Offset: 0x000582D8
		[Token(Token = "0x17001FC9")]
		protected virtual AbnormalFlag abnormalFlag
		{
			[Token(Token = "0x600F415")]
			[Address(RVA = "0x6B8CC0", Offset = "0x6B78C0", VA = "0x1806B8CC0", Slot = "29")]
			get
			{
				return AbnormalFlag.STUNNED;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x0600F416 RID: 62486 RVA: 0x0005A0F0 File Offset: 0x000582F0
		[Token(Token = "0x17001FCA")]
		protected virtual AbnormalCombo abnormalCombo
		{
			[Token(Token = "0x600F416")]
			[Address(RVA = "0x6B8C60", Offset = "0x6B7860", VA = "0x1806B8C60", Slot = "30")]
			get
			{
				return AbnormalCombo.SLEEPING;
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x0600F417 RID: 62487 RVA: 0x0005A108 File Offset: 0x00058308
		[Token(Token = "0x17001FCB")]
		protected int maxTargetNum
		{
			[Token(Token = "0x600F417")]
			[Address(RVA = "0x6B8EA0", Offset = "0x6B7AA0", VA = "0x1806B8EA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F418 RID: 62488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F418")]
		[Address(RVA = "0x6B8630", Offset = "0x6B7230", VA = "0x1806B8630", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F419 RID: 62489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F419")]
		[Address(RVA = "0x6B80A0", Offset = "0x6B6CA0", VA = "0x1806B80A0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F41A RID: 62490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F41A")]
		[Address(RVA = "0x6B85C0", Offset = "0x6B71C0", VA = "0x1806B85C0", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F41B RID: 62491 RVA: 0x0005A120 File Offset: 0x00058320
		[Token(Token = "0x600F41B")]
		[Address(RVA = "0x6B7D80", Offset = "0x6B6980", VA = "0x1806B7D80", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F41C RID: 62492 RVA: 0x0005A138 File Offset: 0x00058338
		[Token(Token = "0x600F41C")]
		[Address(RVA = "0x6B8B30", Offset = "0x6B7730", VA = "0x1806B8B30", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F41D RID: 62493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F41D")]
		[Address(RVA = "0x6B8BF0", Offset = "0x6B77F0", VA = "0x1806B8BF0")]
		public BlockedSelector()
		{
		}

		// Token: 0x0600F41E RID: 62494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F41E")]
		[Address(RVA = "0x6B8B20", Offset = "0x6B7720", VA = "0x1806B8B20")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F41F RID: 62495 RVA: 0x0005A150 File Offset: 0x00058350
		[Token(Token = "0x600F41F")]
		[Address(RVA = "0x6A2DC0", Offset = "0x6A19C0", VA = "0x1806A2DC0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E39 RID: 69177
		[Token(Token = "0x4010E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxTargetNum;

		// Token: 0x04010E3A RID: 69178
		[Token(Token = "0x4010E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TargetOptions m_targetOptions;

		// Token: 0x04010E3B RID: 69179
		[Token(Token = "0x4010E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Enemy m_enemy;

		// Token: 0x04010E3D RID: 69181
		[Token(Token = "0x4010E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04010E3E RID: 69182
		[Token(Token = "0x4010E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04010E3F RID: 69183
		[Token(Token = "0x4010E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010E40 RID: 69184
		[Token(Token = "0x4010E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ignoreAllyTargetFree;

		// Token: 0x04010E41 RID: 69185
		[Token(Token = "0x4010E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04010E42 RID: 69186
		[Token(Token = "0x4010E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_onlyIgnoreSomeOfTargetFreeCase;

		// Token: 0x04010E43 RID: 69187
		[Token(Token = "0x4010E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_abnormalFlag;

		// Token: 0x04010E44 RID: 69188
		[Token(Token = "0x4010E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_abnormalCombo;

		// Token: 0x04010E45 RID: 69189
		[Token(Token = "0x4010E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_maxTargetNum;

		// Token: 0x04010E46 RID: 69190
		[Token(Token = "0x4010E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E47 RID: 69191
		[Token(Token = "0x4010E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E48 RID: 69192
		[Token(Token = "0x4010E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010E49 RID: 69193
		[Token(Token = "0x4010E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010E4A RID: 69194
		[Token(Token = "0x4010E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E4B RID: 69195
		[Token(Token = "0x4010E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
