using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F05 RID: 24325
	[Token(Token = "0x2005F05")]
	public class CharacterInfoHomeBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x060233F2 RID: 144370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F2")]
		[Address(RVA = "0x1DC1B30", Offset = "0x1DC0730", VA = "0x181DC1B30")]
		public void LoadData(int charInstIdParam)
		{
		}

		// Token: 0x060233F3 RID: 144371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F3")]
		[Address(RVA = "0x1DC1A70", Offset = "0x1DC0670", VA = "0x181DC1A70")]
		public void ClearData()
		{
		}

		// Token: 0x060233F4 RID: 144372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233F4")]
		[Address(RVA = "0x1DC2060", Offset = "0x1DC0C60", VA = "0x181DC2060")]
		public CharacterInfoHomeBean()
		{
		}

		// Token: 0x040308FA RID: 198906
		[Token(Token = "0x40308FA")]
		[FieldOffset(Offset = "0x18")]
		public CharacterProfileViewProperty profileProperty;

		// Token: 0x040308FB RID: 198907
		[Token(Token = "0x40308FB")]
		[FieldOffset(Offset = "0x20")]
		public AttributeViewProperty attributeProperty;

		// Token: 0x040308FC RID: 198908
		[Token(Token = "0x40308FC")]
		[FieldOffset(Offset = "0x28")]
		public SkillGroupViewProperty skillProperty;

		// Token: 0x040308FD RID: 198909
		[Token(Token = "0x40308FD")]
		[FieldOffset(Offset = "0x30")]
		public BattleInfoViewProperty battleProperty;

		// Token: 0x040308FE RID: 198910
		[Token(Token = "0x40308FE")]
		[FieldOffset(Offset = "0x38")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x040308FF RID: 198911
		[Token(Token = "0x40308FF")]
		[FieldOffset(Offset = "0x40")]
		public BoolProperty isCharacterLocked;

		// Token: 0x04030900 RID: 198912
		[Token(Token = "0x4030900")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public int charInstId;

		// Token: 0x04030901 RID: 198913
		[Token(Token = "0x4030901")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public string charId;

		// Token: 0x04030902 RID: 198914
		[Token(Token = "0x4030902")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public bool isReachMaxEvolve;

		// Token: 0x04030903 RID: 198915
		[Token(Token = "0x4030903")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030904 RID: 198916
		[Token(Token = "0x4030904")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ClearData;

		// Token: 0x04030905 RID: 198917
		[Token(Token = "0x4030905")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
