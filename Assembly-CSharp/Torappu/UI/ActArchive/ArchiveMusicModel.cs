using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BBB RID: 27579
	[Token(Token = "0x2006BBB")]
	public class ArchiveMusicModel : IHotfixable
	{
		// Token: 0x06027633 RID: 161331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027633")]
		[Address(RVA = "0x22941E0", Offset = "0x2292DE0", VA = "0x1822941E0")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027634 RID: 161332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027634")]
		[Address(RVA = "0x2294840", Offset = "0x2293440", VA = "0x182294840")]
		private ActArchiveResData.AudioArchiveResItemData _getArchiveMusicResData(string musicId)
		{
			return null;
		}

		// Token: 0x06027635 RID: 161333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027635")]
		[Address(RVA = "0x2293F60", Offset = "0x2292B60", VA = "0x182293F60")]
		public string GetDefaultItemID()
		{
			return null;
		}

		// Token: 0x06027636 RID: 161334 RVA: 0x000CE400 File Offset: 0x000CC600
		[Token(Token = "0x6027636")]
		[Address(RVA = "0x22940F0", Offset = "0x2292CF0", VA = "0x1822940F0")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x06027637 RID: 161335 RVA: 0x000CE418 File Offset: 0x000CC618
		[Token(Token = "0x6027637")]
		[Address(RVA = "0x2294180", Offset = "0x2292D80", VA = "0x182294180")]
		public bool IsCurrHomeTheme()
		{
			return default(bool);
		}

		// Token: 0x06027638 RID: 161336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027638")]
		[Address(RVA = "0x2294790", Offset = "0x2293390", VA = "0x182294790")]
		public ArchiveMusicModel()
		{
		}

		// Token: 0x04037CD6 RID: 228566
		[Token(Token = "0x4037CD6")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, MusicItemModel> musicItems;

		// Token: 0x04037CD7 RID: 228567
		[Token(Token = "0x4037CD7")]
		[FieldOffset(Offset = "0x18")]
		public string selectedMusicId;

		// Token: 0x04037CD8 RID: 228568
		[Token(Token = "0x4037CD8")]
		[FieldOffset(Offset = "0x20")]
		public string homeMusicId;

		// Token: 0x04037CD9 RID: 228569
		[Token(Token = "0x4037CD9")]
		[FieldOffset(Offset = "0x28")]
		public bool isInit;

		// Token: 0x04037CDA RID: 228570
		[Token(Token = "0x4037CDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037CDB RID: 228571
		[Token(Token = "0x4037CDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__getArchiveMusicResData;

		// Token: 0x04037CDC RID: 228572
		[Token(Token = "0x4037CDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemID;

		// Token: 0x04037CDD RID: 228573
		[Token(Token = "0x4037CDD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x04037CDE RID: 228574
		[Token(Token = "0x4037CDE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsCurrHomeTheme;

		// Token: 0x04037CDF RID: 228575
		[Token(Token = "0x4037CDF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
