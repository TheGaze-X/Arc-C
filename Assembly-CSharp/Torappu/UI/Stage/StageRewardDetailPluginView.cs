using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200692C RID: 26924
	[Token(Token = "0x200692C")]
	public abstract class StageRewardDetailPluginView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060268FF RID: 157951
		[Token(Token = "0x60268FF")]
		public abstract void Dispose();

		// Token: 0x06026900 RID: 157952
		[Token(Token = "0x6026900")]
		public abstract void Render(string actId, StageData stageData, bool getFlag, bool completeFlag);

		// Token: 0x06026901 RID: 157953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026901")]
		[Address(RVA = "0x21B7100", Offset = "0x21B5D00", VA = "0x1821B7100")]
		protected StageRewardDetailPluginView()
		{
		}

		// Token: 0x0403663F RID: 222783
		[Token(Token = "0x403663F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
