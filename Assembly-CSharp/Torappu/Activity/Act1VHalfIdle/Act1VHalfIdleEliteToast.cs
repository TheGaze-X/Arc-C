using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007810 RID: 30736
	[Token(Token = "0x2007810")]
	public class Act1VHalfIdleEliteToast : UINotifyView<Act1VHalfIdleEliteToast.Param>
	{
		// Token: 0x0602B1EA RID: 176618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1EA")]
		[Address(RVA = "0x26F9420", Offset = "0x26F8020", VA = "0x1826F9420", Slot = "9")]
		protected override void Render(Act1VHalfIdleEliteToast.Param param)
		{
		}

		// Token: 0x0602B1EB RID: 176619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1EB")]
		[Address(RVA = "0x26F9520", Offset = "0x26F8120", VA = "0x1826F9520")]
		public Act1VHalfIdleEliteToast()
		{
		}

		// Token: 0x0403E50C RID: 255244
		[Token(Token = "0x403E50C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0403E50D RID: 255245
		[Token(Token = "0x403E50D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlElite1;

		// Token: 0x0403E50E RID: 255246
		[Token(Token = "0x403E50E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlElite2;

		// Token: 0x0403E50F RID: 255247
		[Token(Token = "0x403E50F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E510 RID: 255248
		[Token(Token = "0x403E510")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007811 RID: 30737
		[Token(Token = "0x2007811")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0602B1EC RID: 176620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B1EC")]
			[Address(RVA = "0x2704820", Offset = "0x2703420", VA = "0x182704820", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0602B1ED RID: 176621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1ED")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0403E511 RID: 255249
			[Token(Token = "0x403E511")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;

			// Token: 0x0403E512 RID: 255250
			[Token(Token = "0x403E512")]
			[FieldOffset(Offset = "0x18")]
			public int eliteId;

			// Token: 0x0403E513 RID: 255251
			[Token(Token = "0x403E513")]
			[FieldOffset(Offset = "0x1C")]
			public bool useDeduplicate;
		}
	}
}
