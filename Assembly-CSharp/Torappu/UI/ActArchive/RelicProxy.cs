using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC5 RID: 27333
	[Token(Token = "0x2006AC5")]
	public class RelicProxy : ActArchiveCompProxy<ArchiveRelicController>
	{
		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x06027194 RID: 160148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C68")]
		protected override string compType
		{
			[Token(Token = "0x6027194")]
			[Address(RVA = "0x223B780", Offset = "0x223A380", VA = "0x18223B780", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027195 RID: 160149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027195")]
		[Address(RVA = "0x223ACA0", Offset = "0x22398A0", VA = "0x18223ACA0", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027196 RID: 160150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027196")]
		[Address(RVA = "0x223AD70", Offset = "0x2239970", VA = "0x18223AD70", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x06027197 RID: 160151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027197")]
		[Address(RVA = "0x223B3C0", Offset = "0x2239FC0", VA = "0x18223B3C0")]
		private void _OnRelicItemClicked(ActArchiveType type, string relicID)
		{
		}

		// Token: 0x06027198 RID: 160152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027198")]
		[Address(RVA = "0x223B1C0", Offset = "0x2239DC0", VA = "0x18223B1C0")]
		private void _OnFilterMethodClicked(FilterRule rule)
		{
		}

		// Token: 0x06027199 RID: 160153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027199")]
		[Address(RVA = "0x223B510", Offset = "0x223A110", VA = "0x18223B510")]
		private void _OnSwitchDifficultyClicked(int toward)
		{
		}

		// Token: 0x0602719A RID: 160154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602719A")]
		[Address(RVA = "0x223B710", Offset = "0x223A310", VA = "0x18223B710")]
		public RelicProxy()
		{
		}

		// Token: 0x04037503 RID: 226563
		[Token(Token = "0x4037503")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037504 RID: 226564
		[Token(Token = "0x4037504")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037505 RID: 226565
		[Token(Token = "0x4037505")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037506 RID: 226566
		[Token(Token = "0x4037506")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRelicItemClicked;

		// Token: 0x04037507 RID: 226567
		[Token(Token = "0x4037507")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnFilterMethodClicked;

		// Token: 0x04037508 RID: 226568
		[Token(Token = "0x4037508")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSwitchDifficultyClicked;

		// Token: 0x04037509 RID: 226569
		[Token(Token = "0x4037509")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
