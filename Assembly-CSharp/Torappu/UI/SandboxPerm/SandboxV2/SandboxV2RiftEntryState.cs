using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004387 RID: 17287
	[Token(Token = "0x2004387")]
	public class SandboxV2RiftEntryState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601A8A9 RID: 108713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A8A9")]
		[Address(RVA = "0x13B3F60", Offset = "0x13B2B60", VA = "0x1813B3F60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A8AA RID: 108714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8AA")]
		[Address(RVA = "0x13B3FC0", Offset = "0x13B2BC0", VA = "0x1813B3FC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A8AB RID: 108715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8AB")]
		[Address(RVA = "0x13B4400", Offset = "0x13B3000", VA = "0x1813B4400", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A8AC RID: 108716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A8AC")]
		[Address(RVA = "0x13B44F0", Offset = "0x13B30F0", VA = "0x1813B44F0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601A8AD RID: 108717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8AD")]
		[Address(RVA = "0x13B5150", Offset = "0x13B3D50", VA = "0x1813B5150")]
		private void _ToDifficultySelectStateListener(IStateBean obj)
		{
		}

		// Token: 0x0601A8AE RID: 108718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8AE")]
		[Address(RVA = "0x13B47B0", Offset = "0x13B33B0", VA = "0x1813B47B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A8AF RID: 108719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8AF")]
		[Address(RVA = "0x13B4FC0", Offset = "0x13B3BC0", VA = "0x1813B4FC0")]
		private void _ResetEnterAnim(bool isFast)
		{
		}

		// Token: 0x0601A8B0 RID: 108720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B0")]
		[Address(RVA = "0x13B4C80", Offset = "0x13B3880", VA = "0x1813B4C80")]
		private void _PlayEnterAnim(bool isFast)
		{
		}

		// Token: 0x0601A8B1 RID: 108721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B1")]
		[Address(RVA = "0x13B4720", Offset = "0x13B3320", VA = "0x1813B4720")]
		private void _InitAnimIfNot()
		{
		}

		// Token: 0x0601A8B2 RID: 108722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B2")]
		[Address(RVA = "0x13B4850", Offset = "0x13B3450", VA = "0x1813B4850")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0601A8B3 RID: 108723 RVA: 0x000A2540 File Offset: 0x000A0740
		[Token(Token = "0x601A8B3")]
		[Address(RVA = "0x13B4660", Offset = "0x13B3260", VA = "0x1813B4660")]
		private bool _EnsureStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601A8B4 RID: 108724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B4")]
		[Address(RVA = "0x13B41F0", Offset = "0x13B2DF0", VA = "0x1813B41F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601A8B5 RID: 108725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B5")]
		[Address(RVA = "0x13B49B0", Offset = "0x13B35B0", VA = "0x1813B49B0")]
		private void _OnEnterRiftButtonClicked()
		{
		}

		// Token: 0x0601A8B6 RID: 108726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B6")]
		[Address(RVA = "0x13B4910", Offset = "0x13B3510", VA = "0x1813B4910")]
		private void _OnDifficultyButtonClicked()
		{
		}

		// Token: 0x0601A8B7 RID: 108727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B7")]
		[Address(RVA = "0x13B4BE0", Offset = "0x13B37E0", VA = "0x1813B4BE0")]
		private void _OnTeamButtonClicked()
		{
		}

		// Token: 0x0601A8B8 RID: 108728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8B8")]
		[Address(RVA = "0x13B5280", Offset = "0x13B3E80", VA = "0x1813B5280")]
		public SandboxV2RiftEntryState()
		{
		}

		// Token: 0x0601A8BA RID: 108730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8BA")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A8BB RID: 108731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A8BB")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601A8BC RID: 108732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A8BC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04021C79 RID: 138361
		[Token(Token = "0x4021C79")]
		[NonSerialized]
		public const int ON_ENTER_RIFT_BUTTON_CLICKED = 0;

		// Token: 0x04021C7A RID: 138362
		[Token(Token = "0x4021C7A")]
		[NonSerialized]
		public const int ON_DIFFICULTY_BUTTON_CLICKED = 1;

		// Token: 0x04021C7B RID: 138363
		[Token(Token = "0x4021C7B")]
		[NonSerialized]
		public const int ON_TEAM_BUTTON_CLICKED = 2;

		// Token: 0x04021C7C RID: 138364
		[Token(Token = "0x4021C7C")]
		[NonSerialized]
		public const int ON_EXIT_RESERVE_PAGE = 3;

		// Token: 0x04021C7D RID: 138365
		[Token(Token = "0x4021C7D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2RiftEntryView _entryView;

		// Token: 0x04021C7E RID: 138366
		[Token(Token = "0x4021C7E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _loadingAnim;

		// Token: 0x04021C7F RID: 138367
		[Token(Token = "0x4021C7F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04021C80 RID: 138368
		[Token(Token = "0x4021C80")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x04021C81 RID: 138369
		[Token(Token = "0x4021C81")]
		[FieldOffset(Offset = "0xA0")]
		private SandboxV2RiftEntryStateBean m_stateBean;

		// Token: 0x04021C82 RID: 138370
		[Token(Token = "0x4021C82")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04021C83 RID: 138371
		[Token(Token = "0x4021C83")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_hasAnimInited;

		// Token: 0x04021C84 RID: 138372
		[Token(Token = "0x4021C84")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_enterTween;

		// Token: 0x04021C85 RID: 138373
		[Token(Token = "0x4021C85")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedTopicId;

		// Token: 0x04021C86 RID: 138374
		[Token(Token = "0x4021C86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04021C87 RID: 138375
		[Token(Token = "0x4021C87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04021C88 RID: 138376
		[Token(Token = "0x4021C88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04021C89 RID: 138377
		[Token(Token = "0x4021C89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04021C8A RID: 138378
		[Token(Token = "0x4021C8A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ToDifficultySelectStateListener;

		// Token: 0x04021C8B RID: 138379
		[Token(Token = "0x4021C8B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021C8C RID: 138380
		[Token(Token = "0x4021C8C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetEnterAnim;

		// Token: 0x04021C8D RID: 138381
		[Token(Token = "0x4021C8D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04021C8E RID: 138382
		[Token(Token = "0x4021C8E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitAnimIfNot;

		// Token: 0x04021C8F RID: 138383
		[Token(Token = "0x4021C8F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x04021C90 RID: 138384
		[Token(Token = "0x4021C90")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EnsureStateStable;

		// Token: 0x04021C91 RID: 138385
		[Token(Token = "0x4021C91")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04021C92 RID: 138386
		[Token(Token = "0x4021C92")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnEnterRiftButtonClicked;

		// Token: 0x04021C93 RID: 138387
		[Token(Token = "0x4021C93")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnDifficultyButtonClicked;

		// Token: 0x04021C94 RID: 138388
		[Token(Token = "0x4021C94")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnTeamButtonClicked;

		// Token: 0x04021C95 RID: 138389
		[Token(Token = "0x4021C95")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
