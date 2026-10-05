using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003798 RID: 14232
	[Token(Token = "0x2003798")]
	public class UIFlingGesture : IHotfixable
	{
		// Token: 0x06016949 RID: 92489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016949")]
		[Address(RVA = "0xEFE860", Offset = "0xEFD460", VA = "0x180EFE860")]
		public UIFlingGesture(int frameCnt = 4)
		{
		}

		// Token: 0x0601694A RID: 92490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601694A")]
		[Address(RVA = "0xEFE350", Offset = "0xEFCF50", VA = "0x180EFE350")]
		public void BeginDrag(Vector2 pressPos)
		{
		}

		// Token: 0x0601694B RID: 92491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601694B")]
		[Address(RVA = "0xEFE660", Offset = "0xEFD260", VA = "0x180EFE660")]
		public void Tick(Vector2 curPos, float deltaTime)
		{
		}

		// Token: 0x0601694C RID: 92492 RVA: 0x00091E90 File Offset: 0x00090090
		[Token(Token = "0x601694C")]
		[Address(RVA = "0xEFE410", Offset = "0xEFD010", VA = "0x180EFE410")]
		public bool EndDrag(out Vector2 flingSpeed)
		{
			return default(bool);
		}

		// Token: 0x0601694D RID: 92493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601694D")]
		[Address(RVA = "0xEFE7E0", Offset = "0xEFD3E0", VA = "0x180EFE7E0")]
		private void _Reset()
		{
		}

		// Token: 0x0401B36B RID: 111467
		[Token(Token = "0x401B36B")]
		private const int DEFAULT_FRAME_CNT = 4;

		// Token: 0x0401B36C RID: 111468
		[Token(Token = "0x401B36C")]
		[FieldOffset(Offset = "0x10")]
		private int m_frameCacheCnt;

		// Token: 0x0401B36D RID: 111469
		[Token(Token = "0x401B36D")]
		[FieldOffset(Offset = "0x18")]
		private Queue<UIFlingGesture.Frame> m_frames;

		// Token: 0x0401B36E RID: 111470
		[Token(Token = "0x401B36E")]
		[FieldOffset(Offset = "0x20")]
		private float m_curTime;

		// Token: 0x0401B36F RID: 111471
		[Token(Token = "0x401B36F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B370 RID: 111472
		[Token(Token = "0x401B370")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BeginDrag;

		// Token: 0x0401B371 RID: 111473
		[Token(Token = "0x401B371")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0401B372 RID: 111474
		[Token(Token = "0x401B372")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EndDrag;

		// Token: 0x0401B373 RID: 111475
		[Token(Token = "0x401B373")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x02003799 RID: 14233
		[Token(Token = "0x2003799")]
		private struct Frame
		{
			// Token: 0x0401B374 RID: 111476
			[Token(Token = "0x401B374")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x0401B375 RID: 111477
			[Token(Token = "0x401B375")]
			[FieldOffset(Offset = "0x8")]
			public float time;
		}
	}
}
