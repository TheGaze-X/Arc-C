using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200780E RID: 30734
	[Token(Token = "0x200780E")]
	public class Act1VHalfIdleTechTreePage : UIPage
	{
		// Token: 0x0602B1E0 RID: 176608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B1E0")]
		[Address(RVA = "0x26FDDA0", Offset = "0x26FC9A0", VA = "0x1826FDDA0")]
		public string GetActId()
		{
			return null;
		}

		// Token: 0x0602B1E1 RID: 176609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E1")]
		[Address(RVA = "0x26FDE70", Offset = "0x26FCA70", VA = "0x1826FDE70", Slot = "8")]
		protected override void OnCreate(DataBundle savedInstance)
		{
		}

		// Token: 0x0602B1E2 RID: 176610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E2")]
		[Address(RVA = "0x26FE2A0", Offset = "0x26FCEA0", VA = "0x1826FE2A0")]
		private void _OnTopMenuCreated(GameObject obj)
		{
		}

		// Token: 0x0602B1E3 RID: 176611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E3")]
		[Address(RVA = "0x26FE170", Offset = "0x26FCD70", VA = "0x1826FE170")]
		private void _OnBtnBackClicked()
		{
		}

		// Token: 0x0602B1E4 RID: 176612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E4")]
		[Address(RVA = "0x26FE3D0", Offset = "0x26FCFD0", VA = "0x1826FE3D0")]
		private void _OnUnlockNode(string nodeId)
		{
		}

		// Token: 0x0602B1E5 RID: 176613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E5")]
		[Address(RVA = "0x26FE710", Offset = "0x26FD310", VA = "0x1826FE710")]
		private void _UnlockResponse(Act1VHalfIdleUnlockTechResponse resp)
		{
		}

		// Token: 0x0602B1E6 RID: 176614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E6")]
		[Address(RVA = "0x26FE1D0", Offset = "0x26FCDD0", VA = "0x1826FE1D0")]
		private void _OnClickNode(string nodeId)
		{
		}

		// Token: 0x0602B1E7 RID: 176615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E7")]
		[Address(RVA = "0x26FEA60", Offset = "0x26FD660", VA = "0x1826FEA60")]
		public Act1VHalfIdleTechTreePage()
		{
		}

		// Token: 0x0602B1E8 RID: 176616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B1E8")]
		[Address(RVA = "0xE98770", Offset = "0xE97370", VA = "0x180E98770")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0403E4FE RID: 255230
		[Token(Token = "0x403E4FE")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuPrefabHolder;

		// Token: 0x0403E4FF RID: 255231
		[Token(Token = "0x403E4FF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Act1VHalfIdleTechTreeMainView _mainView;

		// Token: 0x0403E500 RID: 255232
		[Token(Token = "0x403E500")]
		[FieldOffset(Offset = "0xE8")]
		private Act1VHalfIdleTechTreePage.Param m_param;

		// Token: 0x0403E501 RID: 255233
		[Token(Token = "0x403E501")]
		[FieldOffset(Offset = "0xF0")]
		private DataBundle m_savedInst;

		// Token: 0x0403E502 RID: 255234
		[Token(Token = "0x403E502")]
		[FieldOffset(Offset = "0xF8")]
		private Act1VHalfIdleTechTreeMainViewModelProperty m_prop;

		// Token: 0x0403E503 RID: 255235
		[Token(Token = "0x403E503")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActId;

		// Token: 0x0403E504 RID: 255236
		[Token(Token = "0x403E504")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403E505 RID: 255237
		[Token(Token = "0x403E505")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTopMenuCreated;

		// Token: 0x0403E506 RID: 255238
		[Token(Token = "0x403E506")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBtnBackClicked;

		// Token: 0x0403E507 RID: 255239
		[Token(Token = "0x403E507")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnUnlockNode;

		// Token: 0x0403E508 RID: 255240
		[Token(Token = "0x403E508")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UnlockResponse;

		// Token: 0x0403E509 RID: 255241
		[Token(Token = "0x403E509")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnClickNode;

		// Token: 0x0403E50A RID: 255242
		[Token(Token = "0x403E50A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200780F RID: 30735
		[Token(Token = "0x200780F")]
		public class Param
		{
			// Token: 0x0602B1E9 RID: 176617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B1E9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403E50B RID: 255243
			[Token(Token = "0x403E50B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
