using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A73 RID: 27251
	[Token(Token = "0x2006A73")]
	public abstract class StageStorylineLocationViewModel : IComparable<StageStorylineLocationViewModel>, IHotfixable
	{
		// Token: 0x17005BD8 RID: 23512
		// (get) Token: 0x06026F30 RID: 159536 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026F31 RID: 159537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD8")]
		public string locationId
		{
			[Token(Token = "0x6026F30")]
			[Address(RVA = "0x2227780", Offset = "0x2226380", VA = "0x182227780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026F31")]
			[Address(RVA = "0x22279C0", Offset = "0x22265C0", VA = "0x1822279C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BD9 RID: 23513
		// (get) Token: 0x06026F32 RID: 159538 RVA: 0x000CCEB8 File Offset: 0x000CB0B8
		// (set) Token: 0x06026F33 RID: 159539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BD9")]
		public StorylineLocationType locationType
		{
			[Token(Token = "0x6026F32")]
			[Address(RVA = "0x22277E0", Offset = "0x22263E0", VA = "0x1822277E0")]
			[CompilerGenerated]
			get
			{
				return StorylineLocationType.STORY_SET;
			}
			[Token(Token = "0x6026F33")]
			[Address(RVA = "0x2227A40", Offset = "0x2226640", VA = "0x182227A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BDA RID: 23514
		// (get) Token: 0x06026F34 RID: 159540 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026F35 RID: 159541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BDA")]
		public string unlockStageId
		{
			[Token(Token = "0x6026F34")]
			[Address(RVA = "0x2227900", Offset = "0x2226500", VA = "0x182227900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026F35")]
			[Address(RVA = "0x2227BA0", Offset = "0x22267A0", VA = "0x182227BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x06026F36 RID: 159542 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026F37 RID: 159543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BDB")]
		public StageStorylineViewModel parentStoryline
		{
			[Token(Token = "0x6026F36")]
			[Address(RVA = "0x2227840", Offset = "0x2226440", VA = "0x182227840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026F37")]
			[Address(RVA = "0x2227AB0", Offset = "0x22266B0", VA = "0x182227AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x06026F38 RID: 159544 RVA: 0x000CCED0 File Offset: 0x000CB0D0
		// (set) Token: 0x06026F39 RID: 159545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BDC")]
		public bool presented
		{
			[Token(Token = "0x6026F38")]
			[Address(RVA = "0x22278A0", Offset = "0x22264A0", VA = "0x1822278A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026F39")]
			[Address(RVA = "0x2227B30", Offset = "0x2226730", VA = "0x182227B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x06026F3A RID: 159546 RVA: 0x000CCEE8 File Offset: 0x000CB0E8
		// (set) Token: 0x06026F3B RID: 159547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BDD")]
		public bool unlocked
		{
			[Token(Token = "0x6026F3A")]
			[Address(RVA = "0x2227960", Offset = "0x2226560", VA = "0x182227960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6026F3B")]
			[Address(RVA = "0x2227C20", Offset = "0x2226820", VA = "0x182227C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026F3C RID: 159548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F3C")]
		[Address(RVA = "0x2227320", Offset = "0x2225F20", VA = "0x182227320", Slot = "5")]
		public virtual void LoadData(StorylineLocationData data, Dictionary<string, StageStorylineStorySetViewModel> storySetDict)
		{
		}

		// Token: 0x06026F3D RID: 159549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F3D")]
		[Address(RVA = "0x22275A0", Offset = "0x22261A0", VA = "0x1822275A0")]
		private void _LoadPresentAndUnlockState(StorylineLocationData data)
		{
		}

		// Token: 0x06026F3E RID: 159550 RVA: 0x000CCF00 File Offset: 0x000CB100
		[Token(Token = "0x6026F3E")]
		[Address(RVA = "0x22271F0", Offset = "0x2225DF0", VA = "0x1822271F0", Slot = "4")]
		public int CompareTo(StageStorylineLocationViewModel other)
		{
			return 0;
		}

		// Token: 0x06026F3F RID: 159551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F3F")]
		[Address(RVA = "0x2227720", Offset = "0x2226320", VA = "0x182227720")]
		protected StageStorylineLocationViewModel()
		{
		}

		// Token: 0x0403717C RID: 225660
		[Token(Token = "0x403717C")]
		[FieldOffset(Offset = "0x10")]
		private int m_sortId;

		// Token: 0x0403717D RID: 225661
		[Token(Token = "0x403717D")]
		[FieldOffset(Offset = "0x18")]
		private long m_startTime;

		// Token: 0x0403717E RID: 225662
		[Token(Token = "0x403717E")]
		[FieldOffset(Offset = "0x20")]
		private string m_presentStageId;

		// Token: 0x04037185 RID: 225669
		[Token(Token = "0x4037185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_locationId;

		// Token: 0x04037186 RID: 225670
		[Token(Token = "0x4037186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_locationId;

		// Token: 0x04037187 RID: 225671
		[Token(Token = "0x4037187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_locationType;

		// Token: 0x04037188 RID: 225672
		[Token(Token = "0x4037188")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_locationType;

		// Token: 0x04037189 RID: 225673
		[Token(Token = "0x4037189")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_unlockStageId;

		// Token: 0x0403718A RID: 225674
		[Token(Token = "0x403718A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_unlockStageId;

		// Token: 0x0403718B RID: 225675
		[Token(Token = "0x403718B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_parentStoryline;

		// Token: 0x0403718C RID: 225676
		[Token(Token = "0x403718C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_parentStoryline;

		// Token: 0x0403718D RID: 225677
		[Token(Token = "0x403718D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_presented;

		// Token: 0x0403718E RID: 225678
		[Token(Token = "0x403718E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_presented;

		// Token: 0x0403718F RID: 225679
		[Token(Token = "0x403718F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_unlocked;

		// Token: 0x04037190 RID: 225680
		[Token(Token = "0x4037190")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_unlocked;

		// Token: 0x04037191 RID: 225681
		[Token(Token = "0x4037191")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037192 RID: 225682
		[Token(Token = "0x4037192")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadPresentAndUnlockState;

		// Token: 0x04037193 RID: 225683
		[Token(Token = "0x4037193")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04037194 RID: 225684
		[Token(Token = "0x4037194")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
