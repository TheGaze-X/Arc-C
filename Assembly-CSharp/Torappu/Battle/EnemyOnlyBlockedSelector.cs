using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200250D RID: 9485
	[Token(Token = "0x200250D")]
	public class EnemyOnlyBlockedSelector : TargetSelector
	{
		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x0600F463 RID: 62563 RVA: 0x0005A408 File Offset: 0x00058608
		[Token(Token = "0x17001FE1")]
		protected virtual bool ignoreTargetFree
		{
			[Token(Token = "0x600F463")]
			[Address(RVA = "0x6BD3A0", Offset = "0x6BBFA0", VA = "0x1806BD3A0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x0600F464 RID: 62564 RVA: 0x0005A420 File Offset: 0x00058620
		[Token(Token = "0x17001FE2")]
		protected virtual bool ignoreAllyTargetFree
		{
			[Token(Token = "0x600F464")]
			[Address(RVA = "0x6BD2E0", Offset = "0x6BBEE0", VA = "0x1806BD2E0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x0600F465 RID: 62565 RVA: 0x0005A438 File Offset: 0x00058638
		[Token(Token = "0x17001FE3")]
		protected virtual bool ignoreHealFree
		{
			[Token(Token = "0x600F465")]
			[Address(RVA = "0x6BD340", Offset = "0x6BBF40", VA = "0x1806BD340", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x0600F466 RID: 62566 RVA: 0x0005A450 File Offset: 0x00058650
		[Token(Token = "0x17001FE4")]
		protected virtual bool onlyIgnoreSomeOfTargetFreeCase
		{
			[Token(Token = "0x600F466")]
			[Address(RVA = "0x6BD400", Offset = "0x6BC000", VA = "0x1806BD400", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x0600F467 RID: 62567 RVA: 0x0005A468 File Offset: 0x00058668
		[Token(Token = "0x17001FE5")]
		protected virtual AbnormalFlag abnormalFlag
		{
			[Token(Token = "0x600F467")]
			[Address(RVA = "0x6BD280", Offset = "0x6BBE80", VA = "0x1806BD280", Slot = "29")]
			get
			{
				return AbnormalFlag.STUNNED;
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x0600F468 RID: 62568 RVA: 0x0005A480 File Offset: 0x00058680
		[Token(Token = "0x17001FE6")]
		protected virtual AbnormalCombo abnormalCombo
		{
			[Token(Token = "0x600F468")]
			[Address(RVA = "0x6BD220", Offset = "0x6BBE20", VA = "0x1806BD220", Slot = "30")]
			get
			{
				return AbnormalCombo.SLEEPING;
			}
		}

		// Token: 0x0600F469 RID: 62569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F469")]
		[Address(RVA = "0x6BCF90", Offset = "0x6BBB90", VA = "0x1806BCF90", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F46A RID: 62570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F46A")]
		[Address(RVA = "0x6BCD50", Offset = "0x6BB950", VA = "0x1806BCD50", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F46B RID: 62571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F46B")]
		[Address(RVA = "0x6BCF20", Offset = "0x6BBB20", VA = "0x1806BCF20", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F46C RID: 62572 RVA: 0x0005A498 File Offset: 0x00058698
		[Token(Token = "0x600F46C")]
		[Address(RVA = "0x6BCC00", Offset = "0x6BB800", VA = "0x1806BCC00", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F46D RID: 62573 RVA: 0x0005A4B0 File Offset: 0x000586B0
		[Token(Token = "0x600F46D")]
		[Address(RVA = "0x6BD110", Offset = "0x6BBD10", VA = "0x1806BD110", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F46E RID: 62574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F46E")]
		[Address(RVA = "0x6BD1C0", Offset = "0x6BBDC0", VA = "0x1806BD1C0")]
		public EnemyOnlyBlockedSelector()
		{
		}

		// Token: 0x0600F46F RID: 62575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F46F")]
		[Address(RVA = "0x6B8B20", Offset = "0x6B7720", VA = "0x1806B8B20")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F470 RID: 62576 RVA: 0x0005A4C8 File Offset: 0x000586C8
		[Token(Token = "0x600F470")]
		[Address(RVA = "0x6A2DC0", Offset = "0x6A19C0", VA = "0x1806A2DC0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010EA3 RID: 69283
		[Token(Token = "0x4010EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool _filterById;

		// Token: 0x04010EA4 RID: 69284
		[Token(Token = "0x4010EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string _filterId;

		// Token: 0x04010EA5 RID: 69285
		[Token(Token = "0x4010EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Enemy m_enemy;

		// Token: 0x04010EA6 RID: 69286
		[Token(Token = "0x4010EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ignoreTargetFree;

		// Token: 0x04010EA7 RID: 69287
		[Token(Token = "0x4010EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_ignoreAllyTargetFree;

		// Token: 0x04010EA8 RID: 69288
		[Token(Token = "0x4010EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ignoreHealFree;

		// Token: 0x04010EA9 RID: 69289
		[Token(Token = "0x4010EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_onlyIgnoreSomeOfTargetFreeCase;

		// Token: 0x04010EAA RID: 69290
		[Token(Token = "0x4010EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_abnormalFlag;

		// Token: 0x04010EAB RID: 69291
		[Token(Token = "0x4010EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_abnormalCombo;

		// Token: 0x04010EAC RID: 69292
		[Token(Token = "0x4010EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010EAD RID: 69293
		[Token(Token = "0x4010EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010EAE RID: 69294
		[Token(Token = "0x4010EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010EAF RID: 69295
		[Token(Token = "0x4010EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010EB0 RID: 69296
		[Token(Token = "0x4010EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010EB1 RID: 69297
		[Token(Token = "0x4010EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
