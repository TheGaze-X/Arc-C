using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B4 RID: 1460
	[Token(Token = "0x20005B4")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CharMetaDB")]
	[Serializable]
	public class CharMetaDB : ConstTable<CharMetaTable, CharMetaDB>
	{
		// Token: 0x060060D5 RID: 24789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D5")]
		[Address(RVA = "0x1CE8090", Offset = "0x1CE6C90", VA = "0x181CE8090", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D6")]
		[Address(RVA = "0x1CE8110", Offset = "0x1CE6D10", VA = "0x181CE8110")]
		private void _InitSpCharInfo()
		{
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D7")]
		[Address(RVA = "0x1CE7DE0", Offset = "0x1CE69E0", VA = "0x181CE7DE0")]
		public string GetSpCharGroupByCharId(string charId)
		{
			return null;
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060D8")]
		[Address(RVA = "0x1CE7ED0", Offset = "0x1CE6AD0", VA = "0x181CE7ED0")]
		public List<string> GetSpCharIdsByCharId(string charId)
		{
			return null;
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060D9")]
		[Address(RVA = "0x1CE83A0", Offset = "0x1CE6FA0", VA = "0x181CE83A0")]
		public CharMetaDB()
		{
		}

		// Token: 0x04002A56 RID: 10838
		[Token(Token = "0x4002A56")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, string> m_spCharGroupMap;

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitSpCharInfo;

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSpCharGroupByCharId;

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSpCharIdsByCharId;

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
