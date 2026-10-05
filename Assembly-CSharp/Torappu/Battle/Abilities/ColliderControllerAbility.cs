using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C45 RID: 11333
	[Token(Token = "0x2002C45")]
	public class ColliderControllerAbility : EmptyAbility
	{
		// Token: 0x06013239 RID: 78393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013239")]
		[Address(RVA = "0xB18BF0", Offset = "0xB177F0", VA = "0x180B18BF0")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		// Token: 0x0601323A RID: 78394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601323A")]
		[Address(RVA = "0xB18E90", Offset = "0xB17A90", VA = "0x180B18E90")]
		public ColliderControllerAbility()
		{
		}

		// Token: 0x040159DF RID: 88543
		[Token(Token = "0x40159DF")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("ColliderController")]
		private Ability[] _abilitiesToRefresh;

		// Token: 0x040159E0 RID: 88544
		[Token(Token = "0x40159E0")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Group("ColliderController")]
		private bool _playCustomTriggerAudioEvent;

		// Token: 0x040159E1 RID: 88545
		[Token(Token = "0x40159E1")]
		[FieldOffset(Offset = "0x120")]
		private ContactPoint2D[] m_contacts;

		// Token: 0x040159E2 RID: 88546
		[Token(Token = "0x40159E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCollisionEnter2D;

		// Token: 0x040159E3 RID: 88547
		[Token(Token = "0x40159E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
