using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C8A RID: 19594
	[Token(Token = "0x2004C8A")]
	public class OpenServerV2MainView : OpenServerMainAbstractView
	{
		// Token: 0x0601D5F5 RID: 120309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F5")]
		[Address(RVA = "0x16EFC60", Offset = "0x16EE860", VA = "0x1816EFC60", Slot = "4")]
		public override void Render()
		{
		}

		// Token: 0x0601D5F6 RID: 120310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F6")]
		[Address(RVA = "0x16EFD00", Offset = "0x16EE900", VA = "0x1816EFD00", Slot = "5")]
		public override void UpdateWithType(OpenServerFuncType funcType)
		{
		}

		// Token: 0x0601D5F7 RID: 120311 RVA: 0x000AB468 File Offset: 0x000A9668
		[Token(Token = "0x601D5F7")]
		[Address(RVA = "0x16EFF00", Offset = "0x16EEB00", VA = "0x1816EFF00")]
		private bool _CheckIndexValid(int index)
		{
			return default(bool);
		}

		// Token: 0x0601D5F8 RID: 120312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F8")]
		[Address(RVA = "0x16EFFA0", Offset = "0x16EEBA0", VA = "0x1816EFFA0")]
		private void _DealWithTabsAvailableOrNot(out int firstAvailableIndex)
		{
		}

		// Token: 0x0601D5F9 RID: 120313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5F9")]
		[Address(RVA = "0x16F0540", Offset = "0x16EF140", VA = "0x1816F0540")]
		private void _SelectTab(int index)
		{
		}

		// Token: 0x0601D5FA RID: 120314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5FA")]
		[Address(RVA = "0x16F03A0", Offset = "0x16EEFA0", VA = "0x1816F03A0")]
		private void _RenderFuncViews(int index, bool isInit = false)
		{
		}

		// Token: 0x0601D5FB RID: 120315 RVA: 0x000AB480 File Offset: 0x000A9680
		[Token(Token = "0x601D5FB")]
		[Address(RVA = "0x16F02A0", Offset = "0x16EEEA0", VA = "0x1816F02A0")]
		private int _GetIndexByType(OpenServerFuncType funcType)
		{
			return 0;
		}

		// Token: 0x0601D5FC RID: 120316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5FC")]
		[Address(RVA = "0x16EFB20", Offset = "0x16EE720", VA = "0x1816EFB20")]
		public void OnBackBtnClick()
		{
		}

		// Token: 0x0601D5FD RID: 120317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5FD")]
		[Address(RVA = "0x16EFBC0", Offset = "0x16EE7C0", VA = "0x1816EFBC0")]
		public void OnTabBtnClick(int index)
		{
		}

		// Token: 0x0601D5FE RID: 120318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5FE")]
		[Address(RVA = "0x16F0690", Offset = "0x16EF290", VA = "0x1816F0690")]
		public OpenServerV2MainView()
		{
		}

		// Token: 0x04026A98 RID: 158360
		[Token(Token = "0x4026A98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<OpenServerV2MainView.OpenServerV2FuncStruct> _funcList;

		// Token: 0x04026A99 RID: 158361
		[Token(Token = "0x4026A99")]
		[FieldOffset(Offset = "0x20")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026A9A RID: 158362
		[Token(Token = "0x4026A9A")]
		[FieldOffset(Offset = "0x30")]
		private int m_currentIndex;

		// Token: 0x04026A9B RID: 158363
		[Token(Token = "0x4026A9B")]
		[FieldOffset(Offset = "0x38")]
		private OpenServerV2MainViewModel m_viewModel;

		// Token: 0x04026A9C RID: 158364
		[Token(Token = "0x4026A9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026A9D RID: 158365
		[Token(Token = "0x4026A9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateWithType;

		// Token: 0x04026A9E RID: 158366
		[Token(Token = "0x4026A9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIndexValid;

		// Token: 0x04026A9F RID: 158367
		[Token(Token = "0x4026A9F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealWithTabsAvailableOrNot;

		// Token: 0x04026AA0 RID: 158368
		[Token(Token = "0x4026AA0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SelectTab;

		// Token: 0x04026AA1 RID: 158369
		[Token(Token = "0x4026AA1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderFuncViews;

		// Token: 0x04026AA2 RID: 158370
		[Token(Token = "0x4026AA2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetIndexByType;

		// Token: 0x04026AA3 RID: 158371
		[Token(Token = "0x4026AA3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBackBtnClick;

		// Token: 0x04026AA4 RID: 158372
		[Token(Token = "0x4026AA4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTabBtnClick;

		// Token: 0x04026AA5 RID: 158373
		[Token(Token = "0x4026AA5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C8B RID: 19595
		[Token(Token = "0x2004C8B")]
		[Serializable]
		private struct OpenServerV2FuncStruct
		{
			// Token: 0x04026AA6 RID: 158374
			[Token(Token = "0x4026AA6")]
			[FieldOffset(Offset = "0x0")]
			public OpenServerFuncType funcType;

			// Token: 0x04026AA7 RID: 158375
			[Token(Token = "0x4026AA7")]
			[FieldOffset(Offset = "0x8")]
			public TwoStateToggle tabStateToggle;

			// Token: 0x04026AA8 RID: 158376
			[Token(Token = "0x4026AA8")]
			[FieldOffset(Offset = "0x10")]
			public OpenServerV2FuncAbstractView funcView;
		}
	}
}
