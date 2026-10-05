using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A82 RID: 27266
	[Token(Token = "0x2006A82")]
	public class StageMixStoryBriefLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602702F RID: 159791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602702F")]
		[Address(RVA = "0x223C3F0", Offset = "0x223AFF0", VA = "0x18223C3F0")]
		public void ResetView()
		{
		}

		// Token: 0x06027030 RID: 159792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027030")]
		[Address(RVA = "0x223C0F0", Offset = "0x223ACF0", VA = "0x18223C0F0")]
		public void Render(MixStoryZoneGroupViewModel model)
		{
		}

		// Token: 0x06027031 RID: 159793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027031")]
		[Address(RVA = "0x223C450", Offset = "0x223B050", VA = "0x18223C450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027032 RID: 159794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027032")]
		[Address(RVA = "0x223C6D0", Offset = "0x223B2D0", VA = "0x18223C6D0")]
		public StageMixStoryBriefLineView()
		{
		}

		// Token: 0x040372E2 RID: 226018
		[Token(Token = "0x40372E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _continuousPanel;

		// Token: 0x040372E3 RID: 226019
		[Token(Token = "0x40372E3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _discretePanel;

		// Token: 0x040372E4 RID: 226020
		[Token(Token = "0x40372E4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StageMixStoryBriefLineItemView _itemPrefab;

		// Token: 0x040372E5 RID: 226021
		[Token(Token = "0x40372E5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _itemParent;

		// Token: 0x040372E6 RID: 226022
		[Token(Token = "0x40372E6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _activeDistance;

		// Token: 0x040372E7 RID: 226023
		[Token(Token = "0x40372E7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Ease _focusEase;

		// Token: 0x040372E8 RID: 226024
		[Token(Token = "0x40372E8")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x040372E9 RID: 226025
		[Token(Token = "0x40372E9")]
		[FieldOffset(Offset = "0x48")]
		private StageMixStoryBriefLineView.Animator m_animator;

		// Token: 0x040372EA RID: 226026
		[Token(Token = "0x40372EA")]
		[FieldOffset(Offset = "0x50")]
		private int m_cachedPosition;

		// Token: 0x040372EB RID: 226027
		[Token(Token = "0x40372EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ResetView;

		// Token: 0x040372EC RID: 226028
		[Token(Token = "0x40372EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040372ED RID: 226029
		[Token(Token = "0x40372ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040372EE RID: 226030
		[Token(Token = "0x40372EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A83 RID: 27267
		[Token(Token = "0x2006A83")]
		private class Animator
		{
			// Token: 0x17005C30 RID: 23600
			// (get) Token: 0x06027033 RID: 159795 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027034 RID: 159796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C30")]
			public List<StageStorylineStorySetViewModel> dataSource
			{
				[Token(Token = "0x6027033")]
				[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6027034")]
				[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06027035 RID: 159797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027035")]
			[Address(RVA = "0x2237300", Offset = "0x2235F00", VA = "0x182237300")]
			public Animator(StageMixStoryBriefLineItemView itemPrefab, Transform itemParent, int activeDistance, Ease focusEase)
			{
			}

			// Token: 0x06027036 RID: 159798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027036")]
			[Address(RVA = "0x22368E0", Offset = "0x22354E0", VA = "0x1822368E0")]
			public void Reset(int focusIndex)
			{
			}

			// Token: 0x06027037 RID: 159799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027037")]
			[Address(RVA = "0x2236930", Offset = "0x2235530", VA = "0x182236930")]
			public void Update(int focusIndex)
			{
			}

			// Token: 0x06027038 RID: 159800 RVA: 0x000CD470 File Offset: 0x000CB670
			[Token(Token = "0x6027038")]
			[Address(RVA = "0x17DB8E0", Offset = "0x17DA4E0", VA = "0x1817DB8E0")]
			private float _GetPosition()
			{
				return 0f;
			}

			// Token: 0x06027039 RID: 159801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027039")]
			[Address(RVA = "0x2236B70", Offset = "0x2235770", VA = "0x182236B70")]
			private void _SetPosition(float position)
			{
			}

			// Token: 0x0602703A RID: 159802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602703A")]
			[Address(RVA = "0x2236AB0", Offset = "0x22356B0", VA = "0x182236AB0")]
			private StageMixStoryBriefLineItemView _FetchSpareView()
			{
				return null;
			}

			// Token: 0x0602703B RID: 159803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602703B")]
			[Address(RVA = "0x2237290", Offset = "0x2235E90", VA = "0x182237290")]
			private void _SpareView(StageMixStoryBriefLineItemView view)
			{
			}

			// Token: 0x0602703C RID: 159804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602703C")]
			[Address(RVA = "0x2237030", Offset = "0x2235C30", VA = "0x182237030")]
			private void _SpareAllViews()
			{
			}

			// Token: 0x040372EF RID: 226031
			[Token(Token = "0x40372EF")]
			[FieldOffset(Offset = "0x10")]
			private readonly StageMixStoryBriefLineItemView m_itemPrefab;

			// Token: 0x040372F0 RID: 226032
			[Token(Token = "0x40372F0")]
			[FieldOffset(Offset = "0x18")]
			private readonly Transform m_itemParent;

			// Token: 0x040372F1 RID: 226033
			[Token(Token = "0x40372F1")]
			[FieldOffset(Offset = "0x20")]
			private readonly int m_activeDistance;

			// Token: 0x040372F2 RID: 226034
			[Token(Token = "0x40372F2")]
			[FieldOffset(Offset = "0x24")]
			private readonly Ease m_focusEase;

			// Token: 0x040372F3 RID: 226035
			[Token(Token = "0x40372F3")]
			[FieldOffset(Offset = "0x28")]
			private readonly float m_focusDuration;

			// Token: 0x040372F4 RID: 226036
			[Token(Token = "0x40372F4")]
			[FieldOffset(Offset = "0x30")]
			private readonly ListDict<int, StageMixStoryBriefLineItemView> m_activeItems;

			// Token: 0x040372F5 RID: 226037
			[Token(Token = "0x40372F5")]
			[FieldOffset(Offset = "0x38")]
			private readonly Stack<StageMixStoryBriefLineItemView> m_inactiveItems;

			// Token: 0x040372F6 RID: 226038
			[Token(Token = "0x40372F6")]
			[FieldOffset(Offset = "0x40")]
			private readonly HashSet<int> m_toRemove;

			// Token: 0x040372F7 RID: 226039
			[Token(Token = "0x40372F7")]
			[FieldOffset(Offset = "0x48")]
			private int m_focusIndex;

			// Token: 0x040372F8 RID: 226040
			[Token(Token = "0x40372F8")]
			[FieldOffset(Offset = "0x4C")]
			private float m_position;

			// Token: 0x040372F9 RID: 226041
			[Token(Token = "0x40372F9")]
			[FieldOffset(Offset = "0x50")]
			private Tween m_tween;
		}
	}
}
