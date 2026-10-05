using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A6F RID: 27247
	[Token(Token = "0x2006A6F")]
	public abstract class StageMixStoryStorylineItemPlugin : MonoBehaviour, IHotfixable, IStageMixStoryStorySetPlugin
	{
		// Token: 0x06026EF3 RID: 159475
		[Token(Token = "0x6026EF3")]
		public abstract bool IsValid(StageStorylineStorySetViewModel model);

		// Token: 0x06026EF4 RID: 159476
		[Token(Token = "0x6026EF4")]
		public abstract void Render(StageStorylineStorySetViewModel model);

		// Token: 0x06026EF5 RID: 159477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EF5")]
		[Address(RVA = "0x22246F0", Offset = "0x22232F0", VA = "0x1822246F0")]
		protected StageMixStoryStorylineItemPlugin()
		{
		}

		// Token: 0x0403712F RID: 225583
		[Token(Token = "0x403712F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
