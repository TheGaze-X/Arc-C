using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A7E RID: 27262
	[Token(Token = "0x2006A7E")]
	public class StageStorylineTagViewModel : IComparable<StageStorylineTagViewModel>, IHotfixable
	{
		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x06026FFB RID: 159739 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026FFC RID: 159740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C1D")]
		public string tagId
		{
			[Token(Token = "0x6026FFB")]
			[Address(RVA = "0x2230030", Offset = "0x222EC30", VA = "0x182230030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026FFC")]
			[Address(RVA = "0x2230260", Offset = "0x222EE60", VA = "0x182230260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C1E RID: 23582
		// (get) Token: 0x06026FFD RID: 159741 RVA: 0x000CD398 File Offset: 0x000CB598
		// (set) Token: 0x06026FFE RID: 159742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C1E")]
		public int sortId
		{
			[Token(Token = "0x6026FFD")]
			[Address(RVA = "0x222FF70", Offset = "0x222EB70", VA = "0x18222FF70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6026FFE")]
			[Address(RVA = "0x2230170", Offset = "0x222ED70", VA = "0x182230170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C1F RID: 23583
		// (get) Token: 0x06026FFF RID: 159743 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027000 RID: 159744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C1F")]
		public string tagDesc
		{
			[Token(Token = "0x6026FFF")]
			[Address(RVA = "0x222FFD0", Offset = "0x222EBD0", VA = "0x18222FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027000")]
			[Address(RVA = "0x22301E0", Offset = "0x222EDE0", VA = "0x1822301E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C20 RID: 23584
		// (get) Token: 0x06027001 RID: 159745 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027002 RID: 159746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C20")]
		public string textColor
		{
			[Token(Token = "0x6027001")]
			[Address(RVA = "0x2230090", Offset = "0x222EC90", VA = "0x182230090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027002")]
			[Address(RVA = "0x22302E0", Offset = "0x222EEE0", VA = "0x1822302E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005C21 RID: 23585
		// (get) Token: 0x06027003 RID: 159747 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027004 RID: 159748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C21")]
		public string bkgColor
		{
			[Token(Token = "0x6027003")]
			[Address(RVA = "0x222FF10", Offset = "0x222EB10", VA = "0x18222FF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027004")]
			[Address(RVA = "0x22300F0", Offset = "0x222ECF0", VA = "0x1822300F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027005 RID: 159749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027005")]
		[Address(RVA = "0x222FC90", Offset = "0x222E890", VA = "0x18222FC90")]
		public void LoadData(StorylineTagData data)
		{
		}

		// Token: 0x06027006 RID: 159750 RVA: 0x000CD3B0 File Offset: 0x000CB5B0
		[Token(Token = "0x6027006")]
		[Address(RVA = "0x222FAD0", Offset = "0x222E6D0", VA = "0x18222FAD0", Slot = "4")]
		public int CompareTo(StageStorylineTagViewModel other)
		{
			return 0;
		}

		// Token: 0x06027007 RID: 159751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027007")]
		[Address(RVA = "0x222FEB0", Offset = "0x222EAB0", VA = "0x18222FEB0")]
		public StageStorylineTagViewModel()
		{
		}

		// Token: 0x04037291 RID: 225937
		[Token(Token = "0x4037291")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tagId;

		// Token: 0x04037292 RID: 225938
		[Token(Token = "0x4037292")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_tagId;

		// Token: 0x04037293 RID: 225939
		[Token(Token = "0x4037293")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04037294 RID: 225940
		[Token(Token = "0x4037294")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04037295 RID: 225941
		[Token(Token = "0x4037295")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tagDesc;

		// Token: 0x04037296 RID: 225942
		[Token(Token = "0x4037296")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tagDesc;

		// Token: 0x04037297 RID: 225943
		[Token(Token = "0x4037297")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_textColor;

		// Token: 0x04037298 RID: 225944
		[Token(Token = "0x4037298")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_textColor;

		// Token: 0x04037299 RID: 225945
		[Token(Token = "0x4037299")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bkgColor;

		// Token: 0x0403729A RID: 225946
		[Token(Token = "0x403729A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_bkgColor;

		// Token: 0x0403729B RID: 225947
		[Token(Token = "0x403729B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403729C RID: 225948
		[Token(Token = "0x403729C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403729D RID: 225949
		[Token(Token = "0x403729D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
