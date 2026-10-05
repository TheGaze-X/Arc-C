using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F22 RID: 24354
	[Token(Token = "0x2005F22")]
	public class CharacterInfoSelectSkillBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x1700536E RID: 21358
		// (get) Token: 0x06023470 RID: 144496 RVA: 0x000C0750 File Offset: 0x000BE950
		[Token(Token = "0x1700536E")]
		public int specialLvlUpTime
		{
			[Token(Token = "0x6023470")]
			[Address(RVA = "0x1DC4A90", Offset = "0x1DC3690", VA = "0x181DC4A90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x06023471 RID: 144497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700536F")]
		public RequireViewModel[] requireSpecialItem
		{
			[Token(Token = "0x6023471")]
			[Address(RVA = "0x1DC4A30", Offset = "0x1DC3630", VA = "0x181DC4A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005370 RID: 21360
		// (get) Token: 0x06023472 RID: 144498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005370")]
		public RequireViewModel[] requireItem
		{
			[Token(Token = "0x6023472")]
			[Address(RVA = "0x1DC49D0", Offset = "0x1DC35D0", VA = "0x181DC49D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023473 RID: 144499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023473")]
		[Address(RVA = "0x1DC33B0", Offset = "0x1DC1FB0", VA = "0x181DC33B0")]
		public string CheckAllSKillRequirements()
		{
			return null;
		}

		// Token: 0x06023474 RID: 144500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023474")]
		[Address(RVA = "0x1DC3410", Offset = "0x1DC2010", VA = "0x181DC3410")]
		public string CheckSpecializedSKillRequirements()
		{
			return null;
		}

		// Token: 0x06023475 RID: 144501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023475")]
		[Address(RVA = "0x1DC3470", Offset = "0x1DC2070", VA = "0x181DC3470")]
		public void RefreshAllData()
		{
		}

		// Token: 0x06023476 RID: 144502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023476")]
		[Address(RVA = "0x1DC34D0", Offset = "0x1DC20D0", VA = "0x181DC34D0")]
		public void RefreshSpecialData()
		{
		}

		// Token: 0x06023477 RID: 144503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023477")]
		[Address(RVA = "0x1DC3530", Offset = "0x1DC2130", VA = "0x181DC3530")]
		private string _CheckRequireViewModels(IList<RequireViewModel> models)
		{
			return null;
		}

		// Token: 0x06023478 RID: 144504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023478")]
		[Address(RVA = "0x1DC3890", Offset = "0x1DC2490", VA = "0x181DC3890")]
		private void _LoadAllLvlUpData()
		{
		}

		// Token: 0x06023479 RID: 144505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023479")]
		[Address(RVA = "0x1DC3C30", Offset = "0x1DC2830", VA = "0x181DC3C30")]
		private void _LoadSpecialLvlUpData()
		{
		}

		// Token: 0x0602347A RID: 144506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602347A")]
		[Address(RVA = "0x1DC3F50", Offset = "0x1DC2B50", VA = "0x181DC3F50")]
		private RequireViewModel[] _ParseSkillAllLvlUpRequirements(PlayerCharacter playerChar, CharacterData charData)
		{
			return null;
		}

		// Token: 0x0602347B RID: 144507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602347B")]
		[Address(RVA = "0x1DC4450", Offset = "0x1DC3050", VA = "0x181DC4450")]
		private RequireViewModel[] _ParseSkillSpecialLvlUpRequirements(PlayerCharacter playerChar, CharacterData charData, int skillIndex)
		{
			return null;
		}

		// Token: 0x0602347C RID: 144508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602347C")]
		[Address(RVA = "0x1DC48F0", Offset = "0x1DC34F0", VA = "0x181DC48F0")]
		public CharacterInfoSelectSkillBean()
		{
		}

		// Token: 0x04030A1C RID: 199196
		[Token(Token = "0x4030A1C")]
		[FieldOffset(Offset = "0x18")]
		public SkillGroupViewProperty skillProperty;

		// Token: 0x04030A1D RID: 199197
		[Token(Token = "0x4030A1D")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int charInstId;

		// Token: 0x04030A1E RID: 199198
		[Token(Token = "0x4030A1E")]
		[FieldOffset(Offset = "0x24")]
		[NonSerialized]
		public int skillIndex;

		// Token: 0x04030A1F RID: 199199
		[Token(Token = "0x4030A1F")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int targetSkillLevel;

		// Token: 0x04030A20 RID: 199200
		[Token(Token = "0x4030A20")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		public int targetSpecialLevel;

		// Token: 0x04030A21 RID: 199201
		[Token(Token = "0x4030A21")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public SpecialOperatorInfoViewModel spOpModel;

		// Token: 0x04030A22 RID: 199202
		[Token(Token = "0x4030A22")]
		[FieldOffset(Offset = "0x38")]
		private RequireViewModel[] m_cacheViewModel;

		// Token: 0x04030A23 RID: 199203
		[Token(Token = "0x4030A23")]
		[FieldOffset(Offset = "0x40")]
		private RequireViewModel[] m_cacheSpecialViewModel;

		// Token: 0x04030A24 RID: 199204
		[Token(Token = "0x4030A24")]
		[FieldOffset(Offset = "0x48")]
		private int m_specialLvlUpTime;

		// Token: 0x04030A25 RID: 199205
		[Token(Token = "0x4030A25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_specialLvlUpTime;

		// Token: 0x04030A26 RID: 199206
		[Token(Token = "0x4030A26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_requireSpecialItem;

		// Token: 0x04030A27 RID: 199207
		[Token(Token = "0x4030A27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_requireItem;

		// Token: 0x04030A28 RID: 199208
		[Token(Token = "0x4030A28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckAllSKillRequirements;

		// Token: 0x04030A29 RID: 199209
		[Token(Token = "0x4030A29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckSpecializedSKillRequirements;

		// Token: 0x04030A2A RID: 199210
		[Token(Token = "0x4030A2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshAllData;

		// Token: 0x04030A2B RID: 199211
		[Token(Token = "0x4030A2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshSpecialData;

		// Token: 0x04030A2C RID: 199212
		[Token(Token = "0x4030A2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckRequireViewModels;

		// Token: 0x04030A2D RID: 199213
		[Token(Token = "0x4030A2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadAllLvlUpData;

		// Token: 0x04030A2E RID: 199214
		[Token(Token = "0x4030A2E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadSpecialLvlUpData;

		// Token: 0x04030A2F RID: 199215
		[Token(Token = "0x4030A2F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ParseSkillAllLvlUpRequirements;

		// Token: 0x04030A30 RID: 199216
		[Token(Token = "0x4030A30")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ParseSkillSpecialLvlUpRequirements;

		// Token: 0x04030A31 RID: 199217
		[Token(Token = "0x4030A31")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
