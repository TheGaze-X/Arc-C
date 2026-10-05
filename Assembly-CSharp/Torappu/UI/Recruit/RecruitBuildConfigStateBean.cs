using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200470A RID: 18186
	[Token(Token = "0x200470A")]
	public class RecruitBuildConfigStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x170041A6 RID: 16806
		// (get) Token: 0x0601B924 RID: 112932 RVA: 0x000A5870 File Offset: 0x000A3A70
		// (set) Token: 0x0601B925 RID: 112933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170041A6")]
		public int editingSlotIndex
		{
			[Token(Token = "0x601B924")]
			[Address(RVA = "0x14DD050", Offset = "0x14DBC50", VA = "0x1814DD050")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601B925")]
			[Address(RVA = "0x14DD0B0", Offset = "0x14DBCB0", VA = "0x1814DD0B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601B926 RID: 112934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B926")]
		[Address(RVA = "0x14DC3B0", Offset = "0x14DAFB0", VA = "0x1814DC3B0")]
		public void SetData(int slotIndex)
		{
		}

		// Token: 0x0601B927 RID: 112935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B927")]
		[Address(RVA = "0x14DBF30", Offset = "0x14DAB30", VA = "0x1814DBF30")]
		public void ModifyTime(long deltaTime)
		{
		}

		// Token: 0x0601B928 RID: 112936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B928")]
		[Address(RVA = "0x14DC9D0", Offset = "0x14DB5D0", VA = "0x1814DC9D0")]
		public void TryToggleTag(int tagIndex)
		{
		}

		// Token: 0x0601B929 RID: 112937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B929")]
		[Address(RVA = "0x14DC140", Offset = "0x14DAD40", VA = "0x1814DC140")]
		public NormalGachaRequest ParseNormalGachaRequest()
		{
			return null;
		}

		// Token: 0x0601B92A RID: 112938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B92A")]
		[Address(RVA = "0x14DBAC0", Offset = "0x14DA6C0", VA = "0x1814DBAC0")]
		public string CheckResourceToBuild()
		{
			return null;
		}

		// Token: 0x0601B92B RID: 112939 RVA: 0x000A5888 File Offset: 0x000A3A88
		[Token(Token = "0x601B92B")]
		[Address(RVA = "0x14DBE50", Offset = "0x14DAA50", VA = "0x1814DBE50")]
		public bool HasSpecialTag()
		{
			return default(bool);
		}

		// Token: 0x0601B92C RID: 112940 RVA: 0x000A58A0 File Offset: 0x000A3AA0
		[Token(Token = "0x601B92C")]
		[Address(RVA = "0x14DB850", Offset = "0x14DA450", VA = "0x1814DB850")]
		public bool CheckNeedSpecialTagWarning(out string warningText)
		{
			return default(bool);
		}

		// Token: 0x0601B92D RID: 112941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B92D")]
		[Address(RVA = "0x14DCCB0", Offset = "0x14DB8B0", VA = "0x1814DCCB0")]
		private void _UpdateCost()
		{
		}

		// Token: 0x0601B92E RID: 112942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B92E")]
		[Address(RVA = "0x14DCE70", Offset = "0x14DBA70", VA = "0x1814DCE70")]
		public RecruitBuildConfigStateBean()
		{
		}

		// Token: 0x04023B52 RID: 146258
		[Token(Token = "0x4023B52")]
		private const long MAX_BUILD_TIME = 32400000L;

		// Token: 0x04023B53 RID: 146259
		[Token(Token = "0x4023B53")]
		private const long DEFAULT_BUILD_TIME = 3600000L;

		// Token: 0x04023B54 RID: 146260
		[Token(Token = "0x4023B54")]
		public const long MIN_BUILD_TIME = 3600000L;

		// Token: 0x04023B55 RID: 146261
		[Token(Token = "0x4023B55")]
		private const int MAX_TAG_SELECT_NUM = 3;

		// Token: 0x04023B56 RID: 146262
		[Token(Token = "0x4023B56")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildConfigTagGroupViewProperty _tagGroupProperty;

		// Token: 0x04023B57 RID: 146263
		[Token(Token = "0x4023B57")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildConfigTimeViewProperty _timeProperty;

		// Token: 0x04023B58 RID: 146264
		[Token(Token = "0x4023B58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildConfigCostViewProperty _costProperty;

		// Token: 0x04023B59 RID: 146265
		[Token(Token = "0x4023B59")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildConfigRarityProperty _rarityProperty;

		// Token: 0x04023B5A RID: 146266
		[Token(Token = "0x4023B5A")]
		[FieldOffset(Offset = "0x38")]
		public bool isConfirmed;

		// Token: 0x04023B5C RID: 146268
		[Token(Token = "0x4023B5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_editingSlotIndex;

		// Token: 0x04023B5D RID: 146269
		[Token(Token = "0x4023B5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_editingSlotIndex;

		// Token: 0x04023B5E RID: 146270
		[Token(Token = "0x4023B5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04023B5F RID: 146271
		[Token(Token = "0x4023B5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ModifyTime;

		// Token: 0x04023B60 RID: 146272
		[Token(Token = "0x4023B60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryToggleTag;

		// Token: 0x04023B61 RID: 146273
		[Token(Token = "0x4023B61")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ParseNormalGachaRequest;

		// Token: 0x04023B62 RID: 146274
		[Token(Token = "0x4023B62")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckResourceToBuild;

		// Token: 0x04023B63 RID: 146275
		[Token(Token = "0x4023B63")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HasSpecialTag;

		// Token: 0x04023B64 RID: 146276
		[Token(Token = "0x4023B64")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckNeedSpecialTagWarning;

		// Token: 0x04023B65 RID: 146277
		[Token(Token = "0x4023B65")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateCost;

		// Token: 0x04023B66 RID: 146278
		[Token(Token = "0x4023B66")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
