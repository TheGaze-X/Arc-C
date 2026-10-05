using System;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x020017E9 RID: 6121
	[Token(Token = "0x20017E9")]
	[CreateAssetMenu(menuName = "Torappu/Building/PrefabMaker")]
	public class BuildingPrefabMaker : ScriptableObject
	{
		// Token: 0x06009AB4 RID: 39604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009AB4")]
		[Address(RVA = "0x315D2A0", Offset = "0x315BEA0", VA = "0x18315D2A0")]
		public BuildingPrefabMaker()
		{
		}

		// Token: 0x040090FB RID: 37115
		[Token(Token = "0x40090FB")]
		private const string VCHARACTER_PATH = "TORAPPU_VAULT_CHARACTER_PATH";

		// Token: 0x040090FC RID: 37116
		[Token(Token = "0x40090FC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] FILTER_SEPARATORS;

		// Token: 0x040090FD RID: 37117
		[Token(Token = "0x40090FD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] REQUIRED_ANIMATIONS;

		// Token: 0x040090FE RID: 37118
		[Token(Token = "0x40090FE")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string[] WARNING_ANIMATIONS;

		// Token: 0x040090FF RID: 37119
		[Token(Token = "0x40090FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _outputFolder;

		// Token: 0x04009100 RID: 37120
		[Token(Token = "0x4009100")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _spineFolder;

		// Token: 0x04009101 RID: 37121
		[Token(Token = "0x4009101")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VCharacter _characterProto;

		// Token: 0x04009102 RID: 37122
		[Token(Token = "0x4009102")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextAsset _characterSpecJson;

		// Token: 0x04009103 RID: 37123
		[Token(Token = "0x4009103")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterDB _charDB;

		// Token: 0x04009104 RID: 37124
		[Token(Token = "0x4009104")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharPatchDB _charPatchDB;

		// Token: 0x04009105 RID: 37125
		[Token(Token = "0x4009105")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _charFilter;

		// Token: 0x020017EA RID: 6122
		[Token(Token = "0x20017EA")]
		public class CharacterSpecEntry
		{
			// Token: 0x06009AB6 RID: 39606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009AB6")]
			[Address(RVA = "0x315EEE0", Offset = "0x315DAE0", VA = "0x18315EEE0")]
			public CharacterSpecEntry()
			{
			}

			// Token: 0x04009106 RID: 37126
			[Token(Token = "0x4009106")]
			[FieldOffset(Offset = "0x10")]
			public float buildingSpineScale;

			// Token: 0x04009107 RID: 37127
			[Token(Token = "0x4009107")]
			[FieldOffset(Offset = "0x14")]
			public float battleSpineScale;

			// Token: 0x04009108 RID: 37128
			[Token(Token = "0x4009108")]
			[FieldOffset(Offset = "0x18")]
			public float moveSpeed;
		}
	}
}
