using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A74 RID: 27252
	[Token(Token = "0x2006A74")]
	public class StageStorylineStorySetLocationViewModel : StageStorylineLocationViewModel
	{
		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x06026F40 RID: 159552 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026F41 RID: 159553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BDE")]
		public StageStorylineStorySetViewModel relevantStorySet
		{
			[Token(Token = "0x6026F40")]
			[Address(RVA = "0x222D430", Offset = "0x222C030", VA = "0x18222D430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026F41")]
			[Address(RVA = "0x222D490", Offset = "0x222C090", VA = "0x18222D490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x06026F42 RID: 159554 RVA: 0x000CCF18 File Offset: 0x000CB118
		[Token(Token = "0x17005BDF")]
		public bool isBlocked
		{
			[Token(Token = "0x6026F42")]
			[Address(RVA = "0x222D320", Offset = "0x222BF20", VA = "0x18222D320")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06026F43 RID: 159555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F43")]
		[Address(RVA = "0x222CF50", Offset = "0x222BB50", VA = "0x18222CF50", Slot = "5")]
		public override void LoadData(StorylineLocationData data, Dictionary<string, StageStorylineStorySetViewModel> storySetDict)
		{
		}

		// Token: 0x06026F44 RID: 159556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F44")]
		[Address(RVA = "0x222D000", Offset = "0x222BC00", VA = "0x18222D000")]
		private void _LoadRelevantStorySet(StorylineLocationData data, Dictionary<string, StageStorylineStorySetViewModel> storySetDict)
		{
		}

		// Token: 0x06026F45 RID: 159557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F45")]
		[Address(RVA = "0x222D280", Offset = "0x222BE80", VA = "0x18222D280")]
		public StageStorylineStorySetLocationViewModel()
		{
		}

		// Token: 0x06026F46 RID: 159558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F46")]
		[Address(RVA = "0x2228F80", Offset = "0x2227B80", VA = "0x182228F80")]
		private void <>xLuaBaseProxy_LoadData(StorylineLocationData P0, Dictionary<string, StageStorylineStorySetViewModel> P1)
		{
		}

		// Token: 0x04037196 RID: 225686
		[Token(Token = "0x4037196")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_relevantStorySet;

		// Token: 0x04037197 RID: 225687
		[Token(Token = "0x4037197")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_relevantStorySet;

		// Token: 0x04037198 RID: 225688
		[Token(Token = "0x4037198")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isBlocked;

		// Token: 0x04037199 RID: 225689
		[Token(Token = "0x4037199")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403719A RID: 225690
		[Token(Token = "0x403719A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadRelevantStorySet;

		// Token: 0x0403719B RID: 225691
		[Token(Token = "0x403719B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
