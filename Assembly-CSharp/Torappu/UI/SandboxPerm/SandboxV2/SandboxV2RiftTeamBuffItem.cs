using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004394 RID: 17300
	[Token(Token = "0x2004394")]
	public class SandboxV2RiftTeamBuffItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A901 RID: 108801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A901")]
		[Address(RVA = "0x13B7AF0", Offset = "0x13B66F0", VA = "0x1813B7AF0")]
		public void Render(string text, bool isActive)
		{
		}

		// Token: 0x0601A902 RID: 108802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A902")]
		[Address(RVA = "0x13B7BF0", Offset = "0x13B67F0", VA = "0x1813B7BF0")]
		public SandboxV2RiftTeamBuffItem()
		{
		}

		// Token: 0x04021D3C RID: 138556
		[Token(Token = "0x4021D3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _buffText;

		// Token: 0x04021D3D RID: 138557
		[Token(Token = "0x4021D3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _activeIconGo;

		// Token: 0x04021D3E RID: 138558
		[Token(Token = "0x4021D3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04021D3F RID: 138559
		[Token(Token = "0x4021D3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _activeAlpha;

		// Token: 0x04021D40 RID: 138560
		[Token(Token = "0x4021D40")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _unactiveAlpha;

		// Token: 0x04021D41 RID: 138561
		[Token(Token = "0x4021D41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021D42 RID: 138562
		[Token(Token = "0x4021D42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
