using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x020046EA RID: 18154
	[Token(Token = "0x20046EA")]
	public class RecruitDialogController : PageSingleComponent, IHotfixable
	{
		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x0601B851 RID: 112721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700418E")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601B851")]
			[Address(RVA = "0x14DFDF0", Offset = "0x14DE9F0", VA = "0x1814DFDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B852 RID: 112722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B852")]
		[Address(RVA = "0x14DFCA0", Offset = "0x14DE8A0", VA = "0x1814DFCA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B853 RID: 112723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B853")]
		[Address(RVA = "0x14DFD90", Offset = "0x14DE990", VA = "0x1814DFD90")]
		public RecruitDialogController()
		{
		}

		// Token: 0x04023A74 RID: 146036
		[Token(Token = "0x4023A74")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04023A75 RID: 146037
		[Token(Token = "0x4023A75")]
		[FieldOffset(Offset = "0x28")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04023A76 RID: 146038
		[Token(Token = "0x4023A76")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x04023A77 RID: 146039
		[Token(Token = "0x4023A77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04023A78 RID: 146040
		[Token(Token = "0x4023A78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023A79 RID: 146041
		[Token(Token = "0x4023A79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
