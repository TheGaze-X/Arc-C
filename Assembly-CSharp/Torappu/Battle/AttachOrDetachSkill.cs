using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002446 RID: 9286
	[Token(Token = "0x2002446")]
	public class AttachOrDetachSkill : BasicSkill
	{
		// Token: 0x0600ED78 RID: 60792 RVA: 0x00056CD0 File Offset: 0x00054ED0
		[Token(Token = "0x600ED78")]
		[Address(RVA = "0x635730", Offset = "0x634330", VA = "0x180635730", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x17001E8D RID: 7821
		// (get) Token: 0x0600ED79 RID: 60793 RVA: 0x00056CE8 File Offset: 0x00054EE8
		[Token(Token = "0x17001E8D")]
		public override bool isAffecting
		{
			[Token(Token = "0x600ED79")]
			[Address(RVA = "0x6362A0", Offset = "0x634EA0", VA = "0x1806362A0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E8E RID: 7822
		// (get) Token: 0x0600ED7A RID: 60794 RVA: 0x00056D00 File Offset: 0x00054F00
		[Token(Token = "0x17001E8E")]
		public override FP remainingTime
		{
			[Token(Token = "0x600ED7A")]
			[Address(RVA = "0x636450", Offset = "0x635050", VA = "0x180636450", Slot = "29")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001E8F RID: 7823
		// (get) Token: 0x0600ED7B RID: 60795 RVA: 0x00056D18 File Offset: 0x00054F18
		[Token(Token = "0x17001E8F")]
		public override FP remainingProgress
		{
			[Token(Token = "0x600ED7B")]
			[Address(RVA = "0x636350", Offset = "0x634F50", VA = "0x180636350", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600ED7C RID: 60796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7C")]
		[Address(RVA = "0x635A20", Offset = "0x634620", VA = "0x180635A20", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600ED7D RID: 60797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7D")]
		[Address(RVA = "0x635BF0", Offset = "0x6347F0", VA = "0x180635BF0", Slot = "61")]
		public override void OnOwnerFinish(Entity.FinishReason reason)
		{
		}

		// Token: 0x0600ED7E RID: 60798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED7E")]
		[Address(RVA = "0x6350B0", Offset = "0x633CB0", VA = "0x1806350B0", Slot = "48")]
		public override void AssignData(SkillData data, Character owner, Blackboard externalBlackboard, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600ED7F RID: 60799 RVA: 0x00056D30 File Offset: 0x00054F30
		[Token(Token = "0x600ED7F")]
		[Address(RVA = "0x6353F0", Offset = "0x633FF0", VA = "0x1806353F0", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600ED80 RID: 60800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED80")]
		[Address(RVA = "0x635800", Offset = "0x634400", VA = "0x180635800", Slot = "62")]
		protected override void OnCastSucceed()
		{
		}

		// Token: 0x0600ED81 RID: 60801 RVA: 0x00056D48 File Offset: 0x00054F48
		[Token(Token = "0x600ED81")]
		[Address(RVA = "0x636040", Offset = "0x634C40", VA = "0x180636040", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600ED82 RID: 60802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED82")]
		[Address(RVA = "0x635CA0", Offset = "0x6348A0", VA = "0x180635CA0", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600ED83 RID: 60803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED83")]
		[Address(RVA = "0x635360", Offset = "0x633F60", VA = "0x180635360", Slot = "77")]
		protected override void Awake()
		{
		}

		// Token: 0x0600ED84 RID: 60804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED84")]
		[Address(RVA = "0x6360F0", Offset = "0x634CF0", VA = "0x1806360F0")]
		private void _DetachSkill()
		{
		}

		// Token: 0x0600ED85 RID: 60805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED85")]
		[Address(RVA = "0x636240", Offset = "0x634E40", VA = "0x180636240")]
		public AttachOrDetachSkill()
		{
		}

		// Token: 0x0600ED86 RID: 60806 RVA: 0x00056D60 File Offset: 0x00054F60
		[Token(Token = "0x600ED86")]
		[Address(RVA = "0x634DF0", Offset = "0x6339F0", VA = "0x180634DF0")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600ED87 RID: 60807 RVA: 0x00056D78 File Offset: 0x00054F78
		[Token(Token = "0x600ED87")]
		[Address(RVA = "0x6346C0", Offset = "0x6332C0", VA = "0x1806346C0")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600ED88 RID: 60808 RVA: 0x00056D90 File Offset: 0x00054F90
		[Token(Token = "0x600ED88")]
		[Address(RVA = "0x635F10", Offset = "0x634B10", VA = "0x180635F10")]
		private FP <>xLuaBaseProxy_get_remainingTime()
		{
			return default(FP);
		}

		// Token: 0x0600ED89 RID: 60809 RVA: 0x00056DA8 File Offset: 0x00054FA8
		[Token(Token = "0x600ED89")]
		[Address(RVA = "0x6346D0", Offset = "0x6332D0", VA = "0x1806346D0")]
		private FP <>xLuaBaseProxy_get_remainingProgress()
		{
			return default(FP);
		}

		// Token: 0x0600ED8A RID: 60810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED8A")]
		[Address(RVA = "0x634E10", Offset = "0x633A10", VA = "0x180634E10")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600ED8B RID: 60811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED8B")]
		[Address(RVA = "0x635EF0", Offset = "0x634AF0", VA = "0x180635EF0")]
		private void <>xLuaBaseProxy_OnOwnerFinish(Entity.FinishReason P0)
		{
		}

		// Token: 0x0600ED8C RID: 60812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED8C")]
		[Address(RVA = "0x635EA0", Offset = "0x634AA0", VA = "0x180635EA0")]
		private void <>xLuaBaseProxy_AssignData(SkillData P0, Character P1, Blackboard P2, UnitDataFlowConfig.Delta P3)
		{
		}

		// Token: 0x0600ED8D RID: 60813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED8D")]
		[Address(RVA = "0x635EE0", Offset = "0x634AE0", VA = "0x180635EE0")]
		private void <>xLuaBaseProxy_OnCastSucceed()
		{
		}

		// Token: 0x0600ED8E RID: 60814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED8E")]
		[Address(RVA = "0x635F00", Offset = "0x634B00", VA = "0x180635F00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600ED8F RID: 60815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED8F")]
		[Address(RVA = "0x635ED0", Offset = "0x634AD0", VA = "0x180635ED0")]
		private void <>xLuaBaseProxy_Awake()
		{
		}

		// Token: 0x04010698 RID: 67224
		[Token(Token = "0x4010698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private bool _switchToState;

		// Token: 0x04010699 RID: 67225
		[Token(Token = "0x4010699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[SerializeField]
		private bool _isInfinity;

		// Token: 0x0401069A RID: 67226
		[Token(Token = "0x401069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Ability[] m_abilities;

		// Token: 0x0401069B RID: 67227
		[Token(Token = "0x401069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FP m_duration;

		// Token: 0x0401069C RID: 67228
		[Token(Token = "0x401069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private FP m_remainingTime;

		// Token: 0x0401069D RID: 67229
		[Token(Token = "0x401069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x0401069E RID: 67230
		[Token(Token = "0x401069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x0401069F RID: 67231
		[Token(Token = "0x401069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_remainingTime;

		// Token: 0x040106A0 RID: 67232
		[Token(Token = "0x40106A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x040106A1 RID: 67233
		[Token(Token = "0x40106A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040106A2 RID: 67234
		[Token(Token = "0x40106A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOwnerFinish;

		// Token: 0x040106A3 RID: 67235
		[Token(Token = "0x40106A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x040106A4 RID: 67236
		[Token(Token = "0x40106A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x040106A5 RID: 67237
		[Token(Token = "0x40106A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCastSucceed;

		// Token: 0x040106A6 RID: 67238
		[Token(Token = "0x40106A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x040106A7 RID: 67239
		[Token(Token = "0x40106A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040106A8 RID: 67240
		[Token(Token = "0x40106A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x040106A9 RID: 67241
		[Token(Token = "0x40106A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DetachSkill;

		// Token: 0x040106AA RID: 67242
		[Token(Token = "0x40106AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
