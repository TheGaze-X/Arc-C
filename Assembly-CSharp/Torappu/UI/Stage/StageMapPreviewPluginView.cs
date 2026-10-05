using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006921 RID: 26913
	[Token(Token = "0x2006921")]
	public abstract class StageMapPreviewPluginView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060268C7 RID: 157895
		[Token(Token = "0x60268C7")]
		public abstract void Show(string actId, StageData stageData, ILoadAsset assetLoader);

		// Token: 0x060268C8 RID: 157896
		[Token(Token = "0x60268C8")]
		public abstract void Dispose();

		// Token: 0x060268C9 RID: 157897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268C9")]
		[Address(RVA = "0x21A0C80", Offset = "0x219F880", VA = "0x1821A0C80")]
		protected StageMapPreviewPluginView()
		{
		}

		// Token: 0x040365DF RID: 222687
		[Token(Token = "0x40365DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
