using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02006006 RID: 24582
	[Token(Token = "0x2006006")]
	public class CGGalleryCollectionLineView : MonoBehaviour, IUIIntegerLocateRegistry, IUILocateRegistry, IHotfixable
	{
		// Token: 0x170053F3 RID: 21491
		// (get) Token: 0x06023887 RID: 145543 RVA: 0x000C1338 File Offset: 0x000BF538
		[Token(Token = "0x170053F3")]
		public bool locked
		{
			[Token(Token = "0x6023887")]
			[Address(RVA = "0x1E2CBE0", Offset = "0x1E2B7E0", VA = "0x181E2CBE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170053F4 RID: 21492
		// (get) Token: 0x06023888 RID: 145544 RVA: 0x000C1350 File Offset: 0x000BF550
		[Token(Token = "0x170053F4")]
		public bool popRight
		{
			[Token(Token = "0x6023888")]
			[Address(RVA = "0x1E2CCA0", Offset = "0x1E2B8A0", VA = "0x181E2CCA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06023889 RID: 145545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023889")]
		[Address(RVA = "0x1E2C030", Offset = "0x1E2AC30", VA = "0x181E2C030")]
		public void ClearPosition()
		{
		}

		// Token: 0x0602388A RID: 145546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602388A")]
		[Address(RVA = "0x1E2C0D0", Offset = "0x1E2ACD0", VA = "0x181E2C0D0")]
		public void LockForPosition(int position)
		{
		}

		// Token: 0x0602388B RID: 145547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602388B")]
		[Address(RVA = "0x1E2C590", Offset = "0x1E2B190", VA = "0x181E2C590")]
		public void Render(List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> groups)
		{
		}

		// Token: 0x170053F5 RID: 21493
		// (get) Token: 0x0602388C RID: 145548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053F5")]
		public IReadOnlyCollection<int> metasObserved
		{
			[Token(Token = "0x602388C")]
			[Address(RVA = "0x1E2CC40", Offset = "0x1E2B840", VA = "0x181E2CC40", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602388D RID: 145549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602388D")]
		[Address(RVA = "0x1E2C510", Offset = "0x1E2B110", VA = "0x181E2C510", Slot = "5")]
		public void OnMetaChange(int id, object meta)
		{
		}

		// Token: 0x0602388E RID: 145550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602388E")]
		[Address(RVA = "0x1E2C1E0", Offset = "0x1E2ADE0", VA = "0x181E2C1E0", Slot = "6")]
		public void OnLocatedChange(int located)
		{
		}

		// Token: 0x0602388F RID: 145551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602388F")]
		[Address(RVA = "0x1E2C4B0", Offset = "0x1E2B0B0", VA = "0x181E2C4B0", Slot = "7")]
		public void OnLocatingStateChange(bool locating)
		{
		}

		// Token: 0x1400008E RID: 142
		// (add) Token: 0x06023890 RID: 145552 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06023891 RID: 145553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400008E")]
		public event Action<int> requestLocate
		{
			[Token(Token = "0x6023890")]
			[Address(RVA = "0x1E2CAE0", Offset = "0x1E2B6E0", VA = "0x181E2CAE0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6023891")]
			[Address(RVA = "0x1E2CD00", Offset = "0x1E2B900", VA = "0x181E2CD00", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06023892 RID: 145554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023892")]
		[Address(RVA = "0x1E2C6D0", Offset = "0x1E2B2D0", VA = "0x181E2C6D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023893 RID: 145555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023893")]
		[Address(RVA = "0x1E2C9A0", Offset = "0x1E2B5A0", VA = "0x181E2C9A0")]
		private void _RequestLocate(int index)
		{
		}

		// Token: 0x06023894 RID: 145556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023894")]
		[Address(RVA = "0x1E2CA60", Offset = "0x1E2B660", VA = "0x181E2CA60")]
		public CGGalleryCollectionLineView()
		{
		}

		// Token: 0x040312AA RID: 201386
		[Token(Token = "0x40312AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CGGalleryCollectionLineItemView _itemPrefab;

		// Token: 0x040312AB RID: 201387
		[Token(Token = "0x40312AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemParent;

		// Token: 0x040312AC RID: 201388
		[Token(Token = "0x40312AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _activeDistance;

		// Token: 0x040312AD RID: 201389
		[Token(Token = "0x40312AD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Ease _focusEase;

		// Token: 0x040312AE RID: 201390
		[Token(Token = "0x40312AE")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040312AF RID: 201391
		[Token(Token = "0x40312AF")]
		[FieldOffset(Offset = "0x38")]
		private CGGalleryCollectionLineView.Animator m_animator;

		// Token: 0x040312B0 RID: 201392
		[Token(Token = "0x40312B0")]
		[FieldOffset(Offset = "0x40")]
		private List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> m_cachedGroups;

		// Token: 0x040312B1 RID: 201393
		[Token(Token = "0x40312B1")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedPosition;

		// Token: 0x040312B2 RID: 201394
		[Token(Token = "0x40312B2")]
		[FieldOffset(Offset = "0x4C")]
		private int m_lockForPosition;

		// Token: 0x040312B3 RID: 201395
		[Token(Token = "0x40312B3")]
		[FieldOffset(Offset = "0x50")]
		private bool m_popRight;

		// Token: 0x040312B5 RID: 201397
		[Token(Token = "0x40312B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_locked;

		// Token: 0x040312B6 RID: 201398
		[Token(Token = "0x40312B6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_popRight;

		// Token: 0x040312B7 RID: 201399
		[Token(Token = "0x40312B7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ClearPosition;

		// Token: 0x040312B8 RID: 201400
		[Token(Token = "0x40312B8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LockForPosition;

		// Token: 0x040312B9 RID: 201401
		[Token(Token = "0x40312B9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040312BA RID: 201402
		[Token(Token = "0x40312BA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_metasObserved;

		// Token: 0x040312BB RID: 201403
		[Token(Token = "0x40312BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMetaChange;

		// Token: 0x040312BC RID: 201404
		[Token(Token = "0x40312BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLocatedChange;

		// Token: 0x040312BD RID: 201405
		[Token(Token = "0x40312BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnLocatingStateChange;

		// Token: 0x040312BE RID: 201406
		[Token(Token = "0x40312BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_add_requestLocate;

		// Token: 0x040312BF RID: 201407
		[Token(Token = "0x40312BF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_remove_requestLocate;

		// Token: 0x040312C0 RID: 201408
		[Token(Token = "0x40312C0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040312C1 RID: 201409
		[Token(Token = "0x40312C1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RequestLocate;

		// Token: 0x040312C2 RID: 201410
		[Token(Token = "0x40312C2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006007 RID: 24583
		[Token(Token = "0x2006007")]
		private class Animator
		{
			// Token: 0x170053F6 RID: 21494
			// (get) Token: 0x06023895 RID: 145557 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06023896 RID: 145558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053F6")]
			public Action<int> requestFocus
			{
				[Token(Token = "0x6023895")]
				[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6023896")]
				[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170053F7 RID: 21495
			// (set) Token: 0x06023897 RID: 145559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170053F7")]
			public List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> dataSource
			{
				[Token(Token = "0x6023897")]
				[Address(RVA = "0x1E29C90", Offset = "0x1E28890", VA = "0x181E29C90")]
				set
				{
				}
			}

			// Token: 0x06023898 RID: 145560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023898")]
			[Address(RVA = "0x1E29AB0", Offset = "0x1E286B0", VA = "0x181E29AB0")]
			public Animator(CGGalleryCollectionLineItemView itemPrefab, Transform itemParent, int activeDistance, Ease focusEase)
			{
			}

			// Token: 0x06023899 RID: 145561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023899")]
			[Address(RVA = "0x1E28F00", Offset = "0x1E27B00", VA = "0x181E28F00")]
			public void Clear()
			{
			}

			// Token: 0x0602389A RID: 145562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602389A")]
			[Address(RVA = "0x1E28F40", Offset = "0x1E27B40", VA = "0x181E28F40")]
			public void Reset(int focusIndex)
			{
			}

			// Token: 0x0602389B RID: 145563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602389B")]
			[Address(RVA = "0x1E28F90", Offset = "0x1E27B90", VA = "0x181E28F90")]
			public void Update(int focusIndex)
			{
			}

			// Token: 0x0602389C RID: 145564 RVA: 0x000C1368 File Offset: 0x000BF568
			[Token(Token = "0x602389C")]
			[Address(RVA = "0x1E29290", Offset = "0x1E27E90", VA = "0x181E29290")]
			private float _GetPosition()
			{
				return 0f;
			}

			// Token: 0x0602389D RID: 145565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602389D")]
			[Address(RVA = "0x1E292C0", Offset = "0x1E27EC0", VA = "0x181E292C0")]
			private void _SetPosition(float position)
			{
			}

			// Token: 0x0602389E RID: 145566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602389E")]
			[Address(RVA = "0x1E29110", Offset = "0x1E27D10", VA = "0x181E29110")]
			private CGGalleryCollectionLineItemView _FetchSpareView()
			{
				return null;
			}

			// Token: 0x0602389F RID: 145567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602389F")]
			[Address(RVA = "0x1E29A40", Offset = "0x1E28640", VA = "0x181E29A40")]
			private void _SpareView(CGGalleryCollectionLineItemView view)
			{
			}

			// Token: 0x060238A0 RID: 145568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60238A0")]
			[Address(RVA = "0x1E29780", Offset = "0x1E28380", VA = "0x181E29780")]
			private void _SpareAllViews()
			{
			}

			// Token: 0x060238A1 RID: 145569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60238A1")]
			[Address(RVA = "0x1E292A0", Offset = "0x1E27EA0", VA = "0x181E292A0")]
			private void _RequestFocus(int index)
			{
			}

			// Token: 0x040312C3 RID: 201411
			[Token(Token = "0x40312C3")]
			[FieldOffset(Offset = "0x10")]
			private readonly CGGalleryCollectionLineItemView m_itemPrefab;

			// Token: 0x040312C4 RID: 201412
			[Token(Token = "0x40312C4")]
			[FieldOffset(Offset = "0x18")]
			private readonly Transform m_itemParent;

			// Token: 0x040312C5 RID: 201413
			[Token(Token = "0x40312C5")]
			[FieldOffset(Offset = "0x20")]
			private readonly int m_activeDistance;

			// Token: 0x040312C6 RID: 201414
			[Token(Token = "0x40312C6")]
			[FieldOffset(Offset = "0x24")]
			private readonly Ease m_focusEase;

			// Token: 0x040312C7 RID: 201415
			[Token(Token = "0x40312C7")]
			[FieldOffset(Offset = "0x28")]
			private readonly float m_focusDuration;

			// Token: 0x040312C8 RID: 201416
			[Token(Token = "0x40312C8")]
			[FieldOffset(Offset = "0x30")]
			private readonly ListDict<int, CGGalleryCollectionLineItemView> m_activeItems;

			// Token: 0x040312C9 RID: 201417
			[Token(Token = "0x40312C9")]
			[FieldOffset(Offset = "0x38")]
			private readonly Stack<CGGalleryCollectionLineItemView> m_inactiveItems;

			// Token: 0x040312CA RID: 201418
			[Token(Token = "0x40312CA")]
			[FieldOffset(Offset = "0x40")]
			private readonly HashSet<int> m_toRemove;

			// Token: 0x040312CB RID: 201419
			[Token(Token = "0x40312CB")]
			[FieldOffset(Offset = "0x48")]
			private List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> m_dataSource;

			// Token: 0x040312CC RID: 201420
			[Token(Token = "0x40312CC")]
			[FieldOffset(Offset = "0x50")]
			private int m_focusIndex;

			// Token: 0x040312CD RID: 201421
			[Token(Token = "0x40312CD")]
			[FieldOffset(Offset = "0x54")]
			private float m_position;

			// Token: 0x040312CE RID: 201422
			[Token(Token = "0x40312CE")]
			[FieldOffset(Offset = "0x58")]
			private Tween m_tween;
		}
	}
}
