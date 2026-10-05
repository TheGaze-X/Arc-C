using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ChatBox
{
	// Token: 0x02005A39 RID: 23097
	[Token(Token = "0x2005A39")]
	public class UIChatBoxView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021A0C RID: 137740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A0C")]
		[Address(RVA = "0x1C11D00", Offset = "0x1C10900", VA = "0x181C11D00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021A0D RID: 137741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A0D")]
		[Address(RVA = "0x1C116F0", Offset = "0x1C102F0", VA = "0x181C116F0")]
		public UIChatBoxView.PlayHandler PlayChat(UIChatBoxView.PlayOptions playOptions)
		{
			return null;
		}

		// Token: 0x06021A0E RID: 137742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A0E")]
		[Address(RVA = "0x1C112F0", Offset = "0x1C0FEF0", VA = "0x181C112F0")]
		public void AppendPlayRecords(IEnumerable<UIRecycleLayoutAdapter.IVirtualView> records)
		{
		}

		// Token: 0x06021A0F RID: 137743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A0F")]
		[Address(RVA = "0x1C11520", Offset = "0x1C10120", VA = "0x181C11520")]
		public void DisplayChat(UIChatBoxView.DisplayOptions options)
		{
		}

		// Token: 0x06021A10 RID: 137744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A10")]
		[Address(RVA = "0x1C11440", Offset = "0x1C10040", VA = "0x181C11440")]
		public void ClearChat()
		{
		}

		// Token: 0x06021A11 RID: 137745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A11")]
		[Address(RVA = "0x1C119E0", Offset = "0x1C105E0", VA = "0x181C119E0")]
		public void RequestScrollRaycast(UIChatBoxView.ScrollRaycastRequestKey key)
		{
		}

		// Token: 0x06021A12 RID: 137746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A12")]
		[Address(RVA = "0x1C118C0", Offset = "0x1C104C0", VA = "0x181C118C0")]
		public void ReleaseScrollRaycast(UIChatBoxView.ScrollRaycastRequestKey key)
		{
		}

		// Token: 0x06021A13 RID: 137747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A13")]
		[Address(RVA = "0x1C11B00", Offset = "0x1C10700", VA = "0x181C11B00")]
		private void Update()
		{
		}

		// Token: 0x06021A14 RID: 137748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A14")]
		[Address(RVA = "0x1C11E80", Offset = "0x1C10A80", VA = "0x181C11E80")]
		public UIChatBoxView()
		{
		}

		// Token: 0x0402DFBF RID: 188351
		[Token(Token = "0x402DFBF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _chatScroll;

		// Token: 0x0402DFC0 RID: 188352
		[Token(Token = "0x402DFC0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _chatLayout;

		// Token: 0x0402DFC1 RID: 188353
		[Token(Token = "0x402DFC1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic _scrollRaycaster;

		// Token: 0x0402DFC2 RID: 188354
		[Token(Token = "0x402DFC2")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0402DFC3 RID: 188355
		[Token(Token = "0x402DFC3")]
		[FieldOffset(Offset = "0x38")]
		private UIChatBoxView.Adapter m_adapter;

		// Token: 0x0402DFC4 RID: 188356
		[Token(Token = "0x402DFC4")]
		[FieldOffset(Offset = "0x40")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_chatItems;

		// Token: 0x0402DFC5 RID: 188357
		[Token(Token = "0x402DFC5")]
		[FieldOffset(Offset = "0x48")]
		private UIChatBoxView.PlayHandler m_activePlayer;

		// Token: 0x0402DFC6 RID: 188358
		[Token(Token = "0x402DFC6")]
		[FieldOffset(Offset = "0x50")]
		private ListSet<UIChatBoxView.ScrollRaycastRequestKey> m_requests;

		// Token: 0x0402DFC7 RID: 188359
		[Token(Token = "0x402DFC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DFC8 RID: 188360
		[Token(Token = "0x402DFC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayChat;

		// Token: 0x0402DFC9 RID: 188361
		[Token(Token = "0x402DFC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AppendPlayRecords;

		// Token: 0x0402DFCA RID: 188362
		[Token(Token = "0x402DFCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DisplayChat;

		// Token: 0x0402DFCB RID: 188363
		[Token(Token = "0x402DFCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearChat;

		// Token: 0x0402DFCC RID: 188364
		[Token(Token = "0x402DFCC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RequestScrollRaycast;

		// Token: 0x0402DFCD RID: 188365
		[Token(Token = "0x402DFCD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReleaseScrollRaycast;

		// Token: 0x0402DFCE RID: 188366
		[Token(Token = "0x402DFCE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402DFCF RID: 188367
		[Token(Token = "0x402DFCF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A3A RID: 23098
		[Token(Token = "0x2005A3A")]
		protected class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06021A15 RID: 137749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A15")]
			[Address(RVA = "0x1C02290", Offset = "0x1C00E90", VA = "0x181C02290")]
			public Adapter(UIChatBoxView closure)
			{
			}

			// Token: 0x06021A16 RID: 137750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A16")]
			[Address(RVA = "0x1C01A60", Offset = "0x1C00660", VA = "0x181C01A60", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06021A17 RID: 137751 RVA: 0x000BAEA0 File Offset: 0x000B90A0
			[Token(Token = "0x6021A17")]
			[Address(RVA = "0x1C01920", Offset = "0x1C00520", VA = "0x181C01920")]
			public bool AddView(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return default(bool);
			}

			// Token: 0x06021A18 RID: 137752 RVA: 0x000BAEB8 File Offset: 0x000B90B8
			[Token(Token = "0x6021A18")]
			[Address(RVA = "0x1C01BF0", Offset = "0x1C007F0", VA = "0x181C01BF0")]
			public bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return default(bool);
			}

			// Token: 0x06021A19 RID: 137753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A19")]
			[Address(RVA = "0x1C01B60", Offset = "0x1C00760", VA = "0x181C01B60")]
			public void RebuildAll()
			{
			}

			// Token: 0x06021A1A RID: 137754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A1A")]
			[Address(RVA = "0x1C02020", Offset = "0x1C00C20", VA = "0x181C02020")]
			public void UpdateView(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x0402DFD0 RID: 188368
			[Token(Token = "0x402DFD0")]
			[FieldOffset(Offset = "0x18")]
			private UIChatBoxView m_closure;

			// Token: 0x0402DFD1 RID: 188369
			[Token(Token = "0x402DFD1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DFD2 RID: 188370
			[Token(Token = "0x402DFD2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0402DFD3 RID: 188371
			[Token(Token = "0x402DFD3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AddView;

			// Token: 0x0402DFD4 RID: 188372
			[Token(Token = "0x402DFD4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RemoveView;

			// Token: 0x0402DFD5 RID: 188373
			[Token(Token = "0x402DFD5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RebuildAll;

			// Token: 0x0402DFD6 RID: 188374
			[Token(Token = "0x402DFD6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}

		// Token: 0x02005A3B RID: 23099
		[Token(Token = "0x2005A3B")]
		public class PlayHandler : IHotfixable
		{
			// Token: 0x06021A1B RID: 137755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A1B")]
			[Address(RVA = "0x1C0EAF0", Offset = "0x1C0D6F0", VA = "0x181C0EAF0")]
			public PlayHandler(UIChatBoxView closure, UIChatBoxView.PlayOptions options)
			{
			}

			// Token: 0x17004EF1 RID: 20209
			// (get) Token: 0x06021A1C RID: 137756 RVA: 0x000BAED0 File Offset: 0x000B90D0
			// (set) Token: 0x06021A1D RID: 137757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004EF1")]
			public bool isPlaying
			{
				[Token(Token = "0x6021A1C")]
				[Address(RVA = "0x1C0EBD0", Offset = "0x1C0D7D0", VA = "0x181C0EBD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6021A1D")]
				[Address(RVA = "0x1C0EC90", Offset = "0x1C0D890", VA = "0x181C0EC90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17004EF2 RID: 20210
			// (get) Token: 0x06021A1E RID: 137758 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06021A1F RID: 137759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004EF2")]
			public UIRecycleLayoutAdapter.IVirtualView tickingItem
			{
				[Token(Token = "0x6021A1E")]
				[Address(RVA = "0x1C0EC30", Offset = "0x1C0D830", VA = "0x181C0EC30")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6021A1F")]
				[Address(RVA = "0x1C0ED00", Offset = "0x1C0D900", VA = "0x181C0ED00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06021A20 RID: 137760 RVA: 0x000BAEE8 File Offset: 0x000B90E8
			[Token(Token = "0x6021A20")]
			[Address(RVA = "0x1C0E8C0", Offset = "0x1C0D4C0", VA = "0x181C0E8C0")]
			private bool _IsValid()
			{
				return default(bool);
			}

			// Token: 0x06021A21 RID: 137761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A21")]
			[Address(RVA = "0x1C0E610", Offset = "0x1C0D210", VA = "0x181C0E610")]
			public IEnumerator PlayItem(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return null;
			}

			// Token: 0x06021A22 RID: 137762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A22")]
			[Address(RVA = "0x1C0E540", Offset = "0x1C0D140", VA = "0x181C0E540")]
			public IEnumerator PlayItemAndRemove(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return null;
			}

			// Token: 0x06021A23 RID: 137763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A23")]
			[Address(RVA = "0x1C0E6E0", Offset = "0x1C0D2E0", VA = "0x181C0E6E0")]
			public IEnumerator ScrollToBottomIfNecessary()
			{
				return null;
			}

			// Token: 0x06021A24 RID: 137764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A24")]
			[Address(RVA = "0x1C0E970", Offset = "0x1C0D570", VA = "0x181C0E970")]
			private IEnumerator _PlayItemImpl(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return null;
			}

			// Token: 0x06021A25 RID: 137765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021A25")]
			[Address(RVA = "0x1C0EA40", Offset = "0x1C0D640", VA = "0x181C0EA40")]
			private IEnumerator _ScrollToBottomIfNecessaryImpl()
			{
				return null;
			}

			// Token: 0x0402DFD7 RID: 188375
			[Token(Token = "0x402DFD7")]
			private const float DEFAULT_SCROLL_DUR = 0.2f;

			// Token: 0x0402DFD8 RID: 188376
			[Token(Token = "0x402DFD8")]
			[FieldOffset(Offset = "0x10")]
			private UIChatBoxView m_closure;

			// Token: 0x0402DFD9 RID: 188377
			[Token(Token = "0x402DFD9")]
			[FieldOffset(Offset = "0x18")]
			private float m_scrollDur;

			// Token: 0x0402DFDC RID: 188380
			[Token(Token = "0x402DFDC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402DFDD RID: 188381
			[Token(Token = "0x402DFDD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isPlaying;

			// Token: 0x0402DFDE RID: 188382
			[Token(Token = "0x402DFDE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isPlaying;

			// Token: 0x0402DFDF RID: 188383
			[Token(Token = "0x402DFDF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_tickingItem;

			// Token: 0x0402DFE0 RID: 188384
			[Token(Token = "0x402DFE0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_set_tickingItem;

			// Token: 0x0402DFE1 RID: 188385
			[Token(Token = "0x402DFE1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__IsValid;

			// Token: 0x0402DFE2 RID: 188386
			[Token(Token = "0x402DFE2")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_PlayItem;

			// Token: 0x0402DFE3 RID: 188387
			[Token(Token = "0x402DFE3")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_PlayItemAndRemove;

			// Token: 0x0402DFE4 RID: 188388
			[Token(Token = "0x402DFE4")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_ScrollToBottomIfNecessary;

			// Token: 0x0402DFE5 RID: 188389
			[Token(Token = "0x402DFE5")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__PlayItemImpl;

			// Token: 0x0402DFE6 RID: 188390
			[Token(Token = "0x402DFE6")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__ScrollToBottomIfNecessaryImpl;
		}

		// Token: 0x02005A41 RID: 23105
		[Token(Token = "0x2005A41")]
		public struct PlayOptions
		{
			// Token: 0x0402E000 RID: 188416
			[Token(Token = "0x402E000")]
			[FieldOffset(Offset = "0x0")]
			public float scrollDuration;
		}

		// Token: 0x02005A42 RID: 23106
		[Token(Token = "0x2005A42")]
		public struct DisplayOptions
		{
			// Token: 0x0402E001 RID: 188417
			[Token(Token = "0x402E001")]
			[FieldOffset(Offset = "0x0")]
			public IList<UIRecycleLayoutAdapter.IVirtualView> chatList;
		}

		// Token: 0x02005A43 RID: 23107
		[Token(Token = "0x2005A43")]
		public enum ScrollRaycastRequestKey
		{
			// Token: 0x0402E003 RID: 188419
			[Token(Token = "0x402E003")]
			CHAT_CONTROLLER,
			// Token: 0x0402E004 RID: 188420
			[Token(Token = "0x402E004")]
			CHAT_ITEM
		}
	}
}
