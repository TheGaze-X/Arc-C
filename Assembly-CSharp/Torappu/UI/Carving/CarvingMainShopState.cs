using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200608F RID: 24719
	[Token(Token = "0x200608F")]
	public class CarvingMainShopState : PopupFadeState, IHotfixable
	{
		// Token: 0x06023C02 RID: 146434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023C02")]
		[Address(RVA = "0x1E649E0", Offset = "0x1E635E0", VA = "0x181E649E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023C03 RID: 146435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C03")]
		[Address(RVA = "0x1E64D10", Offset = "0x1E63910", VA = "0x181E64D10", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023C04 RID: 146436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C04")]
		[Address(RVA = "0x1E65340", Offset = "0x1E63F40", VA = "0x181E65340", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06023C05 RID: 146437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C05")]
		[Address(RVA = "0x1E650C0", Offset = "0x1E63CC0", VA = "0x181E650C0", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06023C06 RID: 146438 RVA: 0x000C1D58 File Offset: 0x000BFF58
		[Token(Token = "0x6023C06")]
		[Address(RVA = "0x1E65690", Offset = "0x1E64290", VA = "0x181E65690", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x06023C07 RID: 146439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023C07")]
		[Address(RVA = "0x1E65530", Offset = "0x1E64130", VA = "0x181E65530", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06023C08 RID: 146440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C08")]
		[Address(RVA = "0x1E65700", Offset = "0x1E64300", VA = "0x181E65700")]
		private void _FromChallengeInfo(IStateBean sb)
		{
		}

		// Token: 0x06023C09 RID: 146441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C09")]
		[Address(RVA = "0x1E65820", Offset = "0x1E64420", VA = "0x181E65820")]
		private void _InitIfNot(CarvingMainPage page)
		{
		}

		// Token: 0x06023C0A RID: 146442 RVA: 0x000C1D70 File Offset: 0x000BFF70
		[Token(Token = "0x6023C0A")]
		[Address(RVA = "0x1E65BA0", Offset = "0x1E647A0", VA = "0x181E65BA0")]
		private bool _TriggerTutorialAVG()
		{
			return default(bool);
		}

		// Token: 0x06023C0B RID: 146443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C0B")]
		[Address(RVA = "0x1E659A0", Offset = "0x1E645A0", VA = "0x181E659A0")]
		private void _PlayShowAnim()
		{
		}

		// Token: 0x06023C0C RID: 146444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C0C")]
		[Address(RVA = "0x1E65DD0", Offset = "0x1E649D0", VA = "0x181E65DD0")]
		private void _TryOpenIntroDialogue([Optional] Story story)
		{
		}

		// Token: 0x06023C0D RID: 146445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023C0D")]
		[Address(RVA = "0x1E64A40", Offset = "0x1E63640", VA = "0x181E64A40", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06023C0E RID: 146446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C0E")]
		[Address(RVA = "0x1E64B90", Offset = "0x1E63790", VA = "0x181E64B90", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06023C0F RID: 146447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C0F")]
		[Address(RVA = "0x1E65F40", Offset = "0x1E64B40", VA = "0x181E65F40")]
		public CarvingMainShopState()
		{
		}

		// Token: 0x06023C12 RID: 146450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C12")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023C13 RID: 146451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C13")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06023C14 RID: 146452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C14")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06023C15 RID: 146453 RVA: 0x000C1D88 File Offset: 0x000BFF88
		[Token(Token = "0x6023C15")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x06023C16 RID: 146454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023C16")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x06023C17 RID: 146455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023C17")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06023C18 RID: 146456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023C18")]
		[Address(RVA = "0x180FE00", Offset = "0x180EA00", VA = "0x18180FE00")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x040318F6 RID: 202998
		[Token(Token = "0x40318F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CarvingMainShopView _shopView;

		// Token: 0x040318F7 RID: 202999
		[Token(Token = "0x40318F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CarvingMainCardDetailBlocker _cardDetailBlocker;

		// Token: 0x040318F8 RID: 203000
		[Token(Token = "0x40318F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x040318F9 RID: 203001
		[Token(Token = "0x40318F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _hideAnimLocation;

		// Token: 0x040318FA RID: 203002
		[Token(Token = "0x40318FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _rootGroup;

		// Token: 0x040318FB RID: 203003
		[Token(Token = "0x40318FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x040318FC RID: 203004
		[Token(Token = "0x40318FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string m_actId;

		// Token: 0x040318FD RID: 203005
		[Token(Token = "0x40318FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_fromAutoPopInfoState;

		// Token: 0x040318FE RID: 203006
		[Token(Token = "0x40318FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040318FF RID: 203007
		[Token(Token = "0x40318FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Tween m_showTween;

		// Token: 0x04031900 RID: 203008
		[Token(Token = "0x4031900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Tween m_hideTween;

		// Token: 0x04031901 RID: 203009
		[Token(Token = "0x4031901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_dialogueInstId;

		// Token: 0x04031902 RID: 203010
		[Token(Token = "0x4031902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04031903 RID: 203011
		[Token(Token = "0x4031903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04031904 RID: 203012
		[Token(Token = "0x4031904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04031905 RID: 203013
		[Token(Token = "0x4031905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04031906 RID: 203014
		[Token(Token = "0x4031906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04031907 RID: 203015
		[Token(Token = "0x4031907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04031908 RID: 203016
		[Token(Token = "0x4031908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FromChallengeInfo;

		// Token: 0x04031909 RID: 203017
		[Token(Token = "0x4031909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403190A RID: 203018
		[Token(Token = "0x403190A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x0403190B RID: 203019
		[Token(Token = "0x403190B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayShowAnim;

		// Token: 0x0403190C RID: 203020
		[Token(Token = "0x403190C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryOpenIntroDialogue;

		// Token: 0x0403190D RID: 203021
		[Token(Token = "0x403190D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403190E RID: 203022
		[Token(Token = "0x403190E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403190F RID: 203023
		[Token(Token = "0x403190F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
