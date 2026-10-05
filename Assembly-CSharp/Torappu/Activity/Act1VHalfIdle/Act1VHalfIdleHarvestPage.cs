using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077A6 RID: 30630
	[Token(Token = "0x20077A6")]
	public class Act1VHalfIdleHarvestPage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x0602B000 RID: 176128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B000")]
		[Address(RVA = "0x26CC910", Offset = "0x26CB510", VA = "0x1826CC910", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602B001 RID: 176129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B001")]
		[Address(RVA = "0x26CCB20", Offset = "0x26CB720", VA = "0x1826CCB20")]
		private void _OnBtnBackClicked()
		{
		}

		// Token: 0x0602B002 RID: 176130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B002")]
		[Address(RVA = "0x26CCB80", Offset = "0x26CB780", VA = "0x1826CCB80")]
		private void _OnGuideBookClicked()
		{
		}

		// Token: 0x0602B003 RID: 176131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B003")]
		[Address(RVA = "0x26CC8B0", Offset = "0x26CB4B0", VA = "0x1826CC8B0", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0602B004 RID: 176132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B004")]
		[Address(RVA = "0x26CCCC0", Offset = "0x26CB8C0", VA = "0x1826CCCC0")]
		public Act1VHalfIdleHarvestPage()
		{
		}

		// Token: 0x0602B005 RID: 176133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B005")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403E125 RID: 254245
		[Token(Token = "0x403E125")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Act1VHalfIdleCommonTopMenu _topMenu;

		// Token: 0x0403E126 RID: 254246
		[Token(Token = "0x403E126")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _dlgContainer;

		// Token: 0x0403E127 RID: 254247
		[Token(Token = "0x403E127")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIGuidebookTrigger _guidebookTrigger;

		// Token: 0x0403E128 RID: 254248
		[Token(Token = "0x403E128")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0403E129 RID: 254249
		[Token(Token = "0x403E129")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403E12A RID: 254250
		[Token(Token = "0x403E12A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnBtnBackClicked;

		// Token: 0x0403E12B RID: 254251
		[Token(Token = "0x403E12B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnGuideBookClicked;

		// Token: 0x0403E12C RID: 254252
		[Token(Token = "0x403E12C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0403E12D RID: 254253
		[Token(Token = "0x403E12D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077A7 RID: 30631
		[Token(Token = "0x20077A7")]
		public class Param
		{
			// Token: 0x0602B006 RID: 176134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B006")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403E12E RID: 254254
			[Token(Token = "0x403E12E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
