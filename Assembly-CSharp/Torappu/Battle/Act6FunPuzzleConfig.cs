using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020FC RID: 8444
	[Token(Token = "0x20020FC")]
	[CreateAssetMenu(menuName = "Torappu/Tools/Battle/Act6Fun Puzzle Config")]
	public class Act6FunPuzzleConfig : ScriptableObject, IHotfixable
	{
		// Token: 0x0600CF0C RID: 53004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF0C")]
		[Address(RVA = "0x3508BD0", Offset = "0x35077D0", VA = "0x183508BD0")]
		public Act6FunPuzzleConfig()
		{
		}

		// Token: 0x0400DCC8 RID: 56520
		[Token(Token = "0x400DCC8")]
		[FieldOffset(Offset = "0x18")]
		public List<Act6FunPuzzleConfig.LevelPuzzlePack> characterActionPacks;

		// Token: 0x0400DCC9 RID: 56521
		[Token(Token = "0x400DCC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020020FD RID: 8445
		[Token(Token = "0x20020FD")]
		[Serializable]
		public class CharacterAction : IComparable<Act6FunPuzzleConfig.CharacterAction>, IHotfixable
		{
			// Token: 0x0600CF0D RID: 53005 RVA: 0x0004ACA0 File Offset: 0x00048EA0
			[Token(Token = "0x600CF0D")]
			[Address(RVA = "0x3509CE0", Offset = "0x35088E0", VA = "0x183509CE0", Slot = "4")]
			public int CompareTo(Act6FunPuzzleConfig.CharacterAction other)
			{
				return 0;
			}

			// Token: 0x0600CF0E RID: 53006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CF0E")]
			[Address(RVA = "0x3509D60", Offset = "0x3508960", VA = "0x183509D60")]
			public StringBuilder ToStringBuilder()
			{
				return null;
			}

			// Token: 0x0600CF0F RID: 53007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CF0F")]
			[Address(RVA = "0x3509FC0", Offset = "0x3508BC0", VA = "0x183509FC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0600CF10 RID: 53008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF10")]
			[Address(RVA = "0x350A060", Offset = "0x3508C60", VA = "0x18350A060")]
			public CharacterAction()
			{
			}

			// Token: 0x0600CF11 RID: 53009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CF11")]
			[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
			private string <>xLuaBaseProxy_ToString()
			{
				return null;
			}

			// Token: 0x0400DCCA RID: 56522
			[Token(Token = "0x400DCCA")]
			[FieldOffset(Offset = "0x10")]
			public float timestamp;

			// Token: 0x0400DCCB RID: 56523
			[Token(Token = "0x400DCCB")]
			[FieldOffset(Offset = "0x18")]
			public string charId;

			// Token: 0x0400DCCC RID: 56524
			[Token(Token = "0x400DCCC")]
			[FieldOffset(Offset = "0x20")]
			public PlayerOperationType op;

			// Token: 0x0400DCCD RID: 56525
			[Token(Token = "0x400DCCD")]
			[FieldOffset(Offset = "0x24")]
			public SharedConsts.Direction direction;

			// Token: 0x0400DCCE RID: 56526
			[Token(Token = "0x400DCCE")]
			[FieldOffset(Offset = "0x28")]
			public GridPosition pos;

			// Token: 0x0400DCCF RID: 56527
			[Token(Token = "0x400DCCF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x0400DCD0 RID: 56528
			[Token(Token = "0x400DCD0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ToStringBuilder;

			// Token: 0x0400DCD1 RID: 56529
			[Token(Token = "0x400DCD1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ToString;

			// Token: 0x0400DCD2 RID: 56530
			[Token(Token = "0x400DCD2")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020020FE RID: 8446
		[Token(Token = "0x20020FE")]
		[Serializable]
		public class LevelPuzzlePack : IHotfixable
		{
			// Token: 0x0600CF12 RID: 53010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF12")]
			[Address(RVA = "0x3512790", Offset = "0x3511390", VA = "0x183512790")]
			public LevelPuzzlePack()
			{
			}

			// Token: 0x0400DCD3 RID: 56531
			[Token(Token = "0x400DCD3")]
			[FieldOffset(Offset = "0x10")]
			public string levelId;

			// Token: 0x0400DCD4 RID: 56532
			[Token(Token = "0x400DCD4")]
			[FieldOffset(Offset = "0x18")]
			public List<Act6FunPuzzleConfig.CharacterAction> characterActions;

			// Token: 0x0400DCD5 RID: 56533
			[Token(Token = "0x400DCD5")]
			[FieldOffset(Offset = "0x20")]
			public List<Act6FunPuzzleConfig.LevelPuzzlePack.GridActionBundle> triggerPuzzles;

			// Token: 0x0400DCD6 RID: 56534
			[Token(Token = "0x400DCD6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020020FF RID: 8447
			[Token(Token = "0x20020FF")]
			[Serializable]
			public class GridActionBundle
			{
				// Token: 0x0600CF13 RID: 53011 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600CF13")]
				[Address(RVA = "0x350FC10", Offset = "0x350E810", VA = "0x18350FC10")]
				public GridActionBundle()
				{
				}

				// Token: 0x0400DCD7 RID: 56535
				[Token(Token = "0x400DCD7")]
				[FieldOffset(Offset = "0x10")]
				public List<GridPosition> triggerGrids;

				// Token: 0x0400DCD8 RID: 56536
				[Token(Token = "0x400DCD8")]
				[FieldOffset(Offset = "0x18")]
				public List<Act6FunPuzzleConfig.CharacterAction> characterActions;

				// Token: 0x0400DCD9 RID: 56537
				[Token(Token = "0x400DCD9")]
				[FieldOffset(Offset = "0x20")]
				public string branchId;
			}
		}
	}
}
