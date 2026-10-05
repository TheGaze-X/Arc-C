using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Model;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035DD RID: 13789
	[Token(Token = "0x20035DD")]
	public class CustomSquadGroupViewModelForMainlineTypeSquad : ICustomSquadGroupViewModel, IHotfixable, ICustomViewModelMainlineTypeSquad
	{
		// Token: 0x170034C3 RID: 13507
		// (get) Token: 0x06015F1E RID: 89886 RVA: 0x0008ECF8 File Offset: 0x0008CEF8
		// (set) Token: 0x06015F1F RID: 89887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170034C3")]
		public SquadStartButtonTypeEnum startButtonMode
		{
			[Token(Token = "0x6015F1E")]
			[Address(RVA = "0xE7B9B0", Offset = "0xE7A5B0", VA = "0x180E7B9B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return SquadStartButtonTypeEnum.COMMON;
			}
			[Token(Token = "0x6015F1F")]
			[Address(RVA = "0xE7BA10", Offset = "0xE7A610", VA = "0x180E7BA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06015F20 RID: 89888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F20")]
		[Address(RVA = "0xE7B6F0", Offset = "0xE7A2F0", VA = "0x180E7B6F0", Slot = "6")]
		public virtual void LoadData(CommonSquadGroupViewModel squadGroupViewModel)
		{
		}

		// Token: 0x06015F21 RID: 89889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F21")]
		[Address(RVA = "0xE7B8F0", Offset = "0xE7A4F0", VA = "0x180E7B8F0", Slot = "7")]
		public virtual void UpdateData(CommonSquadGroupViewModel squadGroupViewModel)
		{
		}

		// Token: 0x06015F22 RID: 89890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F22")]
		[Address(RVA = "0xE7B690", Offset = "0xE7A290", VA = "0x180E7B690", Slot = "8")]
		protected virtual void LoadCustomData(CommonSquadGroupViewModel squadGroupViewModel)
		{
		}

		// Token: 0x06015F23 RID: 89891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015F23")]
		[Address(RVA = "0xE7B950", Offset = "0xE7A550", VA = "0x180E7B950")]
		public CustomSquadGroupViewModelForMainlineTypeSquad()
		{
		}

		// Token: 0x0401A614 RID: 108052
		[Token(Token = "0x401A614")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_startButtonMode;

		// Token: 0x0401A615 RID: 108053
		[Token(Token = "0x401A615")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_startButtonMode;

		// Token: 0x0401A616 RID: 108054
		[Token(Token = "0x401A616")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401A617 RID: 108055
		[Token(Token = "0x401A617")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401A618 RID: 108056
		[Token(Token = "0x401A618")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadCustomData;

		// Token: 0x0401A619 RID: 108057
		[Token(Token = "0x401A619")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
