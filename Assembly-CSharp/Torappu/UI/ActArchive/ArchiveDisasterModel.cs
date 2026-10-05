using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B67 RID: 27495
	[Token(Token = "0x2006B67")]
	public class ArchiveDisasterModel : IHotfixable
	{
		// Token: 0x06027498 RID: 160920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027498")]
		[Address(RVA = "0x227BC00", Offset = "0x227A800", VA = "0x18227BC00")]
		private string _GetDefaultSelectId()
		{
			return null;
		}

		// Token: 0x06027499 RID: 160921 RVA: 0x000CDEF0 File Offset: 0x000CC0F0
		[Token(Token = "0x6027499")]
		[Address(RVA = "0x227ACA0", Offset = "0x22798A0", VA = "0x18227ACA0")]
		public bool HasNewMark()
		{
			return default(bool);
		}

		// Token: 0x0602749A RID: 160922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602749A")]
		[Address(RVA = "0x227B980", Offset = "0x227A580", VA = "0x18227B980")]
		public void SetSelectedType(string typeId)
		{
		}

		// Token: 0x0602749B RID: 160923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602749B")]
		[Address(RVA = "0x227AC20", Offset = "0x2279820", VA = "0x18227AC20")]
		public DisasterTypeModel GetSelectedTypeModel()
		{
			return null;
		}

		// Token: 0x0602749C RID: 160924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602749C")]
		[Address(RVA = "0x227AE70", Offset = "0x2279A70", VA = "0x18227AE70")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData)
		{
		}

		// Token: 0x0602749D RID: 160925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602749D")]
		[Address(RVA = "0x227BCE0", Offset = "0x227A8E0", VA = "0x18227BCE0")]
		public ArchiveDisasterModel()
		{
		}

		// Token: 0x04037A0A RID: 227850
		[Token(Token = "0x4037A0A")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, DisasterTypeModel> disasterTypeModels;

		// Token: 0x04037A0B RID: 227851
		[Token(Token = "0x4037A0B")]
		[FieldOffset(Offset = "0x18")]
		public string selectedTypeId;

		// Token: 0x04037A0C RID: 227852
		[Token(Token = "0x4037A0C")]
		[FieldOffset(Offset = "0x20")]
		public bool showSwitchAnim;

		// Token: 0x04037A0D RID: 227853
		[Token(Token = "0x4037A0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetDefaultSelectId;

		// Token: 0x04037A0E RID: 227854
		[Token(Token = "0x4037A0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HasNewMark;

		// Token: 0x04037A0F RID: 227855
		[Token(Token = "0x4037A0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedType;

		// Token: 0x04037A10 RID: 227856
		[Token(Token = "0x4037A10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedTypeModel;

		// Token: 0x04037A11 RID: 227857
		[Token(Token = "0x4037A11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037A12 RID: 227858
		[Token(Token = "0x4037A12")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
