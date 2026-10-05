using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B3 RID: 9395
	[Token(Token = "0x20024B3")]
	public class MhPartHpHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x0600F1B8 RID: 61880 RVA: 0x00059130 File Offset: 0x00057330
		[Token(Token = "0x17001F77")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F1B8")]
			[Address(RVA = "0x6921D0", Offset = "0x690DD0", VA = "0x1806921D0", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x0600F1B9 RID: 61881 RVA: 0x00059148 File Offset: 0x00057348
		[Token(Token = "0x17001F78")]
		public FP partHpRatio
		{
			[Token(Token = "0x600F1B9")]
			[Address(RVA = "0x692130", Offset = "0x690D30", VA = "0x180692130")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x0600F1BA RID: 61882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F79")]
		public int[] validModeIndices
		{
			[Token(Token = "0x600F1BA")]
			[Address(RVA = "0x692230", Offset = "0x690E30", VA = "0x180692230")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F1BB RID: 61883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F1BB")]
		[Address(RVA = "0x691170", Offset = "0x68FD70", VA = "0x180691170", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F1BC RID: 61884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1BC")]
		[Address(RVA = "0x690A90", Offset = "0x68F690", VA = "0x180690A90", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F1BD RID: 61885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1BD")]
		[Address(RVA = "0x690CD0", Offset = "0x68F8D0", VA = "0x180690CD0", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1BE")]
		[Address(RVA = "0x690EE0", Offset = "0x68FAE0", VA = "0x180690EE0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1BF")]
		[Address(RVA = "0x6910D0", Offset = "0x68FCD0", VA = "0x1806910D0", Slot = "31")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C0")]
		[Address(RVA = "0x691500", Offset = "0x690100", VA = "0x180691500")]
		private void _OnApplyedModifier(object arg)
		{
		}

		// Token: 0x0600F1C1 RID: 61889 RVA: 0x00059160 File Offset: 0x00057360
		[Token(Token = "0x600F1C1")]
		[Address(RVA = "0x691270", Offset = "0x68FE70", VA = "0x180691270")]
		private bool _CheckDirection(Vector2 mapDir)
		{
			return default(bool);
		}

		// Token: 0x0600F1C2 RID: 61890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C2")]
		[Address(RVA = "0x691DB0", Offset = "0x6909B0", VA = "0x180691DB0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F1C3 RID: 61891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C3")]
		[Address(RVA = "0x691EE0", Offset = "0x690AE0", VA = "0x180691EE0")]
		private void _OnPartHpZero()
		{
		}

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x00059178 File Offset: 0x00057378
		[Token(Token = "0x600F1C4")]
		[Address(RVA = "0x6913B0", Offset = "0x68FFB0", VA = "0x1806913B0")]
		private bool _CheckOwnerValidMode()
		{
			return default(bool);
		}

		// Token: 0x0600F1C5 RID: 61893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C5")]
		[Address(RVA = "0x692080", Offset = "0x690C80", VA = "0x180692080")]
		public MhPartHpHudPluginTalent()
		{
		}

		// Token: 0x0600F1C6 RID: 61894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C6")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F1C7 RID: 61895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C7")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F1C8 RID: 61896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C8")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F1C9 RID: 61897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1C9")]
		[Address(RVA = "0x6900B0", Offset = "0x68ECB0", VA = "0x1806900B0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04010B78 RID: 68472
		[Token(Token = "0x4010B78")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("UI Plugin")]
		private float _hpRatio;

		// Token: 0x04010B79 RID: 68473
		[Token(Token = "0x4010B79")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("UI Plugin")]
		private BuffData[] _buffsToTirgger;

		// Token: 0x04010B7A RID: 68474
		[Token(Token = "0x4010B7A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("UI Plugin")]
		private int[] _validModeIndices;

		// Token: 0x04010B7B RID: 68475
		[Token(Token = "0x4010B7B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("UI Plugin")]
		private MhPartHpHudPluginTalent.FacePosition _facePosition;

		// Token: 0x04010B7C RID: 68476
		[Token(Token = "0x4010B7C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("UI Plugin")]
		private string _logKey;

		// Token: 0x04010B7D RID: 68477
		[Token(Token = "0x4010B7D")]
		[FieldOffset(Offset = "0x90")]
		private FP m_partMaxHpRatio;

		// Token: 0x04010B7E RID: 68478
		[Token(Token = "0x4010B7E")]
		[FieldOffset(Offset = "0x98")]
		private FP m_maxPartHp;

		// Token: 0x04010B7F RID: 68479
		[Token(Token = "0x4010B7F")]
		[FieldOffset(Offset = "0xA0")]
		private FP m_partHp;

		// Token: 0x04010B80 RID: 68480
		[Token(Token = "0x4010B80")]
		[FieldOffset(Offset = "0xA8")]
		private string m_extraBattleLogKey;

		// Token: 0x04010B81 RID: 68481
		[Token(Token = "0x4010B81")]
		[FieldOffset(Offset = "0xB0")]
		private List<uint> m_buffUids;

		// Token: 0x04010B82 RID: 68482
		[Token(Token = "0x4010B82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B83 RID: 68483
		[Token(Token = "0x4010B83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_partHpRatio;

		// Token: 0x04010B84 RID: 68484
		[Token(Token = "0x4010B84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_validModeIndices;

		// Token: 0x04010B85 RID: 68485
		[Token(Token = "0x4010B85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B86 RID: 68486
		[Token(Token = "0x4010B86")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010B87 RID: 68487
		[Token(Token = "0x4010B87")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B88 RID: 68488
		[Token(Token = "0x4010B88")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B89 RID: 68489
		[Token(Token = "0x4010B89")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04010B8A RID: 68490
		[Token(Token = "0x4010B8A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnApplyedModifier;

		// Token: 0x04010B8B RID: 68491
		[Token(Token = "0x4010B8B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckDirection;

		// Token: 0x04010B8C RID: 68492
		[Token(Token = "0x4010B8C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B8D RID: 68493
		[Token(Token = "0x4010B8D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnPartHpZero;

		// Token: 0x04010B8E RID: 68494
		[Token(Token = "0x4010B8E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckOwnerValidMode;

		// Token: 0x04010B8F RID: 68495
		[Token(Token = "0x4010B8F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024B4 RID: 9396
		[Token(Token = "0x20024B4")]
		private enum FacePosition
		{
			// Token: 0x04010B91 RID: 68497
			[Token(Token = "0x4010B91")]
			BACK = -1,
			// Token: 0x04010B92 RID: 68498
			[Token(Token = "0x4010B92")]
			FRONT = 1
		}
	}
}
