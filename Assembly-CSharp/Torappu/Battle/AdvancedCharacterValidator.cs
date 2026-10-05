using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002578 RID: 9592
	[Token(Token = "0x2002578")]
	public class AdvancedCharacterValidator : TargetValidator
	{
		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x0600F78F RID: 63375 RVA: 0x0005C820 File Offset: 0x0005AA20
		[Token(Token = "0x17002082")]
		protected bool checkDeployPosition
		{
			[Token(Token = "0x600F78F")]
			[Address(RVA = "0x6EF370", Offset = "0x6EDF70", VA = "0x1806EF370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F790 RID: 63376 RVA: 0x0005C838 File Offset: 0x0005AA38
		[Token(Token = "0x600F790")]
		[Address(RVA = "0x6EEA90", Offset = "0x6ED690", VA = "0x1806EEA90", Slot = "5")]
		public override bool Validate(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x0005C850 File Offset: 0x0005AA50
		[Token(Token = "0x600F791")]
		[Address(RVA = "0x6EEFF0", Offset = "0x6EDBF0", VA = "0x1806EEFF0")]
		private bool _BuildableValidate(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x0005C868 File Offset: 0x0005AA68
		[Token(Token = "0x600F792")]
		[Address(RVA = "0x6EF090", Offset = "0x6EDC90", VA = "0x1806EF090")]
		private bool _DeployValidate(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600F793 RID: 63379 RVA: 0x0005C880 File Offset: 0x0005AA80
		[Token(Token = "0x600F793")]
		[Address(RVA = "0x6EF140", Offset = "0x6EDD40", VA = "0x1806EF140")]
		private bool _RarityValidate(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600F794 RID: 63380 RVA: 0x0005C898 File Offset: 0x0005AA98
		[Token(Token = "0x600F794")]
		[Address(RVA = "0x6EF1E0", Offset = "0x6EDDE0", VA = "0x1806EF1E0")]
		private bool _SkillAffectingValidate(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600F795 RID: 63381 RVA: 0x0005C8B0 File Offset: 0x0005AAB0
		[Token(Token = "0x600F795")]
		[Address(RVA = "0x6EEED0", Offset = "0x6EDAD0", VA = "0x1806EEED0")]
		private bool _BlockValidate(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600F796 RID: 63382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F796")]
		[Address(RVA = "0x6EF2B0", Offset = "0x6EDEB0", VA = "0x1806EF2B0")]
		public AdvancedCharacterValidator()
		{
		}

		// Token: 0x0600F797 RID: 63383 RVA: 0x0005C8C8 File Offset: 0x0005AAC8
		[Token(Token = "0x600F797")]
		[Address(RVA = "0x6EEA80", Offset = "0x6ED680", VA = "0x1806EEA80")]
		private bool <>xLuaBaseProxy_Validate(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x0401130C RID: 70412
		[Token(Token = "0x401130C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuildableType _buildableType;

		// Token: 0x0401130D RID: 70413
		[Token(Token = "0x401130D")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _checkDeployPosition;

		// Token: 0x0401130E RID: 70414
		[Token(Token = "0x401130E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Inspect("checkDeployPosition")]
		private BuildableType _deployPositionFromData;

		// Token: 0x0401130F RID: 70415
		[Token(Token = "0x401130F")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private RarityRankMask _rarityMask;

		// Token: 0x04011310 RID: 70416
		[Token(Token = "0x4011310")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool _checkSkillAffecting;

		// Token: 0x04011311 RID: 70417
		[Token(Token = "0x4011311")]
		[FieldOffset(Offset = "0xA1")]
		[SerializeField]
		[Inspect("checkSkillAffecting")]
		private bool _skillAffecting;

		// Token: 0x04011312 RID: 70418
		[Token(Token = "0x4011312")]
		[FieldOffset(Offset = "0xA2")]
		[SerializeField]
		private bool _checkBlock;

		// Token: 0x04011313 RID: 70419
		[Token(Token = "0x4011313")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkDeployPosition;

		// Token: 0x04011314 RID: 70420
		[Token(Token = "0x4011314")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Validate;

		// Token: 0x04011315 RID: 70421
		[Token(Token = "0x4011315")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BuildableValidate;

		// Token: 0x04011316 RID: 70422
		[Token(Token = "0x4011316")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DeployValidate;

		// Token: 0x04011317 RID: 70423
		[Token(Token = "0x4011317")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RarityValidate;

		// Token: 0x04011318 RID: 70424
		[Token(Token = "0x4011318")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SkillAffectingValidate;

		// Token: 0x04011319 RID: 70425
		[Token(Token = "0x4011319")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__BlockValidate;

		// Token: 0x0401131A RID: 70426
		[Token(Token = "0x401131A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
