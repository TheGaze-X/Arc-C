using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E64 RID: 20068
	[Token(Token = "0x2004E64")]
	public class FireworkNpcDialogModel : IHotfixable
	{
		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x0601DF22 RID: 122658 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF23 RID: 122659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004645")]
		public string desc
		{
			[Token(Token = "0x601DF22")]
			[Address(RVA = "0x17A1BA0", Offset = "0x17A07A0", VA = "0x1817A1BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF23")]
			[Address(RVA = "0x17A1CC0", Offset = "0x17A08C0", VA = "0x1817A1CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x0601DF24 RID: 122660 RVA: 0x000ACFB0 File Offset: 0x000AB1B0
		// (set) Token: 0x0601DF25 RID: 122661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004646")]
		public Act38SideData.NpcDialogType dialogType
		{
			[Token(Token = "0x601DF24")]
			[Address(RVA = "0x17A1C00", Offset = "0x17A0800", VA = "0x1817A1C00")]
			[CompilerGenerated]
			get
			{
				return Act38SideData.NpcDialogType.NONE;
			}
			[Token(Token = "0x601DF25")]
			[Address(RVA = "0x17A1D40", Offset = "0x17A0940", VA = "0x1817A1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x0601DF26 RID: 122662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF27 RID: 122663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004647")]
		public string npcSpineName
		{
			[Token(Token = "0x601DF26")]
			[Address(RVA = "0x17A1C60", Offset = "0x17A0860", VA = "0x1817A1C60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF27")]
			[Address(RVA = "0x17A1DB0", Offset = "0x17A09B0", VA = "0x1817A1DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601DF28 RID: 122664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF28")]
		[Address(RVA = "0x17A19D0", Offset = "0x17A05D0", VA = "0x1817A19D0")]
		public void LoadData(Act38SideData.Act38SideNpcDialogData dialogData)
		{
		}

		// Token: 0x0601DF29 RID: 122665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF29")]
		[Address(RVA = "0x17A1B40", Offset = "0x17A0740", VA = "0x1817A1B40")]
		public FireworkNpcDialogModel()
		{
		}

		// Token: 0x04027C28 RID: 162856
		[Token(Token = "0x4027C28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x04027C29 RID: 162857
		[Token(Token = "0x4027C29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x04027C2A RID: 162858
		[Token(Token = "0x4027C2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dialogType;

		// Token: 0x04027C2B RID: 162859
		[Token(Token = "0x4027C2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_dialogType;

		// Token: 0x04027C2C RID: 162860
		[Token(Token = "0x4027C2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_npcSpineName;

		// Token: 0x04027C2D RID: 162861
		[Token(Token = "0x4027C2D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_npcSpineName;

		// Token: 0x04027C2E RID: 162862
		[Token(Token = "0x4027C2E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027C2F RID: 162863
		[Token(Token = "0x4027C2F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
