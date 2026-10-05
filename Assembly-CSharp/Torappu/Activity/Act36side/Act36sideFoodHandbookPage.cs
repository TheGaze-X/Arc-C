using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200744B RID: 29771
	[Token(Token = "0x200744B")]
	public class Act36sideFoodHandbookPage : UIPage, IValueMsgReceiver
	{
		// Token: 0x0602A02B RID: 172075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A02B")]
		[Address(RVA = "0x259C3A0", Offset = "0x259AFA0", VA = "0x18259C3A0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0602A02C RID: 172076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A02C")]
		[Address(RVA = "0x259C860", Offset = "0x259B460", VA = "0x18259C860", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0602A02D RID: 172077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A02D")]
		[Address(RVA = "0x259CCC0", Offset = "0x259B8C0", VA = "0x18259CCC0")]
		private void _PlayAnimFromBegin(UIAnimationLocation location, ref Tween tween)
		{
		}

		// Token: 0x0602A02E RID: 172078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A02E")]
		[Address(RVA = "0x259CE00", Offset = "0x259BA00", VA = "0x18259CE00")]
		private void _PlayEnterAudio()
		{
		}

		// Token: 0x0602A02F RID: 172079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A02F")]
		[Address(RVA = "0x259C580", Offset = "0x259B180", VA = "0x18259C580", Slot = "24")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A030 RID: 172080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A030")]
		[Address(RVA = "0x259CC50", Offset = "0x259B850", VA = "0x18259CC50")]
		private void _ClosePage()
		{
		}

		// Token: 0x0602A031 RID: 172081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A031")]
		[Address(RVA = "0x259CFC0", Offset = "0x259BBC0", VA = "0x18259CFC0")]
		private void _SwitchTab(Act36sideFoodHandbookTabType selectType)
		{
		}

		// Token: 0x0602A032 RID: 172082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A032")]
		[Address(RVA = "0x259CF00", Offset = "0x259BB00", VA = "0x18259CF00")]
		private void _SelectToken(string selectTokenId)
		{
		}

		// Token: 0x0602A033 RID: 172083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A033")]
		[Address(RVA = "0x259C920", Offset = "0x259B520", VA = "0x18259C920")]
		private void _ClaimReward()
		{
		}

		// Token: 0x0602A034 RID: 172084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A034")]
		[Address(RVA = "0x259D0B0", Offset = "0x259BCB0", VA = "0x18259D0B0")]
		public Act36sideFoodHandbookPage()
		{
		}

		// Token: 0x0602A035 RID: 172085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A035")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602A036 RID: 172086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A036")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x0403C400 RID: 246784
		[Token(Token = "0x403C400")]
		[NonSerialized]
		public const int CLOSE_PAGE = 0;

		// Token: 0x0403C401 RID: 246785
		[Token(Token = "0x403C401")]
		[NonSerialized]
		public const int SWITCH_TAB = 1;

		// Token: 0x0403C402 RID: 246786
		[Token(Token = "0x403C402")]
		[NonSerialized]
		public const int SELECT_TOKEN = 2;

		// Token: 0x0403C403 RID: 246787
		[Token(Token = "0x403C403")]
		[NonSerialized]
		public const int CLAIM_REWARD = 3;

		// Token: 0x0403C404 RID: 246788
		[Token(Token = "0x403C404")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Act36sideFoodHandbookView _view;

		// Token: 0x0403C405 RID: 246789
		[Token(Token = "0x403C405")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0403C406 RID: 246790
		[Token(Token = "0x403C406")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _closeArea;

		// Token: 0x0403C407 RID: 246791
		[Token(Token = "0x403C407")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403C408 RID: 246792
		[Token(Token = "0x403C408")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIAnimationLocation _rightPanelEnterAnim;

		// Token: 0x0403C409 RID: 246793
		[Token(Token = "0x403C409")]
		[FieldOffset(Offset = "0x110")]
		private Act36sideFoodHandbookProperty m_property;

		// Token: 0x0403C40A RID: 246794
		[Token(Token = "0x403C40A")]
		[FieldOffset(Offset = "0x118")]
		private Tween m_enterAnimTween;

		// Token: 0x0403C40B RID: 246795
		[Token(Token = "0x403C40B")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_rightPanelEnterTween;

		// Token: 0x0403C40C RID: 246796
		[Token(Token = "0x403C40C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403C40D RID: 246797
		[Token(Token = "0x403C40D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403C40E RID: 246798
		[Token(Token = "0x403C40E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayAnimFromBegin;

		// Token: 0x0403C40F RID: 246799
		[Token(Token = "0x403C40F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAudio;

		// Token: 0x0403C410 RID: 246800
		[Token(Token = "0x403C410")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403C411 RID: 246801
		[Token(Token = "0x403C411")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClosePage;

		// Token: 0x0403C412 RID: 246802
		[Token(Token = "0x403C412")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SwitchTab;

		// Token: 0x0403C413 RID: 246803
		[Token(Token = "0x403C413")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SelectToken;

		// Token: 0x0403C414 RID: 246804
		[Token(Token = "0x403C414")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ClaimReward;

		// Token: 0x0403C415 RID: 246805
		[Token(Token = "0x403C415")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200744C RID: 29772
		[Token(Token = "0x200744C")]
		public class Param
		{
			// Token: 0x0602A037 RID: 172087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A037")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403C416 RID: 246806
			[Token(Token = "0x403C416")]
			[FieldOffset(Offset = "0x10")]
			public string activityId;
		}
	}
}
