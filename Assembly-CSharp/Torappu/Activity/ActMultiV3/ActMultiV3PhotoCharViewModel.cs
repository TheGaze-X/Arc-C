using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F87 RID: 28551
	[Token(Token = "0x2006F87")]
	public class ActMultiV3PhotoCharViewModel : IHotfixable
	{
		// Token: 0x0602884B RID: 165963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602884B")]
		[Address(RVA = "0x23DB7A0", Offset = "0x23DA3A0", VA = "0x1823DB7A0")]
		public ActMultiV3PhotoCharViewModel(PlayerActivity.PlayerMultiV3Activity.PhotoCharInfo charInfo, List<ActMultiV3PhotoSlotData> slots, string defaultAct)
		{
		}

		// Token: 0x04039B1A RID: 236314
		[Token(Token = "0x4039B1A")]
		[FieldOffset(Offset = "0x10")]
		public int slotIdx;

		// Token: 0x04039B1B RID: 236315
		[Token(Token = "0x4039B1B")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;

		// Token: 0x04039B1C RID: 236316
		[Token(Token = "0x4039B1C")]
		[FieldOffset(Offset = "0x20")]
		public bool isValidChar;

		// Token: 0x04039B1D RID: 236317
		[Token(Token = "0x4039B1D")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 translation;

		// Token: 0x04039B1E RID: 236318
		[Token(Token = "0x4039B1E")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion rotation;

		// Token: 0x04039B1F RID: 236319
		[Token(Token = "0x4039B1F")]
		[FieldOffset(Offset = "0x40")]
		public Vector3 scale;

		// Token: 0x04039B20 RID: 236320
		[Token(Token = "0x4039B20")]
		[FieldOffset(Offset = "0x50")]
		public string animName;

		// Token: 0x04039B21 RID: 236321
		[Token(Token = "0x4039B21")]
		[FieldOffset(Offset = "0x58")]
		public string defaultAnimName;

		// Token: 0x04039B22 RID: 236322
		[Token(Token = "0x4039B22")]
		[FieldOffset(Offset = "0x60")]
		public int frame;

		// Token: 0x04039B23 RID: 236323
		[Token(Token = "0x4039B23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
