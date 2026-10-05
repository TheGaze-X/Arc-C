using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007911 RID: 30993
	[Token(Token = "0x2007911")]
	public class Act1ArcadeEntryPage : StateEnginePage
	{
		// Token: 0x170065DD RID: 26077
		// (get) Token: 0x0602B79C RID: 178076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065DD")]
		public string actId
		{
			[Token(Token = "0x602B79C")]
			[Address(RVA = "0x2750920", Offset = "0x274F520", VA = "0x182750920")]
			get
			{
				return null;
			}
		}

		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x0602B79D RID: 178077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065DE")]
		public DataBundle savedInst
		{
			[Token(Token = "0x602B79D")]
			[Address(RVA = "0x2750A40", Offset = "0x274F640", VA = "0x182750A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x0602B79E RID: 178078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065DF")]
		public UICompDialogMgr commonDlgMgr
		{
			[Token(Token = "0x602B79E")]
			[Address(RVA = "0x27509E0", Offset = "0x274F5E0", VA = "0x1827509E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x0602B79F RID: 178079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065E0")]
		public Act1ArcadeStateViewStatusComp statusViewComp
		{
			[Token(Token = "0x602B79F")]
			[Address(RVA = "0x2750AA0", Offset = "0x274F6A0", VA = "0x182750AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B7A0 RID: 178080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A0")]
		[Address(RVA = "0x274FB80", Offset = "0x274E780", VA = "0x18274FB80", Slot = "8")]
		protected override void OnCreate(DataBundle dataBundle)
		{
		}

		// Token: 0x0602B7A1 RID: 178081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A1")]
		[Address(RVA = "0x274FE60", Offset = "0x274EA60", VA = "0x18274FE60", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602B7A2 RID: 178082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7A2")]
		[Address(RVA = "0x274FA10", Offset = "0x274E610", VA = "0x18274FA10", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0602B7A3 RID: 178083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7A3")]
		[Address(RVA = "0x274F930", Offset = "0x274E530", VA = "0x18274F930", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0602B7A4 RID: 178084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A4")]
		[Address(RVA = "0x274FC70", Offset = "0x274E870", VA = "0x18274FC70", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0602B7A5 RID: 178085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7A5")]
		[Address(RVA = "0x274FAD0", Offset = "0x274E6D0", VA = "0x18274FAD0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602B7A6 RID: 178086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A6")]
		[Address(RVA = "0x27501A0", Offset = "0x274EDA0", VA = "0x1827501A0", Slot = "28")]
		protected override void OnStateEngineReady(bool isPageFromStack)
		{
		}

		// Token: 0x0602B7A7 RID: 178087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A7")]
		[Address(RVA = "0x2750470", Offset = "0x274F070", VA = "0x182750470")]
		private void _OnRouteToState(Type targetStateType)
		{
		}

		// Token: 0x0602B7A8 RID: 178088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A8")]
		[Address(RVA = "0x2750500", Offset = "0x274F100", VA = "0x182750500")]
		private void _OnStatePreResume(Type targetStateType, bool isFromStack)
		{
		}

		// Token: 0x0602B7A9 RID: 178089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7A9")]
		[Address(RVA = "0x27505B0", Offset = "0x274F1B0", VA = "0x1827505B0")]
		private void _OnStateResume(Type targetStateType, bool isFromStack)
		{
		}

		// Token: 0x0602B7AA RID: 178090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7AA")]
		[Address(RVA = "0x2750710", Offset = "0x274F310", VA = "0x182750710")]
		private void _TriggerBGMSignal()
		{
		}

		// Token: 0x0602B7AB RID: 178091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7AB")]
		[Address(RVA = "0x2750660", Offset = "0x274F260", VA = "0x182750660")]
		private void _SetPageShow(bool isShow)
		{
		}

		// Token: 0x0602B7AC RID: 178092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7AC")]
		[Address(RVA = "0x27508C0", Offset = "0x274F4C0", VA = "0x1827508C0")]
		public Act1ArcadeEntryPage()
		{
		}

		// Token: 0x0602B7B1 RID: 178097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7B1")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602B7B2 RID: 178098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7B2")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0602B7B3 RID: 178099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7B3")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0602B7B4 RID: 178100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7B4")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0602B7B5 RID: 178101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7B5")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x0602B7B6 RID: 178102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B7B6")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602B7B7 RID: 178103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7B7")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x0403EDDE RID: 257502
		[Token(Token = "0x403EDDE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _commonDlgContainer;

		// Token: 0x0403EDDF RID: 257503
		[Token(Token = "0x403EDDF")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _fisheyeRootCanvas;

		// Token: 0x0403EDE0 RID: 257504
		[Token(Token = "0x403EDE0")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _commonRootCanvas;

		// Token: 0x0403EDE1 RID: 257505
		[Token(Token = "0x403EDE1")]
		[FieldOffset(Offset = "0x108")]
		private Act1ArcadeComponentHolder m_componentHolder;

		// Token: 0x0403EDE2 RID: 257506
		[Token(Token = "0x403EDE2")]
		[FieldOffset(Offset = "0x110")]
		private DataBundle m_savedInst;

		// Token: 0x0403EDE3 RID: 257507
		[Token(Token = "0x403EDE3")]
		[FieldOffset(Offset = "0x118")]
		private UICompDialogMgr m_commonDlgMgr;

		// Token: 0x0403EDE4 RID: 257508
		[Token(Token = "0x403EDE4")]
		[FieldOffset(Offset = "0x120")]
		private Act1ArcadeStateViewStatusComp m_statusViewComp;

		// Token: 0x0403EDE5 RID: 257509
		[Token(Token = "0x403EDE5")]
		[FieldOffset(Offset = "0x128")]
		private StateEngine.OnStateChangeListener m_stateChangeListener;

		// Token: 0x0403EDE6 RID: 257510
		[Token(Token = "0x403EDE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403EDE7 RID: 257511
		[Token(Token = "0x403EDE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_savedInst;

		// Token: 0x0403EDE8 RID: 257512
		[Token(Token = "0x403EDE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_commonDlgMgr;

		// Token: 0x0403EDE9 RID: 257513
		[Token(Token = "0x403EDE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_statusViewComp;

		// Token: 0x0403EDEA RID: 257514
		[Token(Token = "0x403EDEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403EDEB RID: 257515
		[Token(Token = "0x403EDEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403EDEC RID: 257516
		[Token(Token = "0x403EDEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0403EDED RID: 257517
		[Token(Token = "0x403EDED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0403EDEE RID: 257518
		[Token(Token = "0x403EDEE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0403EDEF RID: 257519
		[Token(Token = "0x403EDEF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x0403EDF0 RID: 257520
		[Token(Token = "0x403EDF0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0403EDF1 RID: 257521
		[Token(Token = "0x403EDF1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnRouteToState;

		// Token: 0x0403EDF2 RID: 257522
		[Token(Token = "0x403EDF2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnStatePreResume;

		// Token: 0x0403EDF3 RID: 257523
		[Token(Token = "0x403EDF3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnStateResume;

		// Token: 0x0403EDF4 RID: 257524
		[Token(Token = "0x403EDF4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TriggerBGMSignal;

		// Token: 0x0403EDF5 RID: 257525
		[Token(Token = "0x403EDF5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetPageShow;

		// Token: 0x0403EDF6 RID: 257526
		[Token(Token = "0x403EDF6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
