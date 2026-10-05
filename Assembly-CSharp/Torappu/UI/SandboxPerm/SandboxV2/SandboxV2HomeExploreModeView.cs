using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004330 RID: 17200
	[Token(Token = "0x2004330")]
	public class SandboxV2HomeExploreModeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A6D3 RID: 108243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D3")]
		[Address(RVA = "0x1385520", Offset = "0x1384120", VA = "0x181385520")]
		public void Render(SandboxV2HomeModel model)
		{
		}

		// Token: 0x0601A6D4 RID: 108244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A6D4")]
		[Address(RVA = "0x1385720", Offset = "0x1384320", VA = "0x181385720")]
		public SandboxV2HomeExploreModeView()
		{
		}

		// Token: 0x0402193E RID: 137534
		[Token(Token = "0x402193E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnPanel;

		// Token: 0x0402193F RID: 137535
		[Token(Token = "0x402193F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _modeSprite;

		// Token: 0x04021940 RID: 137536
		[Token(Token = "0x4021940")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021941 RID: 137537
		[Token(Token = "0x4021941")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021942 RID: 137538
		[Token(Token = "0x4021942")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
