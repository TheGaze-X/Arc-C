using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024B2 RID: 9394
	[Token(Token = "0x20024B2")]
	public class Mh2RidingHudPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x0600F19E RID: 61854 RVA: 0x00059028 File Offset: 0x00057228
		[Token(Token = "0x17001F6F")]
		public FP ridingCumulativeProgress
		{
			[Token(Token = "0x600F19E")]
			[Address(RVA = "0x690800", Offset = "0x68F400", VA = "0x180690800")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x0600F19F RID: 61855 RVA: 0x00059040 File Offset: 0x00057240
		[Token(Token = "0x17001F70")]
		public FP ridingProgress
		{
			[Token(Token = "0x600F19F")]
			[Address(RVA = "0x690930", Offset = "0x68F530", VA = "0x180690930")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x0600F1A0 RID: 61856 RVA: 0x00059058 File Offset: 0x00057258
		[Token(Token = "0x17001F71")]
		public bool isRiding
		{
			[Token(Token = "0x600F1A0")]
			[Address(RVA = "0x690680", Offset = "0x68F280", VA = "0x180690680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x0600F1A1 RID: 61857 RVA: 0x00059070 File Offset: 0x00057270
		[Token(Token = "0x17001F72")]
		public bool isRidingUsedUp
		{
			[Token(Token = "0x600F1A1")]
			[Address(RVA = "0x6905F0", Offset = "0x68F1F0", VA = "0x1806905F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x0600F1A2 RID: 61858 RVA: 0x00059088 File Offset: 0x00057288
		[Token(Token = "0x17001F73")]
		public bool isTimeLimited
		{
			[Token(Token = "0x600F1A2")]
			[Address(RVA = "0x690750", Offset = "0x68F350", VA = "0x180690750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x0600F1A3 RID: 61859 RVA: 0x000590A0 File Offset: 0x000572A0
		[Token(Token = "0x17001F74")]
		public Vector2 hudOffset
		{
			[Token(Token = "0x600F1A3")]
			[Address(RVA = "0x6904E0", Offset = "0x68F0E0", VA = "0x1806904E0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x0600F1A4 RID: 61860 RVA: 0x000590B8 File Offset: 0x000572B8
		[Token(Token = "0x17001F75")]
		public bool isCumulatingValid
		{
			[Token(Token = "0x600F1A4")]
			[Address(RVA = "0x690570", Offset = "0x68F170", VA = "0x180690570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F1A5 RID: 61861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1A5")]
		[Address(RVA = "0x68F4B0", Offset = "0x68E0B0", VA = "0x18068F4B0", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F1A6 RID: 61862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1A6")]
		[Address(RVA = "0x68F830", Offset = "0x68E430", VA = "0x18068F830", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F1A7 RID: 61863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1A7")]
		[Address(RVA = "0x68F950", Offset = "0x68E550", VA = "0x18068F950", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F1A8 RID: 61864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1A8")]
		[Address(RVA = "0x68FCF0", Offset = "0x68E8F0", VA = "0x18068FCF0", Slot = "31")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x0600F1A9 RID: 61865 RVA: 0x000590D0 File Offset: 0x000572D0
		[Token(Token = "0x17001F76")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F1A9")]
			[Address(RVA = "0x690A20", Offset = "0x68F620", VA = "0x180690A20", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F1AA RID: 61866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F1AA")]
		[Address(RVA = "0x68FDA0", Offset = "0x68E9A0", VA = "0x18068FDA0", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F1AB RID: 61867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1AB")]
		[Address(RVA = "0x68FC00", Offset = "0x68E800", VA = "0x18068FC00")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600F1AC RID: 61868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1AC")]
		[Address(RVA = "0x68F2B0", Offset = "0x68DEB0", VA = "0x18068F2B0")]
		public void AddRidingValue(FP value)
		{
		}

		// Token: 0x0600F1AD RID: 61869 RVA: 0x000590E8 File Offset: 0x000572E8
		[Token(Token = "0x600F1AD")]
		[Address(RVA = "0x68FF90", Offset = "0x68EB90", VA = "0x18068FF90")]
		public bool TriggerRiding()
		{
			return default(bool);
		}

		// Token: 0x0600F1AE RID: 61870 RVA: 0x00059100 File Offset: 0x00057300
		[Token(Token = "0x600F1AE")]
		[Address(RVA = "0x68FA90", Offset = "0x68E690", VA = "0x18068FA90")]
		public bool FinishRiding()
		{
			return default(bool);
		}

		// Token: 0x0600F1AF RID: 61871 RVA: 0x00059118 File Offset: 0x00057318
		[Token(Token = "0x600F1AF")]
		[Address(RVA = "0x68FEB0", Offset = "0x68EAB0", VA = "0x18068FEB0")]
		public bool SetRidingCumulatingValid(bool isValid)
		{
			return default(bool);
		}

		// Token: 0x0600F1B0 RID: 61872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B0")]
		[Address(RVA = "0x690190", Offset = "0x68ED90", VA = "0x180690190")]
		private void _OnRidingReady()
		{
		}

		// Token: 0x0600F1B1 RID: 61873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B1")]
		[Address(RVA = "0x6900C0", Offset = "0x68ECC0", VA = "0x1806900C0")]
		private void _OnHudCreated(object arg)
		{
		}

		// Token: 0x0600F1B2 RID: 61874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B2")]
		[Address(RVA = "0x6903F0", Offset = "0x68EFF0", VA = "0x1806903F0")]
		public Mh2RidingHudPluginTalent()
		{
		}

		// Token: 0x0600F1B4 RID: 61876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B4")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x0600F1B5 RID: 61877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B5")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B6")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F1B7 RID: 61879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F1B7")]
		[Address(RVA = "0x6900B0", Offset = "0x68ECB0", VA = "0x1806900B0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04010B56 RID: 68438
		[Token(Token = "0x4010B56")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 DEFAULT_HUD_OFFSET;

		// Token: 0x04010B57 RID: 68439
		[Token(Token = "0x4010B57")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 BOSS_HUD_OFFSET;

		// Token: 0x04010B58 RID: 68440
		[Token(Token = "0x4010B58")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BuffData[] _ridingBuffData;

		// Token: 0x04010B59 RID: 68441
		[Token(Token = "0x4010B59")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _maxRidingCount;

		// Token: 0x04010B5A RID: 68442
		[Token(Token = "0x4010B5A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _ridingDuration;

		// Token: 0x04010B5B RID: 68443
		[Token(Token = "0x4010B5B")]
		[FieldOffset(Offset = "0x80")]
		private FP m_ridingValue;

		// Token: 0x04010B5C RID: 68444
		[Token(Token = "0x4010B5C")]
		[FieldOffset(Offset = "0x88")]
		private FP m_maxRidingValue;

		// Token: 0x04010B5D RID: 68445
		[Token(Token = "0x4010B5D")]
		[FieldOffset(Offset = "0x90")]
		private int m_ridingCount;

		// Token: 0x04010B5E RID: 68446
		[Token(Token = "0x4010B5E")]
		[FieldOffset(Offset = "0x98")]
		private ObjectPtr<Buff> m_ridingCtrlBuff;

		// Token: 0x04010B5F RID: 68447
		[Token(Token = "0x4010B5F")]
		[FieldOffset(Offset = "0xA8")]
		private FP m_ridingDuration;

		// Token: 0x04010B60 RID: 68448
		[Token(Token = "0x4010B60")]
		[FieldOffset(Offset = "0xB0")]
		private PeriodicTimer m_ridingTimer;

		// Token: 0x04010B61 RID: 68449
		[Token(Token = "0x4010B61")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 m_hudOffset;

		// Token: 0x04010B62 RID: 68450
		[Token(Token = "0x4010B62")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isValid;

		// Token: 0x04010B63 RID: 68451
		[Token(Token = "0x4010B63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ridingCumulativeProgress;

		// Token: 0x04010B64 RID: 68452
		[Token(Token = "0x4010B64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_ridingProgress;

		// Token: 0x04010B65 RID: 68453
		[Token(Token = "0x4010B65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isRiding;

		// Token: 0x04010B66 RID: 68454
		[Token(Token = "0x4010B66")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isRidingUsedUp;

		// Token: 0x04010B67 RID: 68455
		[Token(Token = "0x4010B67")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isTimeLimited;

		// Token: 0x04010B68 RID: 68456
		[Token(Token = "0x4010B68")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hudOffset;

		// Token: 0x04010B69 RID: 68457
		[Token(Token = "0x4010B69")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isCumulatingValid;

		// Token: 0x04010B6A RID: 68458
		[Token(Token = "0x4010B6A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010B6B RID: 68459
		[Token(Token = "0x4010B6B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B6C RID: 68460
		[Token(Token = "0x4010B6C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B6D RID: 68461
		[Token(Token = "0x4010B6D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04010B6E RID: 68462
		[Token(Token = "0x4010B6E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B6F RID: 68463
		[Token(Token = "0x4010B6F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B70 RID: 68464
		[Token(Token = "0x4010B70")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04010B71 RID: 68465
		[Token(Token = "0x4010B71")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_AddRidingValue;

		// Token: 0x04010B72 RID: 68466
		[Token(Token = "0x4010B72")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TriggerRiding;

		// Token: 0x04010B73 RID: 68467
		[Token(Token = "0x4010B73")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FinishRiding;

		// Token: 0x04010B74 RID: 68468
		[Token(Token = "0x4010B74")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SetRidingCumulatingValid;

		// Token: 0x04010B75 RID: 68469
		[Token(Token = "0x4010B75")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnRidingReady;

		// Token: 0x04010B76 RID: 68470
		[Token(Token = "0x4010B76")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnHudCreated;

		// Token: 0x04010B77 RID: 68471
		[Token(Token = "0x4010B77")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
