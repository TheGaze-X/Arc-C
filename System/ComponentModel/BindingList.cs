using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	[Serializable]
	public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents
	{
		// Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000982")]
		public BindingList()
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000983")]
		public BindingList(IList<T> list)
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000984")]
		private void Initialize()
		{
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x170001DC")]
		private bool ItemTypeHasDefaultConstructor
		{
			[Token(Token = "0x6000985")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000986 RID: 2438 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000987 RID: 2439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000005")]
		public event AddingNewEventHandler AddingNew
		{
			[Token(Token = "0x6000986")]
			add
			{
			}
			[Token(Token = "0x6000987")]
			remove
			{
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000988")]
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000989")]
		private object FireAddingNew()
		{
			return null;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600098A RID: 2442 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600098B RID: 2443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public event ListChangedEventHandler ListChanged
		{
			[Token(Token = "0x600098A")]
			add
			{
			}
			[Token(Token = "0x600098B")]
			remove
			{
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600098C")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x000059D0 File Offset: 0x00003BD0
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DD")]
		public bool RaiseListChangedEvents
		{
			[Token(Token = "0x600098D")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098E")]
			set
			{
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600098F")]
		public void ResetBindings()
		{
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000990")]
		public void ResetItem(int position)
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000991")]
		private void FireListChanged(ListChangedType type, int index)
		{
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000992")]
		protected override void ClearItems()
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000993")]
		protected override void InsertItem(int index, T item)
		{
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000994")]
		protected override void RemoveItem(int index)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000995")]
		protected override void SetItem(int index, T item)
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000996")]
		public virtual void CancelNew(int itemIndex)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000997")]
		public virtual void EndNew(int itemIndex)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		public T AddNew()
		{
			return null;
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000999")]
		private object AddNew()
		{
			return null;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x170001DE")]
		private bool AddingNewHandled
		{
			[Token(Token = "0x600099A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		protected virtual object AddNewCore()
		{
			return null;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00005A00 File Offset: 0x00003C00
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001DF")]
		public bool AllowNew
		{
			[Token(Token = "0x600099C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600099D")]
			set
			{
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x170001E0")]
		private bool AllowNew
		{
			[Token(Token = "0x600099E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00005A30 File Offset: 0x00003C30
		// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001E1")]
		public bool AllowEdit
		{
			[Token(Token = "0x600099F")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A0")]
			set
			{
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x170001E2")]
		private bool AllowEdit
		{
			[Token(Token = "0x60009A1")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00005A60 File Offset: 0x00003C60
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001E3")]
		public bool AllowRemove
		{
			[Token(Token = "0x60009A2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009A3")]
			set
			{
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x170001E4")]
		private bool AllowRemove
		{
			[Token(Token = "0x60009A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x170001E5")]
		private bool SupportsChangeNotification
		{
			[Token(Token = "0x60009A5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x170001E6")]
		protected virtual bool SupportsChangeNotificationCore
		{
			[Token(Token = "0x60009A6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x170001E7")]
		private bool SupportsSearching
		{
			[Token(Token = "0x60009A7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x170001E8")]
		protected virtual bool SupportsSearchingCore
		{
			[Token(Token = "0x60009A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x170001E9")]
		private bool SupportsSorting
		{
			[Token(Token = "0x60009A9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x170001EA")]
		protected virtual bool SupportsSortingCore
		{
			[Token(Token = "0x60009AA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x170001EB")]
		private bool IsSorted
		{
			[Token(Token = "0x60009AB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x170001EC")]
		protected virtual bool IsSortedCore
		{
			[Token(Token = "0x60009AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001ED")]
		private PropertyDescriptor SortProperty
		{
			[Token(Token = "0x60009AD")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EE")]
		protected virtual PropertyDescriptor SortPropertyCore
		{
			[Token(Token = "0x60009AE")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x170001EF")]
		private ListSortDirection SortDirection
		{
			[Token(Token = "0x60009AF")]
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x170001F0")]
		protected virtual ListSortDirection SortDirectionCore
		{
			[Token(Token = "0x60009B0")]
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B1")]
		private void ApplySort(PropertyDescriptor prop, ListSortDirection direction)
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B2")]
		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B3")]
		private void RemoveSort()
		{
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B4")]
		protected virtual void RemoveSortCore()
		{
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x60009B5")]
		private int Find(PropertyDescriptor prop, object key)
		{
			return 0;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x60009B6")]
		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			return 0;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B7")]
		private void AddIndex(PropertyDescriptor prop)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B8")]
		private void RemoveIndex(PropertyDescriptor prop)
		{
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009B9")]
		private void HookPropertyChanged(T item)
		{
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BA")]
		private void UnhookPropertyChanged(T item)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009BB")]
		private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x170001F1")]
		private bool RaisesItemChangedEvents
		{
			[Token(Token = "0x60009BC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		[FieldOffset(Offset = "0x0")]
		private int addNewPos;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0x0")]
		private bool raiseListChangedEvents;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x0")]
		private bool raiseItemChangedEvents;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private PropertyDescriptorCollection _itemTypeProperties;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private PropertyChangedEventHandler _propertyChangedEventHandler;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private AddingNewEventHandler _onAddingNew;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private ListChangedEventHandler _onListChanged;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private int _lastChangeIndex;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0x0")]
		private bool allowNew;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0x0")]
		private bool allowEdit;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[FieldOffset(Offset = "0x0")]
		private bool allowRemove;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[FieldOffset(Offset = "0x0")]
		private bool userSetAllowNew;
	}
}
