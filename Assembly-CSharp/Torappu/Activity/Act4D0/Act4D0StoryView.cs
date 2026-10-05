using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x02007281 RID: 29313
	[Token(Token = "0x2007281")]
	public class Act4D0StoryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029851 RID: 170065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029851")]
		[Address(RVA = "0x24E36D0", Offset = "0x24E22D0", VA = "0x1824E36D0")]
		public void RenderInfo(List<Act4D0StoryItemViewModel> viewModel, Action<int> callback, bool needScroll)
		{
		}

		// Token: 0x06029852 RID: 170066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029852")]
		[Address(RVA = "0x24E3940", Offset = "0x24E2540", VA = "0x1824E3940")]
		private IEnumerator _RefreshTargetState(float index)
		{
			return null;
		}

		// Token: 0x06029853 RID: 170067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029853")]
		[Address(RVA = "0x24E38C0", Offset = "0x24E24C0", VA = "0x1824E38C0")]
		private void _OnItemClickCallBack(int index)
		{
		}

		// Token: 0x06029854 RID: 170068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029854")]
		[Address(RVA = "0x24E3A00", Offset = "0x24E2600", VA = "0x1824E3A00")]
		public Act4D0StoryView()
		{
		}

		// Token: 0x0403B525 RID: 242981
		[Token(Token = "0x403B525")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Activity4D0StoryItem> _itemList;

		// Token: 0x0403B526 RID: 242982
		[Token(Token = "0x403B526")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _rect;

		// Token: 0x0403B527 RID: 242983
		[Token(Token = "0x403B527")]
		[FieldOffset(Offset = "0x28")]
		private Action<int> m_callback;

		// Token: 0x0403B528 RID: 242984
		[Token(Token = "0x403B528")]
		[FieldOffset(Offset = "0x30")]
		private string m_activityId;

		// Token: 0x0403B529 RID: 242985
		[Token(Token = "0x403B529")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403B52A RID: 242986
		[Token(Token = "0x403B52A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshTargetState;

		// Token: 0x0403B52B RID: 242987
		[Token(Token = "0x403B52B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClickCallBack;

		// Token: 0x0403B52C RID: 242988
		[Token(Token = "0x403B52C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
