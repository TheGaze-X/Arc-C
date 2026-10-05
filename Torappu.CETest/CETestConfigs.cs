using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.CETest
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[CreateAssetMenu(fileName = "CETestConfigs", menuName = "Torappu/CETest/Create New Version CETestConfig", order = 0)]
	public sealed class CETestConfigs : ScriptableObject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public string luaRootPath
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public string luaHotfixRootPath
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002054 File Offset: 0x00000254
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x54D5180", Offset = "0x54D3D80", VA = "0x1854D5180")]
		public bool TryParseUIData(out CETestDataType ret)
		{
			return default(bool);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x54D4FC0", Offset = "0x54D3BC0", VA = "0x1854D4FC0")]
		public bool TryGetLevelAndSquad(string levelId, string squadId, out TextAsset levelAsset, out TextAsset squadAsset)
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public CETestConfigs()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _version;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CETestConfigs.ConfigUnit[] _levels;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _luaRootPath;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CETestConfigs.SquadConfigUnit[] _squads;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private CETestConfigs.ConfigLevelPair[] _levelSquadPairs;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _luaHotfixRootPath;

		// Token: 0x02000003 RID: 3
		[Token(Token = "0x2000003")]
		[Serializable]
		public class ConfigUnit
		{
			// Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConfigUnit()
			{
			}

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			[FieldOffset(Offset = "0x20")]
			public TextAsset json;
		}

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		[Serializable]
		public class CharacterGroup
		{
			// Token: 0x06000007 RID: 7 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x54DA9E0", Offset = "0x54D95E0", VA = "0x1854DA9E0")]
			public CharacterGroup()
			{
			}

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public List<string> group;
		}

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		[Serializable]
		public class SquadConfigUnit : CETestConfigs.ConfigUnit
		{
			// Token: 0x06000008 RID: 8 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SquadConfigUnit()
			{
			}

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x28")]
			public bool isAlways;

			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x29")]
			public bool isGroupedExclude;

			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public List<CETestConfigs.CharacterGroup> groups;
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		[Serializable]
		public class ConfigLevelPair
		{
			// Token: 0x06000009 RID: 9 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConfigLevelPair()
			{
			}

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			public string levelId;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x18")]
			public string[] squadIds;
		}
	}
}
