using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C3 RID: 18627
	[Token(Token = "0x20048C3")]
	public class MiniActTrialBinderView : DataBinder<MiniActTrialProperty>
	{
		// Token: 0x170042B1 RID: 17073
		// (get) Token: 0x0601C194 RID: 115092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042B1")]
		public UICommonTrackPoint reviewRewardTrackPoint
		{
			[Token(Token = "0x601C194")]
			[Address(RVA = "0x1597420", Offset = "0x1596020", VA = "0x181597420")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042B2 RID: 17074
		// (get) Token: 0x0601C195 RID: 115093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042B2")]
		public LoopScrollRect loopScrollRect
		{
			[Token(Token = "0x601C195")]
			[Address(RVA = "0x15973C0", Offset = "0x1595FC0", VA = "0x1815973C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C196 RID: 115094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C196")]
		[Address(RVA = "0x15970A0", Offset = "0x1595CA0", VA = "0x1815970A0", Slot = "7")]
		public override void OnValueChanged(MiniActTrialProperty property)
		{
		}

		// Token: 0x0601C197 RID: 115095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C197")]
		[Address(RVA = "0x15971C0", Offset = "0x1595DC0", VA = "0x1815971C0")]
		public void SetCallbacks(Action<string> onChapterClicked, Action<string, List<string>> onTrialCollect, Action onBtnReview, Action onBtnRule)
		{
		}

		// Token: 0x0601C198 RID: 115096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C198")]
		[Address(RVA = "0x1596FC0", Offset = "0x1595BC0", VA = "0x181596FC0")]
		public void OnBtnReview()
		{
		}

		// Token: 0x0601C199 RID: 115097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C199")]
		[Address(RVA = "0x1597030", Offset = "0x1595C30", VA = "0x181597030")]
		public void OnBtnRule()
		{
		}

		// Token: 0x0601C19A RID: 115098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C19A")]
		[Address(RVA = "0x1597350", Offset = "0x1595F50", VA = "0x181597350")]
		public MiniActTrialBinderView()
		{
		}

		// Token: 0x04024B8E RID: 150414
		[Token(Token = "0x4024B8E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MiniActTrialListAdapter _trialListAdapter;

		// Token: 0x04024B8F RID: 150415
		[Token(Token = "0x4024B8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _reviewRewardTrackPoint;

		// Token: 0x04024B90 RID: 150416
		[Token(Token = "0x4024B90")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		// Token: 0x04024B91 RID: 150417
		[Token(Token = "0x4024B91")]
		[FieldOffset(Offset = "0x38")]
		private Action m_onBtnReview;

		// Token: 0x04024B92 RID: 150418
		[Token(Token = "0x4024B92")]
		[FieldOffset(Offset = "0x40")]
		private Action m_onBtnRule;

		// Token: 0x04024B93 RID: 150419
		[Token(Token = "0x4024B93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_reviewRewardTrackPoint;

		// Token: 0x04024B94 RID: 150420
		[Token(Token = "0x4024B94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_loopScrollRect;

		// Token: 0x04024B95 RID: 150421
		[Token(Token = "0x4024B95")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024B96 RID: 150422
		[Token(Token = "0x4024B96")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x04024B97 RID: 150423
		[Token(Token = "0x4024B97")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBtnReview;

		// Token: 0x04024B98 RID: 150424
		[Token(Token = "0x4024B98")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBtnRule;

		// Token: 0x04024B99 RID: 150425
		[Token(Token = "0x4024B99")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
