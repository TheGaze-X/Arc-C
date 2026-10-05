using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x020079A1 RID: 31137
	[Token(Token = "0x20079A1")]
	public abstract class Act1ArcadeStateStatusBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BAE4 RID: 178916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAE4")]
		[Address(RVA = "0x27A7A00", Offset = "0x27A6600", VA = "0x1827A7A00", Slot = "4")]
		public virtual void EnterView()
		{
		}

		// Token: 0x0602BAE5 RID: 178917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAE5")]
		[Address(RVA = "0x27A7AD0", Offset = "0x27A66D0", VA = "0x1827A7AD0", Slot = "5")]
		public virtual void PreResumeView(bool isFromStack)
		{
		}

		// Token: 0x0602BAE6 RID: 178918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAE6")]
		[Address(RVA = "0x27A7B50", Offset = "0x27A6750", VA = "0x1827A7B50", Slot = "6")]
		public virtual void ResumeView(bool isFromStack)
		{
		}

		// Token: 0x0602BAE7 RID: 178919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAE7")]
		[Address(RVA = "0x27A7A60", Offset = "0x27A6660", VA = "0x1827A7A60", Slot = "7")]
		public virtual void LeaveView()
		{
		}

		// Token: 0x0602BAE8 RID: 178920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAE8")]
		[Address(RVA = "0x27A7BB0", Offset = "0x27A67B0", VA = "0x1827A7BB0")]
		protected Act1ArcadeStateStatusBaseView()
		{
		}

		// Token: 0x0403F332 RID: 258866
		[Token(Token = "0x403F332")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnterView;

		// Token: 0x0403F333 RID: 258867
		[Token(Token = "0x403F333")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreResumeView;

		// Token: 0x0403F334 RID: 258868
		[Token(Token = "0x403F334")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResumeView;

		// Token: 0x0403F335 RID: 258869
		[Token(Token = "0x403F335")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LeaveView;

		// Token: 0x0403F336 RID: 258870
		[Token(Token = "0x403F336")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
