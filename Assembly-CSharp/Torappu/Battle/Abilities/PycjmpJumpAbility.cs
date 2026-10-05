using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BAD RID: 11181
	[Token(Token = "0x2002BAD")]
	[RequireComponent(typeof(Collider2D))]
	public class PycjmpJumpAbility : AbstractAnimatedAbility
	{
		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x06012DB6 RID: 77238 RVA: 0x000737A0 File Offset: 0x000719A0
		[Token(Token = "0x1700299D")]
		public PycjmpJumpAbility.JumpEndType lastJumpEndType
		{
			[Token(Token = "0x6012DB6")]
			[Address(RVA = "0xACA4D0", Offset = "0xAC90D0", VA = "0x180ACA4D0")]
			get
			{
				return PycjmpJumpAbility.JumpEndType.NONE;
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x06012DB7 RID: 77239 RVA: 0x000737B8 File Offset: 0x000719B8
		[Token(Token = "0x1700299E")]
		public bool checkWallLikeEntity
		{
			[Token(Token = "0x6012DB7")]
			[Address(RVA = "0xACA470", Offset = "0xAC9070", VA = "0x180ACA470")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012DB8 RID: 77240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DB8")]
		[Address(RVA = "0xAC9680", Offset = "0xAC8280", VA = "0x180AC9680", Slot = "76")]
		protected override IEnumerator OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012DB9 RID: 77241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DB9")]
		[Address(RVA = "0xAC8DB0", Offset = "0xAC79B0", VA = "0x180AC8DB0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012DBA RID: 77242 RVA: 0x000737D0 File Offset: 0x000719D0
		[Token(Token = "0x6012DBA")]
		[Address(RVA = "0xAC9730", Offset = "0xAC8330", VA = "0x180AC9730", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x06012DBB RID: 77243 RVA: 0x000737E8 File Offset: 0x000719E8
		[Token(Token = "0x6012DBB")]
		[Address(RVA = "0xAC8D00", Offset = "0xAC7900", VA = "0x180AC8D00", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012DBC RID: 77244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DBC")]
		[Address(RVA = "0xAC9270", Offset = "0xAC7E70", VA = "0x180AC9270", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06012DBD RID: 77245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DBD")]
		[Address(RVA = "0xAC90F0", Offset = "0xAC7CF0", VA = "0x180AC90F0", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x06012DBE RID: 77246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DBE")]
		[Address(RVA = "0xAC9060", Offset = "0xAC7C60", VA = "0x180AC9060", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012DBF RID: 77247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DBF")]
		[Address(RVA = "0xAC8FF0", Offset = "0xAC7BF0", VA = "0x180AC8FF0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012DC0 RID: 77248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DC0")]
		[Address(RVA = "0xAC9FB0", Offset = "0xAC8BB0", VA = "0x180AC9FB0")]
		private void _StartJump()
		{
		}

		// Token: 0x06012DC1 RID: 77249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DC1")]
		[Address(RVA = "0xAC9A00", Offset = "0xAC8600", VA = "0x180AC9A00")]
		private void _DoJump(FP deltaTime)
		{
		}

		// Token: 0x06012DC2 RID: 77250 RVA: 0x00073800 File Offset: 0x00071A00
		[Token(Token = "0x6012DC2")]
		[Address(RVA = "0xAC9CB0", Offset = "0xAC88B0", VA = "0x180AC9CB0")]
		private bool _FilterWallLikeEntity(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x06012DC3 RID: 77251 RVA: 0x00073818 File Offset: 0x00071A18
		[Token(Token = "0x6012DC3")]
		[Address(RVA = "0xAC98E0", Offset = "0xAC84E0", VA = "0x180AC98E0")]
		private bool _CheckReached()
		{
			return default(bool);
		}

		// Token: 0x06012DC4 RID: 77252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DC4")]
		[Address(RVA = "0xAC9480", Offset = "0xAC8080", VA = "0x180AC9480")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x06012DC5 RID: 77253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DC5")]
		[Address(RVA = "0xACA3A0", Offset = "0xAC8FA0", VA = "0x180ACA3A0")]
		public PycjmpJumpAbility()
		{
		}

		// Token: 0x06012DC7 RID: 77255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012DC7")]
		[Address(RVA = "0xA4B060", Offset = "0xA49C60", VA = "0x180A4B060")]
		private IEnumerator <>xLuaBaseProxy_OnWaitForPostDelay()
		{
			return null;
		}

		// Token: 0x06012DC8 RID: 77256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DC8")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012DC9 RID: 77257 RVA: 0x00073848 File Offset: 0x00071A48
		[Token(Token = "0x6012DC9")]
		[Address(RVA = "0xA25D30", Offset = "0xA24930", VA = "0x180A25D30")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x06012DCA RID: 77258 RVA: 0x00073860 File Offset: 0x00071A60
		[Token(Token = "0x6012DCA")]
		[Address(RVA = "0xA25730", Offset = "0xA24330", VA = "0x180A25730")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012DCB RID: 77259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DCB")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012DCC RID: 77260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012DCC")]
		[Address(RVA = "0xA1E520", Offset = "0xA1D120", VA = "0x180A1E520")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x0401547B RID: 87163
		[Token(Token = "0x401547B")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private float _jumpDistance;

		// Token: 0x0401547C RID: 87164
		[Token(Token = "0x401547C")]
		[FieldOffset(Offset = "0x1CC")]
		[SerializeField]
		private float _jumpSpeed;

		// Token: 0x0401547D RID: 87165
		[Token(Token = "0x401547D")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private bool _checkReachTarget;

		// Token: 0x0401547E RID: 87166
		[Token(Token = "0x401547E")]
		[FieldOffset(Offset = "0x1D1")]
		[SerializeField]
		private bool _jumpBackFromTarget;

		// Token: 0x0401547F RID: 87167
		[Token(Token = "0x401547F")]
		[FieldOffset(Offset = "0x1D4")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox)]
		private TileTypesMask _invalidTileTypes;

		// Token: 0x04015480 RID: 87168
		[Token(Token = "0x4015480")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private bool _checkWallLikeEntity;

		// Token: 0x04015481 RID: 87169
		[Token(Token = "0x4015481")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		[Inspect("checkWallLikeEntity")]
		private List<string> _wallLikeEntityIds;

		// Token: 0x04015482 RID: 87170
		[Token(Token = "0x4015482")]
		[FieldOffset(Offset = "0x1E8")]
		private Vector2 m_jumpTargetPos;

		// Token: 0x04015483 RID: 87171
		[Token(Token = "0x4015483")]
		[FieldOffset(Offset = "0x1F0")]
		private Vector2 m_inputTargetPos;

		// Token: 0x04015484 RID: 87172
		[Token(Token = "0x4015484")]
		[FieldOffset(Offset = "0x1F8")]
		private float m_jumpDistance;

		// Token: 0x04015485 RID: 87173
		[Token(Token = "0x4015485")]
		[FieldOffset(Offset = "0x200")]
		private Collider2D m_collider;

		// Token: 0x04015486 RID: 87174
		[Token(Token = "0x4015486")]
		[FieldOffset(Offset = "0x208")]
		private bool m_isJumping;

		// Token: 0x04015487 RID: 87175
		[Token(Token = "0x4015487")]
		[FieldOffset(Offset = "0x20C")]
		private Vector2 m_JumpDirection;

		// Token: 0x04015488 RID: 87176
		[Token(Token = "0x4015488")]
		[FieldOffset(Offset = "0x214")]
		private PycjmpJumpAbility.JumpEndType m_lastJumpEndType;

		// Token: 0x04015489 RID: 87177
		[Token(Token = "0x4015489")]
		[FieldOffset(Offset = "0x218")]
		private Vector2 m_lastPos;

		// Token: 0x0401548A RID: 87178
		[Token(Token = "0x401548A")]
		[FieldOffset(Offset = "0x220")]
		private FP m_maxCastingTime;

		// Token: 0x0401548B RID: 87179
		[Token(Token = "0x401548B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lastJumpEndType;

		// Token: 0x0401548C RID: 87180
		[Token(Token = "0x401548C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_checkWallLikeEntity;

		// Token: 0x0401548D RID: 87181
		[Token(Token = "0x401548D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnWaitForPostDelay;

		// Token: 0x0401548E RID: 87182
		[Token(Token = "0x401548E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x0401548F RID: 87183
		[Token(Token = "0x401548F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04015490 RID: 87184
		[Token(Token = "0x4015490")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x04015491 RID: 87185
		[Token(Token = "0x4015491")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015492 RID: 87186
		[Token(Token = "0x4015492")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x04015493 RID: 87187
		[Token(Token = "0x4015493")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015494 RID: 87188
		[Token(Token = "0x4015494")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015495 RID: 87189
		[Token(Token = "0x4015495")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StartJump;

		// Token: 0x04015496 RID: 87190
		[Token(Token = "0x4015496")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoJump;

		// Token: 0x04015497 RID: 87191
		[Token(Token = "0x4015497")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__FilterWallLikeEntity;

		// Token: 0x04015498 RID: 87192
		[Token(Token = "0x4015498")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckReached;

		// Token: 0x04015499 RID: 87193
		[Token(Token = "0x4015499")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x0401549A RID: 87194
		[Token(Token = "0x401549A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002BAE RID: 11182
		[Token(Token = "0x2002BAE")]
		public enum JumpEndType
		{
			// Token: 0x0401549C RID: 87196
			[Token(Token = "0x401549C")]
			NONE,
			// Token: 0x0401549D RID: 87197
			[Token(Token = "0x401549D")]
			NORMAL,
			// Token: 0x0401549E RID: 87198
			[Token(Token = "0x401549E")]
			HIT_WALL
		}
	}
}
