using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004996 RID: 18838
	[Token(Token = "0x2004996")]
	public class MedalEntryListBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C627 RID: 116263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C627")]
		[Address(RVA = "0x15EA4C0", Offset = "0x15E90C0", VA = "0x1815EA4C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C628 RID: 116264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C628")]
		[Address(RVA = "0x15EA320", Offset = "0x15E8F20", VA = "0x1815EA320")]
		public void Render(int haveCount, int totalCount)
		{
		}

		// Token: 0x0601C629 RID: 116265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C629")]
		[Address(RVA = "0x15EA550", Offset = "0x15E9150", VA = "0x1815EA550")]
		public MedalEntryListBtn()
		{
		}

		// Token: 0x040252D0 RID: 152272
		[Token(Token = "0x40252D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _countPart;

		// Token: 0x040252D1 RID: 152273
		[Token(Token = "0x40252D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommonTrackPoint _medalTrackPoint;

		// Token: 0x040252D2 RID: 152274
		[Token(Token = "0x40252D2")]
		[FieldOffset(Offset = "0x28")]
		private TrackPointViewProperty m_medalTrackModel;

		// Token: 0x040252D3 RID: 152275
		[Token(Token = "0x40252D3")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x040252D4 RID: 152276
		[Token(Token = "0x40252D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040252D5 RID: 152277
		[Token(Token = "0x40252D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252D6 RID: 152278
		[Token(Token = "0x40252D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
