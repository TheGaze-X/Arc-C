using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.CharacterCommon;
using UnityEngine;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005EFC RID: 24316
	[Token(Token = "0x2005EFC")]
	public class CharacterDetailViewModel : MonoBehaviour, IDataBindWrapper
	{
		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x060233B1 RID: 144305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005350")]
		public string charName
		{
			[Token(Token = "0x60233B1")]
			[Address(RVA = "0x1DBECD0", Offset = "0x1DBD8D0", VA = "0x181DBECD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060233B2 RID: 144306 RVA: 0x000C02B8 File Offset: 0x000BE4B8
		[Token(Token = "0x60233B2")]
		[Address(RVA = "0x1DBE4B0", Offset = "0x1DBD0B0", VA = "0x181DBE4B0")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x060233B3 RID: 144307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233B3")]
		[Address(RVA = "0x1DBE500", Offset = "0x1DBD100", VA = "0x181DBE500")]
		public void LoadData(int charInstIdParam, bool autoActivateIllust)
		{
		}

		// Token: 0x060233B4 RID: 144308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233B4")]
		[Address(RVA = "0x1DBE430", Offset = "0x1DBD030", VA = "0x181DBE430")]
		public void ClearData()
		{
		}

		// Token: 0x060233B5 RID: 144309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60233B5")]
		[Address(RVA = "0x1DBEAB0", Offset = "0x1DBD6B0", VA = "0x181DBEAB0")]
		public CharacterDetailViewModel()
		{
		}

		// Token: 0x040308AE RID: 198830
		[Token(Token = "0x40308AE")]
		[FieldOffset(Offset = "0x18")]
		public AttributeViewProperty attributeProperty;

		// Token: 0x040308AF RID: 198831
		[Token(Token = "0x40308AF")]
		[FieldOffset(Offset = "0x20")]
		public CharacterProfileViewProperty profileProperty;

		// Token: 0x040308B0 RID: 198832
		[Token(Token = "0x40308B0")]
		[FieldOffset(Offset = "0x28")]
		public SkillGroupViewProperty skillProperty;

		// Token: 0x040308B1 RID: 198833
		[Token(Token = "0x40308B1")]
		[FieldOffset(Offset = "0x30")]
		public BattleInfoViewProperty battleProperty;

		// Token: 0x040308B2 RID: 198834
		[Token(Token = "0x40308B2")]
		[FieldOffset(Offset = "0x38")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x040308B3 RID: 198835
		[Token(Token = "0x40308B3")]
		[FieldOffset(Offset = "0x40")]
		public SpCharInfoViewProperty spCharInfoProperty;

		// Token: 0x040308B4 RID: 198836
		[Token(Token = "0x40308B4")]
		[FieldOffset(Offset = "0x48")]
		public BoolProperty isCharacterLocked;

		// Token: 0x040308B5 RID: 198837
		[Token(Token = "0x40308B5")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public int charInstId;

		// Token: 0x040308B6 RID: 198838
		[Token(Token = "0x40308B6")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public string charId;

		// Token: 0x040308B7 RID: 198839
		[Token(Token = "0x40308B7")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public string tmplId;

		// Token: 0x040308B8 RID: 198840
		[Token(Token = "0x40308B8")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public bool isReachMaxEvolve;

		// Token: 0x040308B9 RID: 198841
		[Token(Token = "0x40308B9")]
		[FieldOffset(Offset = "0x6C")]
		[NonSerialized]
		public EvolvePhase evolvePhase;

		// Token: 0x040308BA RID: 198842
		[Token(Token = "0x40308BA")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public CharacterData charDataCache;

		// Token: 0x040308BB RID: 198843
		[Token(Token = "0x40308BB")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public bool isStarMarked;
	}
}
