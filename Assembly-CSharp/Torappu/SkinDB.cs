using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005D7 RID: 1495
	[Token(Token = "0x20005D7")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/SkinTable")]
	[Serializable]
	public class SkinDB : ConstTable<SkinTable, SkinDB>
	{
		// Token: 0x06006187 RID: 24967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006187")]
		[Address(RVA = "0x1DF52F0", Offset = "0x1DF3EF0", VA = "0x181DF52F0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x0002FC70 File Offset: 0x0002DE70
		[Token(Token = "0x6006188")]
		[Address(RVA = "0x1DF5D80", Offset = "0x1DF4980", VA = "0x181DF5D80")]
		public bool TryGetSkinListByCharId(string charId, out List<string> skinList)
		{
			return default(bool);
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x0002FC88 File Offset: 0x0002DE88
		[Token(Token = "0x6006189")]
		[Address(RVA = "0x1DF5840", Offset = "0x1DF4440", VA = "0x181DF5840")]
		public bool TryGetCharSkin(string skinId, out CharSkinData skin)
		{
			return default(bool);
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
		[Token(Token = "0x600618A")]
		[Address(RVA = "0x1DF4A60", Offset = "0x1DF3660", VA = "0x181DF4A60")]
		public bool ContainsCharSkin(string skinId)
		{
			return default(bool);
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x0002FCB8 File Offset: 0x0002DEB8
		[Token(Token = "0x600618B")]
		[Address(RVA = "0x1DF6380", Offset = "0x1DF4F80", VA = "0x181DF6380")]
		public static bool TryPickBestBuildinSkinId(CharQuery charQuery, EvolvePhase evolvePhase, out string skinId)
		{
			return default(bool);
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x0002FCD0 File Offset: 0x0002DED0
		[Token(Token = "0x600618C")]
		[Address(RVA = "0x1DF6F60", Offset = "0x1DF5B60", VA = "0x181DF6F60")]
		private static bool _TryPickPatchSkin(string charId, string tmplId, out string skinId)
		{
			return default(bool);
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x0002FCE8 File Offset: 0x0002DEE8
		[Token(Token = "0x600618D")]
		[Address(RVA = "0x1DF5960", Offset = "0x1DF4560", VA = "0x181DF5960")]
		public static bool TryGetEvolveSkin(string charId, EvolvePhase evolvePhase, out string skinId)
		{
			return default(bool);
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x0002FD00 File Offset: 0x0002DF00
		[Token(Token = "0x600618E")]
		[Address(RVA = "0x1DF5AD0", Offset = "0x1DF46D0", VA = "0x181DF5AD0")]
		public static bool TryGetNPCSkin(string npcId, out string skinId)
		{
			return default(bool);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600618F")]
		[Address(RVA = "0x1DF4D20", Offset = "0x1DF3920", VA = "0x181DF4D20")]
		public static ListSet<string> GetSelectableSkinsWithPatch(PlayerCharacter playerChar)
		{
			return null;
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x0002FD18 File Offset: 0x0002DF18
		[Token(Token = "0x6006190")]
		[Address(RVA = "0x1DF5C80", Offset = "0x1DF4880", VA = "0x181DF5C80")]
		public static bool TryGetSkinIdFromUniqueSkinTag(string skinTag, out string skinId)
		{
			return default(bool);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x0002FD30 File Offset: 0x0002DF30
		[Token(Token = "0x6006191")]
		[Address(RVA = "0x1DF5E80", Offset = "0x1DF4A80", VA = "0x181DF5E80")]
		public static bool TryGetSkinStructFromUniqueSkinTag(string skinTag, out CharUISkinStruct skinStruct)
		{
			return default(bool);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x0002FD48 File Offset: 0x0002DF48
		[Token(Token = "0x6006192")]
		[Address(RVA = "0x1DF6160", Offset = "0x1DF4D60", VA = "0x181DF6160")]
		public static bool TryGetSkinTagFromSkinStruct(CharUISkinStruct skinStruct, out string skinTag)
		{
			return default(bool);
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006193")]
		[Address(RVA = "0x1DF4940", Offset = "0x1DF3540", VA = "0x181DF4940")]
		public static void AuditOnlyHookBasicSkin(ref CharQuery charQuery, ref string illustId)
		{
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006194")]
		[Address(RVA = "0x1DF6780", Offset = "0x1DF5380", VA = "0x181DF6780")]
		private static void _FlushSkinsToDefault(SkinTable skinTable)
		{
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006195")]
		[Address(RVA = "0x1DF6DC0", Offset = "0x1DF59C0", VA = "0x181DF6DC0")]
		private static string _RevertToDefaultIfNecessary(string charId, string skinId, SkinTable skinTable)
		{
			return null;
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x0002FD60 File Offset: 0x0002DF60
		[Token(Token = "0x6006196")]
		[Address(RVA = "0x1DF6710", Offset = "0x1DF5310", VA = "0x181DF6710")]
		private static bool _CheckIfBasicThinMode()
		{
			return default(bool);
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006197")]
		[Address(RVA = "0x1DF4B40", Offset = "0x1DF3740", VA = "0x181DF4B40")]
		public static List<CharSkinData> EditorGetAllNonDefaultSkinList()
		{
			return null;
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006198")]
		[Address(RVA = "0x1DF72E0", Offset = "0x1DF5EE0", VA = "0x181DF72E0")]
		public SkinDB()
		{
		}

		// Token: 0x04002B2D RID: 11053
		[Token(Token = "0x4002B2D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly HashSet<string> BASIC_CHAR_ARTS;

		// Token: 0x04002B2E RID: 11054
		[Token(Token = "0x4002B2E")]
		public const string BASIC_ILLUST_CHAR = "char_502_nblade";

		// Token: 0x04002B2F RID: 11055
		[Token(Token = "0x4002B2F")]
		public const string BASIC_ILLUST_ID = "illust_char_502_nblade_1";

		// Token: 0x04002B30 RID: 11056
		[Token(Token = "0x4002B30")]
		[FieldOffset(Offset = "0x8")]
		[NonSerialized]
		private static ListSet<string> s_sharedSet;

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<string, List<string>> m_charIdSkinMap;

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetSkinListByCharId;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryGetCharSkin;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ContainsCharSkin;

		// Token: 0x04002B36 RID: 11062
		[Token(Token = "0x4002B36")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryPickBestBuildinSkinId;

		// Token: 0x04002B37 RID: 11063
		[Token(Token = "0x4002B37")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryPickPatchSkin;

		// Token: 0x04002B38 RID: 11064
		[Token(Token = "0x4002B38")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetEvolveSkin;

		// Token: 0x04002B39 RID: 11065
		[Token(Token = "0x4002B39")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryGetNPCSkin;

		// Token: 0x04002B3A RID: 11066
		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetSelectableSkinsWithPatch;

		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetSkinIdFromUniqueSkinTag;

		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetSkinStructFromUniqueSkinTag;

		// Token: 0x04002B3D RID: 11069
		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGetSkinTagFromSkinStruct;

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_AuditOnlyHookBasicSkin;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FlushSkinsToDefault;

		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RevertToDefaultIfNecessary;

		// Token: 0x04002B41 RID: 11073
		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckIfBasicThinMode;

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EditorGetAllNonDefaultSkinList;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
