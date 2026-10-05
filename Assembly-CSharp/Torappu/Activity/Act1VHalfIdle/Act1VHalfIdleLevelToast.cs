using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007814 RID: 30740
	[Token(Token = "0x2007814")]
	public class Act1VHalfIdleLevelToast : UINotifyView<Act1VHalfIdleLevelToast.Param>
	{
		// Token: 0x0602B1F2 RID: 176626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1F2")]
		[Address(RVA = "0x26F97C0", Offset = "0x26F83C0", VA = "0x1826F97C0", Slot = "9")]
		protected override void Render(Act1VHalfIdleLevelToast.Param param)
		{
		}

		// Token: 0x0602B1F3 RID: 176627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1F3")]
		[Address(RVA = "0x26F98F0", Offset = "0x26F84F0", VA = "0x1826F98F0")]
		public Act1VHalfIdleLevelToast()
		{
		}

		// Token: 0x0403E51C RID: 255260
		[Token(Token = "0x403E51C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0403E51D RID: 255261
		[Token(Token = "0x403E51D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0403E51E RID: 255262
		[Token(Token = "0x403E51E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E51F RID: 255263
		[Token(Token = "0x403E51F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007815 RID: 30741
		[Token(Token = "0x2007815")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0602B1F4 RID: 176628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B1F4")]
			[Address(RVA = "0x2704A60", Offset = "0x2703660", VA = "0x182704A60", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0602B1F5 RID: 176629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1F5")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0403E520 RID: 255264
			[Token(Token = "0x403E520")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;

			// Token: 0x0403E521 RID: 255265
			[Token(Token = "0x403E521")]
			[FieldOffset(Offset = "0x18")]
			public int level;

			// Token: 0x0403E522 RID: 255266
			[Token(Token = "0x403E522")]
			[FieldOffset(Offset = "0x1C")]
			public bool useDeduplicate;
		}
	}
}
