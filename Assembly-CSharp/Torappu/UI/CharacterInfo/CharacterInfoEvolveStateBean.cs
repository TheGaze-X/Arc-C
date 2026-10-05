using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F0F RID: 24335
	[Token(Token = "0x2005F0F")]
	public class CharacterInfoEvolveStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x0602340D RID: 144397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602340D")]
		[Address(RVA = "0x1DC0440", Offset = "0x1DBF040", VA = "0x181DC0440")]
		public void LoadData(int charInstId)
		{
		}

		// Token: 0x0602340E RID: 144398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602340E")]
		[Address(RVA = "0x1DC0A70", Offset = "0x1DBF670", VA = "0x181DC0A70")]
		private static RequireViewModel[] _ParseEvolveRequirements(PlayerCharacter playerChar, CharacterData charData)
		{
			return null;
		}

		// Token: 0x0602340F RID: 144399 RVA: 0x000C03F0 File Offset: 0x000BE5F0
		[Token(Token = "0x602340F")]
		[Address(RVA = "0x1DC0320", Offset = "0x1DBEF20", VA = "0x181DC0320")]
		public bool IsAllRequiresSatisfied()
		{
			return default(bool);
		}

		// Token: 0x06023410 RID: 144400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023410")]
		[Address(RVA = "0x1DBFD20", Offset = "0x1DBE920", VA = "0x181DBFD20")]
		public string CheckEvolveRequirements()
		{
			return null;
		}

		// Token: 0x06023411 RID: 144401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023411")]
		[Address(RVA = "0x1DC10A0", Offset = "0x1DBFCA0", VA = "0x181DC10A0")]
		public CharacterInfoEvolveStateBean()
		{
		}

		// Token: 0x04030955 RID: 198997
		[Token(Token = "0x4030955")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public int chrInstId;

		// Token: 0x04030956 RID: 198998
		[Token(Token = "0x4030956")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string chrRealName;

		// Token: 0x04030957 RID: 198999
		[Token(Token = "0x4030957")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public string charId;

		// Token: 0x04030958 RID: 199000
		[Token(Token = "0x4030958")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public string tmplId;

		// Token: 0x04030959 RID: 199001
		[Token(Token = "0x4030959")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public EvolveAttributeViewModel evolveAttrs;

		// Token: 0x0403095A RID: 199002
		[Token(Token = "0x403095A")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public RequireViewModel[] evolveRequires;

		// Token: 0x0403095B RID: 199003
		[Token(Token = "0x403095B")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public string oldIllustId;

		// Token: 0x0403095C RID: 199004
		[Token(Token = "0x403095C")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public CharUISkinStruct oldSkinStruct;

		// Token: 0x0403095D RID: 199005
		[Token(Token = "0x403095D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public string newIllustId;

		// Token: 0x0403095E RID: 199006
		[Token(Token = "0x403095E")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public CharUISkinStruct newSkinStruct;

		// Token: 0x0403095F RID: 199007
		[Token(Token = "0x403095F")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public bool afterEvolveFlag;

		// Token: 0x04030960 RID: 199008
		[Token(Token = "0x4030960")]
		[FieldOffset(Offset = "0x8C")]
		[NonSerialized]
		public EvolvePhase evolvePhase;

		// Token: 0x04030961 RID: 199009
		[Token(Token = "0x4030961")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public PlayerCharacter cachePlayerData;

		// Token: 0x04030962 RID: 199010
		[Token(Token = "0x4030962")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public CharacterInfoEvolveInfoViewModel evolveInfoViewModel;

		// Token: 0x04030963 RID: 199011
		[Token(Token = "0x4030963")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public SpecialOperatorInfoViewModel spOpModel;

		// Token: 0x04030964 RID: 199012
		[Token(Token = "0x4030964")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030965 RID: 199013
		[Token(Token = "0x4030965")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ParseEvolveRequirements;

		// Token: 0x04030966 RID: 199014
		[Token(Token = "0x4030966")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsAllRequiresSatisfied;

		// Token: 0x04030967 RID: 199015
		[Token(Token = "0x4030967")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckEvolveRequirements;

		// Token: 0x04030968 RID: 199016
		[Token(Token = "0x4030968")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
