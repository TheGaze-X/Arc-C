using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E68 RID: 20072
	[Token(Token = "0x2004E68")]
	public class FireworkPuzzleDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x0601DF4B RID: 122699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601DF4C RID: 122700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004654")]
		public string puzzleId
		{
			[Token(Token = "0x601DF4B")]
			[Address(RVA = "0x17A4210", Offset = "0x17A2E10", VA = "0x1817A4210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601DF4C")]
			[Address(RVA = "0x17A4270", Offset = "0x17A2E70", VA = "0x1817A4270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x0601DF4D RID: 122701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004655")]
		public FireworkPuzzleDetailProp prop
		{
			[Token(Token = "0x601DF4D")]
			[Address(RVA = "0x17A41B0", Offset = "0x17A2DB0", VA = "0x1817A41B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601DF4E RID: 122702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF4E")]
		[Address(RVA = "0x17A40C0", Offset = "0x17A2CC0", VA = "0x1817A40C0")]
		public FireworkPuzzleDetailStateBean()
		{
		}

		// Token: 0x04027C5E RID: 162910
		[Token(Token = "0x4027C5E")]
		[FieldOffset(Offset = "0x10")]
		private FireworkPuzzleDetailProp m_prop;

		// Token: 0x04027C60 RID: 162912
		[Token(Token = "0x4027C60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_puzzleId;

		// Token: 0x04027C61 RID: 162913
		[Token(Token = "0x4027C61")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_puzzleId;

		// Token: 0x04027C62 RID: 162914
		[Token(Token = "0x4027C62")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04027C63 RID: 162915
		[Token(Token = "0x4027C63")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
