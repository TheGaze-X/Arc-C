using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200680C RID: 26636
	[Token(Token = "0x200680C")]
	public class SideStoryMapDecroTrailInfo : MonoBehaviour, IHotfixable
	{
		// Token: 0x060262AA RID: 156330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262AA")]
		[Address(RVA = "0x2136710", Offset = "0x2135310", VA = "0x182136710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060262AB RID: 156331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262AB")]
		[Address(RVA = "0x2136440", Offset = "0x2135040", VA = "0x182136440")]
		public void RenderInfo(string retroId)
		{
		}

		// Token: 0x060262AC RID: 156332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262AC")]
		[Address(RVA = "0x21362F0", Offset = "0x2134EF0", VA = "0x1821362F0")]
		public void OnClick()
		{
		}

		// Token: 0x060262AD RID: 156333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262AD")]
		[Address(RVA = "0x21367F0", Offset = "0x21353F0", VA = "0x1821367F0")]
		public SideStoryMapDecroTrailInfo()
		{
		}

		// Token: 0x04035C38 RID: 220216
		[Token(Token = "0x4035C38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonTrackPoint _uiTrackContainer;

		// Token: 0x04035C39 RID: 220217
		[Token(Token = "0x4035C39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _currentStar;

		// Token: 0x04035C3A RID: 220218
		[Token(Token = "0x4035C3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxStar;

		// Token: 0x04035C3B RID: 220219
		[Token(Token = "0x4035C3B")]
		[FieldOffset(Offset = "0x30")]
		private TrackPointViewProperty m_trailAvailProperty;

		// Token: 0x04035C3C RID: 220220
		[Token(Token = "0x4035C3C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04035C3D RID: 220221
		[Token(Token = "0x4035C3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035C3E RID: 220222
		[Token(Token = "0x4035C3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x04035C3F RID: 220223
		[Token(Token = "0x4035C3F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04035C40 RID: 220224
		[Token(Token = "0x4035C40")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
