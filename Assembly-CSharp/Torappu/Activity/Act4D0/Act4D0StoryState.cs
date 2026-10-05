using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007280 RID: 29312
	[Token(Token = "0x2007280")]
	public class Act4D0StoryState : PopupFadeState
	{
		// Token: 0x06029847 RID: 170055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029847")]
		[Address(RVA = "0x24E2B00", Offset = "0x24E1700", VA = "0x1824E2B00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029848 RID: 170056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029848")]
		[Address(RVA = "0x24E2B60", Offset = "0x24E1760", VA = "0x1824E2B60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029849 RID: 170057 RVA: 0x000D5D38 File Offset: 0x000D3F38
		[Token(Token = "0x6029849")]
		[Address(RVA = "0x24E3240", Offset = "0x24E1E40", VA = "0x1824E3240")]
		private bool _NeedScroll()
		{
			return default(bool);
		}

		// Token: 0x0602984A RID: 170058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602984A")]
		[Address(RVA = "0x24E3470", Offset = "0x24E2070", VA = "0x1824E3470")]
		private void _OnItemClickCallBack(int index)
		{
		}

		// Token: 0x0602984B RID: 170059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602984B")]
		[Address(RVA = "0x24E2F10", Offset = "0x24E1B10", VA = "0x1824E2F10", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602984C RID: 170060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602984C")]
		[Address(RVA = "0x24E3510", Offset = "0x24E2110", VA = "0x1824E3510")]
		private void _OnJumpToDetailState(Act4D0StoryDetailStateBean bean)
		{
		}

		// Token: 0x0602984D RID: 170061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602984D")]
		[Address(RVA = "0x24E3670", Offset = "0x24E2270", VA = "0x1824E3670")]
		public Act4D0StoryState()
		{
		}

		// Token: 0x0602984F RID: 170063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602984F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029850 RID: 170064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029850")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403B51B RID: 242971
		[Token(Token = "0x403B51B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act4D0StoryStateBean _stateBean;

		// Token: 0x0403B51C RID: 242972
		[Token(Token = "0x403B51C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act4D0StoryView _view;

		// Token: 0x0403B51D RID: 242973
		[Token(Token = "0x403B51D")]
		[FieldOffset(Offset = "0x80")]
		private int m_currentSelect;

		// Token: 0x0403B51E RID: 242974
		[Token(Token = "0x403B51E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B51F RID: 242975
		[Token(Token = "0x403B51F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B520 RID: 242976
		[Token(Token = "0x403B520")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__NeedScroll;

		// Token: 0x0403B521 RID: 242977
		[Token(Token = "0x403B521")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClickCallBack;

		// Token: 0x0403B522 RID: 242978
		[Token(Token = "0x403B522")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B523 RID: 242979
		[Token(Token = "0x403B523")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToDetailState;

		// Token: 0x0403B524 RID: 242980
		[Token(Token = "0x403B524")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
