using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002620 RID: 9760
	[Token(Token = "0x2002620")]
	public class UnitManager
	{
		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x0600FF63 RID: 65379 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FF64 RID: 65380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022C2")]
		public UnorderedArray<Unit> allUnits
		{
			[Token(Token = "0x600FF63")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FF64")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x0600FF65 RID: 65381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FF66 RID: 65382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022C3")]
		public UnorderedArray<Unit> characters
		{
			[Token(Token = "0x600FF65")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FF66")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x0600FF67 RID: 65383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FF68 RID: 65384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022C4")]
		public UnorderedArray<Unit> enemies
		{
			[Token(Token = "0x600FF67")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FF68")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x0600FF69 RID: 65385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600FF6A RID: 65386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170022C5")]
		public UnorderedArray<Unit> neutralUnits
		{
			[Token(Token = "0x600FF69")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600FF6A")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x0600FF6B RID: 65387 RVA: 0x000610C8 File Offset: 0x0005F2C8
		[Token(Token = "0x170022C6")]
		public int enemyCnt
		{
			[Token(Token = "0x600FF6B")]
			[Address(RVA = "0x787C50", Offset = "0x786850", VA = "0x180787C50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x0600FF6C RID: 65388 RVA: 0x000610E0 File Offset: 0x0005F2E0
		[Token(Token = "0x170022C7")]
		public int characterCnt
		{
			[Token(Token = "0x600FF6C")]
			[Address(RVA = "0x787C10", Offset = "0x786810", VA = "0x180787C10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x0600FF6D RID: 65389 RVA: 0x000610F8 File Offset: 0x0005F2F8
		[Token(Token = "0x170022C8")]
		public int neutralCnt
		{
			[Token(Token = "0x600FF6D")]
			[Address(RVA = "0x787C90", Offset = "0x786890", VA = "0x180787C90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600FF6E RID: 65390 RVA: 0x00061110 File Offset: 0x0005F310
		[Token(Token = "0x600FF6E")]
		[Address(RVA = "0x786D60", Offset = "0x785960", VA = "0x180786D60")]
		public int GetPlayerCharacterCnt(PlayerSide playerSide = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600FF6F RID: 65391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF6F")]
		[Address(RVA = "0x787590", Offset = "0x786190", VA = "0x180787590")]
		public void SetPlayerCharacterCnt(int delta, PlayerSide side)
		{
		}

		// Token: 0x0600FF70 RID: 65392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF70")]
		[Address(RVA = "0x787A00", Offset = "0x786600", VA = "0x180787A00")]
		public UnitManager(int capacity, List<PlayerSide> activePlayers)
		{
		}

		// Token: 0x0600FF71 RID: 65393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF71")]
		[Address(RVA = "0x787440", Offset = "0x786040", VA = "0x180787440")]
		public void Register(Unit unit)
		{
		}

		// Token: 0x0600FF72 RID: 65394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FF72")]
		[Address(RVA = "0x7878E0", Offset = "0x7864E0", VA = "0x1807878E0")]
		public void Unregister(Unit unit)
		{
		}

		// Token: 0x0600FF73 RID: 65395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF73")]
		[Address(RVA = "0x786E00", Offset = "0x785A00", VA = "0x180786E00")]
		public UnorderedArray<Unit> GetUnitsBySingleSide(SideType sidePower2)
		{
			return null;
		}

		// Token: 0x0600FF74 RID: 65396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF74")]
		[Address(RVA = "0x786720", Offset = "0x785320", VA = "0x180786720")]
		public Character GetCharacterById(string id)
		{
			return null;
		}

		// Token: 0x0600FF75 RID: 65397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF75")]
		[Address(RVA = "0x786BF0", Offset = "0x7857F0", VA = "0x180786BF0")]
		public Character GetFirstCharacterByUid(uint uniqueId)
		{
			return null;
		}

		// Token: 0x0600FF76 RID: 65398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF76")]
		[Address(RVA = "0x786A90", Offset = "0x785690", VA = "0x180786A90")]
		public Character GetFirstCharacterByInstanceUid(uint instanceUid)
		{
			return null;
		}

		// Token: 0x0600FF77 RID: 65399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF77")]
		[Address(RVA = "0x786890", Offset = "0x785490", VA = "0x180786890")]
		public ReusableList<Entity> GetCharactersByCardUid_DISPOSE(uint cardUid)
		{
			return null;
		}

		// Token: 0x0600FF78 RID: 65400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600FF78")]
		[Address(RVA = "0x7865A0", Offset = "0x7851A0", VA = "0x1807865A0")]
		public Character GetCharacterByAlias(string alias)
		{
			return null;
		}

		// Token: 0x0600FF79 RID: 65401 RVA: 0x00061128 File Offset: 0x0005F328
		[Token(Token = "0x600FF79")]
		[Address(RVA = "0x787690", Offset = "0x786290", VA = "0x180787690")]
		public bool TryGetCharacterById(string id, out Character character)
		{
			return default(bool);
		}

		// Token: 0x0600FF7A RID: 65402 RVA: 0x00061140 File Offset: 0x0005F340
		[Token(Token = "0x600FF7A")]
		[Address(RVA = "0x787850", Offset = "0x786450", VA = "0x180787850")]
		public bool TryGetCharacterByUid(uint uniqueId, out Character character)
		{
			return default(bool);
		}

		// Token: 0x04011BCA RID: 72650
		[Token(Token = "0x4011BCA")]
		[FieldOffset(Offset = "0x30")]
		private readonly ListDict<PlayerSide, int> m_activePlayerCharacterCnt;
	}
}
