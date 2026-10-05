using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.Activity.AutoChess;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200624D RID: 25165
	[Token(Token = "0x200624D")]
	public class AutoChessPreparePage : StateEnginePage, IDialogMgrHolder, IHotfixable
	{
		// Token: 0x170055AC RID: 21932
		// (get) Token: 0x06024544 RID: 148804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055AC")]
		public string actId
		{
			[Token(Token = "0x6024544")]
			[Address(RVA = "0x1F2E7D0", Offset = "0x1F2D3D0", VA = "0x181F2E7D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170055AD RID: 21933
		// (get) Token: 0x06024545 RID: 148805 RVA: 0x000C3D98 File Offset: 0x000C1F98
		[Token(Token = "0x170055AD")]
		public AutoChessPreparePage.Input inputData
		{
			[Token(Token = "0x6024545")]
			[Address(RVA = "0x1F2E890", Offset = "0x1F2D490", VA = "0x181F2E890")]
			get
			{
				return default(AutoChessPreparePage.Input);
			}
		}

		// Token: 0x170055AE RID: 21934
		// (get) Token: 0x06024546 RID: 148806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170055AE")]
		public AutoChessPrepareController controller
		{
			[Token(Token = "0x6024546")]
			[Address(RVA = "0x1F2E830", Offset = "0x1F2D430", VA = "0x181F2E830")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024547 RID: 148807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024547")]
		[Address(RVA = "0x1F2DED0", Offset = "0x1F2CAD0", VA = "0x181F2DED0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x06024548 RID: 148808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024548")]
		[Address(RVA = "0x1F2DF80", Offset = "0x1F2CB80", VA = "0x181F2DF80", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06024549 RID: 148809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024549")]
		[Address(RVA = "0x1F2E1D0", Offset = "0x1F2CDD0", VA = "0x181F2E1D0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602454A RID: 148810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602454A")]
		[Address(RVA = "0x1F2DE70", Offset = "0x1F2CA70", VA = "0x181F2DE70", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0602454B RID: 148811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602454B")]
		[Address(RVA = "0x1F2E160", Offset = "0x1F2CD60", VA = "0x181F2E160", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0602454C RID: 148812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602454C")]
		[Address(RVA = "0x1F2E5C0", Offset = "0x1F2D1C0", VA = "0x181F2E5C0")]
		private void _TriggerBGMSignal(string actId)
		{
		}

		// Token: 0x0602454D RID: 148813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602454D")]
		[Address(RVA = "0x1F2E520", Offset = "0x1F2D120", VA = "0x181F2E520")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0602454E RID: 148814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602454E")]
		[Address(RVA = "0x1F2E410", Offset = "0x1F2D010", VA = "0x181F2E410")]
		public static void SaveParamToBundle(AutoChessPreparePage.Params param, DataBundle targetBundle)
		{
		}

		// Token: 0x0602454F RID: 148815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602454F")]
		[Address(RVA = "0x1F2E770", Offset = "0x1F2D370", VA = "0x181F2E770")]
		public AutoChessPreparePage()
		{
		}

		// Token: 0x06024551 RID: 148817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024551")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06024552 RID: 148818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024552")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06024553 RID: 148819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024553")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06024554 RID: 148820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024554")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0403283F RID: 206911
		[Token(Token = "0x403283F")]
		public const string KEY_PARAM_BUNDLE = "key_auto_chess_param";

		// Token: 0x04032840 RID: 206912
		[Token(Token = "0x4032840")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04032841 RID: 206913
		[Token(Token = "0x4032841")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private AutoChessPrepareController _controller;

		// Token: 0x04032842 RID: 206914
		[Token(Token = "0x4032842")]
		[FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04032843 RID: 206915
		[Token(Token = "0x4032843")]
		[FieldOffset(Offset = "0x108")]
		private AutoChessPreparePage.Input m_inputData;

		// Token: 0x04032844 RID: 206916
		[Token(Token = "0x4032844")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04032845 RID: 206917
		[Token(Token = "0x4032845")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inputData;

		// Token: 0x04032846 RID: 206918
		[Token(Token = "0x4032846")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04032847 RID: 206919
		[Token(Token = "0x4032847")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04032848 RID: 206920
		[Token(Token = "0x4032848")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04032849 RID: 206921
		[Token(Token = "0x4032849")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403284A RID: 206922
		[Token(Token = "0x403284A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0403284B RID: 206923
		[Token(Token = "0x403284B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403284C RID: 206924
		[Token(Token = "0x403284C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x0403284D RID: 206925
		[Token(Token = "0x403284D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x0403284E RID: 206926
		[Token(Token = "0x403284E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveParamToBundle;

		// Token: 0x0403284F RID: 206927
		[Token(Token = "0x403284F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200624E RID: 25166
		[Token(Token = "0x200624E")]
		public class Params : ICustomPageParam, IHotfixable
		{
			// Token: 0x06024555 RID: 148821 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024555")]
			[Address(RVA = "0x1F35D90", Offset = "0x1F34990", VA = "0x181F35D90")]
			public string Serialize()
			{
				return null;
			}

			// Token: 0x06024556 RID: 148822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024556")]
			[Address(RVA = "0x1F35C40", Offset = "0x1F34840", VA = "0x181F35C40")]
			public static AutoChessPreparePage.Params Deserialize(string str)
			{
				return null;
			}

			// Token: 0x06024557 RID: 148823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024557")]
			[Address(RVA = "0x1F35E10", Offset = "0x1F34A10", VA = "0x181F35E10")]
			public Params()
			{
			}

			// Token: 0x04032850 RID: 206928
			[Token(Token = "0x4032850")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04032851 RID: 206929
			[Token(Token = "0x4032851")]
			[FieldOffset(Offset = "0x18")]
			public ActAutoChessModeType modeType;

			// Token: 0x04032852 RID: 206930
			[Token(Token = "0x4032852")]
			[FieldOffset(Offset = "0x1C")]
			public ActAutoChessMultiModeSubType multiModeSubType;

			// Token: 0x04032853 RID: 206931
			[Token(Token = "0x4032853")]
			[FieldOffset(Offset = "0x20")]
			public FromBattleSource fromBattleSource;

			// Token: 0x04032854 RID: 206932
			[Token(Token = "0x4032854")]
			[FieldOffset(Offset = "0x28")]
			public ActAutoChessSyncInfoBattleInfo battleInfo;

			// Token: 0x04032855 RID: 206933
			[Token(Token = "0x4032855")]
			[FieldOffset(Offset = "0x30")]
			public string teamCode;

			// Token: 0x04032856 RID: 206934
			[Token(Token = "0x4032856")]
			[FieldOffset(Offset = "0x38")]
			public TrainingModeSettleData trainingModeSettleData;

			// Token: 0x04032857 RID: 206935
			[Token(Token = "0x4032857")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Serialize;

			// Token: 0x04032858 RID: 206936
			[Token(Token = "0x4032858")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Deserialize;

			// Token: 0x04032859 RID: 206937
			[Token(Token = "0x4032859")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200624F RID: 25167
		[Token(Token = "0x200624F")]
		public struct Input
		{
			// Token: 0x0403285A RID: 206938
			[Token(Token = "0x403285A")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x0403285B RID: 206939
			[Token(Token = "0x403285B")]
			[FieldOffset(Offset = "0x8")]
			public ActAutoChessModeType modeType;

			// Token: 0x0403285C RID: 206940
			[Token(Token = "0x403285C")]
			[FieldOffset(Offset = "0xC")]
			public ActAutoChessMultiModeSubType multiModeSubType;

			// Token: 0x0403285D RID: 206941
			[Token(Token = "0x403285D")]
			[FieldOffset(Offset = "0x10")]
			public FromBattleSource fromBattleSource;

			// Token: 0x0403285E RID: 206942
			[Token(Token = "0x403285E")]
			[FieldOffset(Offset = "0x18")]
			public ActAutoChessSyncInfoBattleInfo battleInfo;

			// Token: 0x0403285F RID: 206943
			[Token(Token = "0x403285F")]
			[FieldOffset(Offset = "0x20")]
			public string teamCode;
		}
	}
}
