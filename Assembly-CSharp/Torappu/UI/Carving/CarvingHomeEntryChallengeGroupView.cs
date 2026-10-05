using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200601D RID: 24605
	[Token(Token = "0x200601D")]
	public class CarvingHomeEntryChallengeGroupView : DataBinder<CarvingHomeEntryProperty>, IHotfixable
	{
		// Token: 0x06023965 RID: 145765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023965")]
		[Address(RVA = "0x1E39190", Offset = "0x1E37D90", VA = "0x181E39190")]
		public void OnExit()
		{
		}

		// Token: 0x06023966 RID: 145766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023966")]
		[Address(RVA = "0x1E39220", Offset = "0x1E37E20", VA = "0x181E39220", Slot = "7")]
		public override void OnValueChanged(CarvingHomeEntryProperty property)
		{
		}

		// Token: 0x06023967 RID: 145767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023967")]
		[Address(RVA = "0x1E39B10", Offset = "0x1E38710", VA = "0x181E39B10")]
		private void _ResetItemStatus(string currId, string nextId)
		{
		}

		// Token: 0x06023968 RID: 145768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023968")]
		[Address(RVA = "0x1E397A0", Offset = "0x1E383A0", VA = "0x181E397A0")]
		private void _AppendItemAnim(Sequence sequence, CarvingHomeEntryChallengeTabView item, CarvingHomeEntryChallengeTabView.AnimType type)
		{
		}

		// Token: 0x06023969 RID: 145769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023969")]
		[Address(RVA = "0x1E39890", Offset = "0x1E38490", VA = "0x181E39890")]
		private CarvingHomeEntryChallengeTabView _GetItemTab(string itemId)
		{
			return null;
		}

		// Token: 0x0602396A RID: 145770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602396A")]
		[Address(RVA = "0x1E39D70", Offset = "0x1E38970", VA = "0x181E39D70")]
		public CarvingHomeEntryChallengeGroupView()
		{
		}

		// Token: 0x04031411 RID: 201745
		[Token(Token = "0x4031411")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _tabContainer;

		// Token: 0x04031412 RID: 201746
		[Token(Token = "0x4031412")]
		[FieldOffset(Offset = "0x28")]
		private Sequence m_switchAnim;

		// Token: 0x04031413 RID: 201747
		[Token(Token = "0x4031413")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_enterAnim;

		// Token: 0x04031414 RID: 201748
		[Token(Token = "0x4031414")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, CarvingHomeEntryChallengeTabView> m_itemTab;

		// Token: 0x04031415 RID: 201749
		[Token(Token = "0x4031415")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedIndex;

		// Token: 0x04031416 RID: 201750
		[Token(Token = "0x4031416")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedCurrId;

		// Token: 0x04031417 RID: 201751
		[Token(Token = "0x4031417")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedTabId;

		// Token: 0x04031418 RID: 201752
		[Token(Token = "0x4031418")]
		[FieldOffset(Offset = "0x58")]
		private CarvingHomeEntryItemViewModel m_cachedPrevModel;

		// Token: 0x04031419 RID: 201753
		[Token(Token = "0x4031419")]
		[FieldOffset(Offset = "0x60")]
		private int m_cacheEnterSequence;

		// Token: 0x0403141A RID: 201754
		[Token(Token = "0x403141A")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403141B RID: 201755
		[Token(Token = "0x403141B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403141C RID: 201756
		[Token(Token = "0x403141C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403141D RID: 201757
		[Token(Token = "0x403141D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetItemStatus;

		// Token: 0x0403141E RID: 201758
		[Token(Token = "0x403141E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AppendItemAnim;

		// Token: 0x0403141F RID: 201759
		[Token(Token = "0x403141F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetItemTab;

		// Token: 0x04031420 RID: 201760
		[Token(Token = "0x4031420")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
