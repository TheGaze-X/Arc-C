using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C2F RID: 11311
	[Token(Token = "0x2002C2F")]
	[Obsolete]
	public class UpdateAtkScaleByTalentData : AbilityStandard.Behaviour
	{
		// Token: 0x060131A0 RID: 78240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A0")]
		[Address(RVA = "0xB28E90", Offset = "0xB27A90", VA = "0x180B28E90", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060131A1 RID: 78241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A1")]
		[Address(RVA = "0xB28C80", Offset = "0xB27880", VA = "0x180B28C80", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060131A2 RID: 78242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A2")]
		[Address(RVA = "0xB291B0", Offset = "0xB27DB0", VA = "0x180B291B0")]
		public UpdateAtkScaleByTalentData()
		{
		}

		// Token: 0x04015920 RID: 88352
		[Token(Token = "0x4015920")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _defaultValue;

		// Token: 0x04015921 RID: 88353
		[Token(Token = "0x4015921")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _talentKey;

		// Token: 0x04015922 RID: 88354
		[Token(Token = "0x4015922")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _overwrite;

		// Token: 0x04015923 RID: 88355
		[Token(Token = "0x4015923")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TargetValidator _ownerValidator;

		// Token: 0x04015924 RID: 88356
		[Token(Token = "0x4015924")]
		[FieldOffset(Offset = "0x40")]
		private FP m_atkScale;
	}
}
