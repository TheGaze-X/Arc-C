using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E6 RID: 26342
	[Token(Token = "0x20066E6")]
	public class HandBookGroupForceEditAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17005992 RID: 22930
		// (get) Token: 0x06025CDD RID: 154845 RVA: 0x000C9180 File Offset: 0x000C7380
		[Token(Token = "0x17005992")]
		public override int count
		{
			[Token(Token = "0x6025CDD")]
			[Address(RVA = "0x20BC620", Offset = "0x20BB220", VA = "0x1820BC620", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025CDE RID: 154846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CDE")]
		[Address(RVA = "0x20BC3F0", Offset = "0x20BAFF0", VA = "0x1820BC3F0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06025CDF RID: 154847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CDF")]
		[Address(RVA = "0x20BC5C0", Offset = "0x20BB1C0", VA = "0x1820BC5C0")]
		public HandBookGroupForceEditAdapter()
		{
		}

		// Token: 0x0403525D RID: 217693
		[Token(Token = "0x403525D")]
		[FieldOffset(Offset = "0x20")]
		public UIStringEvent onClick;

		// Token: 0x0403525E RID: 217694
		[Token(Token = "0x403525E")]
		[FieldOffset(Offset = "0x28")]
		public UIStringEvent onFocusView;

		// Token: 0x0403525F RID: 217695
		[Token(Token = "0x403525F")]
		[FieldOffset(Offset = "0x30")]
		public UIStringEvent onSaveFocusView;

		// Token: 0x04035260 RID: 217696
		[Token(Token = "0x4035260")]
		[FieldOffset(Offset = "0x38")]
		public UIStringEvent onDeleteForce;

		// Token: 0x04035261 RID: 217697
		[Token(Token = "0x4035261")]
		[FieldOffset(Offset = "0x40")]
		public List<HandBookV2GroupPosData.ForceData> forceData;

		// Token: 0x04035262 RID: 217698
		[Token(Token = "0x4035262")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04035263 RID: 217699
		[Token(Token = "0x4035263")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04035264 RID: 217700
		[Token(Token = "0x4035264")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
