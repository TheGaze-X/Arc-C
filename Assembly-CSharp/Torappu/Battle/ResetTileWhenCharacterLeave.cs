using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002387 RID: 9095
	[Token(Token = "0x2002387")]
	public class ResetTileWhenCharacterLeave : Tile.Behaviour
	{
		// Token: 0x0600E6BD RID: 59069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BD")]
		[Address(RVA = "0x5C5DA0", Offset = "0x5C49A0", VA = "0x1805C5DA0", Slot = "4")]
		public override void Init(Tile tile)
		{
		}

		// Token: 0x0600E6BE RID: 59070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BE")]
		[Address(RVA = "0x5C5E20", Offset = "0x5C4A20", VA = "0x1805C5E20", Slot = "8")]
		public override void OnEntityLeave(Entity entity)
		{
		}

		// Token: 0x0600E6BF RID: 59071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6BF")]
		[Address(RVA = "0x5C5CF0", Offset = "0x5C48F0", VA = "0x1805C5CF0")]
		public void AddExcludeCharacter(Character character)
		{
		}

		// Token: 0x0600E6C0 RID: 59072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C0")]
		[Address(RVA = "0x5C6110", Offset = "0x5C4D10", VA = "0x1805C6110")]
		public void RemoveExcludeCharacter(Character character)
		{
		}

		// Token: 0x0600E6C1 RID: 59073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C1")]
		[Address(RVA = "0x5C61F0", Offset = "0x5C4DF0", VA = "0x1805C61F0")]
		private void _ResetTile()
		{
		}

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x00054168 File Offset: 0x00052368
		[Token(Token = "0x600E6C2")]
		[Address(RVA = "0x5C61C0", Offset = "0x5C4DC0", VA = "0x1805C61C0")]
		private bool _CheckLeaveEntityTheLastOnTile()
		{
			return default(bool);
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6C3")]
		[Address(RVA = "0x5C6380", Offset = "0x5C4F80", VA = "0x1805C6380")]
		public ResetTileWhenCharacterLeave()
		{
		}

		// Token: 0x0400FE1A RID: 65050
		[Token(Token = "0x400FE1A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _excludeKeys;

		// Token: 0x0400FE1B RID: 65051
		[Token(Token = "0x400FE1B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _resetTileOptions;

		// Token: 0x0400FE1C RID: 65052
		[Token(Token = "0x400FE1C")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _resetTileMode;

		// Token: 0x0400FE1D RID: 65053
		[Token(Token = "0x400FE1D")]
		[FieldOffset(Offset = "0x30")]
		private List<Character> m_excludeCharacters;
	}
}
