using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E99 RID: 16025
	[Token(Token = "0x2003E99")]
	public class SpecialOperatorBoardMasterNodeView : SpecialOperatorPointViewBase, SpecialOperatorPointViewBase.ISelectAnchorHolder
	{
		// Token: 0x06018E1D RID: 101917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018E1D")]
		[Address(RVA = "0x118E790", Offset = "0x118D390", VA = "0x18118E790", Slot = "7")]
		public RectTransform GetSelectAnchor()
		{
			return null;
		}

		// Token: 0x17003B5F RID: 15199
		// (get) Token: 0x06018E1E RID: 101918 RVA: 0x0009C4F8 File Offset: 0x0009A6F8
		[Token(Token = "0x17003B5F")]
		public override SpecialOperatorPointViewType viewType
		{
			[Token(Token = "0x6018E1E")]
			[Address(RVA = "0x118F8C0", Offset = "0x118E4C0", VA = "0x18118F8C0", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018E1F RID: 101919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E1F")]
		[Address(RVA = "0x118E900", Offset = "0x118D500", VA = "0x18118E900", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x06018E20 RID: 101920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E20")]
		[Address(RVA = "0x118EAD0", Offset = "0x118D6D0", VA = "0x18118EAD0", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06018E21 RID: 101921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E21")]
		[Address(RVA = "0x118E810", Offset = "0x118D410", VA = "0x18118E810")]
		public void OnClick()
		{
		}

		// Token: 0x06018E22 RID: 101922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E22")]
		[Address(RVA = "0x118F320", Offset = "0x118DF20", VA = "0x18118F320")]
		private void _RenderNode(SpecialOperatorBoardMasterNode masterNodeModel, SpecialOperatorBoardMasterNodeView.RenderState renderState)
		{
		}

		// Token: 0x06018E23 RID: 101923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E23")]
		[Address(RVA = "0x118F170", Offset = "0x118DD70", VA = "0x18118F170")]
		private void _RenderNewPart(SpecialOperatorBoardMasterNode masterModel, SpecialOperatorBoardMasterNodeView.RenderState renderState)
		{
		}

		// Token: 0x06018E24 RID: 101924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E24")]
		[Address(RVA = "0x118EFD0", Offset = "0x118DBD0", VA = "0x18118EFD0")]
		private void _RenderLvlupPart(SpecialOperatorBoardMasterNode masterModel, SpecialOperatorBoardMasterNodeView.RenderState renderState)
		{
		}

		// Token: 0x06018E25 RID: 101925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E25")]
		[Address(RVA = "0x118F670", Offset = "0x118E270", VA = "0x18118F670")]
		private void _SetUnlockAnim(SpecialOperatorBoardMasterNodeView.RenderState renderState, bool isFirstRender)
		{
		}

		// Token: 0x06018E26 RID: 101926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E26")]
		[Address(RVA = "0x118EF00", Offset = "0x118DB00", VA = "0x18118EF00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E27 RID: 101927 RVA: 0x0009C510 File Offset: 0x0009A710
		[Token(Token = "0x6018E27")]
		[Address(RVA = "0x118EDA0", Offset = "0x118D9A0", VA = "0x18118EDA0")]
		private SpecialOperatorBoardMasterNodeView.RenderState _GetRenderState(SpecialOperatorBoardMasterNode masterModel)
		{
			return SpecialOperatorBoardMasterNodeView.RenderState.LOCK;
		}

		// Token: 0x06018E28 RID: 101928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E28")]
		[Address(RVA = "0x118F810", Offset = "0x118E410", VA = "0x18118F810")]
		public SpecialOperatorBoardMasterNodeView()
		{
		}

		// Token: 0x06018E29 RID: 101929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E29")]
		[Address(RVA = "0x118ECE0", Offset = "0x118D8E0", VA = "0x18118ECE0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06018E2A RID: 101930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E2A")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0401EA9C RID: 125596
		[Token(Token = "0x401EA9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _newPart;

		// Token: 0x0401EA9D RID: 125597
		[Token(Token = "0x401EA9D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _newBgImg;

		// Token: 0x0401EA9E RID: 125598
		[Token(Token = "0x401EA9E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _lockedBgColor;

		// Token: 0x0401EA9F RID: 125599
		[Token(Token = "0x401EA9F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _masterNameText;

		// Token: 0x0401EAA0 RID: 125600
		[Token(Token = "0x401EAA0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newLockedPrePart;

		// Token: 0x0401EAA1 RID: 125601
		[Token(Token = "0x401EAA1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _newToUnlockPart;

		// Token: 0x0401EAA2 RID: 125602
		[Token(Token = "0x401EAA2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _lvlupPart;

		// Token: 0x0401EAA3 RID: 125603
		[Token(Token = "0x401EAA3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _lvlupLockedPart;

		// Token: 0x0401EAA4 RID: 125604
		[Token(Token = "0x401EAA4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _lvlupLockedPrePart;

		// Token: 0x0401EAA5 RID: 125605
		[Token(Token = "0x401EAA5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _lvlupToUnlockPart;

		// Token: 0x0401EAA6 RID: 125606
		[Token(Token = "0x401EAA6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _lvlupUnlockedPart;

		// Token: 0x0401EAA7 RID: 125607
		[Token(Token = "0x401EAA7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _lvlupNoticeText;

		// Token: 0x0401EAA8 RID: 125608
		[Token(Token = "0x401EAA8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _newSelectAnchor;

		// Token: 0x0401EAA9 RID: 125609
		[Token(Token = "0x401EAA9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401EAAA RID: 125610
		[Token(Token = "0x401EAAA")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0401EAAB RID: 125611
		[Token(Token = "0x401EAAB")]
		[FieldOffset(Offset = "0xB8")]
		private string m_nodeId;

		// Token: 0x0401EAAC RID: 125612
		[Token(Token = "0x401EAAC")]
		[FieldOffset(Offset = "0xC0")]
		private SpecialOperatorBoardMasterNode m_cachedMasterNode;

		// Token: 0x0401EAAD RID: 125613
		[Token(Token = "0x401EAAD")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EAAE RID: 125614
		[Token(Token = "0x401EAAE")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401EAAF RID: 125615
		[Token(Token = "0x401EAAF")]
		[FieldOffset(Offset = "0xE0")]
		private int m_cachedEnterSeqNum;

		// Token: 0x0401EAB0 RID: 125616
		[Token(Token = "0x401EAB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSelectAnchor;

		// Token: 0x0401EAB1 RID: 125617
		[Token(Token = "0x401EAB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0401EAB2 RID: 125618
		[Token(Token = "0x401EAB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401EAB3 RID: 125619
		[Token(Token = "0x401EAB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401EAB4 RID: 125620
		[Token(Token = "0x401EAB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401EAB5 RID: 125621
		[Token(Token = "0x401EAB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNode;

		// Token: 0x0401EAB6 RID: 125622
		[Token(Token = "0x401EAB6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderNewPart;

		// Token: 0x0401EAB7 RID: 125623
		[Token(Token = "0x401EAB7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderLvlupPart;

		// Token: 0x0401EAB8 RID: 125624
		[Token(Token = "0x401EAB8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetUnlockAnim;

		// Token: 0x0401EAB9 RID: 125625
		[Token(Token = "0x401EAB9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EABA RID: 125626
		[Token(Token = "0x401EABA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetRenderState;

		// Token: 0x0401EABB RID: 125627
		[Token(Token = "0x401EABB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E9A RID: 16026
		[Token(Token = "0x2003E9A")]
		private enum RenderState
		{
			// Token: 0x0401EABD RID: 125629
			[Token(Token = "0x401EABD")]
			LOCK,
			// Token: 0x0401EABE RID: 125630
			[Token(Token = "0x401EABE")]
			LOCK_PRE,
			// Token: 0x0401EABF RID: 125631
			[Token(Token = "0x401EABF")]
			CAN_UNLOCK,
			// Token: 0x0401EAC0 RID: 125632
			[Token(Token = "0x401EAC0")]
			UNLOCK
		}
	}
}
