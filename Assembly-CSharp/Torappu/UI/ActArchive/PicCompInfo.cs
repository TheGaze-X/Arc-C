using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BE3 RID: 27619
	[Token(Token = "0x2006BE3")]
	public class PicCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027702 RID: 161538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027702")]
		[Address(RVA = "0x22A64E0", Offset = "0x22A50E0", VA = "0x1822A64E0")]
		public PicCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027703 RID: 161539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027703")]
		[Address(RVA = "0x22A5A80", Offset = "0x22A4680", VA = "0x1822A5A80")]
		public PicItemModel GetPicItemInfo(string picId)
		{
			return null;
		}

		// Token: 0x06027704 RID: 161540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027704")]
		[Address(RVA = "0x22A6330", Offset = "0x22A4F30", VA = "0x1822A6330")]
		public void SetSelectedPicItem(string picID, bool isInit)
		{
		}

		// Token: 0x06027705 RID: 161541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027705")]
		[Address(RVA = "0x22A5F70", Offset = "0x22A4B70", VA = "0x1822A5F70")]
		public void SetHomeKV()
		{
		}

		// Token: 0x06027706 RID: 161542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027706")]
		[Address(RVA = "0x22A6250", Offset = "0x22A4E50", VA = "0x1822A6250")]
		public void SetPicItemFullscreen(bool on)
		{
		}

		// Token: 0x06027707 RID: 161543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027707")]
		[Address(RVA = "0x22A5D50", Offset = "0x22A4950", VA = "0x1822A5D50", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027708 RID: 161544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027708")]
		[Address(RVA = "0x22A5860", Offset = "0x22A4460", VA = "0x1822A5860", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027709 RID: 161545 RVA: 0x000CE610 File Offset: 0x000CC810
		[Token(Token = "0x6027709")]
		[Address(RVA = "0x22A5CD0", Offset = "0x22A48D0", VA = "0x1822A5CD0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602770A RID: 161546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602770A")]
		[Address(RVA = "0x22A5EC0", Offset = "0x22A4AC0", VA = "0x1822A5EC0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x0602770B RID: 161547 RVA: 0x000CE628 File Offset: 0x000CC828
		[Token(Token = "0x602770B")]
		[Address(RVA = "0x22A5B70", Offset = "0x22A4770", VA = "0x1822A5B70", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x0602770C RID: 161548 RVA: 0x000CE640 File Offset: 0x000CC840
		[Token(Token = "0x602770C")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x04037E0B RID: 228875
		[Token(Token = "0x4037E0B")]
		[FieldOffset(Offset = "0x18")]
		public PicProperty pic;

		// Token: 0x04037E0C RID: 228876
		[Token(Token = "0x4037E0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037E0D RID: 228877
		[Token(Token = "0x4037E0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPicItemInfo;

		// Token: 0x04037E0E RID: 228878
		[Token(Token = "0x4037E0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedPicItem;

		// Token: 0x04037E0F RID: 228879
		[Token(Token = "0x4037E0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetHomeKV;

		// Token: 0x04037E10 RID: 228880
		[Token(Token = "0x4037E10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetPicItemFullscreen;

		// Token: 0x04037E11 RID: 228881
		[Token(Token = "0x4037E11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037E12 RID: 228882
		[Token(Token = "0x4037E12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037E13 RID: 228883
		[Token(Token = "0x4037E13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037E14 RID: 228884
		[Token(Token = "0x4037E14")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037E15 RID: 228885
		[Token(Token = "0x4037E15")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HasNewItem;
	}
}
