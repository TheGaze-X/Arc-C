using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EEA RID: 20202
	[Token(Token = "0x2004EEA")]
	public class FifthAnnivExploreEndNodeView : FifthAnnivExploreAbstractNodeView
	{
		// Token: 0x0601E231 RID: 123441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E231")]
		[Address(RVA = "0x17CA7F0", Offset = "0x17C93F0", VA = "0x1817CA7F0", Slot = "4")]
		public override void Render(FifthAnnivExploreMapNodeViewModel nodeViewModel, int currentIndexInRoute)
		{
		}

		// Token: 0x0601E232 RID: 123442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E232")]
		[Address(RVA = "0x17CA8B0", Offset = "0x17C94B0", VA = "0x1817CA8B0")]
		public FifthAnnivExploreEndNodeView()
		{
		}

		// Token: 0x040281AD RID: 164269
		[Token(Token = "0x40281AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelSuccess;

		// Token: 0x040281AE RID: 164270
		[Token(Token = "0x40281AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelFail;

		// Token: 0x040281AF RID: 164271
		[Token(Token = "0x40281AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040281B0 RID: 164272
		[Token(Token = "0x40281B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
