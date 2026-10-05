using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004150 RID: 16720
	[Token(Token = "0x2004150")]
	public class SandboxV2BasementUpgradeResourceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019D1F RID: 105759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D1F")]
		[Address(RVA = "0x12A4A20", Offset = "0x12A3620", VA = "0x1812A4A20")]
		public void Render(ILoadAsset assetLoader, string topicId, SandboxV2BasementUpgradeResourceViewModel viewModel)
		{
		}

		// Token: 0x06019D20 RID: 105760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D20")]
		[Address(RVA = "0x12A4BC0", Offset = "0x12A37C0", VA = "0x1812A4BC0")]
		public SandboxV2BasementUpgradeResourceItemView()
		{
		}

		// Token: 0x040206A7 RID: 132775
		[Token(Token = "0x40206A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x040206A8 RID: 132776
		[Token(Token = "0x40206A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _count;

		// Token: 0x040206A9 RID: 132777
		[Token(Token = "0x40206A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040206AA RID: 132778
		[Token(Token = "0x40206AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
