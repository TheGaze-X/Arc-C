using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BB9 RID: 27577
	[Token(Token = "0x2006BB9")]
	public abstract class ArchiveItemModel : IHotfixable
	{
		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x06027626 RID: 161318 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027627 RID: 161319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CFF")]
		private protected string localTrackType
		{
			[Token(Token = "0x6027626")]
			[Address(RVA = "0x22912C0", Offset = "0x228FEC0", VA = "0x1822912C0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027627")]
			[Address(RVA = "0x2291410", Offset = "0x2290010", VA = "0x182291410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x06027628 RID: 161320 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027629 RID: 161321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D00")]
		public string archiveId
		{
			[Token(Token = "0x6027628")]
			[Address(RVA = "0x2291260", Offset = "0x228FE60", VA = "0x182291260")]
			get
			{
				return null;
			}
			[Token(Token = "0x6027629")]
			[Address(RVA = "0x2291320", Offset = "0x228FF20", VA = "0x182291320")]
			set
			{
			}
		}

		// Token: 0x0602762A RID: 161322 RVA: 0x000CE3E8 File Offset: 0x000CC5E8
		[Token(Token = "0x602762A")]
		[Address(RVA = "0x2290F60", Offset = "0x228FB60", VA = "0x182290F60")]
		public bool CheckIfHasNewMark()
		{
			return default(bool);
		}

		// Token: 0x0602762B RID: 161323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602762B")]
		[Address(RVA = "0x22910F0", Offset = "0x228FCF0", VA = "0x1822910F0")]
		public void RemoveNewMark()
		{
		}

		// Token: 0x0602762C RID: 161324
		[Token(Token = "0x602762C")]
		public abstract string GetFuncId();

		// Token: 0x0602762D RID: 161325
		[Token(Token = "0x602762D")]
		public abstract string GetDesc();

		// Token: 0x0602762E RID: 161326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602762E")]
		[Address(RVA = "0x2291080", Offset = "0x228FC80", VA = "0x182291080", Slot = "6")]
		public virtual string GetTrackType(string archiveId)
		{
			return null;
		}

		// Token: 0x0602762F RID: 161327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602762F")]
		[Address(RVA = "0x2291200", Offset = "0x228FE00", VA = "0x182291200")]
		protected ArchiveItemModel()
		{
		}

		// Token: 0x04037CC5 RID: 228549
		[Token(Token = "0x4037CC5")]
		[FieldOffset(Offset = "0x18")]
		private string m_archiveId;

		// Token: 0x04037CC6 RID: 228550
		[Token(Token = "0x4037CC6")]
		[FieldOffset(Offset = "0x20")]
		public bool locked;

		// Token: 0x04037CC7 RID: 228551
		[Token(Token = "0x4037CC7")]
		[FieldOffset(Offset = "0x28")]
		public string lockedToast;

		// Token: 0x04037CC8 RID: 228552
		[Token(Token = "0x4037CC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_localTrackType;

		// Token: 0x04037CC9 RID: 228553
		[Token(Token = "0x4037CC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_localTrackType;

		// Token: 0x04037CCA RID: 228554
		[Token(Token = "0x4037CCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_archiveId;

		// Token: 0x04037CCB RID: 228555
		[Token(Token = "0x4037CCB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_archiveId;

		// Token: 0x04037CCC RID: 228556
		[Token(Token = "0x4037CCC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfHasNewMark;

		// Token: 0x04037CCD RID: 228557
		[Token(Token = "0x4037CCD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RemoveNewMark;

		// Token: 0x04037CCE RID: 228558
		[Token(Token = "0x4037CCE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTrackType;

		// Token: 0x04037CCF RID: 228559
		[Token(Token = "0x4037CCF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
