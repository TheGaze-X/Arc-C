using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EF3 RID: 24307
	[Token(Token = "0x2005EF3")]
	public class CharacterSpOpLvlupHomeState : State, IValueMsgReceiver
	{
		// Token: 0x06023380 RID: 144256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023380")]
		[Address(RVA = "0x1DCD120", Offset = "0x1DCBD20", VA = "0x181DCD120", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023381 RID: 144257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023381")]
		[Address(RVA = "0x1DCD180", Offset = "0x1DCBD80", VA = "0x181DCD180", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023382 RID: 144258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023382")]
		[Address(RVA = "0x1DCD370", Offset = "0x1DCBF70", VA = "0x181DCD370", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06023383 RID: 144259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023383")]
		[Address(RVA = "0x1DCD950", Offset = "0x1DCC550", VA = "0x181DCD950")]
		private void _OnTargetModeClick()
		{
		}

		// Token: 0x06023384 RID: 144260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023384")]
		[Address(RVA = "0x1DCD890", Offset = "0x1DCC490", VA = "0x181DCD890")]
		public void _OnSpOpMissionClick()
		{
		}

		// Token: 0x06023385 RID: 144261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023385")]
		[Address(RVA = "0x1DCD580", Offset = "0x1DCC180", VA = "0x181DCD580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023386 RID: 144262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023386")]
		[Address(RVA = "0x1DCD760", Offset = "0x1DCC360", VA = "0x181DCD760")]
		private void _OnInitTopMenu(GameObject inst)
		{
		}

		// Token: 0x06023387 RID: 144263 RVA: 0x000C0228 File Offset: 0x000BE428
		[Token(Token = "0x6023387")]
		[Address(RVA = "0x1DCD6C0", Offset = "0x1DCC2C0", VA = "0x181DCD6C0")]
		private bool _IsStateEngineStable()
		{
			return default(bool);
		}

		// Token: 0x06023388 RID: 144264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023388")]
		[Address(RVA = "0x1DCDA10", Offset = "0x1DCC610", VA = "0x181DCDA10")]
		public CharacterSpOpLvlupHomeState()
		{
		}

		// Token: 0x0602338A RID: 144266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602338A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403086C RID: 198764
		[Token(Token = "0x403086C")]
		[NonSerialized]
		public const int ON_TARGET_MODE_CLICKED = 1;

		// Token: 0x0403086D RID: 198765
		[Token(Token = "0x403086D")]
		[NonSerialized]
		public const int ON_SPOP_MISSION_CLICKED = 2;

		// Token: 0x0403086E RID: 198766
		[Token(Token = "0x403086E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0403086F RID: 198767
		[Token(Token = "0x403086F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterLvlupSpOpHomeView _view;

		// Token: 0x04030870 RID: 198768
		[Token(Token = "0x4030870")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CharacterInfoIllustController _illustController;

		// Token: 0x04030871 RID: 198769
		[Token(Token = "0x4030871")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x04030872 RID: 198770
		[Token(Token = "0x4030872")]
		[FieldOffset(Offset = "0x70")]
		private CharacterLvlupSpOpStateBean m_stateBean;

		// Token: 0x04030873 RID: 198771
		[Token(Token = "0x4030873")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030874 RID: 198772
		[Token(Token = "0x4030874")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030875 RID: 198773
		[Token(Token = "0x4030875")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04030876 RID: 198774
		[Token(Token = "0x4030876")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnTargetModeClick;

		// Token: 0x04030877 RID: 198775
		[Token(Token = "0x4030877")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSpOpMissionClick;

		// Token: 0x04030878 RID: 198776
		[Token(Token = "0x4030878")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030879 RID: 198777
		[Token(Token = "0x4030879")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0403087A RID: 198778
		[Token(Token = "0x403087A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsStateEngineStable;

		// Token: 0x0403087B RID: 198779
		[Token(Token = "0x403087B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
