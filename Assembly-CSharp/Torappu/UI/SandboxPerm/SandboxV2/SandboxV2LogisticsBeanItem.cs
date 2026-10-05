using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200433A RID: 17210
	[Token(Token = "0x200433A")]
	public class SandboxV2LogisticsBeanItem : SandboxV2LogisticsAbstractBeanItem
	{
		// Token: 0x0601A704 RID: 108292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A704")]
		[Address(RVA = "0x1386130", Offset = "0x1384D30", VA = "0x181386130", Slot = "4")]
		public override void Render(bool enabledItem)
		{
		}

		// Token: 0x0601A705 RID: 108293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A705")]
		[Address(RVA = "0x13861C0", Offset = "0x1384DC0", VA = "0x1813861C0")]
		public SandboxV2LogisticsBeanItem()
		{
		}

		// Token: 0x04021985 RID: 137605
		[Token(Token = "0x4021985")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelBlock;

		// Token: 0x04021986 RID: 137606
		[Token(Token = "0x4021986")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelValid;

		// Token: 0x04021987 RID: 137607
		[Token(Token = "0x4021987")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021988 RID: 137608
		[Token(Token = "0x4021988")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
