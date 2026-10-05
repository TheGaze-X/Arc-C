using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006936 RID: 26934
	[Token(Token = "0x2006936")]
	public abstract class StagePreviewRewardGroupViewPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026925 RID: 157989
		[Token(Token = "0x6026925")]
		public abstract void Render(OverrideDropInfo viewModel);

		// Token: 0x06026926 RID: 157990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026926")]
		[Address(RVA = "0x21B4BF0", Offset = "0x21B37F0", VA = "0x1821B4BF0")]
		protected StagePreviewRewardGroupViewPlugin()
		{
		}

		// Token: 0x04036680 RID: 222848
		[Token(Token = "0x4036680")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
