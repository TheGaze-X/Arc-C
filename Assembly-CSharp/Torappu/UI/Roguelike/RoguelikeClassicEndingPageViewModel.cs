using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using Torappu.UI.RoguelikeTopic.Ending;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C0 RID: 21184
	[Token(Token = "0x20052C0")]
	public abstract class RoguelikeClassicEndingPageViewModel : IHotfixable
	{
		// Token: 0x0601F3D9 RID: 127961
		[Token(Token = "0x601F3D9")]
		public abstract void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result);

		// Token: 0x0601F3DA RID: 127962
		[Token(Token = "0x601F3DA")]
		public abstract void LoadFromResponse(string topicId, RoguelikeTopicGameSettleResponse response);

		// Token: 0x0601F3DB RID: 127963
		[Token(Token = "0x601F3DB")]
		public abstract bool CheckNeedBpView();

		// Token: 0x0601F3DC RID: 127964
		[Token(Token = "0x601F3DC")]
		public abstract RoguelikeTopicEndingBpAndGpView.Model GeneEndingBpAndGpViewModel();

		// Token: 0x0601F3DD RID: 127965
		[Token(Token = "0x601F3DD")]
		public abstract List<ItemBundle> GetRewardItemList();

		// Token: 0x0601F3DE RID: 127966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3DE")]
		[Address(RVA = "0x18F50C0", Offset = "0x18F3CC0", VA = "0x1818F50C0")]
		protected RoguelikeClassicEndingPageViewModel()
		{
		}

		// Token: 0x04029F5F RID: 171871
		[Token(Token = "0x4029F5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
