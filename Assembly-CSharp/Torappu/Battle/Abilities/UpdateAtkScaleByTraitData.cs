using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C30 RID: 11312
	[Token(Token = "0x2002C30")]
	[Obsolete]
	public class UpdateAtkScaleByTraitData : AbilityStandard.Behaviour
	{
		// Token: 0x060131A3 RID: 78243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A3")]
		[Address(RVA = "0xB293F0", Offset = "0xB27FF0", VA = "0x180B293F0", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x060131A4 RID: 78244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A4")]
		[Address(RVA = "0xB29220", Offset = "0xB27E20", VA = "0x180B29220", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x060131A5 RID: 78245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60131A5")]
		[Address(RVA = "0xB29540", Offset = "0xB28140", VA = "0x180B29540")]
		public UpdateAtkScaleByTraitData()
		{
		}

		// Token: 0x04015925 RID: 88357
		[Token(Token = "0x4015925")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _defaultValue;

		// Token: 0x04015926 RID: 88358
		[Token(Token = "0x4015926")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _overwrite;

		// Token: 0x04015927 RID: 88359
		[Token(Token = "0x4015927")]
		[FieldOffset(Offset = "0x28")]
		private float m_atkScale;
	}
}
