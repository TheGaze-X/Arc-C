using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	public interface IBindingListView : IBindingList, IList, ICollection, IEnumerable
	{
		// Token: 0x06000AE6 RID: 2790
		[Token(Token = "0x6000AE6")]
		void ApplySort(ListSortDescriptionCollection sorts);

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000AE7 RID: 2791
		// (set) Token: 0x06000AE8 RID: 2792
		[Token(Token = "0x17000230")]
		string Filter { [Token(Token = "0x6000AE7")] get; [Token(Token = "0x6000AE8")] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000AE9 RID: 2793
		[Token(Token = "0x17000231")]
		ListSortDescriptionCollection SortDescriptions { [Token(Token = "0x6000AE9")] get; }

		// Token: 0x06000AEA RID: 2794
		[Token(Token = "0x6000AEA")]
		void RemoveFilter();

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000AEB RID: 2795
		[Token(Token = "0x17000232")]
		bool SupportsAdvancedSorting { [Token(Token = "0x6000AEB")] get; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000AEC RID: 2796
		[Token(Token = "0x17000233")]
		bool SupportsFiltering { [Token(Token = "0x6000AEC")] get; }
	}
}
