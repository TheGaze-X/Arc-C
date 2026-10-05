using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200411F RID: 16671
	[Token(Token = "0x200411F")]
	public class SandboxV2FloatPanelManager : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C29 RID: 105513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C29")]
		[Address(RVA = "0x1298380", Offset = "0x1296F80", VA = "0x181298380")]
		private void _CheckTouchingFloatPanel(Vector3 touchPosition)
		{
		}

		// Token: 0x06019C2A RID: 105514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C2A")]
		[Address(RVA = "0x12982C0", Offset = "0x1296EC0", VA = "0x1812982C0")]
		public void Watch(SandboxV2FloatPanel element)
		{
		}

		// Token: 0x06019C2B RID: 105515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C2B")]
		[Address(RVA = "0x1297FA0", Offset = "0x1296BA0", VA = "0x181297FA0")]
		public void Unwatch(SandboxV2FloatPanel element)
		{
		}

		// Token: 0x06019C2C RID: 105516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C2C")]
		[Address(RVA = "0x1297DA0", Offset = "0x12969A0", VA = "0x181297DA0")]
		public void OnFloatPanelShown(SandboxV2FloatPanel element)
		{
		}

		// Token: 0x06019C2D RID: 105517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C2D")]
		[Address(RVA = "0x1297CB0", Offset = "0x12968B0", VA = "0x181297CB0")]
		public void OnFloatPanelHidden(SandboxV2FloatPanel element)
		{
		}

		// Token: 0x06019C2E RID: 105518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C2E")]
		[Address(RVA = "0x1297B00", Offset = "0x1296700", VA = "0x181297B00")]
		public void ClearFloatPanel()
		{
		}

		// Token: 0x06019C2F RID: 105519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C2F")]
		[Address(RVA = "0x12980C0", Offset = "0x1296CC0", VA = "0x1812980C0")]
		private void Update()
		{
		}

		// Token: 0x06019C30 RID: 105520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C30")]
		[Address(RVA = "0x1298700", Offset = "0x1297300", VA = "0x181298700")]
		public SandboxV2FloatPanelManager()
		{
		}

		// Token: 0x0402049B RID: 132251
		[Token(Token = "0x402049B")]
		[FieldOffset(Offset = "0x18")]
		private List<int> m_lastTouchIdList;

		// Token: 0x0402049C RID: 132252
		[Token(Token = "0x402049C")]
		[FieldOffset(Offset = "0x20")]
		private List<RaycastResult> m_raycastResults;

		// Token: 0x0402049D RID: 132253
		[Token(Token = "0x402049D")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<SandboxV2FloatPanel> m_floatPanels;

		// Token: 0x0402049E RID: 132254
		[Token(Token = "0x402049E")]
		[FieldOffset(Offset = "0x30")]
		private SandboxV2FloatPanel m_currActiveFloatPanel;

		// Token: 0x0402049F RID: 132255
		[Token(Token = "0x402049F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CheckTouchingFloatPanel;

		// Token: 0x040204A0 RID: 132256
		[Token(Token = "0x40204A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x040204A1 RID: 132257
		[Token(Token = "0x40204A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Unwatch;

		// Token: 0x040204A2 RID: 132258
		[Token(Token = "0x40204A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFloatPanelShown;

		// Token: 0x040204A3 RID: 132259
		[Token(Token = "0x40204A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnFloatPanelHidden;

		// Token: 0x040204A4 RID: 132260
		[Token(Token = "0x40204A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearFloatPanel;

		// Token: 0x040204A5 RID: 132261
		[Token(Token = "0x40204A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040204A6 RID: 132262
		[Token(Token = "0x40204A6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
