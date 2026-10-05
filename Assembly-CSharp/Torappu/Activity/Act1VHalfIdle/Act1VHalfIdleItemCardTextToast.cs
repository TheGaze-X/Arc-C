using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007812 RID: 30738
	[Token(Token = "0x2007812")]
	public class Act1VHalfIdleItemCardTextToast : UINotifyView<Act1VHalfIdleItemCardTextToast.Param>
	{
		// Token: 0x0602B1EE RID: 176622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1EE")]
		[Address(RVA = "0x26F9590", Offset = "0x26F8190", VA = "0x1826F9590", Slot = "9")]
		protected override void Render(Act1VHalfIdleItemCardTextToast.Param param)
		{
		}

		// Token: 0x0602B1EF RID: 176623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1EF")]
		[Address(RVA = "0x26F9750", Offset = "0x26F8350", VA = "0x1826F9750")]
		public Act1VHalfIdleItemCardTextToast()
		{
		}

		// Token: 0x0403E514 RID: 255252
		[Token(Token = "0x403E514")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0403E515 RID: 255253
		[Token(Token = "0x403E515")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x0403E516 RID: 255254
		[Token(Token = "0x403E516")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _scaler;

		// Token: 0x0403E517 RID: 255255
		[Token(Token = "0x403E517")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403E518 RID: 255256
		[Token(Token = "0x403E518")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007813 RID: 30739
		[Token(Token = "0x2007813")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0602B1F0 RID: 176624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B1F0")]
			[Address(RVA = "0x2704B80", Offset = "0x2703780", VA = "0x182704B80", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0602B1F1 RID: 176625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1F1")]
			[Address(RVA = "0x13A7560", Offset = "0x13A6160", VA = "0x1813A7560")]
			public Param()
			{
			}

			// Token: 0x0403E519 RID: 255257
			[Token(Token = "0x403E519")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;

			// Token: 0x0403E51A RID: 255258
			[Token(Token = "0x403E51A")]
			[FieldOffset(Offset = "0x18")]
			public UIItemViewModel uiItemViewModel;

			// Token: 0x0403E51B RID: 255259
			[Token(Token = "0x403E51B")]
			[FieldOffset(Offset = "0x20")]
			public bool useDeduplicate;
		}
	}
}
