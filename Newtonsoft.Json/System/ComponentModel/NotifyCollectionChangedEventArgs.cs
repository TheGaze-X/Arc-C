using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Preserve]
	public class NotifyCollectionChangedEventArgs
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002058 File Offset: 0x00000258
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000002")]
		internal NotifyCollectionChangedAction Action
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return NotifyCollectionChangedAction.Add;
			}
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000003")]
		internal IList NewItems
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000004")]
		internal int NewStartingIndex
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000005")]
		internal IList OldItems
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002088 File Offset: 0x00000288
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000006")]
		internal int OldStartingIndex
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4D7CB20", Offset = "0x4D7B720", VA = "0x184D7CB20")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4D7CDE0", Offset = "0x4D7B9E0", VA = "0x184D7CDE0")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F04A0", Offset = "0x4EF0A0", VA = "0x1804F04A0")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4D7CC50", Offset = "0x4D7B850", VA = "0x184D7CC50")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4D7CC80", Offset = "0x4D7B880", VA = "0x184D7CC80")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4D7CBE0", Offset = "0x4D7B7E0", VA = "0x184D7CBE0")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4D7CD50", Offset = "0x4D7B950", VA = "0x184D7CD50")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4D7CDB0", Offset = "0x4D7B9B0", VA = "0x184D7CDB0")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4D7CA50", Offset = "0x4D7B650", VA = "0x184D7CA50")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
		}
	}
}
