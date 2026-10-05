using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	public interface IBindingList : IList, ICollection, IEnumerable
	{
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000AD5 RID: 2773
		[Token(Token = "0x17000227")]
		bool AllowNew { [Token(Token = "0x6000AD5")] get; }

		// Token: 0x06000AD6 RID: 2774
		[Token(Token = "0x6000AD6")]
		object AddNew();

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000AD7 RID: 2775
		[Token(Token = "0x17000228")]
		bool AllowEdit { [Token(Token = "0x6000AD7")] get; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000AD8 RID: 2776
		[Token(Token = "0x17000229")]
		bool AllowRemove { [Token(Token = "0x6000AD8")] get; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000AD9 RID: 2777
		[Token(Token = "0x1700022A")]
		bool SupportsChangeNotification { [Token(Token = "0x6000AD9")] get; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000ADA RID: 2778
		[Token(Token = "0x1700022B")]
		bool SupportsSearching { [Token(Token = "0x6000ADA")] get; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000ADB RID: 2779
		[Token(Token = "0x1700022C")]
		bool SupportsSorting { [Token(Token = "0x6000ADB")] get; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000ADC RID: 2780
		[Token(Token = "0x1700022D")]
		bool IsSorted { [Token(Token = "0x6000ADC")] get; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000ADD RID: 2781
		[Token(Token = "0x1700022E")]
		PropertyDescriptor SortProperty { [Token(Token = "0x6000ADD")] get; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000ADE RID: 2782
		[Token(Token = "0x1700022F")]
		ListSortDirection SortDirection { [Token(Token = "0x6000ADE")] get; }

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000ADF RID: 2783
		// (remove) Token: 0x06000AE0 RID: 2784
		[Token(Token = "0x14000007")]
		event ListChangedEventHandler ListChanged;

		// Token: 0x06000AE1 RID: 2785
		[Token(Token = "0x6000AE1")]
		void AddIndex(PropertyDescriptor property);

		// Token: 0x06000AE2 RID: 2786
		[Token(Token = "0x6000AE2")]
		void ApplySort(PropertyDescriptor property, ListSortDirection direction);

		// Token: 0x06000AE3 RID: 2787
		[Token(Token = "0x6000AE3")]
		int Find(PropertyDescriptor property, object key);

		// Token: 0x06000AE4 RID: 2788
		[Token(Token = "0x6000AE4")]
		void RemoveIndex(PropertyDescriptor property);

		// Token: 0x06000AE5 RID: 2789
		[Token(Token = "0x6000AE5")]
		void RemoveSort();
	}
}
