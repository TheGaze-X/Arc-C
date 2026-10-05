using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077A8 RID: 30632
	[Token(Token = "0x20077A8")]
	public class Act1VHalfIdleHarvestState : State, ICompDialogCallBack
	{
		// Token: 0x0602B007 RID: 176135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B007")]
		[Address(RVA = "0x26CD340", Offset = "0x26CBF40", VA = "0x1826CD340", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B008 RID: 176136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B008")]
		[Address(RVA = "0x26CD4B0", Offset = "0x26CC0B0", VA = "0x1826CD4B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B009 RID: 176137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B009")]
		[Address(RVA = "0x26CDB00", Offset = "0x26CC700", VA = "0x1826CDB00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602B00A RID: 176138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B00A")]
		[Address(RVA = "0x26CDA50", Offset = "0x26CC650", VA = "0x1826CDA50", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602B00B RID: 176139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B00B")]
		[Address(RVA = "0x26CD450", Offset = "0x26CC050", VA = "0x1826CD450")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602B00C RID: 176140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B00C")]
		[Address(RVA = "0x26CE280", Offset = "0x26CCE80", VA = "0x1826CE280")]
		private void _OnTimerTick()
		{
		}

		// Token: 0x0602B00D RID: 176141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B00D")]
		[Address(RVA = "0x26CE950", Offset = "0x26CD550", VA = "0x1826CE950")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x0602B00E RID: 176142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B00E")]
		[Address(RVA = "0x26CEAB0", Offset = "0x26CD6B0", VA = "0x1826CEAB0")]
		private void _PlayHarvestAnim(float harvestPoint, TweenCallback onHarvestPoint, TweenCallback onComplete)
		{
		}

		// Token: 0x0602B00F RID: 176143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B00F")]
		[Address(RVA = "0x26CE3E0", Offset = "0x26CCFE0", VA = "0x1826CE3E0")]
		private void _ParseAndShowHarvestToasts(string actId, Act1VHalfIdleHarvestResponse resp)
		{
		}

		// Token: 0x0602B010 RID: 176144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B010")]
		[Address(RVA = "0x26CDFA0", Offset = "0x26CCBA0", VA = "0x1826CDFA0")]
		private void _HandleHarvestResp(Act1VHalfIdleHarvestResponse resp)
		{
		}

		// Token: 0x0602B011 RID: 176145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B011")]
		[Address(RVA = "0x26CCD80", Offset = "0x26CB980", VA = "0x1826CCD80")]
		public void EventOnClickHarvest()
		{
		}

		// Token: 0x0602B012 RID: 176146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B012")]
		[Address(RVA = "0x26CD0C0", Offset = "0x26CBCC0", VA = "0x1826CD0C0")]
		public void EventOnClickIncomeDialog()
		{
		}

		// Token: 0x0602B013 RID: 176147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B013")]
		[Address(RVA = "0x26CEE60", Offset = "0x26CDA60", VA = "0x1826CEE60")]
		private void _TryRaiseAVGSignal()
		{
		}

		// Token: 0x0602B014 RID: 176148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B014")]
		[Address(RVA = "0x26CEC90", Offset = "0x26CD890", VA = "0x1826CEC90")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x0602B015 RID: 176149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B015")]
		[Address(RVA = "0x26CF000", Offset = "0x26CDC00", VA = "0x1826CF000")]
		private IEnumerator _WaitAndRaiseSignal()
		{
			return null;
		}

		// Token: 0x0602B016 RID: 176150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B016")]
		[Address(RVA = "0x26CED70", Offset = "0x26CD970", VA = "0x1826CED70")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x0602B017 RID: 176151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B017")]
		[Address(RVA = "0x26CD3A0", Offset = "0x26CBFA0", VA = "0x1826CD3A0", Slot = "23")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602B018 RID: 176152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B018")]
		[Address(RVA = "0x26CF0B0", Offset = "0x26CDCB0", VA = "0x1826CF0B0")]
		public Act1VHalfIdleHarvestState()
		{
		}

		// Token: 0x0602B01C RID: 176156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B01C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602B01D RID: 176157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B01D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602B01E RID: 176158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B01E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403E12F RID: 254255
		[Token(Token = "0x403E12F")]
		[NonSerialized]
		public const float STATE_ENTRY_DELAY = 0.1f;

		// Token: 0x0403E130 RID: 254256
		[Token(Token = "0x403E130")]
		[NonSerialized]
		public const float HARVEST_TOAST_DELAY = 1.5f;

		// Token: 0x0403E131 RID: 254257
		[Token(Token = "0x403E131")]
		[NonSerialized]
		public const float HARVEST_POINT_TIME = 1f;

		// Token: 0x0403E132 RID: 254258
		[Token(Token = "0x403E132")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "harvest";

		// Token: 0x0403E133 RID: 254259
		[Token(Token = "0x403E133")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act1VHalfIdleHarvestView _view;

		// Token: 0x0403E134 RID: 254260
		[Token(Token = "0x403E134")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403E135 RID: 254261
		[Token(Token = "0x403E135")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _harvestAnim;

		// Token: 0x0403E136 RID: 254262
		[Token(Token = "0x403E136")]
		[FieldOffset(Offset = "0x78")]
		private Act1VHalfIdleHarvestProperty m_prop;

		// Token: 0x0403E137 RID: 254263
		[Token(Token = "0x403E137")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_entryTween;

		// Token: 0x0403E138 RID: 254264
		[Token(Token = "0x403E138")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_harvestTween;

		// Token: 0x0403E139 RID: 254265
		[Token(Token = "0x403E139")]
		[FieldOffset(Offset = "0x90")]
		private int m_timerId;

		// Token: 0x0403E13A RID: 254266
		[Token(Token = "0x403E13A")]
		[FieldOffset(Offset = "0x94")]
		private bool m_isDataExpired;

		// Token: 0x0403E13B RID: 254267
		[Token(Token = "0x403E13B")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0403E13C RID: 254268
		[Token(Token = "0x403E13C")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedIncomeDialogId;

		// Token: 0x0403E13D RID: 254269
		[Token(Token = "0x403E13D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E13E RID: 254270
		[Token(Token = "0x403E13E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E13F RID: 254271
		[Token(Token = "0x403E13F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403E140 RID: 254272
		[Token(Token = "0x403E140")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403E141 RID: 254273
		[Token(Token = "0x403E141")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403E142 RID: 254274
		[Token(Token = "0x403E142")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnTimerTick;

		// Token: 0x0403E143 RID: 254275
		[Token(Token = "0x403E143")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0403E144 RID: 254276
		[Token(Token = "0x403E144")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayHarvestAnim;

		// Token: 0x0403E145 RID: 254277
		[Token(Token = "0x403E145")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ParseAndShowHarvestToasts;

		// Token: 0x0403E146 RID: 254278
		[Token(Token = "0x403E146")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleHarvestResp;

		// Token: 0x0403E147 RID: 254279
		[Token(Token = "0x403E147")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnClickHarvest;

		// Token: 0x0403E148 RID: 254280
		[Token(Token = "0x403E148")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnClickIncomeDialog;

		// Token: 0x0403E149 RID: 254281
		[Token(Token = "0x403E149")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryRaiseAVGSignal;

		// Token: 0x0403E14A RID: 254282
		[Token(Token = "0x403E14A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0403E14B RID: 254283
		[Token(Token = "0x403E14B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__WaitAndRaiseSignal;

		// Token: 0x0403E14C RID: 254284
		[Token(Token = "0x403E14C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0403E14D RID: 254285
		[Token(Token = "0x403E14D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403E14E RID: 254286
		[Token(Token = "0x403E14E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
