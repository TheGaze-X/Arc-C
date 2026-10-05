using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E65 RID: 20069
	[Token(Token = "0x2004E65")]
	public class FireworkNpcModel : IHotfixable
	{
		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x0601DF2A RID: 122666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF2B RID: 122667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004648")]
		public string idleSpineName
		{
			[Token(Token = "0x601DF2A")]
			[Address(RVA = "0x17A2560", Offset = "0x17A1160", VA = "0x1817A2560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF2B")]
			[Address(RVA = "0x17A25C0", Offset = "0x17A11C0", VA = "0x1817A25C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601DF2C RID: 122668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF2C")]
		[Address(RVA = "0x17A1E30", Offset = "0x17A0A30", VA = "0x1817A1E30")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601DF2D RID: 122669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DF2D")]
		[Address(RVA = "0x17A2380", Offset = "0x17A0F80", VA = "0x1817A2380")]
		public FireworkNpcDialogModel RandomDialogByType(Act38SideData.NpcDialogType dialogType, FireworkNpcDialogModel lastDialog)
		{
			return null;
		}

		// Token: 0x0601DF2E RID: 122670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF2E")]
		[Address(RVA = "0x17A24B0", Offset = "0x17A10B0", VA = "0x1817A24B0")]
		public FireworkNpcModel()
		{
		}

		// Token: 0x04027C30 RID: 162864
		[Token(Token = "0x4027C30")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, List<FireworkNpcDialogModel>> m_dialogDict;

		// Token: 0x04027C32 RID: 162866
		[Token(Token = "0x4027C32")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_idleSpineName;

		// Token: 0x04027C33 RID: 162867
		[Token(Token = "0x4027C33")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_idleSpineName;

		// Token: 0x04027C34 RID: 162868
		[Token(Token = "0x4027C34")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027C35 RID: 162869
		[Token(Token = "0x4027C35")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RandomDialogByType;

		// Token: 0x04027C36 RID: 162870
		[Token(Token = "0x4027C36")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
