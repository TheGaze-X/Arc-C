using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E70 RID: 15984
	[Token(Token = "0x2003E70")]
	public class SpecialOperatorBoardLvlupMasterDetailView : SpecialOperatorBoardLvlupDetailView<SpecialOperatorBoardMasterNode>
	{
		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x06018D8E RID: 101774 RVA: 0x0009C2E8 File Offset: 0x0009A4E8
		[Token(Token = "0x17003B4F")]
		public override SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018D8E")]
			[Address(RVA = "0x118D3A0", Offset = "0x118BFA0", VA = "0x18118D3A0", Slot = "4")]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
		}

		// Token: 0x06018D8F RID: 101775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D8F")]
		[Address(RVA = "0x118CB40", Offset = "0x118B740", VA = "0x18118CB40", Slot = "5")]
		public override void SetViewShow(bool isShow)
		{
		}

		// Token: 0x06018D90 RID: 101776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D90")]
		[Address(RVA = "0x118C7C0", Offset = "0x118B3C0", VA = "0x18118C7C0", Slot = "7")]
		public override void Render(SpecialOperatorBoardMasterNode viewModel, bool fastMode)
		{
		}

		// Token: 0x06018D91 RID: 101777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D91")]
		[Address(RVA = "0x118CCF0", Offset = "0x118B8F0", VA = "0x18118CCF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018D92 RID: 101778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D92")]
		[Address(RVA = "0x118CE10", Offset = "0x118BA10", VA = "0x18118CE10")]
		private void _RenderDetail(SpecialOperatorBoardMasterNode viewModel, SpecialOperatorBoardLvlupMasterDetailView.RenderState renderState)
		{
		}

		// Token: 0x06018D93 RID: 101779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D93")]
		[Address(RVA = "0x118D210", Offset = "0x118BE10", VA = "0x18118D210")]
		private void _SetAnim(SpecialOperatorBoardLvlupMasterDetailView.RenderState renderState, bool fastMode)
		{
		}

		// Token: 0x06018D94 RID: 101780 RVA: 0x0009C300 File Offset: 0x0009A500
		[Token(Token = "0x6018D94")]
		[Address(RVA = "0x118CBC0", Offset = "0x118B7C0", VA = "0x18118CBC0")]
		private SpecialOperatorBoardLvlupMasterDetailView.RenderState _GetRenderState(SpecialOperatorBoardMasterNode masterModel)
		{
			return SpecialOperatorBoardLvlupMasterDetailView.RenderState.LOCK;
		}

		// Token: 0x06018D95 RID: 101781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D95")]
		[Address(RVA = "0x118D330", Offset = "0x118BF30", VA = "0x18118D330")]
		public SpecialOperatorBoardLvlupMasterDetailView()
		{
		}

		// Token: 0x0401E92E RID: 125230
		[Token(Token = "0x401E92E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0401E92F RID: 125231
		[Token(Token = "0x401E92F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _masterNameText;

		// Token: 0x0401E930 RID: 125232
		[Token(Token = "0x401E930")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _conditionDescText;

		// Token: 0x0401E931 RID: 125233
		[Token(Token = "0x401E931")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _effectDescText;

		// Token: 0x0401E932 RID: 125234
		[Token(Token = "0x401E932")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelTaskFinished;

		// Token: 0x0401E933 RID: 125235
		[Token(Token = "0x401E933")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _taskText;

		// Token: 0x0401E934 RID: 125236
		[Token(Token = "0x401E934")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _taskUnfinishedColor;

		// Token: 0x0401E935 RID: 125237
		[Token(Token = "0x401E935")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _taskFinishedColor;

		// Token: 0x0401E936 RID: 125238
		[Token(Token = "0x401E936")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelClickLocked;

		// Token: 0x0401E937 RID: 125239
		[Token(Token = "0x401E937")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelClickToUnlock;

		// Token: 0x0401E938 RID: 125240
		[Token(Token = "0x401E938")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelClickUnlocked;

		// Token: 0x0401E939 RID: 125241
		[Token(Token = "0x401E939")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0401E93A RID: 125242
		[Token(Token = "0x401E93A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401E93B RID: 125243
		[Token(Token = "0x401E93B")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0401E93C RID: 125244
		[Token(Token = "0x401E93C")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401E93D RID: 125245
		[Token(Token = "0x401E93D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401E93E RID: 125246
		[Token(Token = "0x401E93E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetViewShow;

		// Token: 0x0401E93F RID: 125247
		[Token(Token = "0x401E93F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E940 RID: 125248
		[Token(Token = "0x401E940")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E941 RID: 125249
		[Token(Token = "0x401E941")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderDetail;

		// Token: 0x0401E942 RID: 125250
		[Token(Token = "0x401E942")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetAnim;

		// Token: 0x0401E943 RID: 125251
		[Token(Token = "0x401E943")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetRenderState;

		// Token: 0x0401E944 RID: 125252
		[Token(Token = "0x401E944")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E71 RID: 15985
		[Token(Token = "0x2003E71")]
		private enum RenderState
		{
			// Token: 0x0401E946 RID: 125254
			[Token(Token = "0x401E946")]
			LOCK,
			// Token: 0x0401E947 RID: 125255
			[Token(Token = "0x401E947")]
			CAN_UNLOCK,
			// Token: 0x0401E948 RID: 125256
			[Token(Token = "0x401E948")]
			UNLOCK
		}
	}
}
