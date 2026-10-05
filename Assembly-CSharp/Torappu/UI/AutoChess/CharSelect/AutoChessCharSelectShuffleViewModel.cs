using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C8 RID: 25544
	[Token(Token = "0x20063C8")]
	public class AutoChessCharSelectShuffleViewModel : TemplateShuffleViewModelBase<AutoChessCharSelectCardViewModel>
	{
		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x06024D49 RID: 150857 RVA: 0x000C5970 File Offset: 0x000C3B70
		// (set) Token: 0x06024D4A RID: 150858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056F6")]
		public bool showFilterPanel
		{
			[Token(Token = "0x6024D49")]
			[Address(RVA = "0x1FBB460", Offset = "0x1FBA060", VA = "0x181FBB460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6024D4A")]
			[Address(RVA = "0x1FBB520", Offset = "0x1FBA120", VA = "0x181FBB520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x06024D4B RID: 150859 RVA: 0x000C5988 File Offset: 0x000C3B88
		[Token(Token = "0x170056F7")]
		public override CharacterSortType sortType
		{
			[Token(Token = "0x6024D4B")]
			[Address(RVA = "0x1FBB4C0", Offset = "0x1FBA0C0", VA = "0x181FBB4C0", Slot = "4")]
			get
			{
				return CharacterSortType.BY_LEVEL_UP;
			}
		}

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x06024D4C RID: 150860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056F8")]
		public override CharacterProfessionFilterViewModel profFilter
		{
			[Token(Token = "0x6024D4C")]
			[Address(RVA = "0x1FBB400", Offset = "0x1FBA000", VA = "0x181FBB400", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024D4D RID: 150861 RVA: 0x000C59A0 File Offset: 0x000C3BA0
		[Token(Token = "0x6024D4D")]
		[Address(RVA = "0x1FBB230", Offset = "0x1FB9E30", VA = "0x181FBB230")]
		public bool SetFilter(ProfessionCategory filter, string subProfessionId, bool isAll)
		{
			return default(bool);
		}

		// Token: 0x06024D4E RID: 150862 RVA: 0x000C59B8 File Offset: 0x000C3BB8
		[Token(Token = "0x6024D4E")]
		[Address(RVA = "0x1FBAFB0", Offset = "0x1FB9BB0", VA = "0x181FBAFB0", Slot = "10")]
		protected override int OnSortChar(AutoChessCharSelectCardViewModel a, AutoChessCharSelectCardViewModel b)
		{
			return 0;
		}

		// Token: 0x06024D4F RID: 150863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D4F")]
		[Address(RVA = "0x1FBB330", Offset = "0x1FB9F30", VA = "0x181FBB330")]
		public AutoChessCharSelectShuffleViewModel()
		{
		}

		// Token: 0x040337E1 RID: 210913
		[Token(Token = "0x40337E1")]
		[FieldOffset(Offset = "0x10")]
		private CharacterProfessionFilterViewModel m_profFilter;

		// Token: 0x040337E3 RID: 210915
		[Token(Token = "0x40337E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showFilterPanel;

		// Token: 0x040337E4 RID: 210916
		[Token(Token = "0x40337E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_showFilterPanel;

		// Token: 0x040337E5 RID: 210917
		[Token(Token = "0x40337E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sortType;

		// Token: 0x040337E6 RID: 210918
		[Token(Token = "0x40337E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_profFilter;

		// Token: 0x040337E7 RID: 210919
		[Token(Token = "0x40337E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetFilter;

		// Token: 0x040337E8 RID: 210920
		[Token(Token = "0x40337E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSortChar;

		// Token: 0x040337E9 RID: 210921
		[Token(Token = "0x40337E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
