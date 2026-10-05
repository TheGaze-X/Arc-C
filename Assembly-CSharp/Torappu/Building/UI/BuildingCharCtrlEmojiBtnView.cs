using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AED RID: 6893
	[Token(Token = "0x2001AED")]
	public class BuildingCharCtrlEmojiBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AE43 RID: 44611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE43")]
		[Address(RVA = "0x328AE30", Offset = "0x3289A30", VA = "0x18328AE30")]
		public void Render(string id)
		{
		}

		// Token: 0x0600AE44 RID: 44612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE44")]
		[Address(RVA = "0x328AD50", Offset = "0x3289950", VA = "0x18328AD50")]
		public void OnClick()
		{
		}

		// Token: 0x0600AE45 RID: 44613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE45")]
		[Address(RVA = "0x328AFC0", Offset = "0x3289BC0", VA = "0x18328AFC0")]
		public BuildingCharCtrlEmojiBtnView()
		{
		}

		// Token: 0x0400A6AB RID: 42667
		[Token(Token = "0x400A6AB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0400A6AC RID: 42668
		[Token(Token = "0x400A6AC")]
		[FieldOffset(Offset = "0x20")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400A6AD RID: 42669
		[Token(Token = "0x400A6AD")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedId;

		// Token: 0x0400A6AE RID: 42670
		[Token(Token = "0x400A6AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A6AF RID: 42671
		[Token(Token = "0x400A6AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0400A6B0 RID: 42672
		[Token(Token = "0x400A6B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
