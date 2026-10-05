using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007816 RID: 30742
	[Token(Token = "0x2007816")]
	public class Act1VHalfIdleTextToast : UINotifyView<Act1VHalfIdleTextToast.Param>
	{
		// Token: 0x0602B1F6 RID: 176630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1F6")]
		[Address(RVA = "0x26FEAC0", Offset = "0x26FD6C0", VA = "0x1826FEAC0", Slot = "9")]
		protected override void Render(Act1VHalfIdleTextToast.Param param)
		{
		}

		// Token: 0x0602B1F7 RID: 176631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1F7")]
		[Address(RVA = "0x26FEBC0", Offset = "0x26FD7C0", VA = "0x1826FEBC0")]
		public Act1VHalfIdleTextToast()
		{
		}

		// Token: 0x0403E523 RID: 255267
		[Token(Token = "0x403E523")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0403E524 RID: 255268
		[Token(Token = "0x403E524")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x0403E525 RID: 255269
		[Token(Token = "0x403E525")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlInfo;

		// Token: 0x0403E526 RID: 255270
		[Token(Token = "0x403E526")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E527 RID: 255271
		[Token(Token = "0x403E527")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007817 RID: 30743
		[Token(Token = "0x2007817")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0602B1F8 RID: 176632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B1F8")]
			[Address(RVA = "0x2704940", Offset = "0x2703540", VA = "0x182704940", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0602B1F9 RID: 176633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1F9")]
			[Address(RVA = "0x2704CA0", Offset = "0x27038A0", VA = "0x182704CA0")]
			public Param()
			{
			}

			// Token: 0x0403E528 RID: 255272
			[Token(Token = "0x403E528")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;

			// Token: 0x0403E529 RID: 255273
			[Token(Token = "0x403E529")]
			[FieldOffset(Offset = "0x18")]
			public bool isLocked;

			// Token: 0x0403E52A RID: 255274
			[Token(Token = "0x403E52A")]
			[FieldOffset(Offset = "0x19")]
			public bool useDeduplicate;
		}
	}
}
