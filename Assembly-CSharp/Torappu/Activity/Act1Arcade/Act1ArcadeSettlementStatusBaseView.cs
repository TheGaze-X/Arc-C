using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007973 RID: 31091
	[Token(Token = "0x2007973")]
	public abstract class Act1ArcadeSettlementStatusBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700663C RID: 26172
		// (get) Token: 0x0602B9C5 RID: 178629
		[Token(Token = "0x1700663C")]
		public abstract Act1ArcadeSettlementModel.SettlementViewStatus viewStatus { [Token(Token = "0x602B9C5")] get; }

		// Token: 0x1700663D RID: 26173
		// (get) Token: 0x0602B9C6 RID: 178630
		[Token(Token = "0x1700663D")]
		public abstract Act1ArcadeSettlementModel.SettlementViewStatus nextViewStatus { [Token(Token = "0x602B9C6")] get; }

		// Token: 0x0602B9C7 RID: 178631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9C7")]
		[Address(RVA = "0x2783440", Offset = "0x2782040", VA = "0x182783440", Slot = "6")]
		public virtual void SetToDefaultShow()
		{
		}

		// Token: 0x0602B9C8 RID: 178632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9C8")]
		[Address(RVA = "0x2783370", Offset = "0x2781F70", VA = "0x182783370", Slot = "7")]
		public virtual void ChangeInStatusAndRender(Act1ArcadeSettlementModel model)
		{
		}

		// Token: 0x0602B9C9 RID: 178633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9C9")]
		[Address(RVA = "0x27833E0", Offset = "0x2781FE0", VA = "0x1827833E0", Slot = "8")]
		public virtual void LeaveStatus()
		{
		}

		// Token: 0x1700663E RID: 26174
		// (get) Token: 0x0602B9CA RID: 178634 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B9CB RID: 178635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700663E")]
		public Action OnClick
		{
			[Token(Token = "0x602B9CA")]
			[Address(RVA = "0x27837E0", Offset = "0x27823E0", VA = "0x1827837E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B9CB")]
			[Address(RVA = "0x2783840", Offset = "0x2782440", VA = "0x182783840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602B9CC RID: 178636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9CC")]
		[Address(RVA = "0x2783780", Offset = "0x2782380", VA = "0x182783780")]
		protected Act1ArcadeSettlementStatusBaseView()
		{
		}

		// Token: 0x0403F16A RID: 258410
		[Token(Token = "0x403F16A")]
		[FieldOffset(Offset = "0x18")]
		protected bool isStatusActive;

		// Token: 0x0403F16C RID: 258412
		[Token(Token = "0x403F16C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetToDefaultShow;

		// Token: 0x0403F16D RID: 258413
		[Token(Token = "0x403F16D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ChangeInStatusAndRender;

		// Token: 0x0403F16E RID: 258414
		[Token(Token = "0x403F16E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LeaveStatus;

		// Token: 0x0403F16F RID: 258415
		[Token(Token = "0x403F16F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_OnClick;

		// Token: 0x0403F170 RID: 258416
		[Token(Token = "0x403F170")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_OnClick;

		// Token: 0x0403F171 RID: 258417
		[Token(Token = "0x403F171")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
