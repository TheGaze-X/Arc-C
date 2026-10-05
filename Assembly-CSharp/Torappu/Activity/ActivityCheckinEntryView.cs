using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D9F RID: 28063
	[Token(Token = "0x2006D9F")]
	public abstract class ActivityCheckinEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x06027F8B RID: 163723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E77")]
		private UISwitchTween switchTween
		{
			[Token(Token = "0x6027F8B")]
			[Address(RVA = "0x2335CB0", Offset = "0x23348B0", VA = "0x182335CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027F8C RID: 163724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F8C")]
		[Address(RVA = "0x23359E0", Offset = "0x23345E0", VA = "0x1823359E0")]
		public void SetEvent(ActivityCheckinEntryView.OptionStruct optionStruct)
		{
		}

		// Token: 0x06027F8D RID: 163725
		[Token(Token = "0x6027F8D")]
		public abstract void RenderView(ActivityCommonCheckinViewModel viewModel);

		// Token: 0x06027F8E RID: 163726
		[Token(Token = "0x6027F8E")]
		public abstract ActivityCheckinEntryView.CheckinViewType GetViewType();

		// Token: 0x06027F8F RID: 163727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F8F")]
		[Address(RVA = "0x2335A80", Offset = "0x2334680", VA = "0x182335A80", Slot = "6")]
		public virtual void Show()
		{
		}

		// Token: 0x06027F90 RID: 163728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F90")]
		[Address(RVA = "0x2335650", Offset = "0x2334250", VA = "0x182335650", Slot = "7")]
		public virtual void Hide()
		{
		}

		// Token: 0x06027F91 RID: 163729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F91")]
		[Address(RVA = "0x2335B80", Offset = "0x2334780", VA = "0x182335B80", Slot = "8")]
		protected virtual void _InitSwitchTweenIfNot()
		{
		}

		// Token: 0x06027F92 RID: 163730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F92")]
		[Address(RVA = "0x2335540", Offset = "0x2334140", VA = "0x182335540")]
		protected void CloseEntry()
		{
		}

		// Token: 0x06027F93 RID: 163731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F93")]
		[Address(RVA = "0x23355B0", Offset = "0x23341B0", VA = "0x1823355B0")]
		protected void ConfirmReward(int index, [Optional] string option)
		{
		}

		// Token: 0x06027F94 RID: 163732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F94")]
		[Address(RVA = "0x2335B00", Offset = "0x2334700", VA = "0x182335B00")]
		protected void TriggerUpdateEntry(ActivityCheckinEntryView.CheckinViewType viewType)
		{
		}

		// Token: 0x06027F95 RID: 163733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F95")]
		[Address(RVA = "0x2335770", Offset = "0x2334370", VA = "0x182335770")]
		protected Sprite LoadSpriteFromAutoPackHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06027F96 RID: 163734 RVA: 0x000D0380 File Offset: 0x000CE580
		[Token(Token = "0x6027F96")]
		[Address(RVA = "0x2335830", Offset = "0x2334430", VA = "0x182335830")]
		protected bool SetActionDelay(Action nextAction, float delay)
		{
			return default(bool);
		}

		// Token: 0x06027F97 RID: 163735 RVA: 0x000D0398 File Offset: 0x000CE598
		[Token(Token = "0x6027F97")]
		[Address(RVA = "0x23356D0", Offset = "0x23342D0", VA = "0x1823356D0")]
		protected bool IsDelayProcessing()
		{
			return default(bool);
		}

		// Token: 0x06027F98 RID: 163736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F98")]
		[Address(RVA = "0x2335C50", Offset = "0x2334850", VA = "0x182335C50")]
		protected ActivityCheckinEntryView()
		{
		}

		// Token: 0x04038A5F RID: 232031
		[Token(Token = "0x4038A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04038A60 RID: 232032
		[Token(Token = "0x4038A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ActivityCheckinEntryView.OptionStruct m_optionStruct;

		// Token: 0x04038A61 RID: 232033
		[Token(Token = "0x4038A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UISwitchTween m_switchTween;

		// Token: 0x04038A62 RID: 232034
		[Token(Token = "0x4038A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_switchTween;

		// Token: 0x04038A63 RID: 232035
		[Token(Token = "0x4038A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetEvent;

		// Token: 0x04038A64 RID: 232036
		[Token(Token = "0x4038A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04038A65 RID: 232037
		[Token(Token = "0x4038A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04038A66 RID: 232038
		[Token(Token = "0x4038A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitSwitchTweenIfNot;

		// Token: 0x04038A67 RID: 232039
		[Token(Token = "0x4038A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CloseEntry;

		// Token: 0x04038A68 RID: 232040
		[Token(Token = "0x4038A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ConfirmReward;

		// Token: 0x04038A69 RID: 232041
		[Token(Token = "0x4038A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerUpdateEntry;

		// Token: 0x04038A6A RID: 232042
		[Token(Token = "0x4038A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHub;

		// Token: 0x04038A6B RID: 232043
		[Token(Token = "0x4038A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetActionDelay;

		// Token: 0x04038A6C RID: 232044
		[Token(Token = "0x4038A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsDelayProcessing;

		// Token: 0x04038A6D RID: 232045
		[Token(Token = "0x4038A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006DA0 RID: 28064
		[Token(Token = "0x2006DA0")]
		public enum CheckinViewType
		{
			// Token: 0x04038A6F RID: 232047
			[Token(Token = "0x4038A6F")]
			NONE,
			// Token: 0x04038A70 RID: 232048
			[Token(Token = "0x4038A70")]
			LIST_VIEW,
			// Token: 0x04038A71 RID: 232049
			[Token(Token = "0x4038A71")]
			DETAIL_VIEW
		}

		// Token: 0x02006DA1 RID: 28065
		[Token(Token = "0x2006DA1")]
		public struct OptionStruct
		{
			// Token: 0x04038A72 RID: 232050
			[Token(Token = "0x4038A72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ActivityCommonCheckinEntry.DelayHandler delayHandler;

			// Token: 0x04038A73 RID: 232051
			[Token(Token = "0x4038A73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Action closeEntryEvent;

			// Token: 0x04038A74 RID: 232052
			[Token(Token = "0x4038A74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<int, string> confirmRewardEvent;

			// Token: 0x04038A75 RID: 232053
			[Token(Token = "0x4038A75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action<ActivityCheckinEntryView.CheckinViewType> notifyUpdateEntryEvent;

			// Token: 0x04038A76 RID: 232054
			[Token(Token = "0x4038A76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<string, string, Sprite> loadSpriteFromAutoPackHub;
		}
	}
}
