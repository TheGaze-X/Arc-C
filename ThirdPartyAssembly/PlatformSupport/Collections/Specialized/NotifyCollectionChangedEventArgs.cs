using System;
using System.Collections;
using Il2CppDummyDll;

namespace PlatformSupport.Collections.Specialized
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	public class NotifyCollectionChangedEventArgs : EventArgs
	{
		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x536D5D0", Offset = "0x536C1D0", VA = "0x18536D5D0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
		{
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x536DCC0", Offset = "0x536C8C0", VA = "0x18536DCC0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem)
		{
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x536D6C0", Offset = "0x536C2C0", VA = "0x18536D6C0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index)
		{
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x536D040", Offset = "0x536BC40", VA = "0x18536D040")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems)
		{
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x536CAB0", Offset = "0x536B6B0", VA = "0x18536CAB0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x536D3F0", Offset = "0x536BFF0", VA = "0x18536D3F0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem)
		{
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x536DAE0", Offset = "0x536C6E0", VA = "0x18536DAE0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object newItem, object oldItem, int index)
		{
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x536D930", Offset = "0x536C530", VA = "0x18536D930")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems)
		{
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x536CD40", Offset = "0x536B940", VA = "0x18536CD40")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x536D220", Offset = "0x536BE20", VA = "0x18536D220")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, object changedItem, int index, int oldIndex)
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x536CEF0", Offset = "0x536BAF0", VA = "0x18536CEF0")]
		public NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList changedItems, int index, int oldIndex)
		{
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x536C970", Offset = "0x536B570", VA = "0x18536C970")]
		internal NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int newIndex, int oldIndex)
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x536C630", Offset = "0x536B230", VA = "0x18536C630")]
		private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x536C6F0", Offset = "0x536B2F0", VA = "0x18536C6F0")]
		private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex)
		{
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x536C8C0", Offset = "0x536B4C0", VA = "0x18536C8C0")]
		private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex)
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x536C7A0", Offset = "0x536B3A0", VA = "0x18536C7A0")]
		private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex)
		{
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x170004C7")]
		public NotifyCollectionChangedAction Action
		{
			[Token(Token = "0x6002441")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return NotifyCollectionChangedAction.Add;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C8")]
		public IList NewItems
		{
			[Token(Token = "0x6002442")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C9")]
		public IList OldItems
		{
			[Token(Token = "0x6002443")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x170004CA")]
		public int NewStartingIndex
		{
			[Token(Token = "0x6002444")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x170004CB")]
		public int OldStartingIndex
		{
			[Token(Token = "0x6002445")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04001486 RID: 5254
		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x10")]
		private NotifyCollectionChangedAction _action;

		// Token: 0x04001487 RID: 5255
		[Token(Token = "0x4001487")]
		[FieldOffset(Offset = "0x18")]
		private IList _newItems;

		// Token: 0x04001488 RID: 5256
		[Token(Token = "0x4001488")]
		[FieldOffset(Offset = "0x20")]
		private IList _oldItems;

		// Token: 0x04001489 RID: 5257
		[Token(Token = "0x4001489")]
		[FieldOffset(Offset = "0x28")]
		private int _newStartingIndex;

		// Token: 0x0400148A RID: 5258
		[Token(Token = "0x400148A")]
		[FieldOffset(Offset = "0x2C")]
		private int _oldStartingIndex;
	}
}
