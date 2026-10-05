using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004975 RID: 18805
	[Token(Token = "0x2004975")]
	public class MedalGroupListLoopAdapter : RecycleLoopScrollAdapter, IHotfixable
	{
		// Token: 0x1700431F RID: 17183
		// (get) Token: 0x0601C576 RID: 116086 RVA: 0x000A7EE0 File Offset: 0x000A60E0
		[Token(Token = "0x1700431F")]
		public override int totalCount
		{
			[Token(Token = "0x601C576")]
			[Address(RVA = "0x15CD2D0", Offset = "0x15CBED0", VA = "0x1815CD2D0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601C577 RID: 116087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C577")]
		[Address(RVA = "0x15CD160", Offset = "0x15CBD60", VA = "0x1815CD160", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601C578 RID: 116088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C578")]
		[Address(RVA = "0x15CCFB0", Offset = "0x15CBBB0", VA = "0x1815CCFB0", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x0601C579 RID: 116089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C579")]
		[Address(RVA = "0x15CD270", Offset = "0x15CBE70", VA = "0x1815CD270")]
		public MedalGroupListLoopAdapter()
		{
		}

		// Token: 0x04025168 RID: 151912
		[Token(Token = "0x4025168")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public List<MedalGroupViewModel> groupViewModelList;

		// Token: 0x04025169 RID: 151913
		[Token(Token = "0x4025169")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x0402516A RID: 151914
		[Token(Token = "0x402516A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _onClickEvent;

		// Token: 0x0402516B RID: 151915
		[Token(Token = "0x402516B")]
		[FieldOffset(Offset = "0x70")]
		private UIPageListener m_pageListener;

		// Token: 0x0402516C RID: 151916
		[Token(Token = "0x402516C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0402516D RID: 151917
		[Token(Token = "0x402516D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402516E RID: 151918
		[Token(Token = "0x402516E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402516F RID: 151919
		[Token(Token = "0x402516F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
