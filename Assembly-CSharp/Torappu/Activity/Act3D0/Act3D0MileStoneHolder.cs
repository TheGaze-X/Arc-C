using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007408 RID: 29704
	[Token(Token = "0x2007408")]
	public class Act3D0MileStoneHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F2C RID: 171820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F2C")]
		[Address(RVA = "0x258E470", Offset = "0x258D070", VA = "0x18258E470")]
		public void RefreshInfo(List<Act3D0MileStoneViewModel> viewModelList, int count)
		{
		}

		// Token: 0x06029F2D RID: 171821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F2D")]
		[Address(RVA = "0x258E520", Offset = "0x258D120", VA = "0x18258E520")]
		public void RenderInfo(List<Act3D0MileStoneViewModel> viewModelList, int count)
		{
		}

		// Token: 0x06029F2E RID: 171822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029F2E")]
		[Address(RVA = "0x258E8F0", Offset = "0x258D4F0", VA = "0x18258E8F0")]
		private IEnumerator _RefreshTargetState(float index)
		{
			return null;
		}

		// Token: 0x06029F2F RID: 171823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F2F")]
		[Address(RVA = "0x258E9B0", Offset = "0x258D5B0", VA = "0x18258E9B0")]
		public Act3D0MileStoneHolder()
		{
		}

		// Token: 0x0403C1F6 RID: 246262
		[Token(Token = "0x403C1F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403C1F7 RID: 246263
		[Token(Token = "0x403C1F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopVerticalScrollRect _content;

		// Token: 0x0403C1F8 RID: 246264
		[Token(Token = "0x403C1F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act3D0MileStoneGridAdapter _adapter;

		// Token: 0x0403C1F9 RID: 246265
		[Token(Token = "0x403C1F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403C1FA RID: 246266
		[Token(Token = "0x403C1FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIStringEvent _clickEvent;

		// Token: 0x0403C1FB RID: 246267
		[Token(Token = "0x403C1FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshInfo;

		// Token: 0x0403C1FC RID: 246268
		[Token(Token = "0x403C1FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403C1FD RID: 246269
		[Token(Token = "0x403C1FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshTargetState;

		// Token: 0x0403C1FE RID: 246270
		[Token(Token = "0x403C1FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
