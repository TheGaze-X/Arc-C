using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.ActArchive;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200410C RID: 16652
	[Token(Token = "0x200410C")]
	public class SandboxV2ArchiveEntryButtonDynamicMusicPlugin : ArchiveEntryButtonBasePlugin
	{
		// Token: 0x06019BEA RID: 105450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BEA")]
		[Address(RVA = "0x1295120", Offset = "0x1293D20", VA = "0x181295120", Slot = "5")]
		public override void ApplyData(ActArchiveCompInfo data)
		{
		}

		// Token: 0x06019BEB RID: 105451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BEB")]
		[Address(RVA = "0x1295340", Offset = "0x1293F40", VA = "0x181295340")]
		private void _PlayLoopAnimIfNot()
		{
		}

		// Token: 0x06019BEC RID: 105452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BEC")]
		[Address(RVA = "0x1295470", Offset = "0x1294070", VA = "0x181295470")]
		public SandboxV2ArchiveEntryButtonDynamicMusicPlugin()
		{
		}

		// Token: 0x04020416 RID: 132118
		[Token(Token = "0x4020416")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animLoop;

		// Token: 0x04020417 RID: 132119
		[Token(Token = "0x4020417")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _musicName;

		// Token: 0x04020418 RID: 132120
		[Token(Token = "0x4020418")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x04020419 RID: 132121
		[Token(Token = "0x4020419")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402041A RID: 132122
		[Token(Token = "0x402041A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayLoopAnimIfNot;

		// Token: 0x0402041B RID: 132123
		[Token(Token = "0x402041B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
