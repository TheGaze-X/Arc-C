using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003240 RID: 12864
	[Token(Token = "0x2003240")]
	public class PauseEffectIf : Effect.Behaviour, IHotfixable
	{
		// Token: 0x17003052 RID: 12370
		// (get) Token: 0x0601467E RID: 83582 RVA: 0x00086BC8 File Offset: 0x00084DC8
		[Token(Token = "0x17003052")]
		public bool checkAbnormalFlag
		{
			[Token(Token = "0x601467E")]
			[Address(RVA = "0xCAA570", Offset = "0xCA9170", VA = "0x180CAA570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003053 RID: 12371
		// (get) Token: 0x0601467F RID: 83583 RVA: 0x00086BE0 File Offset: 0x00084DE0
		[Token(Token = "0x17003053")]
		public bool checkAbnormalImmune
		{
			[Token(Token = "0x601467F")]
			[Address(RVA = "0xCAA5D0", Offset = "0xCA91D0", VA = "0x180CAA5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003054 RID: 12372
		// (get) Token: 0x06014680 RID: 83584 RVA: 0x00086BF8 File Offset: 0x00084DF8
		[Token(Token = "0x17003054")]
		public bool checkAbnormalCombo
		{
			[Token(Token = "0x6014680")]
			[Address(RVA = "0xCAA510", Offset = "0xCA9110", VA = "0x180CAA510")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003055 RID: 12373
		// (get) Token: 0x06014681 RID: 83585 RVA: 0x00086C10 File Offset: 0x00084E10
		[Token(Token = "0x17003055")]
		public bool checkContainBuff
		{
			[Token(Token = "0x6014681")]
			[Address(RVA = "0xCAA690", Offset = "0xCA9290", VA = "0x180CAA690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003056 RID: 12374
		// (get) Token: 0x06014682 RID: 83586 RVA: 0x00086C28 File Offset: 0x00084E28
		[Token(Token = "0x17003056")]
		public bool checkUnitModeIndex
		{
			[Token(Token = "0x6014682")]
			[Address(RVA = "0xCAA7B0", Offset = "0xCA93B0", VA = "0x180CAA7B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003057 RID: 12375
		// (get) Token: 0x06014683 RID: 83587 RVA: 0x00086C40 File Offset: 0x00084E40
		[Token(Token = "0x17003057")]
		public bool checkNotInAbnormalFlag
		{
			[Token(Token = "0x6014683")]
			[Address(RVA = "0xCAA6F0", Offset = "0xCA92F0", VA = "0x180CAA6F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003058 RID: 12376
		// (get) Token: 0x06014684 RID: 83588 RVA: 0x00086C58 File Offset: 0x00084E58
		[Token(Token = "0x17003058")]
		public bool checkCharacterSharedBlackboardKey
		{
			[Token(Token = "0x6014684")]
			[Address(RVA = "0xCAA630", Offset = "0xCA9230", VA = "0x180CAA630")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003059 RID: 12377
		// (get) Token: 0x06014685 RID: 83589 RVA: 0x00086C70 File Offset: 0x00084E70
		[Token(Token = "0x17003059")]
		public bool checkState
		{
			[Token(Token = "0x6014685")]
			[Address(RVA = "0xCAA750", Offset = "0xCA9350", VA = "0x180CAA750")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014686 RID: 83590 RVA: 0x00086C88 File Offset: 0x00084E88
		[Token(Token = "0x6014686")]
		[Address(RVA = "0xCAA2C0", Offset = "0xCA8EC0", VA = "0x180CAA2C0")]
		private bool? _CombinePauseFlag(bool? current, bool checkFlag)
		{
			return null;
		}

		// Token: 0x06014687 RID: 83591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014687")]
		[Address(RVA = "0xCA9C70", Offset = "0xCA8870", VA = "0x180CA9C70", Slot = "4")]
		public override void Init(Effect effect)
		{
		}

		// Token: 0x06014688 RID: 83592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014688")]
		[Address(RVA = "0xCA9D70", Offset = "0xCA8970", VA = "0x180CA9D70", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014689 RID: 83593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014689")]
		[Address(RVA = "0xCA9DE0", Offset = "0xCA89E0", VA = "0x180CA9DE0")]
		private void Update()
		{
		}

		// Token: 0x0601468A RID: 83594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601468A")]
		[Address(RVA = "0xCAA0E0", Offset = "0xCA8CE0", VA = "0x180CAA0E0")]
		private void _CheckPause()
		{
		}

		// Token: 0x0601468B RID: 83595 RVA: 0x00086CA0 File Offset: 0x00084EA0
		[Token(Token = "0x601468B")]
		[Address(RVA = "0xCA9330", Offset = "0xCA7F30", VA = "0x180CA9330", Slot = "10")]
		protected virtual bool? GetCheckResult()
		{
			return null;
		}

		// Token: 0x0601468C RID: 83596 RVA: 0x00086CB8 File Offset: 0x00084EB8
		[Token(Token = "0x601468C")]
		[Address(RVA = "0xCAA030", Offset = "0xCA8C30", VA = "0x180CAA030")]
		private bool _CheckPauseIfFlag(PauseEffectIf.CheckType checkType, bool flag)
		{
			return default(bool);
		}

		// Token: 0x0601468D RID: 83597 RVA: 0x00086CD0 File Offset: 0x00084ED0
		[Token(Token = "0x601468D")]
		[Address(RVA = "0xCA9E40", Offset = "0xCA8A40", VA = "0x180CA9E40")]
		private bool _CheckContainBuffList()
		{
			return default(bool);
		}

		// Token: 0x0601468E RID: 83598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601468E")]
		[Address(RVA = "0xCAA3E0", Offset = "0xCA8FE0", VA = "0x180CAA3E0")]
		public PauseEffectIf()
		{
		}

		// Token: 0x0601468F RID: 83599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601468F")]
		[Address(RVA = "0xC9CCD0", Offset = "0xC9B8D0", VA = "0x180C9CCD0")]
		private void <>xLuaBaseProxy_Init(Effect P0)
		{
		}

		// Token: 0x06014690 RID: 83600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014690")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018177 RID: 98679
		[Token(Token = "0x4018177")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _checkOnPlay;

		// Token: 0x04018178 RID: 98680
		[Token(Token = "0x4018178")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _requireAllConditions;

		// Token: 0x04018179 RID: 98681
		[Token(Token = "0x4018179")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool _checkAbnormalFlag;

		// Token: 0x0401817A RID: 98682
		[Token(Token = "0x401817A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("checkAbnormalFlag")]
		private AbnormalFlag _pauseWhenAbnormalFlag;

		// Token: 0x0401817B RID: 98683
		[Token(Token = "0x401817B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("checkAbnormalFlag")]
		private List<AbnormalFlag> _pauseWhenAbnormalFlags;

		// Token: 0x0401817C RID: 98684
		[Token(Token = "0x401817C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _checkAbnormalImmune;

		// Token: 0x0401817D RID: 98685
		[Token(Token = "0x401817D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Inspect("checkAbnormalImmune")]
		private AbnormalFlag _pauseWhenAbnormalImmune;

		// Token: 0x0401817E RID: 98686
		[Token(Token = "0x401817E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkAbnormalCombo;

		// Token: 0x0401817F RID: 98687
		[Token(Token = "0x401817F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Inspect("checkAbnormalCombo")]
		private AbnormalCombo _pauseWhenAbnormalCombo;

		// Token: 0x04018180 RID: 98688
		[Token(Token = "0x4018180")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkUnitModeIndex;

		// Token: 0x04018181 RID: 98689
		[Token(Token = "0x4018181")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Inspect("checkUnitModeIndex")]
		private List<int> _pauseWhenModeIndexList;

		// Token: 0x04018182 RID: 98690
		[Token(Token = "0x4018182")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkContainBuff;

		// Token: 0x04018183 RID: 98691
		[Token(Token = "0x4018183")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Inspect("checkContainBuff")]
		private string _pauseWhenContainBuffKey;

		// Token: 0x04018184 RID: 98692
		[Token(Token = "0x4018184")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Inspect("checkContainBuff")]
		private List<string> _pauseWhenContainBuffKeyList;

		// Token: 0x04018185 RID: 98693
		[Token(Token = "0x4018185")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkCharacterSharedBlackboardKey;

		// Token: 0x04018186 RID: 98694
		[Token(Token = "0x4018186")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Inspect("checkCharacterSharedBlackboardKey")]
		private List<string> _characterSharedBlackboardKeyList;

		// Token: 0x04018187 RID: 98695
		[Token(Token = "0x4018187")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkFaceToBack;

		// Token: 0x04018188 RID: 98696
		[Token(Token = "0x4018188")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkFaceToRight;

		// Token: 0x04018189 RID: 98697
		[Token(Token = "0x4018189")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _disableMeshRendererWhenPause;

		// Token: 0x0401818A RID: 98698
		[Token(Token = "0x401818A")]
		[FieldOffset(Offset = "0x81")]
		[SerializeField]
		private bool _checkDisappear;

		// Token: 0x0401818B RID: 98699
		[Token(Token = "0x401818B")]
		[FieldOffset(Offset = "0x82")]
		[SerializeField]
		private bool _checkNotInAbnormalFlag;

		// Token: 0x0401818C RID: 98700
		[Token(Token = "0x401818C")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Inspect("checkNotInAbnormalFlag")]
		private AbnormalFlag _pauseWhenNotInAbnormalFlag;

		// Token: 0x0401818D RID: 98701
		[Token(Token = "0x401818D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PauseEffectIf.CheckType _checkState;

		// Token: 0x0401818E RID: 98702
		[Token(Token = "0x401818E")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Inspect("checkState")]
		private Character.States.State _pauseWhenCharState;

		// Token: 0x0401818F RID: 98703
		[Token(Token = "0x401818F")]
		[FieldOffset(Offset = "0x90")]
		private List<MeshRenderer> m_meshRenderers;

		// Token: 0x04018190 RID: 98704
		[Token(Token = "0x4018190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkAbnormalFlag;

		// Token: 0x04018191 RID: 98705
		[Token(Token = "0x4018191")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_checkAbnormalImmune;

		// Token: 0x04018192 RID: 98706
		[Token(Token = "0x4018192")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_checkAbnormalCombo;

		// Token: 0x04018193 RID: 98707
		[Token(Token = "0x4018193")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_checkContainBuff;

		// Token: 0x04018194 RID: 98708
		[Token(Token = "0x4018194")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_checkUnitModeIndex;

		// Token: 0x04018195 RID: 98709
		[Token(Token = "0x4018195")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_checkNotInAbnormalFlag;

		// Token: 0x04018196 RID: 98710
		[Token(Token = "0x4018196")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_checkCharacterSharedBlackboardKey;

		// Token: 0x04018197 RID: 98711
		[Token(Token = "0x4018197")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_checkState;

		// Token: 0x04018198 RID: 98712
		[Token(Token = "0x4018198")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CombinePauseFlag;

		// Token: 0x04018199 RID: 98713
		[Token(Token = "0x4018199")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401819A RID: 98714
		[Token(Token = "0x401819A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401819B RID: 98715
		[Token(Token = "0x401819B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401819C RID: 98716
		[Token(Token = "0x401819C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckPause;

		// Token: 0x0401819D RID: 98717
		[Token(Token = "0x401819D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCheckResult;

		// Token: 0x0401819E RID: 98718
		[Token(Token = "0x401819E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckPauseIfFlag;

		// Token: 0x0401819F RID: 98719
		[Token(Token = "0x401819F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckContainBuffList;

		// Token: 0x040181A0 RID: 98720
		[Token(Token = "0x40181A0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003241 RID: 12865
		[Token(Token = "0x2003241")]
		public enum CheckType
		{
			// Token: 0x040181A2 RID: 98722
			[Token(Token = "0x40181A2")]
			NOT_CHECK,
			// Token: 0x040181A3 RID: 98723
			[Token(Token = "0x40181A3")]
			CHECK_YES,
			// Token: 0x040181A4 RID: 98724
			[Token(Token = "0x40181A4")]
			CHECK_NO
		}
	}
}
