using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004276 RID: 17014
	[Token(Token = "0x2004276")]
	public class SandboxV2NodePreviewUpgradeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A36B RID: 107371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A36B")]
		[Address(RVA = "0x131FFC0", Offset = "0x131EBC0", VA = "0x18131FFC0")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel)
		{
		}

		// Token: 0x0601A36C RID: 107372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A36C")]
		[Address(RVA = "0x13201E0", Offset = "0x131EDE0", VA = "0x1813201E0")]
		public SandboxV2NodePreviewUpgradeView()
		{
		}

		// Token: 0x040212CF RID: 135887
		[Token(Token = "0x40212CF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _upgradedColor;

		// Token: 0x040212D0 RID: 135888
		[Token(Token = "0x40212D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _notUpgradedColor;

		// Token: 0x040212D1 RID: 135889
		[Token(Token = "0x40212D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _upgradeStroke;

		// Token: 0x040212D2 RID: 135890
		[Token(Token = "0x40212D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage[] _upgradeIcons;

		// Token: 0x040212D3 RID: 135891
		[Token(Token = "0x40212D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] _upgradeIds;

		// Token: 0x040212D4 RID: 135892
		[Token(Token = "0x40212D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040212D5 RID: 135893
		[Token(Token = "0x40212D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
