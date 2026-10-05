using System;
using Il2CppDummyDll;
using Torappu.UI.ActArchive;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200410A RID: 16650
	[Token(Token = "0x200410A")]
	public class SandboxV2ArchiveEntryButtonAchievementPlugin : ArchiveEntryButtonBasePlugin
	{
		// Token: 0x06019BE6 RID: 105446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE6")]
		[Address(RVA = "0x1294E30", Offset = "0x1293A30", VA = "0x181294E30", Slot = "5")]
		public override void ApplyData(ActArchiveCompInfo data)
		{
		}

		// Token: 0x06019BE7 RID: 105447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BE7")]
		[Address(RVA = "0x1294F80", Offset = "0x1293B80", VA = "0x181294F80")]
		public SandboxV2ArchiveEntryButtonAchievementPlugin()
		{
		}

		// Token: 0x0402040F RID: 132111
		[Token(Token = "0x402040F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2ArchiveEntryButtonAchievementRarityView[] _rarityViews;

		// Token: 0x04020410 RID: 132112
		[Token(Token = "0x4020410")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04020411 RID: 132113
		[Token(Token = "0x4020411")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
